using System.Collections.ObjectModel;
using Core.Entities;

namespace Entities.Concretes;

public class Instructor: IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Collection<Course> Courses { get; set; }
}   