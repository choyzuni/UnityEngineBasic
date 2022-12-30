using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_array
{

    // generic ( 일반화 )
    // 자료형을 일반화 하는 문법
    // 클래스, 구조체, 인터페이스, 함수 등의 이름 뒤에 붙어서 정해지지 않은 타입에 대한
    // 일반식을 정의할 때 사용한다

    internal class dynamic_arr<T>
    {
        // snake_case
        // UPPER_SNAKE_CASE

        // const : 상수 키워드
        // const 키워드가 붙은 변수는 초기화만 가능하며 상수처럼 사용된다
        private const int default_size = 1; // 배열의 크기는 정수형이기 때문에 이건 T로 바꾸면 안됨~
        private T[] data = new T[default_size];

        private int count;

        private int capacity { get { return data.Length; } }

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        // 삽입 알고리즘
        // 일반적으로 O(1)
        // 단, capacity 가 모자랄때는 O(n)
        public void add(T item)
        {
            if (count >= capacity)
            {
                T[] tmp = new T[(int)Math.Ceiling(Math.Log10(capacity)) + 1 + default_size];

                for (int i = 0; i < count; i++)
                {
                    tmp[i] = data[i];
                }

                data = tmp;
            }

            data[count++] = item;
        }

        // 탐색 알고리즘
        // 시간복잡도 : O(n)
        public bool contains(T target)
        {

            for (int i = 0; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(data[i], target) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // 탐색 알고리즘
        // O(n)
        public T find(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
            {
                if (match(data[i]))
                {
                    return data[i];
                }                
            }
            // default 키워드
            // 해당 타입의 고정값을 반환하는 키워드
            return default(T);
        }

        // 삭제 알고리즘
        // O(n)
        public bool remove(T item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(data[i], item) == 0)
                {
                    index = i;
                    break;
                }
            }

            for (int i = index; i < count; i++)
            {
                data[i] = data[i + 1];
            }

            count--;
            return index >= 0;
        }

        public bool removeat(int index)
        {
            if (index > count - 1)
            {
                return false;
            }

            for (int i = index; i < count; i++)
            {
                data[i] = data[i + 1];
            }

            count--;
            return true;
        }

        public void clear()
        {
            // data = new int[default_size];
            // 위 구문은 쓰레기 수집가를 통해서 자동으로 지울때 사용

            for (int i = 0; i < capacity; i++)
            {
                data[i] = default(T);
            }
        }

        public dynamicarr_enum<T> GetEnumerator()
        {
            return new dynamicarr_enum<T>(data);
        }

        // 열거자의 핵심
        // current - 열거된 자료구조에서 현재 가리키고 있는 자료 아이템
        // move next - 현재에서 그 다음 아이템을 가리키도록 하는 함수
        // reset - 가리키는 인덱스를 초기화하는 함수
        public struct dynamicarr_enum<K>
        {
            public K current { get { return data[index]; } }

            private readonly K[] data;

            private int index;


            public dynamicarr_enum(K[] origin)
            {
                data = origin;
                index = -1;
            }

            public bool movenext()
            {
                index++;

                return (index >= 0) && (index < data.Length);
            }

            public void reset()
            {
                index = -1;
            }
        }





        public string length()
        {
            return $"배열의 크기는 {data.Length}개입니다.";
        }
    }
}
