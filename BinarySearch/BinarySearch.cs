public class Solution {
    public int Search(int[] nums, int target) {
        // tc = o(log2 n)
        int low=0 , high = nums.Length-1;
        while(low<=high)
        {
            int mid = low+(high -low) /2;
            if(mid > nums.Length || mid< 0){
                return -1;
            }
            if(target == nums[mid]){ 
                return mid;
            }
            else if(target < nums[mid]){
                high = mid-1;
            }
            else if(target > nums[mid]){
                low = mid+1;
            } 
        }
        return -1;
       
    }
}