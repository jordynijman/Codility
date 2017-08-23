// Codility 	- C-Sharp C# 	-  Lesson 2 Arrays Task OddOccurencesInArray
// A Quick XOR Linq aggregate method solution - By Jordy Nijman
// My Github 	- https://github.com/jordynijman/Codility

using System;
using System.Linq;


class Solution {
    public int solution(int[] A) {
        return A.Aggregate(0, (x,y) => x^y);
    }
}

