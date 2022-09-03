using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 403 (Forbidden)
    /// </summary>
    public class Response403ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response403ProblemDetailsAttribute() : base(typeof(ErrorProblemDetails), StatusCodes.Status403Forbidden) { }
    }
}
