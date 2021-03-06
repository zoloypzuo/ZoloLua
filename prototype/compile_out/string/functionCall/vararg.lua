------------------------------
local a,b,c,d,e = 100, ...
------------------------------
success compiling learn.lua
; source chunk: learn.lua
; x86 standard (32-bit, little endian, doubles)

; function [0] definition (level 1) 0
; 0 upvalues, 0 params, is_vararg = 2, 5 stacks
.function  0 0 2 5
.local  "a"  ; 0
.local  "b"  ; 1
.local  "c"  ; 2
.local  "d"  ; 3
.local  "e"  ; 4
.const  100  ; 0
[1] loadk      0   0        ; R0 := 100
[2] vararg     1   5        ; R1 to R4 := ...
[3] return     0   1        ; return 
; end of function 0

; source chunk: luac.out
; x86 standard (32-bit, little endian, doubles)

; function [0] definition (level 1) 0
; 0 upvalues, 0 params, is_vararg = 2, 5 stacks
.function  0 0 2 5
.local  "a"  ; 0
.local  "b"  ; 1
.local  "c"  ; 2
.local  "d"  ; 3
.local  "e"  ; 4
.const  100  ; 0
[1] loadk      0   0        ; R0 := 100
[2] vararg     1   5        ; R1 to R4 := ...
[3] return     0   1        ; return 
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
002A  05                 maxstacksize (5)
                         * code:
002B  03000000           sizecode (3)
002F  01000000           [1] loadk      0   0        ; R0 := 100
0033  65008002           [2] vararg     1   5        ; R1 to R4 := ...
0037  1E008000           [3] return     0   1        ; return 
                         * constants:
003B  01000000           sizek (1)
003F  03                 const type 3
0040  0000000000005940   const [0]: (100)
                         * functions:
0048  00000000           sizep (0)
                         * lines:
004C  03000000           sizelineinfo (3)
                         [pc] (line)
0050  01000000           [1] (1)
0054  01000000           [2] (1)
0058  01000000           [3] (1)
                         * locals:
005C  05000000           sizelocvars (5)
0060  0200000000000000   string size (2)
0068  6100               "a\0"
                         local [0]: a
006A  02000000             startpc (2)
006E  02000000             endpc   (2)
0072  0200000000000000   string size (2)
007A  6200               "b\0"
                         local [1]: b
007C  02000000             startpc (2)
0080  02000000             endpc   (2)
0084  0200000000000000   string size (2)
008C  6300               "c\0"
                         local [2]: c
008E  02000000             startpc (2)
0092  02000000             endpc   (2)
0096  0200000000000000   string size (2)
009E  6400               "d\0"
                         local [3]: d
00A0  02000000             startpc (2)
00A4  02000000             endpc   (2)
00A8  0200000000000000   string size (2)
00B0  6500               "e\0"
                         local [4]: e
00B2  02000000             startpc (2)
00B6  02000000             endpc   (2)
                         * upvalues:
00BA  00000000           sizeupvalues (0)
                         ** end of function 0 **

00BE                     ** end of chunk **
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
002A  05                 maxstacksize (5)
                         * code:
002B  03000000           sizecode (3)
002F  01000000           [1] loadk      0   0        ; R0 := 100
0033  65008002           [2] vararg     1   5        ; R1 to R4 := ...
0037  1E008000           [3] return     0   1        ; return 
                         * constants:
003B  01000000           sizek (1)
003F  03                 const type 3
0040  0000000000005940   const [0]: (100)
                         * functions:
0048  00000000           sizep (0)
                         * lines:
004C  03000000           sizelineinfo (3)
                         [pc] (line)
0050  01000000           [1] (1)
0054  01000000           [2] (1)
0058  01000000           [3] (1)
                         * locals:
005C  05000000           sizelocvars (5)
0060  0200000000000000   string size (2)
0068  6100               "a\0"
                         local [0]: a
006A  02000000             startpc (2)
006E  02000000             endpc   (2)
0072  0200000000000000   string size (2)
007A  6200               "b\0"
                         local [1]: b
007C  02000000             startpc (2)
0080  02000000             endpc   (2)
0084  0200000000000000   string size (2)
008C  6300               "c\0"
                         local [2]: c
008E  02000000             startpc (2)
0092  02000000             endpc   (2)
0096  0200000000000000   string size (2)
009E  6400               "d\0"
                         local [3]: d
00A0  02000000             startpc (2)
00A4  02000000             endpc   (2)
00A8  0200000000000000   string size (2)
00B0  6500               "e\0"
                         local [4]: e
00B2  02000000             startpc (2)
00B6  02000000             endpc   (2)
                         * upvalues:
00BA  00000000           sizeupvalues (0)
                         ** end of function 0 **

00BE                     ** end of chunk **
