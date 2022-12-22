using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance
{
    // abstract - 추상화 키워드
    // 멤버 앞에 붙어서 해당 멤버를 추상화 시킴
    // ( 구현부 없이 선언만 하고 해당 추상화 클래스를 상속 받은 자식이 반드시 구현 해야한다 )

    internal abstract class animal : iatk
    {
        public static string species = string.Empty;

        public abstract void breath();


        // virtual : 가상 키워드
        // 추상화용 키워드이며, 기본 구현을 할 수 있고
        // 그 구현을 다시 자식 클래스에서 재정의 할 수 있다

        public virtual void atk()
        {
            Console.WriteLine($"{species}(이)가 공격했다");
        }
    }
}
