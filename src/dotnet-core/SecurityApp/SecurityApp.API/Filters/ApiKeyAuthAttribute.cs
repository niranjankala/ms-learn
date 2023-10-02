using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityApp.API.Filters
{
    public class ApiKeyAuthAttribute
    {
        private const string CustomApiKeyParam = "X-API-Key";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var apiKey = context.HttpContext.Request.Headers.TryGetValue(CustomApiKeyParam, out var apiKeyValue);

            if (!apiKey)
            {
                context.Result = new UnauthorizedObjectResult("X-API-Key is missing in the header");
            }

            // apiKeyValue check
            //if(apiKeyValue //does not exist)
            //    context.Result = new UnauthorizedObjectResult("X-API-Key is not valid");

            //if(apiKeyValue rate < //limit for hte apiKey)
            //    context.Result = new UnauthorizedObjectResult($"{apiKeyValue} has exceeded the daily limit");

            base.OnActionExecuting(context);
        }
    }
}
