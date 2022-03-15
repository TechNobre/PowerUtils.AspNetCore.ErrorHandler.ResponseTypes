using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response401ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response401ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status401Unauthorized) { }
    }
}
