public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        // time complexity = O(n)
        IList<IList<int>> result = new List<IList<int>>();
        // a list of triplets list to store the result 
        int n = nums.Length; 
        Array.Sort(nums); // sort the array given   
        for(int i =0 ;i<n-2 ;i++)
        {   // at start we fix one ele from the start of the array 
            // and then find the next 2 ele to get triplet 
            // for loop stops at the third last ele beacause we have to form a triplet 

            if(i> 0 && nums[i] == nums[i-1]) continue;
            // If the current element is the same as the previous one, we skip it to avoid duplicate triplets.

            // use the same logic as 2 sum to get the another two ele for the triplet
            int l = i+1,r =n-1; // usage 2 pointers 
            while(l <r)
            { // here we add the all the 3 ele i (fixed ele ), left pointer , right pointer 
                int sum = nums[i] +nums[l] +nums[r];
                if(sum == 0)
                { // and check if the sum is 0 
                    IList<int> temp = new List<int> {nums[i] ,nums[l] ,nums[r]};
                    // add that list in the result list 
                    result.Add(temp);
                    l++; // move both pointers to find another triplets 
                    r--;

                    // after increment check if the previous left pointer was same as the current 
                    // and if same move forward again to avoid duplicate 
                    while(l < r && nums[l] == nums[l-1]) l++;
                    while(l < r && nums[r] == nums[r+1]) r--;
                }
                    
                else if(sum < 0){
                    l++;
                    // if sum is < 0  then move for forward to get the larger valued number to increase the sum
                }
                else if(sum > 0  ){
                      r--;
                        // if sum is > 0  then move for backward to get the samller valued number to decrease the sum
                }
            }
        }
        return result; // return the list of triplets 
    }
}

