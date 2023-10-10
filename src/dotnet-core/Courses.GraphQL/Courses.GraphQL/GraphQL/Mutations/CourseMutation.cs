using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.GraphQL.Mutations
{
    public class CourseMutation:ObjectGraphType
    {
        public CourseMutation(CoursesRepository repository)
        {
            Field<CourseType>(
                "addCourse",
                "Is used to add a new course to the database",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CourseInputType>> { Name = "course", Description = "Course input parameter" }
                    ),
                resolve: context =>
                {
                    var course = context.GetArgument<Course>("course");
                    return repository.AddCourse(course);
                });
        }
    }
}
