using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response409ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response409ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status409Conflict) { }
    }
}
