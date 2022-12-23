using System;


namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person_1 = new person("사람", 357, "naver.com");
            student student_1 = new student("학생", 475, "gmail.com");
            professor professor_1 = new professor("교수", 555, "nate.com");

            person_1.purchasePP();
            student_1.purchasePP();
            professor_1.purchasePP();

            Console.WriteLine();

            // 공변성
            // 자식 타입으로 캐스팅, 참조할 수 있는 성질
            //
            // 반공변성
            // 부모 타입으로 캐스팅, 참조할 수 있는 성질
            //
            // 불공변성
            // 다른 타입으로 참조 불가능

            person student_2 = student_1;
            person professor_2 = professor_1;

            person[] people = new person[] { student_1, professor_1 };

            for (int ti = 0; ti < people.Length; ti++)
            {
                people[ti].purchasePP();
            }

            Console.WriteLine();

            // animal animal = new animal();

            cat cat_1 = new cat();

            student_1.atk();
            cat_1.atk();

            Console.WriteLine();

            iatk[] iatks = new iatk[] { person_1, professor_1, student_1, cat_1 };

            for (int ti = 0; ti < iatks.Length; ti++)
            {
                iatks[ti].atk();
            }

            

        }
    }
}
