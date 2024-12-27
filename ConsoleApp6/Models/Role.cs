using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    // IsActive, IsDeleted , CreationDate
    public class Role: SharedProp
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

       
    }
}
