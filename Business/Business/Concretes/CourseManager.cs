using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.Business.Abstracts;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;

namespace KodlamaIO.Business.Concretes;
public class CourseManager : ICourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int id)
    {
        _courseDal.Delete(id);
    }

    public void Update(int id, string newName, string newDescription, double newPrice)
    {
        _courseDal.Update(id, newName, newDescription, newPrice);
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }
}
