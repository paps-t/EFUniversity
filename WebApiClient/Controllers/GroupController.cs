using DAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiClient.Controllers
{
    public class GroupController : ApiController
    {
        private UniversityContext context;

        public IEnumerable<Group> GetAllGroups()
        {
            IEnumerable<Group> groups = null;

            try
            {
                return context.Groups.AsEnumerable<Group>();
            }
            catch(Exception)
            {
                //this.ActionContext.Response.StatusCode = HttpStatusCode.InternalServerError;
            }
        }
    }
}
