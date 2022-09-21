using FreeCourse.Shared.Dtos;
using FreeCourseServices.Catalog.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Services
{
    public interface ICourseService
    {
        public Task<Response<List<CourseDto>>> GetAllAsync();
        public Task<Response<CourseDto>> GetByIdAsync(string id);
        public Task<Response<List<CourseDto>>> GetAllByUserId(string userId);
        public Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        public Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdate);
        public Task<Response<NoContent>> DeleteAsync(string id);
    }
}
