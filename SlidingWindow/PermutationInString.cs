public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //	O(s1.Length + s2.Length)
        if (s1.Length > s2.Length) return false;
       // using the map solution
       // Create frequency maps for s1 and sliding window of s2
        var s1map = new Dictionary<char,int>();
        var s2map = new Dictionary<char,int>();
        // Count frequency of each character in s1
        foreach(char c in s1){
            if(s1map.ContainsKey(c)) s1map[c]++;
            else s1map[c] =1;
        }

        int windowsize =s1.Length; // Set the size of the sliding window
         // Slide the window over s2 to find if the permutaion of s1 is present or not in s2
        for(int i=0; i< s2.Length; i++){
            char c = s2[i];// get current character in s2

            // Add current character to s2map (update frequency)
            if(s2map.ContainsKey(c)) s2map[c]++;
            else s2map[c] =1;

         // If window is larger than s1, remove the oldest character
            if(i >= windowsize){
                char removechar = s2[i-windowsize];// character to remove
                s2map[removechar]--; // decrease the count 
                // Remove key from map if count becomes 0
                if(s2map[removechar] == 0){
                    s2map.Remove(removechar);
                }
            }

             // When the window is fully formed, compare both maps
            if(i >= s1.Length -1 && AreEqual(s1map ,s2map)){
                return true;
            }
           
        }
    return false;
    }
 // Helper method to compare two frequency maps
    private static bool AreEqual(Dictionary<char, int> s1 ,Dictionary<char,int> s2){
        if(s2.Count() != s1.Count()) return false;// If number of keys is different, they can't be equal

        foreach(var k in s1.Keys){
            // check if the key is not present int s2 and  values of s1[key] != s2[key] then return false 
            // if any one is false 
            if(!s2.ContainsKey(k) || s1[k] != s2[k]){
                return false;
            }
        }
        return true;
    }
}