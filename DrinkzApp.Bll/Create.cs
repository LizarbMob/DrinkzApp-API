using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Bll
{
    public class Create
    {
        public static void CreateNewProfile(ViewModel.CreateNewProfile profile)
        {
            profile.PK_PROFILE =  Dal.Profile.CreateNewProfile(new Dto.Profile {
            
                NAME = profile.NAME,
                DEVICE_ID = profile.DEVICE_ID,
                FACEBOOK_ID = profile.FACEBOOK_ID,
                URL_IMAGE = profile.URL_IMAGE,
                OS_ID = profile.OS_ID
            
            });

            Dal.Address.CreateNewAddress(new Dto.Address {
            
                FK_PROFILE = profile.PK_PROFILE,
                STATE = profile.STATE,
                STREET = profile.STREET,
                ZIP_CODE = profile.ZIP_CODE

            });
        }
    }
}
