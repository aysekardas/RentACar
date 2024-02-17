using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Brand
{
    public class DeleteBrandResponse
    {
        public DeleteBrandResponse()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}
