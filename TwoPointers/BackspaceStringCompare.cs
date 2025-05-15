public class Solution {
    public bool BackspaceCompare(string s, string t) {
        // time ans space complexity = o(n+m)
        // create two arrays to store these string so that we can also change it 
        char[] schars = s.ToCharArray();
        char[] tchars = t.ToCharArray();
        // call the helper method and pass character arrays
        // returns the length of array after applying(#) backspace to the array ele
        int s1 = helpermethod(schars); 
        int t1 = helpermethod(tchars);

        // here we compare the lengths of both array to check if equal if len is not same false arrays cannot be same 
        if(s1 != t1) return false;

        //here we actually check the ele of both array if they are same 
        for(int i =0; i<s1 ;i++){
            if(schars[i] != tchars[i]) return false; // if any one ele is not equal return false 
        }

        return true ;
    }

    // helper method is used to remove the (#) backspace charaters from the array 
    // a b # c = here b will be removed from array = ac
    // and the method return 2 which is the length of array 
    public int helpermethod(char[] chars){
        int ind = 0;
        // check each character
        foreach(char c in chars){
            if(c != '#'){
                // character is not hash store it 
                chars[ind] = c;
                ind++; 
            }
            else if(ind > 0){
                // # means backspace so remove a character from last of array 
                ind--;
            }
        }
        return ind;
    }
}