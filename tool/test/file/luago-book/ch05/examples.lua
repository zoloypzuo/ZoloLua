-- diff between 5.1 and 5.3
-- no // and no bit op

--print(5 // 3)       --> 1
--print(-5 // 3)      --> -2
--print(5 // -3.0)    --> -2.0
--print(-5.0 // -3.0) --> 1.0

print(5 % 3)       --> 2
print(-5 % 3)      --> 1
print(5 % -3.0)    --> -1.0
print(-5.0 % -3.0) --> -2.0

print(100 / 10 / 2) -- (100/10)/2 == 5.0
print(4 ^ 3 ^ 2)    -- 4^(3^2) == 262144.0

--print(-1 >> 63)   --> 1
--print(2 << -1)    --> 1
--print("1" << 1.0) --> 2

print(#"hello")   --> 5
print(#{ 7, 8, 9 }) --> 3

print("a" .. "b" .. "c") --> abc
print(1 .. 2 .. 3)       --> 123
