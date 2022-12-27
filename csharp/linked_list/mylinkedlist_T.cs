using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class node<T>
    {
        public T value;
        public node<T> next;
        public node<T> prev;

        public node (T tvalue)
        {
            value = tvalue;
        }

        public static bool operator ==(node<T> _1, T _2)
        {
            if (Equals(_1.value, _2))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(node<T> _1, T _2)
        {
            if (Equals(_1.value, _2))
            {
                return false;
            }

            return true;
        }
    }

    internal class mylinkedlist<T>
    {
        public node<T> first_p => first;
        public node<T> last_p => last;

        private node<T> first, last, tmp1, tmp2;

        public int count
        {
            get
            {
                int count = 0;

                tmp1 = first;

                while (tmp1 != null)
                {
                    count++;
                    tmp1 = tmp1.next;
                }

                return count;
            }
        }

        public void addfirst(T value)
        {
            tmp1 = new node<T>(value);

            // 노드가 현재 하나 이상 존재한다
            if (first != null)
            {
                tmp1.next = first;
                first.prev = tmp1;
            }

            // 노드가 하나도 없다면
            if (last == null)
            {
                last = tmp1;
            }

            first = tmp1;
        }

        public void addlast(T value)
        { 
            tmp2 = new node<T>(value);

            if (last != null)
            {
                last.next = tmp2;
                tmp2.prev = last;
            }

            if (first == null)
            {
                first = tmp2;
            }

            last = tmp2;        
        }

        public void display() // 순차적으로 출력
        {
            if (first == null)
            {
                Console.WriteLine("아무것도 추가되지 않았습니다");
                return;
            }

            node<T> dis = first;

            while (dis != null)
            {
                Console.WriteLine(dis.value);

                dis = dis.next;
            }

            Console.WriteLine($"노드의 갯수는 {count} 개 입니다.");
        }

        // public void addbefore(node<T> node, T value) // 특정 노드 뒤에
        public void addbefore(T findvalue,T value) // 특정 노드 뒤에
        {
            node<T> fnode = find(findvalue);

            if (fnode != null)
            {
                node<T> fnode2 = new node<T>(value);

                if (fnode == last)
                {
                    fnode.next = fnode2;
                    fnode2.next = null;

                    fnode2.prev = fnode;

                    last = fnode2;
                }
                else
                {
                    fnode2.next = fnode.next;
                    fnode.next.prev = fnode2;

                    fnode2.prev = fnode;
                    fnode.next = fnode2;
                }
            }
        }

        public void addafter(T findvalue, T value) // 특정 노드 앞에
        {
            node<T> fnode = find(findvalue);

            if (fnode != null)  // if (comparer<T>.default.compare(fnode.value, value) == 0) 로도 사용 가능
            {
                node<T> fnode2 = new node<T>(value);

                if (fnode == first)
                {
                    fnode2.prev = null;
                    fnode.prev = fnode2;

                    fnode2.next = fnode;

                    first = fnode2;
                }
                else
                {
                    fnode2.prev = fnode.prev;
                    fnode.prev.next = fnode2;

                    fnode2.next = fnode;
                    fnode.prev = fnode2;
                }
            }
        }

        public node<T> find(T value) // 찾기
        {
            node<T> fnode = first;

            while (fnode != value && fnode != last)
            {
                fnode = fnode.next;
            }

            if (fnode != value && fnode == last)
            {
                return null;
            }

            return fnode;
        }

        public node<T> findlast(T value) // 뒤에서부터 찾기
        {
            node<T> fnode = last;

            while (fnode != value && fnode != first)
            {
                fnode = fnode.prev;
            }

            if (fnode != value && fnode == first)
            {
                return null;
            }

            return fnode;
        }

        public bool remove(T value) // 지우기
        {
            node<T> fnode = find(value);

            if (fnode != null)
            {
                if (fnode.prev != null)
                {
                    fnode.prev.next = fnode.next;
                }
                else
                {
                    first = fnode.next;
                }

                if (fnode.next != null)
                {
                    fnode.next.prev = fnode.prev;
                }
                else
                {
                    last = fnode.prev;
                }

                //fnode.next = null;
                //fnode.prev = null;
                //fnode = null;
                // 지역변수이므로 알아서 null 값이 할당된다

                return true;
            }

            return false;
        }

        public bool removelast(T value) // 뒤에서부터 지우기
        {
            node<T> fnode = findlast(value);

            if (fnode != null)
            {
                if (fnode.prev != null)
                {
                    fnode.prev.next = fnode.next;
                }
                else
                {
                    first = fnode.next;
                }

                if (fnode.next != null)
                {
                    fnode.next.prev = fnode.prev;
                }
                else
                {
                    last = fnode.prev;
                }

                //fnode.next = null;
                //fnode.prev = null;
                //fnode = null;
                // 지역변수이므로 알아서 null 값이 할당된다

                return true;
            }

            return false;
        }
    }
}
