// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Microsoft">
//   Copyright � 2014 Microsoft
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Peerpoint
{
    using System.Web.Routing;

    using App.Peerpoint.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
