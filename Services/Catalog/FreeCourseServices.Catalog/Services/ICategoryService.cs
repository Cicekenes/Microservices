using FreeCourse.Shared.Dtos;
using FreeCourseServices.Catalog.Dtos;
using FreeCourseServices.Catalog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Services
{
    public interface ICategoryService
    {
        public Task<Response<List<CategoryDto>>> GetAllAsync();
        public Task<Response<CategoryDto>> CreateAsync(CategoryDto category);
        public Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
