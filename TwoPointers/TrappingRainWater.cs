public class Solution {
    public int Trap(int[] height) {
        // time complexity = o(n) sc = o(1)
        int n = height.Length , ans =0;;
        int l = 0 ,r = n-1; // two pointer to move
         // to calculate the max of boundaries from both side 
        int lmax = -1 , rmax = -1 ;
        while(l < r){
            // calculate the max boundary from the left and right 
            lmax = Math.Max(lmax , height[l]); 
            rmax = Math.Max(rmax , height[r]);
            // main logic here the deciding factor is the shortest boundary (lmax ,rmax)
            if(lmax < rmax){ 
                // here lmax is short so water trapped according to the height of lmax 
                ans += (lmax - height[l] );
                l++; // move the left pointer to next bar forward
            }
            else{// here rmax is short so water trapped according to the height of rmax 
                ans += (rmax - height[r]);
                r--;// move the right pointer to next bar backward
            }
        } 
        return ans;
    }
}