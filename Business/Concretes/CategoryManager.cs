using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CategoryManager:ICategoryService
{
    ICategoryDal _categoryDal;
    
    
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    
    public IDataResult<List<Category>> GetAll()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll().ToList());
    }

    public IDataResult<Category> GetById(int id)
    {
        return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == id));
    }

    public IResult Add(Category category)
    {
        _categoryDal.Add(category);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Update(Category category)
    {
        _categoryDal.Update(category);
        return new SuccessResult(Messages.CategoryUpdated); 
    }

    public IResult Delete(Category category)
    {
        _categoryDal.Delete(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }
}