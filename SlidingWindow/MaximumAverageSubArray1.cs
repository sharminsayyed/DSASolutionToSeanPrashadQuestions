public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // time complexity = O(n) space = O(1)
        int sum =0;
        for (int i= 0;i < k;i ++){
            sum += nums[i]; // add the first k ele from the start 
        }
        int maxsum = sum ;// assign the current sum to max to help in comparison
        // these 2 pointers will help to slide the window in the array
        int startind =0 ; // pointer at the start 
        int endind = k; // pointer at the k index in array 
        while(endind < nums.Length){
            // dont terminate until the endind pointer travels to the end index of array 
            sum -= nums[startind]; // remove the previous ele form the sum and shift/slide startind
            startind++;

            sum += nums[endind]; // add the next ele to the sum and shift/slide endind
            endind++;

            maxsum =Math.Max(sum,maxsum); // compare the current sum and maxsum to find the maximum
        }

        return (double) maxsum/k; // divide by k to get the average 
    }
}