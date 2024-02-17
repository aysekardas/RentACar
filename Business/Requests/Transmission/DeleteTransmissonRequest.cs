using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission
{
    public class DeleteTransmissonRequest
    {
        public int Id { get; set; }

        public DeleteTransmissonRequest(int id)
        {
            Id = id;
        }
    }
}
