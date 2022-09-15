using PYP_Task_Middleware.Middlewares;

namespace PYP_Task_Middleware.Entensions
{
    public static class MiddlewaresExtension
    {
        public static IApplicationBuilder UseRequestHeader(this IApplicationBuilder header)
        {
            header.UseMiddleware<QequestHandlerMiddleware>();
            return header;
        }
    }
}
