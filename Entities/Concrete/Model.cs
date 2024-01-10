using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Model
    {
        public int Id { get; set; }
        public int BrandId { get; set; }

        public string Name { get; set; }

        public short Year { get; set; }

        public Brand? Brand { get; set; } = null;


    }
}
