using System;

namespace StaticTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string fullname = "";
            do
            {
                Console.WriteLine("studentin full name'ni daxil edin");
                fullname = Console.ReadLine();

            } while (!Student.CheckFullname(fullname));

            string groupNo = "";
            do
            {             
                Console.WriteLine("studentin group no'sunu daxil edin");
                groupNo = Console.ReadLine();

            } while (! Student.CheckGroupNo(groupNo));

            Console.WriteLine("studentin yasini daxil edin");
            byte age = byte.Parse(Console.ReadLine());

            Student student1 = new Student
            {
                Fullname = fullname,
                GroupNo = groupNo,

            };

            Console.WriteLine($"FULLNAME: {fullname} | GROUPNO: {groupNo} | AGE: {age}");




        }
    }
}
