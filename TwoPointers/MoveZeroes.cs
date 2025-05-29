public class Solution {
    public void MoveZeroes(int[] nums) {
        int l= 0;
        int n = nums.Length;
        for (int r = 1 ;r <n ; r++)
        {
            if( nums[l] != 0)
            {
                l++;

            }
            else if( nums[r] != 0 && nums[l] == 0)
            {
                (nums[l] ,nums[r]) = (nums[r] ,nums[l]);
                 l++;
            
            }
        }
    }
}
