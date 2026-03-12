using System.Text;

namespace _11_Custom_MiddleWare
{
    public class TrimMiddleware
    {
        private readonly RequestDelegate _next;

        public TrimMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Request.EnableBuffering();

            using var reader = new StreamReader(context.Request.Body, Encoding.UTF8, leaveOpen: true);
            var body = await reader.ReadToEndAsync();

            context.Request.Body.Position = 0;

            body = body.Replace("   ", "").Replace("  ", "");

            var bytes = Encoding.UTF8.GetBytes(body);
            context.Request.Body = new MemoryStream(bytes);

            await _next(context);
        }


    }
}
