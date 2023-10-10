using Courses.GraphQL.GraphQL.Mutations;
using Courses.GraphQL.GraphQL.Queries;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.GraphQL
{
    public class AppSchema:Schema
    {
        public AppSchema(CourseQuery query, CourseMutation mutation)
        {
            this.Query = query;
            this.Mutation = mutation;
        }
    }
}
