﻿#pragma checksum "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A1295C82BB6CA433D918A5F863529569FA9F3347"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using ServiceCenter.Client.Mvc;
    
    #line 2 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
    using ServiceCenter.MES.Model.RBAC;
    
    #line default
    #line hidden
    
    #line 3 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
    using ServiceCenter.Client.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 4 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
    using ServiceCenter.Client.Mvc.Resources;
    
    #line default
    #line hidden
    
    #line 5 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    
    
    public class _Page_Views_Shared__MenuPartial_cshtml : System.Web.Mvc.WebViewPage<ServiceCenter.Client.Mvc.Models.MenuViewModel> {
        
#line hidden
        
        #line 7 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
  
    public static IHtmlString ShowSubmenu(IList<Resource> lstMenuItem, Resource menu, string menuClass)
    {
        return new HtmlString(RecurSubmenuString(lstMenuItem,menu,menuClass, 1));
    }

    private static string RecurSubmenuString(IList<Resource> lstMenuItem, Resource menu, string menuClass,int count)
    {
        StringBuilder sb = new StringBuilder();
        var lnq = from item in lstMenuItem
                  where item.Key.Code.StartsWith(menu.Key.Code)
                        && item.Key.Code.Count(ch=>ch=='/')==count
                        && item.Key.Code!=menu.Key.Code
                  orderby item.Key.Code
                  select item;
        string menuName = StringResource.ResourceManager.GetString("Menu_" + menu.Name);
        if (string.IsNullOrEmpty(menuName))
        {
            menuName = menu.Name;
        }
        if (lnq.Count() == 0)
        {
            string functionCode = string.Empty;
            if (!string.IsNullOrEmpty(menu.FunctionCode))
            {
                functionCode = string.Format("{0} - ", menu.FunctionCode);
            }
            sb.AppendFormat("<li><a href ='{0}'>{2}{1}</a></li>", menu.Data, menuName, functionCode);
        }
        else
        {
            string menuItemCode = string.Empty;
            sb.AppendFormat("<li class='{0}'>", menuClass);
            sb.AppendFormat("<a href ='#' class='dropdown-toggle' data-toggle='dropdown' data-submenu>{0} {1}</a>"
                            , menuName
                            , count==1? "<span class='caret'></span>" : string.Empty);
            sb.Append("<ul class='dropdown-menu' role='menu'>");
            foreach (Resource menuItem in lnq)
            {
                if (!string.IsNullOrEmpty(menuItemCode) && !menuItem.Key.Code.StartsWith(menuItemCode))
                {
                    sb.Append("<li class='divider'></li>");
                    menuItemCode = string.Empty;
                }
                sb.Append(RecurSubmenuString(lstMenuItem, menuItem, "dropdown-submenu",count+1));

                int index = menuItem.Key.Code.IndexOf('/',menu.Key.Code.Length);
                if (index > 0 && string.IsNullOrEmpty(menuItemCode))
                {
                    int length = index + 3;
                    if (length > menuItem.Key.Code.Length)
                    {
                        length = menuItem.Key.Code.Length;
                    }
                    menuItemCode = menuItem.Key.Code.Substring(0, length);
                }
            }
            sb.Append("</ul>");
            sb.Append("</li>");
        }
        return sb.ToString();
    }

        #line default
        #line hidden
        
        
        public _Page_Views_Shared__MenuPartial_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {
            
            #line 70 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
 if (Request.IsAuthenticated)
{
    try
    {
        IList<Resource> lstMenu = Model.GetMenuResource(User.Identity.Name);
        IList<Resource> lstMenuItem = Model.GetMenuItemResource(User.Identity.Name);

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_MenuPartial.cshtml", 3148, 11, true);

WriteLiteral("        <ul");

EndContext("~/Views/Shared/_MenuPartial.cshtml", 3148, 11, true);

BeginContext("~/Views/Shared/_MenuPartial.cshtml", 3159, 23, true);

WriteLiteral(" class=\"nav navbar-nav\"");

EndContext("~/Views/Shared/_MenuPartial.cshtml", 3159, 23, true);

BeginContext("~/Views/Shared/_MenuPartial.cshtml", 3182, 3, true);

WriteLiteral(">\r\n");

EndContext("~/Views/Shared/_MenuPartial.cshtml", 3182, 3, true);

            
            #line 77 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
            
            
            #line default
            #line hidden
            
            #line 77 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
             foreach (Resource menu in lstMenu.OrderBy(m => m.Key.Code))
            {
                
            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_MenuPartial.cshtml", 3292, 42, false);

            
            #line 79 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
            Write(ShowSubmenu(lstMenuItem, menu, "dropdown"));

            
            #line default
            #line hidden
EndContext("~/Views/Shared/_MenuPartial.cshtml", 3292, 42, false);

            
            #line 79 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
                                                             ;
            }

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_MenuPartial.cshtml", 3353, 15, true);

WriteLiteral("        </ul>\r\n");

EndContext("~/Views/Shared/_MenuPartial.cshtml", 3353, 15, true);

            
            #line 82 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_MenuPartial.cshtml"
    }
    catch
    {

    }
}

            
            #line default
            #line hidden
        }
    }
}
