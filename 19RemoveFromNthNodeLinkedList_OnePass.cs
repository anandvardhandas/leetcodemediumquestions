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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null)
            return null;
        
        ListNode behind = head;        
        ListNode ahead = head;
        for(int i = 1; i <= n+1; i++ )
        {
            if(ahead == null)
                return head.next;
            ahead = ahead.next;
        }
        
        while(ahead != null)
        {
            ahead = ahead.next;
            behind = behind.next;
        }
        
        behind.next = behind.next.next;
        
        return head;
    }
}
