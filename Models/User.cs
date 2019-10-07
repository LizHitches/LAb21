using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCapp.Models
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string email { get; set; }
        public string phoneNumber { get; set; }


        public string Password { get; set; }

    }
}
