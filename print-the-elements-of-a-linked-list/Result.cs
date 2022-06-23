using static System.Console;

public class SinglyLinkedList{

    public SinglyLinkedListNode head;
    public SinglyLinkedList() => this.head = null;

}

public class SinglyLinkedListNode{

    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData){
        this.data = nodeData;
        this.next = null;
    }

}

public static class Result{

    public static SinglyLinkedListNode InsertAtTheTail(SinglyLinkedListNode head, int data) {

        if (head is null)
            return new SinglyLinkedListNode(data);

        SinglyLinkedListNode tmp = head;

        while (tmp.next != null)
            tmp = tmp.next;

        tmp.next = new SinglyLinkedListNode(data);

        return head;

    }

    public static SinglyLinkedListNode InsertAtHead(SinglyLinkedListNode llist, int data) {

        if (llist is null)
            return new SinglyLinkedListNode(data);

        SinglyLinkedListNode tmp = new(data);
        
        tmp.next = llist;

        return tmp;

    }

    public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode llist, int data, int position) {

        if (llist is null) return new SinglyLinkedListNode(data);

        SinglyLinkedListNode current = llist;

        for (int step = 1; current.next != null; step++) {
            
            if (step == position){
                var nno      = new SinglyLinkedListNode(data);                
                nno.next     = current.next;
                current.next = nno;
                current = current.next;
                break;
            }

            current = current.next;
        }

        return llist;

    }

    public static SinglyLinkedListNode RemoveNodeAtPosition(SinglyLinkedListNode llist, int position) {
        
        if (llist is null) return null;

        SinglyLinkedListNode current = llist;

        for (int step = 1; current.next != null; step++){
            
            if (step == (position - 1)){
                var dismiss  = current.next;
                current.next = dismiss.next;
                current      = current.next;
                break;
            }

            current = current.next;

        }

        return llist;

    }

    public static void Print(SinglyLinkedListNode llist) {
        
        if (llist is null) return;

        Queue<int> que = new();
        SinglyLinkedListNode current = llist.next;

        que.Enqueue(llist.data);

        while (current != null) {
            que.Enqueue(current.data);
            current = current.next;
        }

        for (int i = 0, j = que.Count; i < j; i++)
            Write("{0} ", que.Dequeue());

    }

    public static void ReversePrint(SinglyLinkedListNode llist){

        if (llist is null) return;

        Stack<int> stk = new();
        SinglyLinkedListNode current = llist.next;
        
        stk.Push(llist.data);

        while (current != null) {
            stk.Push(current.data);
            current = current.next;
        }

        for (int i = 0, j = stk.Count; i < j; i++)
            Write("{0} ", stk.Pop());

    }

}
