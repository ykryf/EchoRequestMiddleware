using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoRequestMiddleware
{
    class EchoRequestMiddleware
    {
        private readonly RequestDelegate next;

        public EchoRequestMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, ILogger logger = null)
        {
            Request request = new Request(context);


        }
    }
}
