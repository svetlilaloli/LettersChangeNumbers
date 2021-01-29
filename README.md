Console Application<br/>
Exercise: Strings and Text Processing
# LettersChangeNumbers
Nakov likes Math. But he also likes the English alphabet a lot. He invented a game with numbers and letters from the English alphabet. The game was simple. You get a string consisting of a __number between two letters__. Depending on whether the letter was in front of the number or after it you would perform different mathematical operations on the number to achieve the result.<br/><br/>
__First__ you start with the letter __before__ the number. <br/>
* If it's __uppercase__ you __divide__ the number by the letter's __position in the alphabet__. 
* If it's __lowercase__ you __multiply__ the number with the letter's __position in the alphabet__. 
__Then__ you move to the letter __after__ the number.<br/>
* If it's __uppercase__ you __subtract its position__ from the resulted number.
* If it's __lowercase__ you __add its position__ to the resulted number.
But the game became too easy for Nakov really quick. He decided to complicate it a bit by doing the same but with __multiple__ strings keeping track of only the __total sum__ of all results. Once he started to solve this with more strings and bigger numbers it became quite hard to do it only in his mind. So he kindly asks you to __write a program that calculates the sum of all numbers after the operations on each number have been done__.<br/><br/>
__For example__, you are given the sequence "__A12b s17G__":<br/><br/>
We have two strings – "__A12b__" and "__s17G__". We do the operations on each and sum them. We start with the letter before the number on the first string. __A is Uppercase__ and its position in the alphabet is __1__. So we divide the number 12 with the position 1 (__12/1 = 12__). Then we move to the letter after the number. __b is lowercase__ and its position is __2__. So we add 2 to the resulted number (__12+2=14__). Similarly for the second string __s is lowercase__ and its position is __19__ so we multiply it with the number (__17\*19 = 323__). Then we have __Uppercase G__ with position __7__, so we subtract it from the resulted number (__323 – 7 = 316__). Finally, we sum the 2 results and we get __14 + 316 = 330__.
## Input
The input comes from the console as a __single line, holding the sequence of strings__. Strings are separated by __one or more white spaces__.<br/>
The input data will always be valid and in the format described. There is no need to check it explicitly.
## Output
Print at the console a single number: the __total sum of all processed numbers__ rounded up to __two digits__ after the decimal separator.
## Constraints
The __count__ of the strings will be in the range [1 … 10].
* The numbers between the letters will be integers in range [1 … 2 147 483 647].
* Time limit: 0.3 sec. Memory limit: 16 MB.
## Examples
Input|Output|Comments
-----|------|--------
A12b s17G|330.00|12/1=12, 12+2=14, 17\*19=323, 323–7=316, __14+316=330__
P34562Z q2576f   H456z|46015.13|
a1A|0.00|
