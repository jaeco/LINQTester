using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQRefresher_v3.Enums;
using LINQRefresher_v3.Models;
using LINQRefresher_v3.ExtensionMethods;

namespace LINQTester
{
    public class Program
    {
        List<Student> students = new List<Student>{
           new Student{Name = "Jessica Rabbit", Sex = Gender.Female, Birthdate = new DateTime(1986, 12, 5), GPA = 3.40f, Level = ClassLevel.Senior, Relationship = MaritalStatus.Married, StudentId = 1 },
           new Student{Name = "Matthew Hullabee", Sex = Gender.Male, Birthdate = new DateTime(1974,3,24) , GPA = 4.00f, Level = ClassLevel.Junior, Relationship = MaritalStatus.Widowed, StudentId = 2 },
           new Student{Name = "Joseline Hernandez", Sex = Gender.Female, Birthdate = new DateTime(1989, 5,18) , GPA = 2.10f, Level = ClassLevel.Sophomore, Relationship = MaritalStatus.Divorced, StudentId = 3 },
           new Student{Name = "Sid IceAge", Sex = Gender.Male, Birthdate = new DateTime(1980,1, 31) , GPA = 1.35f, Level = ClassLevel.Freshman, Relationship = MaritalStatus.Single, StudentId = 4 },
           new Student{Name = "Melissa Rose", Sex = Gender.Female, Birthdate = new DateTime(1993,11, 9) , GPA = 2.00f, Level = ClassLevel.Sophomore, Relationship = MaritalStatus.Divorced, StudentId = 5 },
           new Student{Name = "Taylor Rye", Sex = Gender.Male, Birthdate = new DateTime(1997,9, 20) , GPA = 3.09f, Level = ClassLevel.Freshman, Relationship = MaritalStatus.Single, StudentId = 6 },
           new Student{Name = "Liz Taylor", Sex = Gender.Female, Birthdate = new DateTime(1991,6, 6) , GPA = 1.97f, Level = ClassLevel.Senior, Relationship = MaritalStatus.Married, StudentId = 7 },
           new Student{Name = "Dante Jones", Sex = Gender.Male, Birthdate = new DateTime(1995,3, 12) , GPA = 4.00f, Level = ClassLevel.Freshman, Relationship = MaritalStatus.Single, StudentId = 8 },
           new Student{Name = "Jidenna Hudson", Sex = Gender.Male, Birthdate = new DateTime(1996,10, 25) , GPA = 2.25f, Level = ClassLevel.Junior, Relationship = MaritalStatus.Single, StudentId = 9 },
           new Student{Name = "Vivanne Gonzalez", Sex = Gender.Female, Birthdate = new DateTime(1969, 4, 15), GPA = 1.99f, Level = ClassLevel.Sophomore, Relationship = MaritalStatus.Married, StudentId = 10 },
           new Student{Name = "Dolores Limon", Sex = Gender.Female, Birthdate = new DateTime(1964, 2, 5), GPA = 2.89f, Level = ClassLevel.Senior, Relationship = MaritalStatus.Widowed, StudentId = 11 },
        };

