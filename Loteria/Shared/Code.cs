using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria.Shared
{
    public class Code
    {
        public Guid id {  get; set; }
        public string code { get; set; }
        public DateTime DateTimeCreate { get; set; }
    }
}
