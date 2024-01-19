using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.CrossCuttingConcerns.Exceptions
{
    public class BusinessException : Exception
    {

        public BusinessException(string message) : base(message) 
        {
            
        }

        
        //Kendim de yapabilirim; ekstra bir mekanizma ekleyeceksem;
        //public string _message; 
        //public override string Message =>_message;
        //public BusinessException(string message) : base(message)
        //{_message = message;}
    }
}
