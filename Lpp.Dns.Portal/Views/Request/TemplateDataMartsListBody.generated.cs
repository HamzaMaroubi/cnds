﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.Portal.Views.Request
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns;
    using Lpp.Dns.Data;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Controllers;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Request/TemplateDataMartsListBody.cshtml")]
    public partial class TemplateDataMartsListBody : System.Web.Mvc.WebViewPage<RequestDataMartsListModel>
    {
        public TemplateDataMartsListBody()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Request\TemplateDataMartsListBody.cshtml"
   Layout = null; 
            
            #line default
            #line hidden
WriteLiteral(" \r\n\r\n");

            
            #line 4 "..\..\Views\Request\TemplateDataMartsListBody.cshtml"
Write(Html.Render<IGrid>()
    .From( Model.List )
    .Attributes( new { @class = "Grid DataMartGrid" } )
    .ReloadUrl( Url.Action<RequestController>( c => c.TemplateDataMartsListBody( Model.List.ModelForReload() ) ) )
    .Column( dm => dm.Name, c => c.Title( "DataMart" ).Class( "DataMartName" ).Sortable( "Name" ) )
    .Column( dm => string.IsNullOrWhiteSpace(dm.Organization) ? "N/A" : dm.Organization, c => c.Title( "Organization" ).Class( "DataMartOrg" ) )
);

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
