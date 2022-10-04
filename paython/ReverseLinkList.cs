"""
Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.

Example 1:
Input: head = [1,2,3,4,5], left = 2, right = 4
Output: [1,4,3,2,5]
Example 2:

Input: head = [5], left = 1, right = 1
Output: [5]
"""

class Solution:
    def reverseBetween(self, head: Optional[ListNode], left: int, right: int) -> Optional[ListNode]:
        i=1
        arr=[]
        h=head
        while head:
            if left==i:
                arr.append(head.val)
            elif left<i<right:
                arr.append(head.val)
            elif i==right:
                arr.append(head.val)
            i+=1
            head=head.next
        j=1
        head=h
        while head:
            if j==left:
                head.val=arr.pop(-1)
            elif left<j<right:
                head.val=arr.pop(-1)
            elif j==right:
                head.val=arr.pop(-1)
            head=head.next
            j+=1
        return h

