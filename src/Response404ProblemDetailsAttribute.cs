using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 404 (NotFound)
    /// </summary>
    public class Response404ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response404ProblemDetailsAttribute() : base(typeof(ErrorProblemDetails), StatusCodes.Status404NotFound) { }
    }
}
