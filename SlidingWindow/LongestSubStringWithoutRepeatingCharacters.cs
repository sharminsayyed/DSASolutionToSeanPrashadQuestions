public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // time complexity =O(n)
        // smart sliding window -dry run is very important 
        int left = 0,right =0;;
        int maxlen= 0;
        Dictionary<char, int> map = new Dictionary<char ,int>();
        for(right =0; right <s.Length; right++){
            // take the character from the string one by one 
            char c  = s[right];
            if(map.ContainsKey(c)){
                // check if the character is present in the map ( beacause repetition is not allowed)
                // here we shrink/slide the window 
                 // Move the left pointer just after the previous occurrence of the current character
                left = Math.Max(map[c] +1 ,left); // here we are incrementing the left pointer
            }

            // store the value in map along with the current index no (right)
            // Update or add the character's latest index
            map[c] = right;
            maxlen = Math.Max(maxlen , right -left +1);
        }
        return maxlen;
    }
}