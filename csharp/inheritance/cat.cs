using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class cat : animal
    {
        // override : 재정의 키워드
        // 추상화 함수를 재정의 할 때 사용한다

        public override void breath()
        {
            throw new NotImplementedException();
        }

        public override void atk()
        {
            // base 키워드 : 상위타입 ( 부모 )
            // base.atk(); // 기존 부모 클래스의 함수를 베이스로 먼저 호출하고
            Console.WriteLine($"{species}(이)가 이중 공격을 했다");
        }
    }
}
