// Codility 	- C-Sharp 	-  Lesson 3 Time Complexity Task PermMissingElem
// A Quick solution for PermMissingElem - By Jordy Nijman
// My Github 	- https://github.com/jordynijman/Codility

using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {

        if(A.Length == 0)
        return 1;
        
        long sourceArrayLength = A.Length + 1;        
        long sourceArraySum =  A.Select(e => (long)e).Sum();    
        long expectedArraySum =  (sourceArrayLength * (sourceArrayLength + 1)) / 2;
        
        return (int)(expectedArraySum - sourceArraySum);
    }
}