using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Car
{
    public class GetCarByIdRequest
    {
        public int Id{ get; set; }

        public GetCarByIdRequest(int id)
        {
            Id = id;
        }
    }
}
