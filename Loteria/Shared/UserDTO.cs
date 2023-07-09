using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria.Shared
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Code { get; set; }
        public bool Allow { get; set; } = true;
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
