public class Solution {
    public string MinWindow(string s, string t) {
        // time complexity = o(2n)+o(m) space= o(256)
        int[] freq = new int[256];// Frequency array to track character 
        // Fill frequency array with characters from string t
        foreach(char c in t){
            freq[c]++;
        }

        int left =0, right =0;
        int start=0;    // To record the start index of the minimum window
        int minlen = int.MaxValue;  // To store the minimum window length
        int required =t.Length;// Total characters needed from t

// move the right pointer in the s string 
        for(right =0; right <s.Length; right++){
            char rchar  =s[right];// Current character at right pointer

            if(freq[rchar] >0) required--;

            freq[rchar]--;
            // When all required characters are found in the window
            while(required == 0){
                if(right- left +1 <minlen){
                    minlen = right-left+1;
                    start =left;
                }
            // Try to shrink the window from the left
                char lchar = s[left];
                freq[lchar]++;
            // If a needed character is removed, increase required
                if(freq[lchar] >0)
                {
                    required++;
                } 

                left++;
            }
        }
        return minlen == int.MaxValue? "" :s.Substring(start,minlen);
    }
}