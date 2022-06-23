
SinglyLinkedListNode llist_head;
SinglyLinkedList llist = new SinglyLinkedList();
List<int> randomNumbers = new(){ 6,2,19,7,15,9 };

// =================================================================

// place all numbers linked
randomNumbers.ForEach(x => {
    llist_head = Result.InsertAtTheTail(llist.head, x);
    llist.head = llist_head;
});

// =================================================================

// place 20 at the beginning
llist_head = Result.InsertAtHead(llist.head, 20);
llist.head = llist_head;

// =================================================================

// place 6 before 15
llist_head = Result.InsertNodeAtPosition(llist.head, 6, 5);
llist.head = llist_head;

// =================================================================

// remove number 2
llist_head = Result.RemoveNodeAtPosition(llist.head, 3);
llist.head = llist_head;
