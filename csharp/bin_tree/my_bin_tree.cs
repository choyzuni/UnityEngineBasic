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
                        // throw new InvalidOperationException($"my_bin_tree : {item} 은 이미 존재합니다");
                        Console.WriteLine($"중복된 값이 존재합니다 / 값 : {item}");
                        return;
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
                    fnode = fnode.lt;
                }
                // 내가 찾으려는 노드값이 현재 탐색 노드값보다 큰지
                else if (Comparer<T>.Default.Compare(item, fnode.value) > 0)
                {
                    fnode = fnode.rt;
                }
                else
                {
                    return fnode;
                }
            }
            return null;
        }

        public node<T> findparent(T item)
        {
            node<T> fpnode = root;

            while (fpnode != null)
            {
                // 내가 찾으려는 노드값이 현재 탐색 노드값보다 작은지
                if (Comparer<T>.Default.Compare(item, fpnode.value) < 0)
                {
                    if (fpnode.lt == null)
                    {
                        return null;
                    }
                    if (Comparer<T>.Default.Compare(item, fpnode.lt.value) == 0)
                    {
                        return fpnode;
                    }

                    fpnode = fpnode.lt;
                }
                // 내가 찾으려는 노드값이 현재 탐색 노드값보다 큰지
                else if (Comparer<T>.Default.Compare(item, fpnode.value) > 0)
                {
                    if (fpnode.rt == null)
                    {
                        return null;
                    }
                    if (Comparer<T>.Default.Compare(item, fpnode.rt.value) == 0)
                    {
                        return fpnode;
                    }

                    fpnode = fpnode.rt;
                }
                else
                {
                    return fpnode;
                }
            }
            return null;
        }


        // 삭제 알고리즘
        // 삭제시 밸런싱 방법
        // 삭제한 노드의 오른쪽 자식의 가장 왼쪽으로 리프를 탐색하고
        // 더이상 왼쪽이 없더라도 오른쪽이 있으면 또 오른쪽으로 가서 가장 왼쪽 리프를 탐색하는 것을 반복한 후
        // 마지막으로 찾은 리프 노드를 원래 삭제하려던 노드의 오른쪽 자식 위치에다가 놓고
        // 원래 삭제하려던 노드의 오른쪽 자식 노드는 원래 삭제하려던 노드 위치에다가 놓는다
        public bool remove(T item)
        {
            node<T> rpnode = findparent(item);
            node<T> rnode = find(item);
            node<T> tmpnode;

            if (rnode == null)
            {
                return false;
            }

            // 지우고자 하는 노드가 최상단 루트 노드라면?
            if (Comparer<T>.Default.Compare(rnode.value, rpnode.value) == 0)
            {
                tmpnode = findmaxnode(rnode);
                node<T> tmppnode = findparent(tmpnode.value);

                tmpnode.lt = root.lt;
                tmpnode.rt = root.rt;
                root = tmpnode;

                if (Comparer<T>.Default.Compare(tmpnode.value, tmppnode.value) < 0)
                {
                    tmppnode.lt = null;
                }
                else
                {
                    tmppnode.rt = null;
                }

                return true;
            }

            if (rnode.lt == null && rnode.rt == null) // 삭제할 노드의 자식이 없는 경우
            {
                // 자식 단말 노드의 키값이 부모 노드보다 작을 경우 lt
                if (Comparer<T>.Default.Compare(rnode.value, rpnode.value) < 0)
                {
                    rpnode.lt = null;
                }
                // 자식 단말 노드의 키값이 부모 노드보다 클 경우 rt
                else
                {
                    rpnode.rt = null;
                }
                return true;
            }
            else if (rnode.lt == null || rnode.rt == null) // 삭제할 노드의 자식이 1개인 경우
            {
                // 자식 단말 노드의 키값이 부모 노드보다 작을 경우 lt
                if (Comparer<T>.Default.Compare(rnode.value, rpnode.value) < 0)
                {
                    if (rnode.lt != null)
                    {
                        tmpnode = rnode.lt;
                        rpnode.lt = null;
                        rpnode.lt = tmpnode;
                    }
                    else
                    {
                        tmpnode = rnode.rt;
                        rpnode.lt = null;
                        rpnode.lt = tmpnode;
                    }
                }
                // 자식 단말 노드의 키값이 부모 노드보다 클 경우 rt
                else
                {
                    if (rnode.lt != null)
                    {
                        tmpnode = rnode.lt;
                        rpnode.rt = null;
                        rpnode.rt = tmpnode;
                    }
                    else
                    {
                        tmpnode = rnode.rt;
                        rpnode.rt = null;
                        rpnode.rt = tmpnode;
                    }
                }
                return true;
            }
            else // 삭제할 노드의 자식 노드가 2개일 경우
            {
                tmpnode = findmaxnode(rnode);

                // 자식 단말 노드의 키값이 부모 노드보다 작을 경우 lt
                if (Comparer<T>.Default.Compare(rnode.value, rpnode.value) < 0)
                {
                    rnode.rt.lt = rnode.lt;
                    rpnode.lt = null;
                    rpnode.lt = tmpnode;
                }
                // 자식 단말 노드의 키값이 부모 노드보다 클 경우 rt
                else
                {
                    rnode.lt.rt = rnode.rt;
                    rpnode.rt = null;
                    rpnode.rt = tmpnode;
                }
                return true;
            }
        }

        public void InorderTravers(node<T> rootnode)
        {
            if (rootnode != null)
            {
                if (rootnode.lt != null)
                {
                    InorderTravers(rootnode.lt);
                }
                Console.WriteLine(rootnode.value);
                if (rootnode.rt != null)
                {
                    InorderTravers(rootnode.rt);
                }
            }
        }

        public node<T> findmaxnode(node<T> node)
        {
            node = node.rt;

            while (true)
            {
                if (node.lt != null)
                {
                    node = node.lt;
                }
                else if (node.rt != null)
                {
                    node = node.rt;
                }
                else
                {
                    return node;
                }
            }
        }

        public node<T> getroot()
        {
            return root;
        }
    }
}
