using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Requests
{
    public class UgovorParameters
    {
        public int BrojUgovora { get; set; }
        public DateTime Datum { get; set; }
    }
}