using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.CrossCuttingConcerns.Exceptions
{
    public class ValidationProblemDetails : ProblemDetails
    {

        
            public IDictionary<string, string[]> Errors { get; set; }

            public ValidationProblemDetails()
            {
                Errors = new Dictionary<string, string[]>();
            }

            public ValidationProblemDetails(
                string type,
                string title,
                string detail,
                string instance,
                IDictionary<string, string[]> errors
            )
            {
                Type = type;
                Title = title;
                Detail = detail;
                Instance = instance;
                Errors = errors;
            }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }



        }
    }

