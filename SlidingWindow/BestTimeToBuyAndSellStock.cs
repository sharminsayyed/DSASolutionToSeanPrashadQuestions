public class Solution {
    public int MaxProfit(int[] prices) {
        // time complexity = O(n)
        // here we have to buy in smaller price and sell in greater price 
        // so then only we can have a greater profit 
        int buy = 0; // left pointer
        int sell =1;// right pointer
        int maxprofit =0;
        while(sell < prices.Length){
            // if sell is greater than buy than calculate the profit 
            // and remove the maxprofit
            if(prices[sell] > prices[buy]){
                int profit = prices[sell] -prices[buy];
                maxprofit = Math.Max(maxprofit , profit);
            }
            else{ // if sell < buy then assign sell value to buy 
                buy = sell;
            }
            sell++; // incremeant sell 
        }
        return maxprofit;
    }
}