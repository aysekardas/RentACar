using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class Brand : Entity<int>
    {

        public string Name { get; set; }
        //public string LogoUrl { get; set; }
        //public bool Premium { get; set; }
        //public double Rating { get; set; }
        public Brand()
        {

        }
        public Brand(string name) 
        {
            Name = name;
        }
        //public Brand(string name, string logoUrl, bool premium, double rating)
        //{
        //    Name = name;
        //    LogoUrl = logoUrl;
        //    Premium = premium;
        //    Rating = rating;
        //}

        public ICollection<Model> Models { get; set; } = null;
    }
}
