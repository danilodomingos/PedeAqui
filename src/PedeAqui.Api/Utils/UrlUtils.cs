using Microsoft.AspNetCore.Http;

namespace PedeAqui.Api.Utils
{
    public  static class UrlUtils
    {
        public static string GetLocation(this HttpContext httpContext, object id)
        {
            var request = httpContext.Request;
            return $"{request.Scheme}://{request.Host}{request.Path}/{id}";
        }
    }
}