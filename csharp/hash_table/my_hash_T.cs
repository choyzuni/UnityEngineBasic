using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    internal class my_hash_T<Tkey, Tvalue>
    {
        private const int default_size = 100;

        private Tvalue[] data = new Tvalue[default_size];

        private int Hash(Tkey key)
        {
            string keyname = key.ToString();

            int sum = 0;

            for (int i = 0; i < keyname.Length; i++)
            {
                sum += keyname[i];
            }

            return sum %= data.Length;
        }

        public void add(Tkey key, Tvalue value)
        {
            data[Hash(key)] = value;
        }

        public bool containskey(Tkey key)
        {
            return Comparer<Tvalue>.Default.Compare(data[Hash(key)], default(Tvalue)) == 0;
        }

        public bool containsvalue(Tvalue value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (Comparer<Tvalue>.Default.Compare(data[i], value) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        // out 키워드
        // 파라미터와 인자 앞에 붙어서 해당 함수가 리턴할때
        // 결정된 값을 인자에다가 대입해준다
        public bool trygetval(Tkey key, out Tvalue value)
        {
            // try - catch - finally 구문
            // 예외 잡는 구문
            // try 내에서 연산 중에 예외가 던져지면 catch문 실행
            // try - catch 문이 끝나면 finally 구문 실행 ( finally 구문은 생략 가능 )
            bool success = false;
            value= default(Tvalue);
            try
            {
                value = data[Hash(key)];
                success = true;
            }
            catch (Exception e)
            {
                success= false;
                Console.WriteLine($"invalid key {e.Message}");
                throw new Exception("ddddddddd");
                throw e;
            }
            finally
            {
            }

            return success;
        }

    }
}
