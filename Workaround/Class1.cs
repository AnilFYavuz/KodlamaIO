using KodlamaIO.Business.Concretes;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace KodlamaIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());

            List<Course> courses2 = courseManager.GetAll();

            for (int i = 0; i < courses2.Count; i++)
            {
                Console.WriteLine(courses2[i].Name);
            }
        }
    }
}