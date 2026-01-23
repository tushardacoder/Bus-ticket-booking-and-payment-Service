using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus__ticket_and_service_system
{
    public class User
    {

        private static int id = 0;

        public int UserId { get; }
        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public User(string name, string mobile, string emai)
        {
            id++;
            UserId = id;
            Name = name;
            Mobile = mobile;
            Email = emai;
        }


               
        

    }
}
