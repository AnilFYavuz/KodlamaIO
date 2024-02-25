using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts;

public interface ICategoryDal
{
    void Add(Category category);
    Category GetById(int id);
    List<Category> GetAll();
    void Update(int id, string newName);
    void Delete(int id);
}