        List<Person> person = new List<Person>{
           new Person{Name = "Jess Rabbi", Sex = Gender.Female, Birthdate = new DateTime(1986, 12, 5), Relationship = MaritalStatus.Married},
           new Person{Name = "Matt Hulla", Sex = Gender.Male, Birthdate = new DateTime(1974,3,24) , Relationship = MaritalStatus.Widowed},
           new Person{Name = "Tay Tay", Sex = Gender.Female, Birthdate = new DateTime(1986, 12, 5), Relationship = MaritalStatus.Married},
           new Person{Name = "Ken Smith", Sex = Gender.Male, Birthdate = new DateTime(1974,3,24) , Relationship = MaritalStatus.Widowed},
           new Student{Name = "Jessica Rabbit", Sex = Gender.Female, Birthdate = new DateTime(1986, 12, 5), GPA = 3.40f, Level = ClassLevel.Senior, Relationship = MaritalStatus.Married, StudentId = 1 },
           new Student{Name = "Matthew Hullabee", Sex = Gender.Male, Birthdate = new DateTime(1974,3,24) , GPA = 4.00f, Level = ClassLevel.Junior, Relationship = MaritalStatus.Widowed, StudentId = 2 },
           new Student{Name = "Joseline Hernandez", Sex = Gender.Female, Birthdate = new DateTime(1989, 5,18) , GPA = 2.10f, Level = ClassLevel.Sophomore, Relationship = MaritalStatus.Divorced, StudentId = 3 },
           new Student{Name = "Sid IceAge", Sex = Gender.Male, Birthdate = new DateTime(1980,1, 31) , GPA = 1.35f, Level = ClassLevel.Freshman, Relationship = MaritalStatus.Single, StudentId = 4 },
           new Student{Name = "Melissa Rose", Sex = Gender.Female, Birthdate = new DateTime(1993,11, 9) , GPA = 2.00f, Level = ClassLevel.Sophomore, Relationship = MaritalStatus.Divorced, StudentId = 5 },
           new Student{Name = "Taylor Rye", Sex = Gender.Male, Birthdate = new DateTime(1997,9, 20) , GPA = 3.09f, Level = ClassLevel.Freshman, Relationship = MaritalStatus.Single, StudentId = 6 },
           new Student{Name = "Liz Taylor", Sex = Gender.Female, Birthdate = new DateTime(1991,6, 6) , GPA = 1.97f, Level = ClassLevel.Senior, Relationship = MaritalStatus.Married, StudentId = 7 },
           new Student{Name = "Dante Jones", Sex = Gender.Male, Birthdate = new DateTime(1995,3, 12) , GPA = 4.00f, Level = ClassLevel.Freshman, Relationship = MaritalStatus.Single, StudentId = 8 },
           new Student{Name = "Jidenna Hudson", Sex = Gender.Male, Birthdate = new DateTime(1996,10, 25) , GPA = 2.25f, Level = ClassLevel.Junior, Relationship = MaritalStatus.Single, StudentId = 9 },
           new Student{Name = "Vivanne Gonzalez", Sex = Gender.Female, Birthdate = new DateTime(1969, 4, 15), GPA = 1.99f, Level = ClassLevel.Sophomore, Relationship = MaritalStatus.Married, StudentId = 10 },
           new Student{Name = "Dolores Limon", Sex = Gender.Female, Birthdate = new DateTime(1964, 2, 5), GPA = 2.89f, Level = ClassLevel.Senior, Relationship = MaritalStatus.Widowed, StudentId = 11 },
        };

        public static void Main(string[] args)
        {
            (new Program()).Run();
        }

        public void Run()
        {
            //Console.WriteLine("------GENDER------");
            //var collection = students.GetStudentsByGender(Gender.Female);
            //foreach(var c in collection)
            //{
            //    Console.WriteLine(c.Name + ":  " + c.Sex);                
            //}
            //Console.WriteLine("=================\n\n");



            //Console.WriteLine("------AGE------");
            //var agecollection = students.GetStudentsByAgeRange(20,30);
            //foreach (var c in agecollection)
            //{
            //    Console.WriteLine(c.Name +":  "+ c.Age);
            //}
            //Console.WriteLine("=================\n\n");



            //Console.WriteLine("------FAILING------");
            //var failcollection = students.GetTheFailingStudents();
            //foreach (var C in failcollection)
            //{
            //    Console.WriteLine(C.Name + ":  " + C.GPA);
            //}
            //Console.WriteLine("=================\n\n");

            //Console.WriteLine("------STUDENTS PER CLASS------");
            //var classcollection = students.StudentsPerClassLevel();
            //foreach (var C in classcollection)
            //{
            //    Console.WriteLine(C);
            //}
            //Console.WriteLine("=================\n\n");

            Console.WriteLine("------STATUS------");
            var statuscollection = students.MaritalStatusWithHighestAverageGPA();
            Console.WriteLine("Status: "+statuscollection);
            Console.WriteLine("=================\n\n");

        }
    }
}
