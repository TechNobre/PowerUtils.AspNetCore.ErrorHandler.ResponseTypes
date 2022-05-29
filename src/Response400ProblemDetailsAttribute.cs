using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 400 (BadRequest)
    /// </summary>
    public class Response400ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response400ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status400BadRequest) { }
    }
}
