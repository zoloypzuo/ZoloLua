------------------------------

function test()
end
------------------------------
success compiling learn.lua
; source chunk: learn.lua
; x86 standard (32-bit, little endian, doubles)

; function [0] definition (level 1) 0
; 0 upvalues, 0 params, is_vararg = 2, 2 stacks
.function  0 0 2 2
.const  "test"  ; 0
[1] closure    0   0        ; R0 := closure(function[0]) 0 upvalues
[2] setglobal  0   0        ; test := R0
[3] return     0   1        ; return 

; function [0] definition (level 2) 0_0
; 0 upvalues, 0 params, is_vararg = 0, 2 stacks
.function  0 0 0 2
[1] return     0   1        ; return 
; end of function 0_0

; end of function 0

; source chunk: luac.out
; x86 standard (32-bit, little endian, doubles)

; function [0] definition (level 1) 0
; 0 upvalues, 0 params, is_vararg = 2, 2 stacks
.function  0 0 2 2
.const  "test"  ; 0
[1] closure    0   0        ; R0 := closure(function[0]) 0 upvalues
[2] setglobal  0   0        ; test := R0
[3] return     0   1        ; return 

; function [0] definition (level 2) 0_0
; 0 upvalues, 0 params, is_vararg = 0, 2 stacks
.function  0 0 0 2
[1] return     0   1        ; return 
; end of function 0_0

; end of function 0


------------------------------
success compiling learn.lua
Pos   Hex Data           Description or Code
------------------------------------------------------------------------
0000                     ** source chunk: learn.lua
                         ** global header start **
0000  1B4C7561           header signature: "\27Lua"
0004  51                 version (major:minor hex digits)
0005  00                 format (0=official)
0006  01                 endianness (1=little endian)
0007  04                 size of int (bytes)
0008  08                 size of size_t (bytes)
0009  04                 size of Instruction (bytes)
000A  08                 size of number (bytes)
000B  00                 integral (1=integral)
                         * number type: double
                         * x86 standard (32-bit, little endian, doubles)
                         ** global header end **
                         
000C                     ** function [0] definition (level 1) 0
                         ** start of function 0 **
000C  0B00000000000000   string size (11)
0014  406C6561726E2E6C+  "@learn.l"
001C  756100             "ua\0"
                         source name: @learn.lua
001F  00000000           line defined (0)
0023  00000000           last line defined (0)
0027  00                 nups (0)
0028  00                 numparams (0)
0029  02                 is_vararg (2)
002A  02                 maxstacksize (2)
                         * code:
002B  03000000           sizecode (3)
002F  24000000           [1] closure    0   0        ; R0 := closure(function[0]) 0 upvalues
0033  07000000           [2] setglobal  0   0        ; test := R0
0037  1E008000           [3] return     0   1        ; return 
                         * constants:
003B  01000000           sizek (1)
003F  04                 const type 4
0040  0500000000000000   string size (5)
0048  7465737400         "test\0"
                         const [0]: "test"
                         * functions:
004D  01000000           sizep (1)
                         
0051                     ** function [0] definition (level 2) 0_0
                         ** start of function 0_0 **
0051  0000000000000000   string size (0)
                         source name: (none)
0059  02000000           line defined (2)
005D  03000000           last line defined (3)
0061  00                 nups (0)
0062  00                 numparams (0)
0063  00                 is_vararg (0)
0064  02                 maxstacksize (2)
                         * code:
0065  01000000           sizecode (1)
0069  1E008000           [1] return     0   1        ; return 
                         * constants:
006D  00000000           sizek (0)
                         * functions:
0071  00000000           sizep (0)
                         * lines:
0075  01000000           sizelineinfo (1)
                         [pc] (line)
0079  03000000           [1] (3)
                         * locals:
007D  00000000           sizelocvars (0)
                         * upvalues:
0081  00000000           sizeupvalues (0)
                         ** end of function 0_0 **

                         * lines:
0085  03000000           sizelineinfo (3)
                         [pc] (line)
0089  03000000           [1] (3)
008D  02000000           [2] (2)
0091  03000000           [3] (3)
                         * locals:
0095  00000000           sizelocvars (0)
                         * upvalues:
0099  00000000           sizeupvalues (0)
                         ** end of function 0 **

009D                     ** end of chunk **
Pos   Hex Data           Description or Code
------------------------------------------------------------------------
0000                     ** source chunk: luac.out
                         ** global header start **
0000  1B4C7561           header signature: "\27Lua"
0004  51                 version (major:minor hex digits)
0005  00                 format (0=official)
0006  01                 endianness (1=little endian)
0007  04                 size of int (bytes)
0008  08                 size of size_t (bytes)
0009  04                 size of Instruction (bytes)
000A  08                 size of number (bytes)
000B  00                 integral (1=integral)
                         * number type: double
                         * x86 standard (32-bit, little endian, doubles)
                         ** global header end **
                         
000C                     ** function [0] definition (level 1) 0
                         ** start of function 0 **
000C  0B00000000000000   string size (11)
0014  406C6561726E2E6C+  "@learn.l"
001C  756100             "ua\0"
                         source name: @learn.lua
001F  00000000           line defined (0)
0023  00000000           last line defined (0)
0027  00                 nups (0)
0028  00                 numparams (0)
0029  02                 is_vararg (2)
002A  02                 maxstacksize (2)
                         * code:
002B  03000000           sizecode (3)
002F  24000000           [1] closure    0   0        ; R0 := closure(function[0]) 0 upvalues
0033  07000000           [2] setglobal  0   0        ; test := R0
0037  1E008000           [3] return     0   1        ; return 
                         * constants:
003B  01000000           sizek (1)
003F  04                 const type 4
0040  0500000000000000   string size (5)
0048  7465737400         "test\0"
                         const [0]: "test"
                         * functions:
004D  01000000           sizep (1)
                         
0051                     ** function [0] definition (level 2) 0_0
                         ** start of function 0_0 **
0051  0000000000000000   string size (0)
                         source name: (none)
0059  02000000           line defined (2)
005D  03000000           last line defined (3)
0061  00                 nups (0)
0062  00                 numparams (0)
0063  00                 is_vararg (0)
0064  02                 maxstacksize (2)
                         * code:
0065  01000000           sizecode (1)
0069  1E008000           [1] return     0   1        ; return 
                         * constants:
006D  00000000           sizek (0)
                         * functions:
0071  00000000           sizep (0)
                         * lines:
0075  01000000           sizelineinfo (1)
                         [pc] (line)
0079  03000000           [1] (3)
                         * locals:
007D  00000000           sizelocvars (0)
                         * upvalues:
0081  00000000           sizeupvalues (0)
                         ** end of function 0_0 **

                         * lines:
0085  03000000           sizelineinfo (3)
                         [pc] (line)
0089  03000000           [1] (3)
008D  02000000           [2] (2)
0091  03000000           [3] (3)
                         * locals:
0095  00000000           sizelocvars (0)
                         * upvalues:
0099  00000000           sizeupvalues (0)
                         ** end of function 0 **

009D                     ** end of chunk **
