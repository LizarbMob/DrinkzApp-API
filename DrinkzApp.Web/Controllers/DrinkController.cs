using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrinkzApp.Web.Controllers
{
    /// <summary>
    /// Controller for everything related to Drinks
    /// </summary>
    public class DrinkController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CreateNewDrink(ViewModel.CreateNewDrink Drink)
        {
            try
            {
                Bll.Create.CreateNewDrink(Drink);

                return Request.CreateResponse(HttpStatusCode.OK, "Drink created");
            }
            catch (Exception ex)
            {
                
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
