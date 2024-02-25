using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    Instructor GetById(int id);
    List<Instructor> GetAll();
    void Update(int id, string newName);
    void Delete(int id);
}