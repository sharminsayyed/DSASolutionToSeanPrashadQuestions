public class Solution {
    public bool IsSubsequence(string s, string t) {
        // time complexity = o(n)
        int i =0; int j= 0; // two pointer for 2 string 
        while(i < s.Length && j < t.Length){
            // i for s string j for t string 
            if(s[i] == t[j]){
                //  if both val are same move both pointer 
                i++;
                j++;
            }
            else{
                // only move the j pointer for second string t
                // because we checking if s is the subsequence of t
                j++;
            }
        }
        return (i == s.Length) ; // to check if have travelled eqaul to the length of s string if true we have got the sub sequence and if false we didnt got it 
    }
}