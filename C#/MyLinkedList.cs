/**
Design your implementation of the linked list. You can choose to use a singly or doubly linked list.
A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and next is a pointer/reference to the next node.
If you want to use the doubly linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.

Implement the MyLinkedList class:

MyLinkedList() Initializes the MyLinkedList object.
int get(int index) Get the value of the indexth node in the linked list. If the index is invalid, return -1.
void addAtHead(int val) Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
void addAtTail(int val) Append a node of value val as the last element of the linked list.
void addAtIndex(int index, int val) Add a node of value val before the indexth node in the linked list. If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, the node will not be inserted.
void deleteAtIndex(int index) Delete the indexth node in the linked list, if the index is valid.
**/
public class MyLinkedList 
{
    private Node head;
    int count = 0;
    
    public int Get(int index) 
    {
        var node = GetNode(index);
        return node == null ? -1 : node.val;
    }
    
    public Node GetNode(int index) 
    {
        if(index >= count) 
            return null;
        var curr = head;
        for(int i = 0; i < index; i++)
            curr = curr.next;
        
        return curr;
    }
    
    public void AddAtHead(int val) 
    {
        var newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        count++;
    }
    
    public void AddAtTail(int val) 
    {
        if(head == null)
        {
            AddAtHead(val);
            return;
        }
        
        var node = GetNode(count - 1);
        node.next = new Node(val);
        count++;
    }
    
    public void AddAtIndex(int index, int val) 
    {
        if(index > count)
            return;
       if(index == 0)
       {
           AddAtHead(val);
           return;
       }
        var node = GetNode(index - 1);
        var newNode = new Node(val);
        newNode.next = node.next;
        node.next = newNode;
        count++;
    }
    
    public void DeleteAtIndex(int index) 
    {
        if(count == 0)
            return;
        
        if(index < count && index >= 0)
        {
            if(index == 0)
                head = head.next;
            else
            {
                var node = GetNode(index - 1);
                node.next = node.next.next;
            }
            
            count--;
        }
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node(int n)
    {
        val = n; 
    }
}
