using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Car
{
    public class DeleteCarRequest
    {
        public int Id { get; set; }

        public DeleteCarRequest(int id)
        {
            Id = id;
        }
    }
}
