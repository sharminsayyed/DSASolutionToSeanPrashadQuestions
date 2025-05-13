public class Solution {
    public int[] SortedSquares(int[] nums) {
        // time complexity = o(n) space = o(n) for result array
        int n = nums.Length;
        int[] result = new int[n]; // create a new array to store the sorted sqaures 
        
        int l = 0 , r = n-1 ;//place two pointers left in start of array and right in end of array
        int ind = n-1; // start placing the sqaures from the end of result array 

        while(l <= r){ 
            int leftsq = nums[l]*nums[l]; // calculate square of the left index ele 
            int rightsq = nums[r]*nums[r]; // calculate sqaure of the right index ele 
            if(leftsq > rightsq) // compare both as we have to form a sorted array
            { // if leftsq is greater than place at the end of result array 
                result[ind] = leftsq;
                l++; // move left pointer forward
            }
            else{ // if the rightsq is greater than place at the  end of result array
                result[ind] = rightsq;
                r-- ; // move right pointer from back 
            }
            // after we place a sqaure in result array
            // move the ind pointer to next position to place another sqaure 
            ind-- ;
            
        } 
        return result;
    }
}