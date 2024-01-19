using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions
{
    //Middleware'ler arasında bir sonraki adıma geçişi sağlar.
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            
            //Delegate : Bir kod bütnünü temsil eder.
            //RequestDelegate : Bir HTTP Request  akışındaki bir sonraki adımı temsil eder.

            _next = next;

        }

        //Invoke isminde bir metod arayacak
        //Geriye Task dönüyor async yapmamız lazım
        public async Task InvokeAsync(HttpContext httpContext)
        {
            //HttpContext : Bir HTTP Request akışını temsil eder.
            //Asynchronous : Eş zamanlı olarak 
            //Synchronous  : Sırasıyla 

        }
    }
}
