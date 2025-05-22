public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // time complexity = O(n)
        Dictionary<int, int> map = new Dictionary<int ,int>();
        // dictionary[key] = value
        for(int i= 0;i <nums.Length; i++){
            map[nums[i]] = i;
            // here we store all the ele of array in the dictionary with its value 
            // key = value of ele value = index of ele in array 
        }
        for(int i=0; i< nums.Length; i++){
            int num = target - nums[i];
            // 9-2 = 7 we will find if the 7 key is there in the map 
            // and check if it's not the same index, 
            // i= 0 and map[7] = 0  so 0 == 0 condition fails 
            if(map.ContainsKey(num) && map[num] != i){
                return new int[] {map[num] ,i};
                // map[key] = value 
                // map[7] = it will return value of key 7 which we have stored as index and i= which is the current index 
                // will return in form of array 
            }
        }
        return null;
    }
}
