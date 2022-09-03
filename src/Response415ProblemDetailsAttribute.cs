using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 415 (UnsupportedMediaType)
    /// </summary>
    public class Response415ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response415ProblemDetailsAttribute() : base(typeof(ErrorProblemDetails), StatusCodes.Status415UnsupportedMediaType) { }
    }
}
