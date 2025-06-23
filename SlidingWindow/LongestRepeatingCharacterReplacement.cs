public class Solution {
    public int CharacterReplacement(string s, int k) {
        // dry run - time complexity = O(n)
        Dictionary<char ,int>dict = new Dictionary<char,int>();
        int left =0 ,right =0; // taking to 2 pointer to the length of window 
        int maxlen =0;
        int maxcharcount =0; // keep the max count of a character 
        for(right =0; right <s.Length; right++){
            char c = s[right]; // take the character from the string
            // check if char present in the dict then increment its count 
            // or else add the char in dict
            if(dict.ContainsKey(c)) 
                dict[c]++;
            else 
                dict.Add(c,1);
            
            // get the maximum count of a single character 
            maxcharcount = Math.Max(maxcharcount , dict[c]);
            // Check if we need to shrink the window
            // If number of characters to replace > k, move left pointer
            while((right -left +1) -maxcharcount >k){
                char leftchar = s[left];
                dict[leftchar]--;// Remove one count of the left character
                left++;// Shrink window from the left
            }

        // Update the maximum window size found so far
            maxlen = Math.Max(maxlen , right-left+1);
        }
        return maxlen;
    }
}