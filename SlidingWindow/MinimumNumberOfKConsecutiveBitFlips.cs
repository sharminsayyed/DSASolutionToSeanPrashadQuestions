public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
        // here the time complexity = o(n) but space here = O(1)
        // we are modififying the array but we are putting the original value back too  
        int n= nums.Length;
        int ans =0 , times =0;
        for(int i=0 ;i<n;i++){
            if(i>=k){
                if(nums[i-k] >1){
                    nums[i-k] -=2 ;
                    times -=1;
                }
            }
            if(nums[i] == 1 && times %2 == 1 || nums[i]==0 && times%2 == 0){
                if(i+k > n) return -1;
                ans ++;
                times++;
                nums[i]+=2;
            }
        }
        if(nums[n-k] > 1){
            nums[n-k] -=2;
        }
        return ans;
    }
}
/*
// time complexity =O(n) and space =O(n)
int n= nums.Length;
        int[] flipped =new int[n];
        int ans =0 , times =0;
        for(int i=0 ;i<n ;i++){
            if(i >= k){
                times = times -flipped[i-k];// remove old flip from window
            }
            if(nums[i] == 1 && times %2 == 1 || nums[i]==0 && times%2 == 0){
                if(i+k>n) return -1;
                ans++;
                times++;
                flipped[i] =1;

            }
        }
        return ans;*/