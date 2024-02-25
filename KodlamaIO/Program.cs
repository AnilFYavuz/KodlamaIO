using KodlamaIO.Business.Concretes;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;

CourseManager courseManager = new(new CourseDal());

List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name);
}