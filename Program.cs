using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentTable.Add(stud1.Id, stud1);
            studentTable.Add(stud2.Id, stud2);
            studentTable.Add(stud3.Id, stud3);
            studentTable.Add(stud4.Id, stud4);

            ///every hastable entry is a dictionaryentry
            foreach (DictionaryEntry entry in studentTable)
            {
                Student storedStudent = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", storedStudent.Id, storedStudent.Name, storedStudent.GPA);
            }

            //simplest way
            foreach (Student student in studentTable.Values)
            {
                
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", student.Id, student.Name, student.GPA);
            }


            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable testTable = new Hashtable();

            foreach (Student stud in students)
            {
                if (testTable.ContainsKey(stud.Id))
                {
                    Console.WriteLine("A student with the same ID already exists.");
                }
                else
                {
                    testTable.Add(stud.Id, stud);
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
