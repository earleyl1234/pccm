using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Web;

namespace PCCM.Web.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetShortNameCode(this IIdentity principal)
        {
            var claimsPrincipal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            if (claimsPrincipal == null)
            {
                throw new Exception("User is not logged in.");
            }

            var nameClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "Claims.UserShortName");
            if (nameClaim != null)
            {
                return nameClaim.Value;
            }
            return string.Empty;
        }

        public static string GetUserFullName(this IIdentity principal)
        {
            var claimsPrincipal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            if (claimsPrincipal == null)
            {
                throw new Exception("User is not logged in.");
            }

            var nameClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "Claims.FullName");
            if (nameClaim != null)
            {
                return nameClaim.Value;
            }
            return string.Empty;
        }

        public static string GetUserFirstName(this IIdentity principal)
        {
            var claimsPrincipal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            if (claimsPrincipal == null)
            {
                throw new Exception("User is not logged in.");
            }

            var nameClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "Claims.FirstName");
            if (nameClaim != null)
            {
                return nameClaim.Value;
            }
            return string.Empty;
        }

        public static string GetUserLastName(this IIdentity principal)
        {
            var claimsPrincipal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            if (claimsPrincipal == null)
            {
                throw new Exception("User is not logged in.");
            }

            var nameClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "Claims.LastName");
            if (nameClaim != null)
            {
                return nameClaim.Value;
            }
            return string.Empty;
        }
    }
}