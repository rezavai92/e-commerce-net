using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRowLevelSecurity
    {
      
            string[] RolesAllowedToRead { get; set; }

            string[] IdsAllowedToRead { get; set; }

            string[] RolesAllowedToWrite { get; set; }

            string[] IdsAllowedToWrite { get; set; }

            string[] RolesAllowedToUpdate { get; set; }

            string[] IdsAllowedToUpdate { get; set; }

            string[] RolesAllowedToDelete { get; set; }

            string[] IdsAllowedToDelete { get; set; }
        
    }
}
