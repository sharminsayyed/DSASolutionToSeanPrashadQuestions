public class Solution {
    public void SortColors(int[] nums) {
        //Dutch National Flag Algorithm
        // time complexity = O(n)
       int n = nums.Length , low=0 ,mid=0 ,high=n-1;
       
       while(mid <= high)
       {
        if(nums[mid] == 0)
        {
            // when nums[mid] is 0 swap nums[low] and nums[mid] and increment both
            //swap( nums,low  ,mid);
            (nums[low] ,nums[mid]) = (nums[mid],nums[low]);
            low++ ; mid++;
        }
        else if(nums[mid] == 1)
        {
            // when nums[mid] is 1  increment mid pointer
            mid++;
        }
        else if(nums[mid] == 2)
        {
            // when nums[mid] is 2 swap nums[high] and nums[mid] and and decrement high
            //swap(nums ,  mid, high);
            (nums[mid], nums[high]) = (nums[high],nums[mid]);
            high--;
        }
       }
    }
}
/*
 Array.Sort(nums); 

time complexity = o(2n)
 int cnt0 =0 , cnt1 =0, cnt2 =0;
       for (int i =0 ;i<nums.Length ;i++)
       {
            if(nums[i] == 0)  cnt0++;
            else if(nums[i] == 1)  cnt1++;       
            else  if(nums[i] == 2)  cnt2++;
        }

        for(int i= 0;i<cnt0;i++) nums[i] = 0;
        for(int i= cnt0;i<cnt0+cnt1;i++) nums[i] = 1;
        for(int i= cnt0+cnt1;i<nums.Length;i++) nums[i] = 2;


 */