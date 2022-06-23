
SinglyLinkedListNode llist_head;
SinglyLinkedList llist = new SinglyLinkedList();
List<int> randomNumbers = new(){ 383, 484, 392, 975 };

// =================================================================

randomNumbers.ForEach(x => {
    llist_head = Result.InsertAtTheTail(llist.head, x);
    llist.head = llist_head;
});

// =================================================================

llist_head = Result.InsertAtHead(llist.head, 321);
llist.head = llist_head;

Console.WriteLine("Done");