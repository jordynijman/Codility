// Codility 	- C-Sharp C# 	-  Lesson 1 Iterations Task BinaryGap
// A Quick solution for BinaryGap - By Jordy Nijman
// My Github 	- https://github.com/jordynijman/Codility

// NOTE: There are probably better ways to do this..

using System;

class Solution {
    public int solution(int N) {    
        string binary = Convert.ToString(N,2); // Converts number to binary representation
        
        int largestGap = 0;
        int currentGap = 0;
        
        // Steps through the binary string to find the elements belonging to a gap and update the gap count
        for(int index = 0; index < binary.Length - 1; index++)
        {
            // Start Counting
            if(binary[index] == '1' && binary[index + 1] == '0')
            {
                currentGap = 1;
            }
            
            // Continue Counting
            if(binary[index] == '0'&& binary[index + 1] == '0')
            {
                currentGap++;
            }
            
            // Complete Counting upon encountering end of gap
            if(binary[index] == '0' && binary[index + 1] == '1')
            {
                // Check if currentGap is bigger than largestGap
                if(currentGap > largestGap)
                {
                    // Update largestGap
                    largestGap = currentGap;
                }
            }   
        }

        return largestGap;
    }
}