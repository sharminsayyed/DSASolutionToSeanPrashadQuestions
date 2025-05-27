public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        // no duplicates will be there 
        Array.Sort(nums); // we sort to apply the 3 sum logic 
        // and since index of ele are not asked we can sort it 
        int n = nums.Length;
        int closetSum = 100000;
        for(int i =0; i<n-2; i++){
            // here i we fix one ele for 3 sum
            // and then use l and r pointer to get 2 more ele 
            int l = i+1; // usage of two pointer 
            int r = n-1;
            while(l <r){
                // add the 3 ele to get the sum 
                int currsum = nums[i] +nums[l] +nums[r];
                // compare  if the target - currsum is small or target - closetSum is 
                if(Math.Abs(target - currsum) < Math.Abs(target - closetSum)){
                    closetSum = currsum;
                }
                else if(currsum < target){
                    //  if the sum is small move forward towards greater number 
                    l++;
                } 
                else if (currsum > target){
                    // if the sum is large move backwards towards smaller number 
                    r--;
                } 
                else if (currsum == target) { 
                    return target;
                }
                   
            }
        }

        return closetSum;
    }
}