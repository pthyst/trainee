using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        // Foreign items
        public virtual ICollection<TeamDetail> TeamDetails { get; set; }
    }
}
