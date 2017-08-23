// Codility 	- C-Sharp 	-  Lesson 2 Arrays Task OddOccurencesInArray
// A Quick Linq query solution for OddOccurencesInArray - By Jordy Nijman
// My Github 	- https://github.com/jordynijman/Codility

using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        return A.GroupBy(element => element)
				.Where(n => n.Count() % 2 != 0)
				.First()
				.Key; 
    }
}

