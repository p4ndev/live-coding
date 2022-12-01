﻿public partial class LinkedNodeList<T> {

    public Node<T>? First() => HasPeek() ? Head! : null;

    public Node<T>? Last() => HasTail() ? Tail! : null;

    public (Node<T>? Item, int Index) Find(T data) {
        if (HasPeek()) {
            int idx = 0;
            Node<T>? iterator = Head!;
            while (iterator is not null){
                if (iterator.IsEqual(data))
                    return (iterator, idx);
                iterator = iterator.Next;
                idx++;
            }
        }
        return (null, -1);
    }

    public Node<T>? FindAt(int index) {
        if (HasPeek()) {

            int _index = 0;
            Node<T>? iterator = Head!;

            if (index.Equals(_index))
                return iterator;

            while (iterator is not null) {

                if (index.Equals(_index))
                    return iterator;

                iterator = iterator.Next;
                _index++;

            }

        }
        return null;
    }

    public T[]? ToArray() {        
        T[] output;
        if (!HasPeek()) return null;

        int idx = 0;
        output = new T[Count];
        Node<T>? iterator = Head!;

        while (iterator is not null) {
            output[idx] = iterator.Data!;
            iterator = iterator.Next;
            idx++;
        }

        return output;
    }

    public IEnumerable<T?> ToStream() {
        Node<T>? temp, iterator = Head!;
        while (iterator is not null) {
            temp        = iterator;
            iterator    = iterator.Next;
            yield return temp.Data;
        }
    }

}