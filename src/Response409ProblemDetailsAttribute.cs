using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 409 (Conflict)
    /// </summary>
    public class Response409ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response409ProblemDetailsAttribute() : base(typeof(ErrorProblemDetails), StatusCodes.Status409Conflict) { }
    }
}
