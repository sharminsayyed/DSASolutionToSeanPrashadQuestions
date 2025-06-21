public class Solution {
    public int TotalFruit(int[] fruits) {
        // time complexity - O(n) // dry run
        Dictionary<int,int>basket = new Dictionary<int,int>(); // there are 2 baskets 2keys 
        int left=0,right=0; // using 2 pointers sliding window
        int maxfruit=0;
        // right pointer travels tille the end of array 
        for(right=0; right < fruits.Length ;right++){
            int fruit = fruits[right];// takes the fruit 
            // check if the fruit is not present then add the fruit in the basket with 1 count
            if(!basket.ContainsKey(fruit)){
                basket.Add(fruit,1);
            }
            else{ // if the fruit is present increment the count of that fruit 
                basket[fruit]++;
            }
            // if the basket contains more than 2 fruits then run while loop
            while(basket.Count >2){
                // loop runs until there are 3 fruits in the basket 
                int leftfruit = fruits[left]; // take the fruit on left of array
                basket[leftfruit]--; // decrement the count of fruit
                if(basket[leftfruit] == 0){ // if fruit count becomes 0 then remove that fruit
                    basket.Remove(leftfruit);
                }
                left++; // move the left pointer forward in the array 
                // loop will terminate only when there are 2 fruits in the basket
            }

            maxfruit = Math.Max(maxfruit ,right -left +1); // comapre and take maximum
        }

        return maxfruit;
    }
}