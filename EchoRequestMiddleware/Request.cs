using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EchoRequestMiddleware
{
    class Request
    {
        public string HttpMethod { get; set; }
        public string Body { get; set; }
        public List<Header> Headers { get; set; } = new List<Header>();
        public DateTime DateTime { get; set; }

        public Request(HttpContext context)
        {
            HttpRequest request = context.Request;
            
            HttpMethod = request.Method;
            Body = new StreamReader(request.Body).ReadToEnd();

            foreach (var header in request.Headers)
            {
                Headers.Add(new Header { Name = header.Key, Value = header.Value });
            }

            DateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
