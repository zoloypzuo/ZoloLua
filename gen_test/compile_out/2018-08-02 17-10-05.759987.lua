------------------------------
local a = #nil
------------------------------
success compiling learn.lua
; source chunk: learn.lua
; x86 standard (32-bit, little endian, doubles)

; function [0] definition (level 1) 0
; 0 upvalues, 0 params, is_vararg = 2, 2 stacks
.function  0 0 2 2
.local  "a"  ; 0
[1] len        0   0        ; R0 := #R0
[2] return     0   1        ; return 
; end of function 0


------------------------------
Pos   Hex Data           Description or Code
------------------------------------------------------------------------
0000                     ** source chunk: luac.out
                         ** global header start **
0000  1B4C7561           header signature: "\27Lua"
0004  51                 version (major:minor hex digits)
0005  00                 format (0=official)
0006  01                 endianness (1=little endian)
0007  04                 size of int (bytes)
0008  04                 size of size_t (bytes)
0009  04                 size of Instruction (bytes)
000A  08                 size of number (bytes)
000B  00                 integral (1=integral)
                         * number type: double
                         * x86 standard (32-bit, little endian, doubles)
                         ** global header end **
                         
000C                     ** function [0] definition (level 1) 0
                         ** start of function 0 **
000C  0B000000           string size (11)
0010  406C6561726E2E6C+  "@learn.l"
0018  756100             "ua\0"
                         source name: @learn.lua
001B  00000000           line defined (0)
001F  00000000           last line defined (0)
0023  00                 nups (0)
0024  00                 numparams (0)
0025  02                 is_vararg (2)
0026  02                 maxstacksize (2)
                         * code:
0027  02000000           sizecode (2)
002B  14000000           [1] len        0   0        ; R0 := #R0
002F  1E008000           [2] return     0   1        ; return 
                         * constants:
0033  00000000           sizek (0)
                         * functions:
0037  00000000           sizep (0)
                         * lines:
003B  02000000           sizelineinfo (2)
                         [pc] (line)
003F  01000000           [1] (1)
0043  01000000           [2] (1)
                         * locals:
0047  01000000           sizelocvars (1)
004B  02000000           string size (2)
004F  6100               "a\0"
                         local [0]: a
0051  01000000             startpc (1)
0055  01000000             endpc   (1)
                         * upvalues:
0059  00000000           sizeupvalues (0)
                         ** end of function 0 **

005D                     ** end of chunk **
