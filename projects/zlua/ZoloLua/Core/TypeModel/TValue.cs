﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using ZoloLua.Core.Lua;
using ZoloLua.Core.ObjectModel;
using ZoloLua.Core.VirtualMachine;

namespace ZoloLua.Core.TypeModel
{
    // TODO light ud没了解足够，先不管
    /// <summary>
    ///     lua对象
    /// </summary>
    /// <remarks>TODO大小8+8+4=20B，其中指针大小4B或8B，enum大小默认4B，现在的样子是对齐的</remarks>
    public class TValue : IEquatable<TValue>
    {
        /// <summary>
        ///     构造nil
        /// </summary>
        public TValue()
        {
            tt = LuaType.LUA_TNIL;
        }

        public TValue(lua_Number n)
        {
            tt = LuaType.LUA_TNUMBER;
            NumericValue = new LuaNumeric { n = n };
        }

        public TValue(bool b)
        {
            tt = LuaType.LUA_TBOOLEAN;
            NumericValue = new LuaNumeric { b = b };
        }

        public TValue(string s)
        {
            tt = LuaType.LUA_TSTRING;
            gc = new TString(s);
        }

        public TValue(TString tstr)
        {
            tt = LuaType.LUA_TSTRING;
            gc = tstr;
        }

        public TValue(Table table)
        {
            tt = LuaType.LUA_TTABLE;
            gc = table;
        }

        public TValue(lua_State thread)
        {
            tt = LuaType.LUA_TTHREAD;
            gc = thread;
        }

        public TValue(Udata udata)
        {
            tt = LuaType.LUA_TUSERDATA;
            gc = udata;
        }

        public TValue(Closure closure)
        {
            tt = LuaType.LUA_TFUNCTION;
            gc = closure;
        }

        /// <summary>
        ///     lua值类型的值
        /// </summary>
        [JsonProperty]
        private LuaNumeric NumericValue { get; set; }


        /// <summary>
        ///     lua引用类型的值
        /// </summary>
        [JsonProperty]
        public GCObject gc { get; private set; }

        /// <summary>
        ///     light udata
        /// </summary>
        [JsonProperty]
        private object p { get; set; }

        /// <summary>
        ///     类型标签
        /// </summary>
        [JsonProperty]
        public LuaType tt { get; private set; }


        [JsonIgnore]
        public lua_Number N {
            get {
                Debug.Assert(IsNumber);
                return NumericValue.n;
            }
            set {
                tt = LuaType.LUA_TNUMBER;
                NumericValue = new LuaNumeric { n = value };
            }
        }

        [JsonIgnore]
        public bool B {
            get {
                Debug.Assert(IsBool);
                return NumericValue.b;
            }
            set {
                tt = LuaType.LUA_TBOOLEAN;
                NumericValue = new LuaNumeric { b = value };
            }
        }

        [JsonIgnore]
        public TString TStr {
            get {
                Debug.Assert(IsString);
                return gc as TString;
            }
            set {
                tt = LuaType.LUA_TSTRING;
                gc = value;
            }
        }

        [JsonIgnore]
        public string Str {
            get {
                Debug.Assert(IsString);
                return (gc as TString).str;
            }
            set {
                tt = LuaType.LUA_TSTRING;
                TString tstr = gc as TString;
                if (tstr != null) {
                    tstr.str = value;
                } else {
                    gc = new TString(value);
                }
            }
        }

        [JsonIgnore]
        public Closure Cl {
            get {
                return gc as Closure;
            }
            set {
                tt = LuaType.LUA_TFUNCTION;
                gc = value;
            }
        }

        [JsonIgnore]
        public lua_State Thread {
            get { return gc as lua_State; }
            set {
                tt = LuaType.LUA_TTHREAD;
                gc = value;
            }
        }

        [JsonIgnore]
        public Table Table {
            get { return gc as Table; }
            set {
                tt = LuaType.LUA_TTABLE;
                gc = value;
            }
        }

        [JsonIgnore]
        public Udata Udata {
            get {
                return gc as Udata;
            }
            set {
                tt = LuaType.LUA_TUSERDATA;
                gc = value;
            }
        }

