using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response404ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response404ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status404NotFound) { }
    }
}
