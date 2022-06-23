
SinglyLinkedListNode llist_head;
SinglyLinkedList llist = new SinglyLinkedList();
List<int> randomNumbers = new(){ 13,7 };

// =================================================================

randomNumbers.ForEach(x => {
    llist_head = Result.InsertAtTheTail(llist.head, x);
    llist.head = llist_head;
});

// =================================================================

llist_head = Result.InsertAtHead(llist.head, 16);
llist.head = llist_head;

// =================================================================

llist_head = Result.InsertNodeAtPosition(llist.head, 1, 2);
llist.head = llist_head;

// =================================================================

Console.WriteLine("Done");