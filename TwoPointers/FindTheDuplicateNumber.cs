public class Solution {
    public int FindDuplicate(int[] nums) {
        // dry run to understand better 
        // time complexity  =o(n) space = o(1)
        // intailize the slow and fast pointer at the start of array 
        int slow = nums[0];
        int fast = nums[0];
        // move the slow pointer 1 step forward and fast pointer 2 step forward 
        // when the slow and fast pointer collides at the same index terminate the loop
        do{
            slow = nums[slow];
            fast = nums[nums[fast]];
        }while(slow != fast);
        // after the collision point let the slow pointer remain at the collision point and move 
        // the fast pointer to the 1st index
        fast = nums[0];
        // loop until fast and slow pointer meet again 
        // at there meeting is the duplicate number 
        while(fast != slow){
            slow = nums[slow];
            fast = nums[fast];
        }

        return fast;
    }
}
/* 
Array.Sort(nums);
        int d=0;
        for(int i=0 ;i<nums.Length;i++)
        {
            if(nums[i] == nums[(i+1) % nums.Length])
            {//(i+1) % nums.Length
                d=nums[i];
            }
        }
        return d;*/