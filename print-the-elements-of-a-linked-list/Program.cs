
SinglyLinkedListNode llist_head;
SinglyLinkedList llist = new SinglyLinkedList();
List<int> randomNumbers = new(){ 6,2,19,7,15,9 };

// ================== Place all numbers linked =======================

randomNumbers.ForEach(x => {
    llist_head = Result.InsertAtTheTail(llist.head, x);
    llist.head = llist_head;
});

// ================ Place 20 at the beginning ========================

llist_head = Result.InsertAtHead(llist.head, 20);
llist.head = llist_head;

// ====================== Place 6 before 15 ==========================

llist_head = Result.InsertNodeAtPosition(llist.head, 6, 5);
llist.head = llist_head;

// ======================= Remove number 2 ============================

llist_head = Result.RemoveNodeAtPosition(llist.head, 3);
llist.head = llist_head;

// ======================= Print items ============================

Result.Print(llist.head);
Console.WriteLine("\n------------------------------------------------\n");

// ======================= Reversed print ============================

Result.ReversePrint(llist.head);
Console.WriteLine("\n------------------------------------------------\n");