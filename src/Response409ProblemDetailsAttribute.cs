using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 409 (Conflict)
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public class Response409ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response409ProblemDetailsAttribute() : base(typeof(ErrorProblemDetails), StatusCodes.Status409Conflict) { }
    }
}
