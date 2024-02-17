using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Brand
{
    public class DeleteBrandRequest
    {
        public int Id { get; set; }

        public DeleteBrandRequest(int id)
        {
            Id = id;
        }
    }
}
