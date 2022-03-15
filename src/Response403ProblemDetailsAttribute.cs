using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response403ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response403ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status403Forbidden) { }
    }
}
