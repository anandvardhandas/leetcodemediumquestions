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
        
        ListNode current = head;
        int count = 1;
        
        while(current.next != null)
        {
            current = current.next;
            count++;
        }
        
        current = head;
        
        if(n > count)
            return null;
        else if(n == count)
            return head.next;
        
        for(int i = 1; i < count - n; i++)
        {
            current = current.next;
        }
        
        
        current.next = current.next.next;
        
        return head;
    }
}
