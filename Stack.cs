using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Implementera_Stack
{
    public class Stack
        /////bllalblalbla
        //changes made 
    {
        private ListNode firstNode;
        private ListNode tailNode; 
        private int lenght; 

        public Stack()
        {
            firstNode = tailNode = null;
            this.lenght = 0; 
            
        }

        public bool StackEmpty()
        {
            if (firstNode == null)
                return true;
            else return false;
        }

        public void PushStack(object InsertNode)
        {
            if (StackEmpty())
                firstNode = tailNode = new ListNode(InsertNode);
            else firstNode = new ListNode(InsertNode, FirstNode);  
        }

       public Object PopStack()
       {
           if (StackEmpty())
               throw new Exception("Error: No nodes to pop from stack");
           Object RemoveItem = firstNode.Data;
           if (firstNode == tailNode)
               firstNode = tailNode = null;
           else firstNode = firstNode.NextNode; 
           return RemoveItem; 

       }
        public ListNode FirstNode //FirstNode returnerar den första noden
        {
            get 
            { return firstNode; }

        }
        public ListNode TailNode
        {
            get
            { return tailNode; }
            
        }
        
    }
}
