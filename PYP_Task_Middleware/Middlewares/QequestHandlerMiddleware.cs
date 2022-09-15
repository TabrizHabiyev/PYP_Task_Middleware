namespace PYP_Task_Middleware.Middlewares
{
    public class QequestHandlerMiddleware
    {
        private readonly IConfiguration _configuration;
        private readonly RequestDelegate _next;
        public QequestHandlerMiddleware(RequestDelegate next , IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
           _configuration.GetSection("CompanyInfo").GetChildren().ToList().ForEach(x =>
            {
                context.Response.Headers.Add(x.Key, x.Value);
            });

            await _next.Invoke(context);
        }
    }
}
