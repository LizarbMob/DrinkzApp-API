using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Dal
{
    public class Address
    {
        public static void CreateNewAddress(Dto.Address address)
        {
            using (var db = new Data.DrinkzAppBDDataContext())
            {
                var dbAddress = new Data.Address() {
                
                    FK_PROFILE = address.FK_PROFILE,
                    STATE = address.STATE,
                    STREET = address.STREET,
                    ZIP_CODE = address.ZIP_CODE,

                };

                db.Addresses.InsertOnSubmit(dbAddress);

                db.SubmitChanges();
            }
        }
    }
}
