using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstracts;

public interface ICourseManager
{
    List<Course> GetAll();
    void Add(Course course);
    void Delete(int id);
    void Update(int id, string newName,string newDescription, double newPrice);
    Course GetById(int id);

}
