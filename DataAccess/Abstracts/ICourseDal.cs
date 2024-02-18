using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
}