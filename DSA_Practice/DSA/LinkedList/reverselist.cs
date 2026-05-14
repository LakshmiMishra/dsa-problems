using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public class ListNode{
	    public int val;
	    public ListNode next;
	    public ListNode(int val)
	    {
	      this.val=val;
	      this.next=null;
	    }
	  }
	  public class LinkedList{
	    ListNode head;
	    public void Add(int  data){
        	      ListNode node=new ListNode(data);
        	    if(head==null){
        	      head=node;
        	      return;
        	    }
        	    ListNode curr=head;
        
        	    while(curr.next!=null){
        	      curr=curr.next;
        	    }
        	    curr.next=node;
   
        	   
        	    }
	     public void DisplayList(){
	       ListNode current = head;
	        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }

        Console.WriteLine("null");
	     }
	     public void ReverseList(){
	       ListNode Prev=null;
	       ListNode Curr=head;
	       ListNode Next=null;
	       
	       while(Curr!=null){
	         Next=Curr.next;
	         Curr.next=Prev;
	         Prev=Curr;
	         Curr=Next;
	       }
	       head=Prev;
	     }
	  }
	  
	

		public static void Main(string[] args)
		{
		 
	    LinkedList list=new LinkedList();
	    
	    for(int i=1;i<8;i++){
	         list.Add(i*10);
	    }
	  
	 
			Console.WriteLine("LinkedList :");
			list.DisplayList();
			list.ReverseList();
			Console.WriteLine("Revrese LinkedList :");
			list.DisplayList();
			
		}
	}
}