using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 413 (PayloadTooLarge)
    /// </summary>
    public class Response413ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response413ProblemDetailsAttribute() : base(typeof(ErrorProblemDetails), StatusCodes.Status413PayloadTooLarge) { }
    }
}
