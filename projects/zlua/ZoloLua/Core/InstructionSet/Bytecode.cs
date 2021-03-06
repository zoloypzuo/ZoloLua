﻿using System.Diagnostics;
using Newtonsoft.Json;
using ZoloLua.Core.VirtualMachine;

namespace ZoloLua.Core.InstructionSet
{
    /// <summary>
    ///     字节码指令
    /// </summary>
    internal struct Bytecode
    {
        public uint Value { get; set; }

        public Bytecode(uint i)
        {
            Value = i;
        }


        [JsonIgnore]
        public Opcode Opcode {
            get { return (Opcode)Get(SizeOp, PosOp); }
            set { Set((uint)value, SizeOp, PosOp); }
        }

        [JsonIgnore]
        public uint Ax {
            get {
                Debug.Assert(BytecodeTool.GetOpmode(Opcode).OpMode == OpMode.IAx);
                return Get(SIZE_Ax, POS_Ax);
            }
            set {
                Debug.Assert(BytecodeTool.GetOpmode(Opcode).OpMode == OpMode.IAx);
                Set(value, SIZE_Ax, POS_Ax);
            }
        }


        // if x[7] (in bit) is 1, return true, and RKB returns KB
        public static bool IsK(int x)
        {
            return (x & (1 << (int)(SizeB - 1))) != 0;
        }

        public static int IndexK(int x)
        {
            return x & ~(1 << (int)(SizeB - 1));
        }


        // 创建一个从某一位置开始若干位1的掩码
        private static uint Mask1(uint n, uint pos)
        {
            return ~(~(uint)0 << (int)n) << (int)pos;
        }

        // 创建一个从某一位置开始若干位0的掩码
        private static uint Mask0(uint n, uint pos)
        {
            return ~Mask0(n, pos);
        }

        // 得到从某一位置开始若干位的无符号整数值
        private uint Get(uint n, uint pos)
        {
            uint a = Value >> (int)pos;
            uint b = Mask1(n, 0);
            return a & b;
        }

        // 将某一位置开始若干位设为x
        private void Set(uint x, uint n, uint pos)
        {
            uint a = Value & Mask0(n, pos);
            uint b = (x << (int)pos) & Mask1(n, pos);
            Value = a | b;
        }

        public uint A {
            get {
                return Get(SizeA, PosA);
            }
            set {
                Set(value, SizeA, PosA);
            }
        }

        public uint B {
            get {
                return Get(SizeB, PosB);
            }
            set {
                Set(value, SizeB, PosB);
            }
        }

        public uint C {
            get {
                return Get(SizeC, PosC);
            }
            set {
                Set(value, SizeC, PosC);
            }
        }

        public uint Bx {
            get {
                return Get(SizeBx, PosBx);
            }
            set {
                Set(value, SizeBx, PosBx);
            }
        }

        // sBx
        //
        // sBx是把无符号的Bx解释为有符号的移码
        public int SignedBx {
            get {
                return (int)(Bx - MaxArgSignedBx);
            }
            set {
                Bx = (uint)(value + MaxArgSignedBx);
            }
        }


        // 这一片因为是去年写的，全部使用帕斯卡，换成现在我更愿意写成C的全大写形式
        private const uint SizeC = 9;

        private const uint SizeB = 9;
        private const uint SizeBx = SizeC + SizeB;
        private const uint SizeA = 8;
        private const uint SIZE_Ax = SizeC + SizeB + SizeA;
        private const uint SizeOp = 6;

        private const uint PosOp = 0;
        private const uint PosA = PosOp + SizeOp;
        private const uint PosC = PosA + SizeA;
        private const uint PosB = PosC + SizeC;
        private const uint PosBx = PosC;
        private const uint POS_Ax = PosA;


        private const uint MaxArgBx = (1 << (int)SizeBx) - 1;
        private const uint MaxArgSignedBx = MaxArgBx >> 1;
        private const uint MaxArgA = (1 << (int)SizeA) - 1;
        private const uint MaxArgB = (1 << (int)SizeB) - 1;
        private const uint MaxArgC = (1 << (int)SizeC) - 1;


        public override string ToString()
        {
            opmode c = BytecodeTool.GetOpmode(Opcode);
            Opcode op = Opcode;
            switch (c.OpMode) {
                case OpMode.IABC:
                    return $"{op} A: {A} B: {B} C: {C}";

                case OpMode.IABx:
                    return $"{op} A: {A} Bx: {Bx}";

                case OpMode.IAsBx:
                    return $"{op} A: {A} sBx: {SignedBx}";

                case OpMode.IAx:
                    return $"{op} Ax: {Ax}";

                default:
                    throw new System.Exception();
            }
        }
    }
}