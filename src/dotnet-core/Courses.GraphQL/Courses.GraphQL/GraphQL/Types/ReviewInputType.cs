using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.GraphQL.Types
{
    public class ReviewInputType:InputObjectGraphType
    {
        public ReviewInputType()
        {
            Name = "ReviewInputType";

            Field<IntGraphType>("Rate");
            Field<StringGraphType>("Comment");            
        }
    }
}
