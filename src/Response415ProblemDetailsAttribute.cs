using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerUtils.AspNetCore.ErrorHandler;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response415ProblemDetailsAttribute : ProducesResponseTypeAttribute
    {
        public Response415ProblemDetailsAttribute() : base(typeof(ProblemDetailsResponse), StatusCodes.Status415UnsupportedMediaType) { }
    }
}
