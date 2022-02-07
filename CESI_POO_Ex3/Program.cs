using CESI_POO_Ex3.Model;
using System;

namespace CESI_POO_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Michel", "Eleve", 15);
            Subject subject = new Subject("Eval de Maths", "Evaluation sur les additions");
            Teacher teacher = new Teacher("Patrick", "Prof", subject);

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(teacher);
            Console.ReadLine();
            Console.Clear();


            Person studentPerson = (Person) student;
            Person teacherPerson = (Person) teacher;

            Console.WriteLine(studentPerson);
            Console.WriteLine();
            Console.WriteLine(teacherPerson);

        }
    }
}
