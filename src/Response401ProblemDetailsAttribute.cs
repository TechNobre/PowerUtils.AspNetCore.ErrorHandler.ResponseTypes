using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Problem details response with status code 401 (Unauthorized)
    /// </summary>
    public class Response401ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response401ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status401Unauthorized) { }
    }
}
