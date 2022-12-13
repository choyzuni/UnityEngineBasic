using System;

namespace class_obj_inst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human choy = new human();

            choy.sayage();
            choy.sayheight();
            choy.sayname();

            int classsage = 3148;

            choy.getage(classsage);
            choy.sayage();
        }
    }

    class human
    {
        private int age = 30;
        private float height = 170.5f;
        private double weight = 73.4;
        private bool rest = false;
        private char gender = 'M';
        private string name = "choy";

        // C# 에는 두가지 접근 형식이 있음
        // 값 타입, 참조 타입
        //
        // 값 타입 : 할당된 메모리의 데이터를 직접 쓰고 읽는 형태
        // 참조 타입 : 할당된 메모리의 주소를 통해서 간접적으로 데이터를 쓰고 읽는 형태

        public human()
        {

        }

        ~human()
        {

        }

        public void sayage()
        {
            Console.WriteLine(age);
        }

        public void sayheight()
        {
            Console.WriteLine(height);
        }

        public void sayname()
        {
            Console.WriteLine(name);
        }

        public void getage(int t)
        {
            age = t;
        }
    }
}
