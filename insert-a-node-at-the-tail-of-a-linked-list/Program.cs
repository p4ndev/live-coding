
SinglyLinkedListNode llist_head;
SinglyLinkedList llist = new SinglyLinkedList();
List<int> randomNumbers = new(){ 141, 302, 164, 530, 474 };

// =================================================================

randomNumbers.ForEach(x => {
    
    llist_head = Result.Process(llist.head, x);
    
    llist.head = llist_head;

});