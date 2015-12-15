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
    /// <summary>
    /// Profile controller where you can create,select and delete anything
    /// linked to the profile
    /// </summary>
    public class ProfileController : ApiController
    {
        /// <summary>
        /// Create a new Profile
        /// </summary>
        /// <param name="profile">a ViewModel of profile with all parameters needed to create one</param>
        /// <returns>Message if the profile was created or the error explaining why it was not created</returns>
        [HttpPost]
        public HttpResponseMessage CreateNewProfile(ViewModel.CreateNewProfile profile)
        {
            try
            {
                Bll.Create.CreateNewProfile(profile);

                return Request.CreateResponse(HttpStatusCode.OK, "Profile created");
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// <summary>
        /// Deletes a profile by ID
        /// </summary>
        /// <param name="id">Id of the profile you desire to delete</param>
        /// <returns>Message if it was deleted or an error explaining why it was not deleted</returns>
        [HttpDelete]
        public HttpResponseMessage DeleteProfile(int id)
        {
            try
            {
                Bll.Delete.DeleteProfile(id);

                return Request.CreateResponse(HttpStatusCode.OK, "Profile Deleted");
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// <summary>
        /// Get a profile selected by an ID
        /// </summary>
        /// <param name="id">ID of the profile you want to get the information</param>
        /// <returns></returns>
        [HttpGet]
        public ViewModel.GetProfileById GetProfileById(int id)
        {

            var Profile = Bll.Select.GetProfileById(id);

            if(Profile.Profile == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, String.Format("Profile {0} not found.", id)));
            }

            return Profile;
        }

        [HttpPut]
        public HttpResponseMessage UpdateProfile(ViewModel.UpdateProfile profile)
        {
            try
            {
                Bll.Update.UpdateProfile(profile);

                return Request.CreateResponse(HttpStatusCode.OK, "Profile Updated");
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
