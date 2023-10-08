using Courses.GraphQL.Data.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.Types
{
    public class CourseType:ObjectGraphType<Course>
    {
        public CourseType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the Course object");
            Field(x => x.Description, type: typeof(StringGraphType)).Description("Description property from the Course object");
            Field(x => x.Name, type: typeof(StringGraphType)).Description("Name property from the Course object");
            Field(x => x.Review, type: typeof(IntGraphType)).Description("Review property from the Course object");
            Field(x => x.DateAdded, type: typeof(DateTimeGraphType)).Description("Date added property from the Course object");
            Field(x => x.DateUpdated, type: typeof(DateTimeGraphType)).Description("Date updated property from the Course object");
        }
    }
}
