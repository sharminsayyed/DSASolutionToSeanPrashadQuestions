/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
 // very similar to find the duplicate number problem 
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        // time complexity =O(n) space =O(1)
        ListNode slow = head , fast =head;
        // check if there are only 2 ele or more 
        while(fast.next != null && fast.next.next != null){
            // move slow by 1 step and fast by 2 step 
            slow = slow.next;
            fast = fast.next.next;

            // when slow and fast pointers meet at a point
            // intailize fast to head again  
            if(slow == fast){
                fast = head;
                while(slow != fast){
                    // and move both pointers by one step only 
                    // and  the loop terminates when they meet again 
                    // they will meet at the point where cycle starts
                    slow = slow.next;
                    fast = fast.next;
                }
               return fast; // return that point
            }
        }
        return null;
    }
}