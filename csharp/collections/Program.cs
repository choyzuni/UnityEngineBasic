using System;
using System.Collections;
using System.Collections.Generic;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Collections;
            // .net 제공 자료구조 클래스 및 인터페이스
            
            // Arraylist
            // object type 동적 배열

            ArrayList arrlist = new ArrayList();

            arrlist.Add("초이");
            arrlist.Add(123);
            arrlist.Add(0.5);

            arrlist.Remove(0.5);

            Console.WriteLine(arrlist[arrlist.IndexOf(123)]);

            // Hashtable
            // object type 해쉬 테이블

            Hashtable hasht = new Hashtable();

            hasht.Add("choy", 88);
            hasht["choy"] = 99;
            hasht.Remove("choy");

            Console.WriteLine("===================");

            // SSystem.Collections.Generic;
            // .net 제공 자료구조 제네릭 클래스 및 인터페이스

            // List<T>
            // 제네릭 동적 배열
            List<int> list = new List<int>();

            list.Add(3);
            list.Find(x => x == 3);
            list.Remove(3);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // LinkedList<T>
            // 제네릭 링크드 리스트
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddLast(3);
            lst.AddFirst(2);
            lst.AddBefore(lst.Find(3), 7);
            lst.Remove(4);
            lst.Contains(8);

            // Dictionary<T, T>
            // 제네릭 해쉬 테이블
            Dictionary<int, string> pairs= new Dictionary<int, string>();

            pairs.Add(18, "지루하다");
            pairs.Add(19, "아 지루하다");
            pairs.Add(20, "아 준나 지루하다");
            pairs.Add(21, "아 준나게 지루하다");
            pairs.Add(22, "아 준나게 지루하다~");


            // foreach 문
            // IEnumerable 을 iterating 하기 위한 구문
            // IEnumerable 의 모든 아이템들을 중복 없이 순회하는 구문
            foreach (KeyValuePair<int, string> item in pairs)
            {
                Console.Write(item.Key);
                Console.Write("  ");
                Console.WriteLine(item.Value);
            }





        }
    }
}
