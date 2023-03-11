using CollegeApp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
       public static List<Student> Students { get; set; } =  new List<Student>()
            {
                new Student
                {
                  Id = 1,
                  StudentName = "Kousik panda",
                  Email = "K@gmail.com",
                  Address = "Jhargram, wb"
                },
                 new Student
                {
                  Id = 2,
                  StudentName = "Viswajeet",
                  Email = "viswa@gmail.com",
                  Address = "Bihar"
                }
            };
    }
}