using StudentManagmentApp.Models;
using System.Collections.Generic;

namespace StudentManagementApp.Data
{
    public class StudentService
    {
        public List<Student> Students { get; } = new List<Student>
        {
            new Student { FirstName = "Jan", LastName = "Kowalski", BirthDate = new DateTime(2021, 5, 24), Studies = "Informatyka", AvatarUrl = "" },
            new Student { FirstName = "Anna", LastName = "Nowak", BirthDate = new DateTime(1999, 4, 12), Studies = "Biology", AvatarUrl = "" },
            new Student { FirstName = "Marcin", LastName = "Zielinski", BirthDate = new DateTime(2000, 8, 30), Studies = "Physics", AvatarUrl = "" },
            new Student { FirstName = "Katarzyna", LastName = "Wojcik", BirthDate = new DateTime(1998, 11, 5), Studies = "Law", AvatarUrl = "" },
            new Student { FirstName = "Piotr", LastName = "Kaminski", BirthDate = new DateTime(2001, 1, 15), Studies = "Computer Science", AvatarUrl = "" },
            new Student { FirstName = "Agnieszka", LastName = "Lewandowska", BirthDate = new DateTime(2002, 3, 22), Studies = "Graphic Design", AvatarUrl = "" }
        };

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
