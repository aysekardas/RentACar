using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions
{
    public class BusinessProblemDetails : ProblemDetails
    {
        //JSON formatta geri dönüştürülmesini istiyorum 
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
            //içinde bulunduğu nesnenin bir çıktısını oluştur ve JSON olarak geri dön
            //birden fazla alanı tek seferde döndürmek için JSON
        }
    }
}
