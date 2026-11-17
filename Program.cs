using System;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student()
                {
                    StudentName = "Bill"
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine(
                    "Student added successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
