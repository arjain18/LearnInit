using System.Runtime.CompilerServices;

namespace LearnInit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Id = 23 };
            student.Name = "aj";
            //student.Id = 23;
            student.Standard = 34;
            Console.WriteLine(student.Id + " " + student.Name + " " + student.Standard);
        }
     }

    public class Student
    {
        //init introduce in C# 9
        public int Id { get; init; }
        public string Name { get; set; }
        public int Standard {  get; set; }
        //public Student(int Id)
       // {
       //     this.Id = Id;
      //  }
    }
}
