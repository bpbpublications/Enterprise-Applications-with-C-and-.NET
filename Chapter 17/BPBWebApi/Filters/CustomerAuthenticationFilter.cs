using System.Net;
using System.Security.Principal;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BPBWebApi.Filters
{
    public class CustomerAuthorizationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization != null)
            {
                var headerToken = actionContext.Request.Headers
                    .Authorization.Parameter;

                var decodeHeaderToken = System.Text.Encoding.UTF8.GetString(
                    Convert.FromBase64String(headerToken));
   
                var tokenValues = decodeHeaderToken.Split(':');

                if (tokenValues[0] == "admin" && 
                    tokenValues[1] == "test")
                { 
                    Thread.CurrentPrincipal = new GenericPrincipal(
                           new GenericIdentity(tokenValues[0]), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request
                        .CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);
            }
        }
    }
}






