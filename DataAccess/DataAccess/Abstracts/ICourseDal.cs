using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts;

public interface ICourseDal
{
    void Add(Course course);
    Course GetById(int id);
    List<Course> GetAll();
    void Update(int id, string newName,string newDescription,double newPrice);
    void Delete(int id);
}
