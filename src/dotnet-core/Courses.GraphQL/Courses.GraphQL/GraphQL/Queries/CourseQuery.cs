using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.GraphQL.Queries
{
    public class CourseQuery:ObjectGraphType
    {
        public CourseQuery(CoursesRepository repository)
        {
            Field<ListGraphType<CourseType>>(
                "courses",
                "Returns list of courses",
                resolve: context => repository.GetAllCourses());
        }
    }
}
