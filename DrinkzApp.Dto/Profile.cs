using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Dto
{
    /// <summary>
    /// Class Profile from DataBase
    /// </summary>
    public class Profile
    {
        public int PK_PROFILE { get; set; }

        public string FACEBOOK_ID { get; set; }

        public string NAME { get; set; }

        public string URL_IMAGE { get; set; }

        public string DEVICE_ID { get; set; }

        public int OS_ID { get; set; }
    }
}
