﻿using Data.Models;
using Data.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
namespace Data.GraphQL.Mutations;

public class CourseMutation(ICourseService courseService)
{
    private readonly ICourseService _courseService = courseService;


    [GraphQLName("createCourse")]
    public async Task<Course> CreateCourseAsync(CourseCreateRequest input)
    {
        return await _courseService.CreateCourseAsync(input);
    }

    [GraphQLName("updateCourse")]
    public async Task<Course> UpdateCourseAsync(CourseUpdateRequest input)
    {
        return await _courseService.UpdateCourseAsync(input);
    }

    [GraphQLName("deleteCourses")]
    public async Task<bool> DeleteCourseAsync(string id)
    {
        return await _courseService.DeleteCourseAsync(id);
    }
}
