using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin_tree
{
    internal class node<T>
    {
        public T value;
        public node<T> lt;
        public node<T> rt;

        public node(T tvalue)
        {
            value = tvalue;
        }
    }


    internal class my_bin_tree<T>
    {
        private node<T> root, tmp1, tmp2;

        public void add(T item)
        {
            if (root != null)
            {
                tmp1 = root;
                while (tmp1 != null)
                {
                    // 내가 추가하려는 노드값이 현재 탐색 노드값보다 작은지
                    if (Comparer<T>.Default.Compare(item, tmp1.value) < 0)
                    {
                        if (tmp1.lt != null)
                        {
                            tmp1 = tmp1.lt;
                        }
                        else
                        {
                            tmp1.lt = new node<T>(item);
                            return;
                        }
                    }
                    // 내가 추가하려는 노드값이 현재 탐색 노드값보다 큰지
                    else if (Comparer<T>.Default.Compare(item, tmp1.value) > 0)
                    {
                        if (tmp1.rt != null)
                        {
                            tmp1 = tmp1.rt;
                        }
                        else
                        {
                            tmp1.rt = new node<T>(item);
                            return;
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException($"my_bin_tree : {item} 은 이미 존재합니다");
                    }
                }
            }
            else
            {
                root = new node<T>(item);
            }
        }

        public node<T> find(T item)
        {
                node<T> fnode = root;
                while (fnode != null)
                {
                    // 내가 찾으려는 노드값이 현재 탐색 노드값보다 작은지
                    if (Comparer<T>.Default.Compare(item, fnode.value) < 0)
                    {
                        if (fnode.lt != null)
                        {
                            fnode = fnode.lt;
                        }
                        else
                        {
                            Console.WriteLine("찾으려는 값이 없습니다");
                            return null;
                        }
                    }
                    // 내가 찾으려는 노드값이 현재 탐색 노드값보다 큰지
                    else if (Comparer<T>.Default.Compare(item, fnode.value) > 0)
                    {
                        if (fnode.rt != null)
                        {
                            fnode = fnode.rt;
                        }
                        else
                        {
                            Console.WriteLine("찾으려는 값이 없습니다");
                            return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine(fnode.value);
                        return fnode;
                    }
                }
                Console.WriteLine("현재 추가된 노드가 하나도 없습니다");
                return null;
        }

        // 삭제 알고리즘
        // 삭제시 밸런싱 방법
        // 삭제한 노드의 오른쪽 자식의 가장 왼쪽으로 리프를 탐색하고
        // 더이상 왼쪽이 없더라도 오른쪽이 있으면 또 오른쪽으로 가서 가장 왼쪽 리프를 탐색하는 것을 반복한 후
        // 마지막으로 찾은 리프 노드를 원래 삭제하려던 노드의 오른쪽 자식 위치에다가 놓고
        // 원래 삭제하려던 노드의 오른쪽 자식 노든느 원래 삭제하려던 노드 위치에다가 놓는다
        public bool delete(T item)
        {
            node<T> dnode = find(item);



            return true;
        }
    }
}
