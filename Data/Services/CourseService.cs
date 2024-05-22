using Data.Data.Contexts;
using Data.Factories;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Services;

public interface ICourseService
{
    Task<Course> CreateCourseAsync(CourseCreateRequest request);
    Task<IEnumerable<Course>> GetAllCourseAsync();
    Task<Course> GetCourseByIdAsync(string id);
    Task<Course> UpdateCourseAsync(CourseUpdateRequest request);
    Task<bool> DeleteCourseAsync(string id);

}

public class CourseService(IDbContextFactory<DataContext> contextFactory) : ICourseService
{
    private readonly IDbContextFactory<DataContext> _contextFactory = contextFactory;


    public async Task<Course> CreateCourseAsync(CourseCreateRequest request)
    {
        //try
        //{
            await using var context = _contextFactory.CreateDbContext();

            var courseEntity = CourseFactory.Create(request);
            context.Courses.Add(courseEntity);
            await context.SaveChangesAsync();

            return CourseFactory.Create(courseEntity);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //return null!;
    }


    public async Task<IEnumerable<Course>> GetAllCourseAsync()
    {
        //try
        //{
            await using var context = _contextFactory.CreateDbContext();
            var courseEntities = await context.Courses.ToListAsync();
            if (courseEntities != null)
            {
                return courseEntities.Select(CourseFactory.Create);
            }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        return null!;
    }

    public async Task<Course> GetCourseByIdAsync(string id)
    {
        //try
        //{
            await using var context = _contextFactory.CreateDbContext();
            var courseExists = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);
            if (courseExists != null)
            {
                var courseEntity = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);
                if (courseEntity != null)
                {
                    return CourseFactory.Create(courseEntity);
                }
            }
            Console.WriteLine("Course alrdy exists");
            return null!;
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //return null!;
    }

    public async Task<Course> UpdateCourseAsync(CourseUpdateRequest request)
    {
        //try
        //{
            await using var context = _contextFactory.CreateDbContext();
            var courseExists = await context.Courses.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (courseExists != null)
            {
                var updatedCourseEntity = CourseFactory.Create(request);
                if (updatedCourseEntity != null)
                {
                    updatedCourseEntity.Id = courseExists.Id;
                    context.Entry(courseExists).CurrentValues.SetValues(updatedCourseEntity);

                    await context.SaveChangesAsync();
                    return CourseFactory.Create(courseExists);
                }
            }
            Console.WriteLine("Course alrdy exists");
            return null!;
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //return null!;
    }

    public async Task<bool> DeleteCourseAsync(string id)
    {
        //try
        //{
            await using var context = _contextFactory.CreateDbContext();
            var courseExists = await context.Courses.AnyAsync(x => x.Id == id);
            if (courseExists)
            {
                var courseTodelete = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);
                if (courseTodelete != null)
                {
                    var result = context.Courses.Remove(courseTodelete);
                    if (result != null)
                    {
                        await context.SaveChangesAsync();
                        return true;
                    }
                }
            }
            Console.WriteLine("Course doesnt exists");
            return false;
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //return false;
    }
}
