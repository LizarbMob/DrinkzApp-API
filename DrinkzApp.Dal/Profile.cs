﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkzApp.Data;

namespace DrinkzApp.Dal
{
    public class Profile
    {
        public static int CreateNewProfile(Dto.Profile profile)
        {
            using (var db = new DrinkzAppBDDataContext())
            {
                var dbProfile = new Data.Profile()
                {
                    DEVICE_ID = profile.DEVICE_ID,
                    FACEBOOK_ID = profile.FACEBOOK_ID,
                    NAME = profile.NAME,
                    URL_IMAGE = profile.URL_IMAGE,
                    OS_ID = profile.OS_ID
                };

                db.Profiles.InsertOnSubmit(dbProfile);

                db.SubmitChanges();

                return dbProfile.PK_PROFILE;
            }
        }

        public static void DeleteProfile(int id)
        {
            using (var db = new Data.DrinkzAppBDDataContext())
            {
                var dbProfile = db.Profiles.Where(c => c.PK_PROFILE == id).FirstOrDefault();

                db.Profiles.DeleteOnSubmit(dbProfile);

                db.SubmitChanges();
            }
        }
    }
}
