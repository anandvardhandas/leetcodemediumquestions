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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null || l2 == null)
                return null;

        ListNode result = new ListNode();
        
        ListNode current = result;
        
        int carry = 0;
        while(l1 != null || l2 != null)
        {      
            if(l1 != null)
            {
                carry += l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                carry += l2.val;
                l2 = l2.next;
            }
            
            current.val = carry % 10;
            carry /= 10;
            
            if(l1 !=null || l2 != null)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }
        
        if(carry == 1)
        {
            current.next = new ListNode(carry);
        }
        
        return result;
    }
}
