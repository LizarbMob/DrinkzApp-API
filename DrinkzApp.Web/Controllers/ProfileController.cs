using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DrinkzApp.ViewModel;
using DrinkzApp.Bll;

namespace DrinkzApp.Web.Controllers
{
    public class ProfileController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CreateNewProfile(ViewModel.CreateNewProfile profile)
        {
            try
            {
                Bll.Create.CreateNewProfile(profile);

                return Request.CreateResponse(HttpStatusCode.OK,"Profile created");
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest,"Error, please try again later");
            }
        }
    }
}
