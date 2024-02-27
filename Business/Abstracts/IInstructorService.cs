using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IInstructorService
{
    IDataResult<List<Instructor>> GetAll(); 
    IDataResult<List<Instructor>>GetById(int id);
    
    IResult Add(Instructor instructor);
    IResult Update(Instructor instructor);
    IResult Delete(Instructor instructor);
}