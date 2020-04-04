using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 2");

            School school1 = new School("SP1");
            Classroom class1 = new Classroom("1A");
            Classroom class2 = new Classroom("1B");
            Pupil pupil1 = new Pupil("Adam");
            Pupil pupil2 = new Pupil("Jan");
            Pupil pupil3 = new Pupil("Ania");
            class1.AddPupil(pupil1);
            class1.AddPupil(pupil2);
            class2.AddPupil(pupil3);
            school1.AddClassroom(class1);
            school1.AddClassroom(class2);

            Pupil pupil5 = pupil1.PupilCopy();
            bool test1 = Object.ReferenceEquals(pupil1, pupil5);
            bool test2 = Object.ReferenceEquals(pupil1.GetName(), pupil5.GetName());
            Console.WriteLine(test1);
            Console.WriteLine(test2);

            Classroom class3 = class1.ClassroomCopy();
            bool test3 = Object.ReferenceEquals(class3, class1);
            Console.WriteLine(test3);
            bool test4 = Object.ReferenceEquals(class3.GetClassName(), class1.GetClassName());
            Console.WriteLine(test4);
            bool test5 = Object.ReferenceEquals(class3.GetPupilsList(), class1.GetPupilsList());
            Console.WriteLine(test5);
            for (int i = 0; i < class1.GetPupilsList().Count; i++)
            {
                bool test6 = Object.ReferenceEquals(class3.GetPupilsList()[i], class1.GetPupilsList()[i]);
                Console.WriteLine(test6);
                bool test7 = Object.ReferenceEquals(class3.GetPupilsList()[i].GetName(), class1.GetPupilsList()[i].GetName());
                Console.WriteLine(test7);
            }

            School school2 = school1.SchoolCopy();
            bool test8 = Object.ReferenceEquals(school2, school1);
            Console.WriteLine(test8);

            Console.ReadKey();
        }
    }
}
