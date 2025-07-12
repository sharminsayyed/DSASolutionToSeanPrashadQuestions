public class Solution {
    public int MinOperations(int[] nums) {
        // time c = O(n) but it modifies the array 
        // subarray of 3 to me flipped here 
        int ans =0; 
        int n =nums.Length;
        for(int i= 0;i <n-2; i++){
           if(nums[i] == 0){
                nums[i] = nums[i]^ 1; // 0^1 = 1, 1^1 =0
                nums[i+1] = nums[i+1] ^ 1;
                nums[i+2] = nums[i+2]^1;
                ans++;
           }
           else{
            // nums[i] ==1 
            continue;
           }
        }
        if(nums[n-1] == 0 || nums[n-2] == 0) return -1;
        else return ans;
    }
}