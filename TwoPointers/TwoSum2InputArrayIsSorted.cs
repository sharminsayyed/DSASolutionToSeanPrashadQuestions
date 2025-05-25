public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // time complexity = O(n) 
        int n = numbers.Length;
        int left = 0, right = n-1;
        // left pointer starts from the starting index and
        // right pointer starts from the ending index 
        while(left <right){
            // add the numbers from start and end 
            int ans = numbers[left]+numbers[right];
            if(ans == target){
                // if target sum is found then return both indexes 
                // +1 beacuse the index starts from 1
                return new int[] {left+1 , right+1};
            }
            else if(ans < target){
                // if the ans is less than the target 
                // we move the left pointer forward ensures that we get a bigger numbers in the array 
                left++;
            }
            else{
                // if the ans is greater than the target 
                // we move the right pointer backward ensures that we get a smaller numbers in the array 
                right--;
            }
        }
        return null;
    }
}
