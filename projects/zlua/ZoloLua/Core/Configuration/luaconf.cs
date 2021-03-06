﻿namespace ZoloLua.Core.VirtualMachine
{
    /// <summary>
    ///     lua配置
    /// </summary>
    /// <remarks>clua这里太繁琐了，所以只能其他代码用到再到这里来添加</remarks>
    public partial class lua_State
    {
        /// <summary>
        ///     LUAI_MAXCALLS limits the number of nested calls.
        ///     its only purpose is to stop infinite recursion before exhausting memory.
        /// </summary>
        public const int LUAI_MAXCALLS = 20000;

        /// <summary>
        ///     LUAI_MAXCCALLS is the maximum depth for nested C calls (short) and
        /// </summary>
        public const int LUAI_MAXCCALLS = 200;

        /// <summary>
        ///     LUAI_MAXCSTACK limits the number of Lua stack slots that a C function can use.
        ///     its only purpose is to stop C functions to consume unlimited stack space.(must be smaller than -LUA_REGISTRYINDEX)
        /// </summary>
        public const int LUAI_MAXCSTACK = 8000;

        /// <summary>
        ///     LUAI_MAXUPVALUES is the maximum number of upvalues per function (must be smaller than 250).
        /// </summary>
        public const int LUAI_MAXUPVALUES = 60;

        /// <summary>
        ///     LUAI_MAXVARS is the maximum number of local variables per function (must be smaller than 250).
        /// </summary>
        public const int LUAI_MAXVARS = 200;
    }
}