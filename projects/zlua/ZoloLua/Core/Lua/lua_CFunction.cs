﻿using ZoloLua.Core.VirtualMachine;

namespace ZoloLua.Core.Lua
{
    /// <summary>
    /// 	<see href="https://www.lua.org/manual/5.1/manual.html#lua_CFunction">lua_CFunction</see>
    /// </summary>
    /// <remarks>
    /// 	<para>
    /// 		lua_CFunction
    /// 		typedef int (*lua_CFunction) (lua_State *L);
    /// 		
    /// 		C 函数的类型。
    /// 		
    /// 		为了正确的和 Lua 通讯，C 函数必须使用下列
    /// 		定义了参数以及返回值传递方法的协议：
    /// 		C 函数通过 Lua 中的堆栈来接受参数，参数以正序入栈（第一个参数首先入栈）。
    /// 		因此，当函数开始的时候，
    /// 		lua_gettop(L) 可以返回函数收到的参数个数。
    /// 		第一个参数（如果有的话）在索引 1 的地方，而最后一个参数在索引 lua_gettop(L) 处。
    /// 		当需要向 Lua 返回值的时候，C 函数只需要把它们以正序压到堆栈上（第一个返回值最先压入），
    /// 		然后返回这些返回值的个数。
    /// 		在这些返回值之下的，堆栈上的东西都会被 Lua 丢掉。
    /// 		和 Lua 函数一样，从 Lua 中调用 C 函数也可以有很多返回值。
    /// 		
    /// 		下面这个例子中的函数将接收若干数字参数，并返回它们的平均数与和：
    /// 		<code>
    /// 		     static int foo (lua_State *L) {
    /// 		       int n = lua_gettop(L);    /* 参数的个数 */
    /// 		       lua_Number sum = 0;
    /// 		       int i;
    /// 		       for (i = 1; i less equal n; i++) {
    /// 		         if (!lua_isnumber(L, i)) {
    /// 		           lua_pushstring(L, "incorrect argument");
    /// 		           lua_error(L);
    /// 		         }
    /// 		         sum += lua_tonumber(L, i);
    /// 		       }
    /// 		       lua_pushnumber(L, sum/n);   /* 第一个返回值 */
    /// 		       lua_pushnumber(L, sum);     /* 第二个返回值 */
    /// 		       return 2;                   /* 返回值的个数 */
    /// 		     }
    /// 		</code>
    /// 	</para>
    /// </remarks>
    public delegate int lua_CFunction(lua_State L);
}
