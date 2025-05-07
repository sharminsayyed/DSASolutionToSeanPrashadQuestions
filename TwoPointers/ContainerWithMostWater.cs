public class Solution {
    public int MaxArea(int[] height) {
        // time complexity = o(n)
        int n = height.Length , mostwater = 0;
        // here lp and rp pointer are used as two pointers to travel in the array 
        int lp = 0 , rp = n-1; // lp at start index and rp at end index 
        while(lp < rp){
            // remove the width and height and area and then compare 
            int w = rp-lp;
            int h = Math.Min(height[lp],height[rp]);
            int currwater = w*h;
            mostwater = Math.Max(mostwater,currwater);
            // move the pointer whose height is minimum // main logic
            if(height[lp] < height[rp])
                lp++;
            else rp--;
            // if the height of lp is less move the lp forward 
            // if the height of rp is less move the rp backward
        }
        return mostwater;

    }
}
/* brute force  = will give time limit exceeded
time complexity = o(n2)
int mostwater =0 , n = height.Length ;// storing the answer 
        // removing all the possible containers
        for (int i =0; i< n; i++){
            for(int j = i+1 ;j < n; j++){
                // calculating area of all possible container and comapring 
                int w = j -i;
                int h = Math.Min(height[i], height[j]);
                int area = w*h;
                mostwater = Math.Max(mostwater,area);
            }
        }
        return mostwater;
*/