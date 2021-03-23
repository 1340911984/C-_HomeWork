using System;

namespace Work4{
    class Program{

        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        //泛型链表类
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public GenericList() { tail = head = null; }
            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t); if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action){
                Node<T> node = head;
                while(node != null)
                {
                    T data = node.Data;
                    action(data);
                    node = node.Next;
                }
            }
        }

        static void Main(string[] args) {
            GenericList<String> names = new GenericList<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            GenericList<int> nums = new GenericList<int>();
            nums.Add(32);
            nums.Add(19);
            nums.Add(12);
            nums.Add(16);
            nums.Add(116);
            nums.Add(6);
            int sum = 0;
            int max = nums.Head.Data;
            int min = nums.Head.Data;
            try
            {
                names.ForEach(s => { Console.WriteLine(s); });
                nums.ForEach (i => { sum += i; });
                nums.ForEach (i => { if (i >  max) max = i; });
                nums.ForEach (i => { if (i <= min) min = i; });
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
