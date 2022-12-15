using System;
using System.Collections.Specialized;

namespace class_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human human_M = new human(100,200.0f,"남자");
            human human_W = new human();
            human_W.getter(50,150.0f, "여자");

            human_M.sayage();
            human_M.sayheight();
            human_M.saygender();

            Console.WriteLine("");

            human_W.sayage();
            human_W.sayheight();
            human_W.saygender();
        }
    }
}

class human
{
    private int age;
    private float height;
    private string gender;

    public human()
    {

    }

    public human(int tage, float theight, string tgender)
    {
        age = tage;
        height = theight;
        gender = tgender;
    }

    ~human()
    {

    }

    public void sayage()
    {
        Console.WriteLine("제 나이는 " + age + "살입니다.");
    }

    public void sayheight()
    {
        Console.WriteLine("제 키는 " + height + "cm입니다.");
    }

    public void saygender()
    {
        Console.WriteLine("제 성별은 " + gender + "입니다.");
    }

    public void getter(int tage, float theight, string tgender)
    {
        age = tage;
        height = theight;
        gender = tgender;
    }

}