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
        
        }

        public void addbefore(node<T> node, T value) // 특정 노드 뒤에
        { 
        
        }

        public void addafter(node<T> node, T value) // 특정 노드 앞에
        {

        }

        public node<T> find(int value) // 찾기
        {
            return null;
        }

        public node<T> findlast(int value) // 뒤에서부터 찾기
        {
            return null;
        }

        public bool remove(int value) // 지우기
        {
            return false;
        }

        public bool removelast(int value) // 뒤에서부터 지우기
        {
            return false;
        }

    }
}
