﻿// zlua v0.1 基于 clua5.3
//
// lua解释器

using Antlr4.Runtime;

using System;
using System.IO;

using zlua.Compiler;
using zlua.Compiler.CodeGenerator;
using zlua.Core.InstructionSet;
using zlua.Core.ObjectModel;
using zlua.Core.Undumper;

namespace zlua.Core.VirtualMachine
{
    // 见鬼了异常，因为有些分支根本不可能走到，用于占位
    internal class GodDamnException : Exception
    { }

    // 错误的操作数类型，我们用opcode作为提示
    internal class OprdTypeException : Exception
    {
        public OprdTypeException(Opcode opcode) : base(opcode.ToString() + "错误的操作数")
        {
        }
    }

    public partial class lua_State
    {
        /* option for multiple returns in 'lua_pcall' and 'lua_call' */
        public const int LUA_MULTRET = -1;
        /* minimum Lua stack available to a C function */
        const int LUA_MINSTACK = 20;

        // 《Lua设计与实现》p39
        public void luaL_dofile(string path)
        {
            luaL_loadfile(path);
            lua_pcall(nargs: 0, nresults: LUA_MULTRET, errfunc: 0);
        }

        public void luaL_loadfile(string path)
        {
            Proto p;
            if (IsBinaryChunk(path)) {
                p = luaU.Undump(new FileStream(path, FileMode.Open));
                var env = new Table(1, 1);
                env.luaH_set(new TValue("print")).Cl = new CSharpClosure()
                {
                    f = (L) =>
                    {
                        TValue s = L.pop();
                        Console.WriteLine(s.Str);
                        return 0;
                    }
                };
                LuaClosure cl = new LuaClosure(env, 1, p);
                push(new TValue(cl));
            } else {
                lua_load(new AntlrFileStream(path, System.Text.Encoding.UTF8), $"@{path}");
            }
        }

        /// <summary>
        /// zlua和clua这点不同，clua的dofile和dostring都会调用lua_load，后者用lookahead判断是否是二进制，再用parser或unudmp
        /// zlua的dostring只能parse，不能undump
        /// 主要是ANTLRStream，太烦了
        /// </summary>
        /// <param name="s"></param>
        public void luaL_dostring(string s)
        {
            luaL_loadstring(s);
            lua_pcall(nargs: 0, nresults: LUA_MULTRET, errfunc: 0);
        }

        public void luaL_loadstring(string s)
        {
            lua_load(new AntlrInputStream(s), s);
        }

        /// <summary>
        /// clua是parser或undump，zlua只parse
        /// </summary>
        /// <param name=""></param>
        /// <param name="chunkname"></param>
        /// <returns></returns>
        int lua_load(ICharStream chunk, string chunkname)
        {
            // status是parser返回的错误码
            int status = 0;

            if (chunkname == null) chunkname = "?";

            LuaLexer lexer = new LuaLexer(chunk);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            LuaParser parser = new LuaParser(tokenStream);
            var tree = parser.chunk();
            LuaCodeGenerator codeGenerator = new LuaCodeGenerator();
            codeGenerator.Visit(tree);

            Proto p = codeGenerator.Chunk;
            var env = new Table(1, 1);
            env.luaH_set(new TValue("print")).Cl = new CSharpClosure()
            {
                f = (L) =>
                {
                    TValue s = L.pop();
                    Console.WriteLine(s.Str);
                    return 0;
                }
            };
            LuaClosure cl = new LuaClosure(env, 1, p);
            push(new TValue(cl));
            return status;
        }

        /// 注册一个C#函数，在lua代码中用name调用
        /// 被调用函数被包装成closure，在G中，key是`name
        /// no upval，你要自己设置（永远用不到）
        public void Register(lua_CFunction csFunc, string name)
        {
            var newFunc = new CSharpClosure() { f = csFunc };
            gt.Table.luaH_getstr((TString)name).Cl = newFunc;
        }

        /// 基于L.top，压函数，压args，返回n个值
        public delegate int lua_CFunction(lua_State L);


        private bool IsBinaryChunk(string path)
        {
            using (var f = new FileStream(path, FileMode.Open)) {
                // TODO check and throw file open error
                char c = (char)f.ReadByte();
                return c == luaU.FirstChar;
            }
        }
    }
}