// Codility 	- C-Sharp 	-  Lesson 2 Arrays Task CyclicRotation
// A Quick solution for CyclicRotation - By Jordy Nijman
// My Github 	- https://github.com/jordynijman/Codility

// Note: There are definitely ways to do this better...

using System;

class Solution {
    public int[] solution(int[] A, int K) {
        int length = A.Length; // I dislike retyping A.Length hence this local variable. 
		
        // Check for empty Array OR Empty shift
        if(length == 0 || K == 0 )
        {
            return A;
        }
        
        while(K > length)
        {
            K = K - length;
        }
        
        if(K == length)
        {
            return A;
        }
        
        int[] result = new int[length];
        
        Array.Copy(A,length - K,result,0,K);
        Array.Copy(A,0,result,K,length - K);
        
        return result;
    }
}