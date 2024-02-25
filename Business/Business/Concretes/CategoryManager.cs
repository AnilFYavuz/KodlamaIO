using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;

namespace KodlamaIO.Business.Concretes;

public class CategoryManager //: ICategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public void Update(int id, string newName)
    {
        _categoryDal.Update(id, newName);
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }
}

