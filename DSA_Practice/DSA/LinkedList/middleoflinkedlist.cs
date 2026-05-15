/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if(head==null)
        return null ;
        //fast slow pointer technique
        ListNode slow=head;
        ListNode fast=head;
        while(fast!=null && fast.next!=null) //fast should reach the end
        {
            slow=slow.next;
            fast=fast.next.next;//2 steps ahead
        }
       return slow;//this is the middle 
    }
}