        [JsonIgnore]
        public object LightUserdata {
            get {
                return p;
            }
            set {
                tt = LuaType.LUA_TLIGHTUSERDATA;
                p = value;
            }
        }

        /// <summary>
        ///     拷贝函数
        /// </summary>
        [JsonIgnore]
        public TValue Value {
            set {
                tt = value.tt;
                NumericValue = value.NumericValue;
                if (value.IsCollectable) {
                    gc = value.gc;
                } else {
                    gc = null;
                }
            }
        }


        public bool IsNil {
            get {
                return tt == LuaType.LUA_TNIL;
            }
        }

        public bool IsNumber {
            get {
                return tt == LuaType.LUA_TNUMBER;
            }
        }

        public bool IsString {
            get {
                return tt == LuaType.LUA_TSTRING;
            }
        }

        public bool IsTable {
            get {
                return tt == LuaType.LUA_TTABLE;
            }
        }

        public bool IsProto {
            get {
                return tt == LuaType.LUA_TFUNCTION;
            }
        }

        public bool IsBool {
            get {
                return tt == LuaType.LUA_TBOOLEAN;
            }
        }

        public bool IsUserdata {
            get {
                return tt == LuaType.LUA_TUSERDATA;
            }
        }

        public bool IsThread {
            get {
                return tt == LuaType.LUA_TTHREAD;
            }
        }

        public bool IsLightUserdata {
            get {
                return tt == LuaType.LUA_TLIGHTUSERDATA;
            }
        }

        public bool IsCSharpFunction {
            get {
                return tt == LuaType.LUA_TFUNCTION && gc is CSharpClosure;
            }
        }

        public bool IsLuaFunction {
            get {
                return tt == LuaType.LUA_TFUNCTION && gc is LuaClosure;
            }
        }

        public bool IsFunction {
            get {
                return tt == LuaType.LUA_TFUNCTION;
            }
        }


        public bool IsCollectable {
            get {
                return (int)tt >= (int)LuaType.LUA_TSTRING;
            }
        }

        /// <summary>
        ///     lua值都可以作为条件测试，只有false和nil是条件为假
        /// </summary>
        public bool IsFalse {
            get {
                return IsNil || IsBool && B == false;
            }
        }

        /// <summary>
        ///     lua值都可以作为条件测试，只有false和nil是条件为假
        /// </summary>
        public bool IsTrue {
            get {
                return !IsFalse;
            }
        }


        public bool Equals(TValue other)
        {
            return lobject.luaO_rawequalObj(this, other);
        }

        public override bool Equals(object obj)
        {
            return obj is TValue && Equals(obj as TValue);
        }

        public override int GetHashCode()
        {
            switch (tt) {
                case LuaType.LUA_TNUMBER: return N.GetHashCode();
                case LuaType.LUA_TSTRING: return Str.GetHashCode();
                case LuaType.LUA_TBOOLEAN: return B.GetHashCode();
                default:
                    return gc.GetHashCode();
            }
        }

        [DebuggerStepThrough]
        public void SetNil()
        {
            tt = LuaType.LUA_TNIL;
            gc = null;
        }

        public override string ToString()
        {
            switch (tt) {
                case LuaType.LUA_TBOOLEAN:
                    return $"{tt} {B}";
                case LuaType.LUA_TNUMBER:
                    return $"{tt} {N.Value}";
                case LuaType.LUA_TSTRING:
                    return $"{tt} {Str}";
            }
            return tt.ToString();
        }

        /// <summary>
        ///     lua值类型
        /// </summary>
        /// <remarks>
        ///     <list>
        ///         <item>大小8B</item>
        ///         <item>
        ///             是union，这个特性不允许使用c#引用类型，所以放在外面
        ///             https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.structlayoutattribute?view=netframework-4.7.2
        ///         </item>
        ///     </list>
        /// </remarks>
        [StructLayout(LayoutKind.Explicit)]
        private struct LuaNumeric
        {
            [FieldOffset(0)]
            public lua_Number n;

            [FieldOffset(0)]
            public bool b;
        }
    }
}