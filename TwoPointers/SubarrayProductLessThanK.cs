public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        //time complexity = o(n) space = o(1)
        int n = nums.Length;
        if(n <= 0||k <= 1) return 0;
       
        int product =1 ; // to calculate the product of array ele
        // i and j for traversal and count for counting the no of subarray found whose product is less than k 
        int i = 0 ,count =0;
        // here j and i point to the first index and ele in array 
        for(int j =0 ;j<n ;j++){
            product *= nums[j]; // calculate the product
            while(product >= k ){
                // if the product is greater than the k given than shrink the window 
                // and remove the ele from the start index  by diving product
                product /= nums[i]; 
                i++; // increment the i because we deducted the that number[i] from the window 
            }

            count += j- i +1 ; // this removes all the possible subarray between i and j
            // increment j to move to next ele and index
        }
        return count;
    }
}