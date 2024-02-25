using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;

namespace KodlamaIO.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        Category category1 = new Category();
        category1.ID = 1;
        category1.Name = "Programlama";

        categories = new List<Category> { category1 };
    }

    public void Add(Category category)
    {
        category.ID = categories.Count + 1;
        categories.Add(category);
        Console.WriteLine("Kategori başarıyla eklendi.");
    }

    public void Delete(int id)
    {
        Category category = GetById(id);

        if (category != null)
        {
            categories.Remove(category);
            Console.WriteLine("Kategori başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kategori bulunamadı.");
        }
    }

    public List<Category> GetAll()
    {
        foreach (Category category in categories)
        {
            Console.WriteLine(category);
            Console.WriteLine("Tüm kategoriler başarıyla listelendi.");
        }
        return categories;
    }

    public Category GetById(int id)
    {
        return categories.Find(c => c.ID == id);
    }

    public void Update(int id, string newName)
    {
        Category category = GetById(id);

        if (category != null)
        {
            category.Name = newName;
            Console.WriteLine("Kategori başarıyla güncellendi.");
        }
        else
        {
            Console.WriteLine("Kategori bulunamadı.");
        }
    }
}