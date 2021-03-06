﻿namespace ZoloLua.Core.VirtualMachine
{
    public partial class lua_State
    {
        /// <summary>
        ///     栈帧信息，或者说是一次调用的信息
        /// </summary>
        private class CallInfo
        {
            public StkId @base; /* base for this function */
            public StkId func; /* function index in the stack */

            public int nresults; /* expected number of results from this function */

            /// saved pc when call function, index of instruction array
            /// 调用别的函数时保存LuaState的savedpc
            public int savedpc;
            public int tailcalls; /* number of tail calls lost under this entry */
            public StkId top; /* top for this function */
        }
    }
}