using Lets__study_.User.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets__study_.User
{
    class User : IUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
