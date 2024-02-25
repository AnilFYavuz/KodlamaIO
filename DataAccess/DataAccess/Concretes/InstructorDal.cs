using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;

namespace KodlamaIO.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.ID = 1;
        instructor1.Name = "Engin Demiroğ";

        Instructor instructor2 = new Instructor();
        instructor2.ID = 2;
        instructor2.Name = "Halit Enes Kalaycı";

        instructors = new List<Instructor> { instructor1,instructor2 };
    }

    public void Add(Instructor instructor)
    {
        instructor.ID = instructors.Count + 1;
        instructors.Add(instructor);
        Console.WriteLine("Kursiyer başarıyla eklendi.");
    }

    public void Delete(int id)
    {
        Instructor instructor = GetById(id);

        if (instructor != null)
        {
            instructors.Remove(instructor);
            Console.WriteLine("Kursiyer başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kursiyer bulunamadı.");
        }
    }

    public List<Instructor> GetAll()
    {
        foreach (Instructor instructor in instructors)
        {
            Console.WriteLine(instructor);
            Console.WriteLine("Tüm kursiyerler başarıyla listelendi.");
        }
        return instructors;
    }

    public Instructor GetById(int id)
    {
        return instructors.Find(c => c.ID == id);
    }

    public void Update(int id, string newName)
    {
        Instructor instructor = GetById(id);

        if (instructor != null)
        {
            instructor.Name = newName;
            Console.WriteLine("Kursiyer başarıyla güncellendi.");
        }
        else
        {
            Console.WriteLine("Kursiyer bulunamadı.");
        }
    }
}

