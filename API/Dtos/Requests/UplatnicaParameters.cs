using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Requests
{
    public class UplatnicaParameters
    {
        public int Id { get; set; }
        public string? SvrhaUplate { get; set; }
        public double Iznos { get; set; }
    }
}