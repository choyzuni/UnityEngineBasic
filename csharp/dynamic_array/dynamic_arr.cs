using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_array
{
    internal class dynamic_arr
    {
        // snake_case
        // UPPER_SNAKE_CASE

        // const : 상수 키워드
        // const 키워드가 붙은 변수는 초기화만 가능하며 상수처럼 사용된다
        private const int default_size = 1;
        private int[] data = new int[default_size];

        private int count;

        private int capacity { get { return data.Length; } }

        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        // 삽입 알고리즘
        // 일반적으로 O(1)
        // 단, capacity 가 모자랄때는 O(n)
        public void add(int item)
        {
            if (count >= capacity)
            {
                int[] tmp = new int[(int)Math.Ceiling(Math.Log10(capacity)) + 1];

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
        public bool contains(int target)
        {

            for (int i = 0; i < count; i++)
            {
                if (data[i] == target)
                {
                    return true;
                }
            }
            return false;
        }

        // 탐색 알고리즘
        // O(n)
        public int find(Predicate<int> match)
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
            return default(int);
        }

        // 삭제 알고리즘
        // O(n)
        public bool remove(int item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (data[i] == item)
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
                data[i] = default(int);
            }
        }




        public string length()
        {
            return $"배열의 크기는 {data.Length}개입니다.";
        }
    }
}
