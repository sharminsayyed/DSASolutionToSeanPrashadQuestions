public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        // dry run is important
        // time complexity = o(n) space =o(n)
        //using linkedlist as dequeue 
        int n = nums.Length;
        int[] result = new int[n-k+1];
        LinkedList<int> dequeue = new LinkedList<int>(); // in this we store only indes of the ele 
        // calculation of th first window only First Window (i = 0 to k - 1) 
        // tc = o(k)
        for(int i=0 ;i<k;i++){
            // Remove indices from the back if the current element is greater
            while(dequeue.Count >0 && nums[dequeue.Last.Value] < nums[i]){
                dequeue.RemoveLast(); // if the last value entered is small then remove that value
            }
            dequeue.AddLast(i);// add the current index
        } 
        result[0] = nums[dequeue.First.Value];

        //Remaining windows (i = k to n - 1)
        // tc = o(n-k)
        for(int i= k; i<n ;i++){
            // remove the ele(index) on in the current window
            while(dequeue.Count >0 && dequeue.First.Value <= i-k){
                dequeue.RemoveFirst();
            }

            // Remove indices from the back if the current element is greater
            while(dequeue.Count >0 && nums[dequeue.Last.Value] < nums[i]){
                dequeue.RemoveLast();
            }

            dequeue.AddLast(i);

            result[i-k+1] = nums[dequeue.First.Value];
        }
        return result ;
    }
}