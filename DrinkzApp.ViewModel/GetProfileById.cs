using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.ViewModel
{
    /// <summary>
    /// ViewModel to get a profile by an ID
    /// Contains the profile and address INFO
    /// </summary>
    public class GetProfileById
    {
        public Dto.Profile Profile { get; set; }

        public Dto.Address Address { get; set; }
    }
}
