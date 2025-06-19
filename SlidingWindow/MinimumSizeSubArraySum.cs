public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        // needs dry run 
        // time complexity =O(n) space =O(1)
        int minlen = int.MaxValue; // set the minimum len as maximum value 
        int cursum =0; // keep the track of sum // to check if sum >= target
        int low =0,high =0; // using 2 pointers to slide the window through the array 
        while(high < nums.Length){
            cursum += nums[high]; // add until the cursum >= target

            // enter the loop when the currsum >= target only
            while(cursum >= target){
                // this is a loop terminate when the currsum < target 
                int curlen = high-low+1; // find the len of the curr window 
                minlen = Math.Min(minlen , curlen); // compare and take the minimum length
                cursum -= nums[low]; // remove the ele from back and shift /slide the window 
                low++; // move to the next ind
                // again check if the currsum >= target if yes run the loop again or else terminate
            }

            high++; // add until the cursum >= target
        }

        return minlen == int.MaxValue ? 0: minlen; // if the minimum length remain same as the maximum value than return 0 means  we cannot find the minlen (sum eqauls to target)
        //else return the min len obtained 
    }
}