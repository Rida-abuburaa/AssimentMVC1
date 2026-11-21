using System.Diagnostics;

namespace AssimentMVC1.CustomMiddlware
{
    public class Millscandmiddleware
    {
        private readonly RequestDelegate next;
        public Millscandmiddleware(RequestDelegate next )
        {
           this.next = next;
        }

        

        public async Task InvokeAsync(HttpContext context){

            var watch = Stopwatch.StartNew();

            // next
            await next(context);

            watch.Stop();
            Console.WriteLine($"[[{context.Request.Path}]] :: {watch.ElapsedMilliseconds} ms");

            }


    } 
}
