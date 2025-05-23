public class Solution {
    public bool IsPalindrome(string s) {
        // time complexity = O(n)
        int n = s.Length;
        int st = 0 ,end = n-1; // 2 pointer to traverse the string 
        while(st < end){
            // check if the character is alpha numeric(a-z ,A-Z ,0-9)
            // any character beside the range will be ignored
            if(!isAlphanum(s[st])){
                st++; continue;
            }
             if(!isAlphanum(s[end])){
                end--; continue;
            }
            if(char.ToLower(s[st]) != char.ToLower(s[end])){
                return false ; //if we find the characters are not same from the ending and starting we say the string is not palindrome
            }
            // or else just move to the next character in the string 
            st++;end--; 
        }
        return true ; 
    }

    public bool isAlphanum(char ch){
       if(ch >= '0' && ch <= '9' ||
        char.ToLower(ch) >= 'a' && char.ToLower(ch) <= 'z' ){
            return true;
       }
       return false;
    }
}