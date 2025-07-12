public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
       IList<int> res = new List<int>();
       
       int wordlen = words[0].Length;
       int wordcount = words.Length;
       int totallen = wordcount*wordlen;
       int n = s.Length;

       Dictionary<string ,int> wordfreq = new();
       foreach(string word in words){
            if(wordfreq.ContainsKey(word)) wordfreq[word]++;
            else wordfreq[word]=1;
       }

       for(int i=0; i< wordlen; i++){

        int left =i;// to keep strat ind from where concatenation starts
        int count =0;
        Dictionary<string ,int> ins = new();
        for(int right = i; right + wordlen <= s.Length; right += wordlen){
            // the get current word
            string word = s.Substring(right ,wordlen);

            if(wordfreq.ContainsKey(word)){
                if(!ins.ContainsKey(word)) ins[word] = 0;
                ins[word]++;
                count++;
                // if thw words occurs more times than we want then shrink thw window from front 
                while(ins[word] >wordfreq[word]){
                    //use left to shirk the window and get the word from the first 
                    string lword = s.Substring(left,wordlen);
                    ins[lword]--;// decrement the count 
                    if(ins[lword] == 0){
                        ins.Remove(lword);
                    }
                    left += wordlen;// move left to shirk the window
                    count--;// 
                }

                if(count == wordcount){
                    res.Add(left);
                }
            }
            // if the word found is not in the words string array then clear the dictionary and move to the next word 
            else{
                ins.Clear();
                count =0;
                left = right +wordlen;
            }
        }
       }
        return res;
    }
}
