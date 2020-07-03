using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvcAPI.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public string GeneralNote { get; set; }
    }
}
