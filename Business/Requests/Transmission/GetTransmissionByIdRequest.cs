using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission
{
    public class GetTransmissionByIdRequest
    {
        public int Id { get; set; }

        public GetTransmissionByIdRequest(int id)
        {
            Id = id;
        }
    }
}
