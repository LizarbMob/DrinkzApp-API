using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Bll
{
    public class Delete
    {
        public static void DeleteProfile(int id)
        {
            Dal.Address.DeleteProfileAddress(id);

            Dal.Profile.DeleteProfile(id);
        }
    }
}
