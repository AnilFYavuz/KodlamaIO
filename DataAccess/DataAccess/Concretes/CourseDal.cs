using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.DataAccess.Abstracts;

namespace KodlamaIO.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.ID = 1;
        course1.Name = "Senior Yazılımcı Geliştirme Kampı (.NET)";
        course1.Description =
            "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız";
        course1.Price = 0;

        Course course2 = new Course();
        course2.ID = 2;
        course2.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)";
        course2.Description =
            "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
        course2.Price = 0;

        Course course3 = new Course();
        course3.ID = 3;
        course3.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)";
        course3.Description =
            "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
        course3.Price = 0;

        Course course4 = new Course();
        course4.ID = 4;
        course4.Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)";
        course4.Description =
            "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
        course4.Price = 0;

        Course course5 = new Course();
        course5.ID = 5;
        course5.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
        course5.Description =
            "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
        course5.Price = 0;

        Course course6 = new Course();
        course6.ID = 6;
        course6.Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT)";
        course6.Description =
            "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
        course6.Price = 0;

        Course course7 = new Course();
        course7.ID = 7;
        course7.Name = "2024 - Yazılım Geliştirici Yetiştirme Kampı C#";
        course7.Description =
            "Ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
        course7.Price = 0;

        Course course8 = new Course();
        course8.ID = 8;
        course8.Name = "Programlamaya Giriş İçin Temel Kurs";
        course8.Description =
            "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.";
        course8.Price = 0;

        courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };
    }

    //Create operasyonu
    public void Add(Course course)
    {
        course.ID = courses.Count + 1;
        courses.Add(course);
        Console.WriteLine("Kurs başarıyla eklendi.");
    }

    //Read operasyonu
    public Course GetById(int id)
    {
        return courses.Find(c => c.ID == id);
    }

    public List<Course> GetAll()
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(course);
            Console.WriteLine("Tüm kurslar başarıyla listelendi.");
        }
        return courses;
    }

    //Update operasyonu
    public void Update(int id, string newName,string newDescription,double newPrice)
    {
        Course course = GetById(id);

        if (course != null)
        {
            course.Name = newName;
            course.Description = newDescription;
            course.Price = newPrice;
            Console.WriteLine("Kurs başarıyla güncellendi.");
        }
        else
        {
            Console.WriteLine("Kurs bulunamadı.");
        }
    }

    //Delete operasyonu
    public void Delete(int id)
    {
        Course course = GetById(id);

        if (course != null)
        {
            courses.Remove(course);
            Console.WriteLine("Kurs başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kurs bulunamadı.");
        }
    }
}

