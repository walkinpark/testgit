﻿#pragma checksum "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62CF996EF586629161DD53C3577F98C285452B2B"
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
    
    
    public class _Page_Views_Shared__PaginationPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden
        
        public _Page_Views_Shared__PaginationPartial_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {
            
            #line 1 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
  
    ServiceCenter.Model.PagingConfig cfg = ViewBag.PagingConfig;

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 71, 2, true);

WriteLiteral("\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 71, 2, true);

            
            #line 4 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
 if (cfg != null)
{
    int MaxPageNo = cfg.MaxPageNo;
    int SplitPageNo = MaxPageNo / 2;
    int startPageNo = 0;

    if (cfg.PageNo > SplitPageNo - 1)
    {
        startPageNo = cfg.PageNo - SplitPageNo;
    }
    if ((cfg.Pages - SplitPageNo) < cfg.PageNo && (cfg.Pages - SplitPageNo) > 0)
    {
        startPageNo = cfg.Pages - MaxPageNo;
    }

    if (startPageNo < 0)
    {
        startPageNo = 0;
    }


            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 511, 8, true);

WriteLiteral("    <div");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 511, 8, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 519, 18, true);

WriteLiteral(" class=\"btn-group\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 519, 18, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 537, 31, true);

WriteLiteral(" style=\"padding:0px;margin:0px\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 537, 31, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 568, 3, true);

WriteLiteral(">\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 568, 3, true);

            
            #line 25 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
         if (cfg.PageNo == 0 && cfg.Records > 0)
        {

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 632, 19, true);

WriteLiteral("            <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 632, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 651, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 651, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 665, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 665, 24, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 689, 28, true);

WriteLiteral(" disabled>&laquo;</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 689, 28, true);

            
            #line 28 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
        }
        else if (cfg.Records > 0)
        {

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 774, 19, true);

WriteLiteral("            <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 774, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 793, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 793, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 807, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 807, 24, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 831, 14, true);

WriteLiteral(" name=\"PageNo\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 831, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 845, 10, true);

WriteLiteral(" value=\"0\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 845, 10, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 855, 26, true);

WriteLiteral(">&laquo;&laquo;</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 855, 26, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 881, 19, true);

WriteLiteral("            <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 881, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 900, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 900, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 914, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 914, 24, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 938, 14, true);

WriteLiteral(" name=\"PageNo\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 938, 14, true);

WriteAttribute("value", Tuple.Create(" value=\"", 952), Tuple.Create("\"", 975)
            
            #line 32 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
 , Tuple.Create(Tuple.Create("", 960), Tuple.Create<System.Object, System.Int32>(cfg.PageNo-1
            
            #line default
            #line hidden
, 960), false)
);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 976, 19, true);

WriteLiteral(">&laquo;</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 976, 19, true);

            
            #line 33 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
        }

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1006, 8, true);

WriteLiteral("        ");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1006, 8, true);

            
            #line 34 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
         for (int i = startPageNo; i < cfg.Pages && i < MaxPageNo + startPageNo; i++)
        {
            if (cfg.PageNo == i)
            {

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1153, 23, true);

WriteLiteral("                <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1153, 23, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1176, 14, true);

WriteLiteral(" type=\"button\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1176, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1190, 24, true);

WriteLiteral(" class=\"btn btn-primary\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1190, 24, true);

WriteAttribute("value", Tuple.Create(" value=\"", 1214), Tuple.Create("\"", 1224)
            
            #line 38 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
, Tuple.Create(Tuple.Create("", 1222), Tuple.Create<System.Object, System.Int32>(i
            
            #line default
            #line hidden
, 1222), false)
);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1225, 1, true);

WriteLiteral(">");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1225, 1, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1228, 3, false);

            
            #line 38 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
                                                                     Write(i+1);

            
            #line default
            #line hidden
EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1228, 3, false);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1232, 11, true);

WriteLiteral("</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1232, 11, true);

            
            #line 39 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1291, 23, true);

WriteLiteral("                <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1291, 23, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1314, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1314, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1328, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1328, 24, true);

WriteAttribute("value", Tuple.Create(" value=\"", 1352), Tuple.Create("\"", 1362)
            
            #line 42 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(i
            
            #line default
            #line hidden
, 1360), false)
);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1363, 14, true);

WriteLiteral(" name=\"PageNo\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1363, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1377, 1, true);

WriteLiteral(">");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1377, 1, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1380, 3, false);

            
            #line 42 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
                                                                                   Write(i+1);

            
            #line default
            #line hidden
EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1380, 3, false);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1384, 11, true);

WriteLiteral("</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1384, 11, true);

            
            #line 43 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
            }
        }

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1421, 8, true);

WriteLiteral("        ");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1421, 8, true);

            
            #line 45 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
         if (cfg.PageNo >= cfg.Pages - 1 && cfg.Records > 0)
        {

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1494, 19, true);

WriteLiteral("            <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1494, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1513, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1513, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1527, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1527, 24, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1551, 28, true);

WriteLiteral(" disabled>&raquo;</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1551, 28, true);

            
            #line 48 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
        }
        else if (cfg.Records > 0)
        {

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1636, 19, true);

WriteLiteral("            <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1636, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1655, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1655, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1669, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1669, 24, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1693, 14, true);

WriteLiteral(" name=\"PageNo\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1693, 14, true);

WriteAttribute("value", Tuple.Create(" value=\"", 1707), Tuple.Create("\"", 1730)
            
            #line 51 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
, Tuple.Create(Tuple.Create("", 1715), Tuple.Create<System.Object, System.Int32>(cfg.PageNo+1
            
            #line default
            #line hidden
, 1715), false)
);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1731, 19, true);

WriteLiteral(">&raquo;</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1731, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1750, 19, true);

WriteLiteral("            <button");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1750, 19, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1769, 14, true);

WriteLiteral(" type=\"submit\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1769, 14, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1783, 24, true);

WriteLiteral(" class=\"btn btn-default\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1783, 24, true);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1807, 14, true);

WriteLiteral(" name=\"PageNo\"");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1807, 14, true);

WriteAttribute("value", Tuple.Create(" value=\"", 1821), Tuple.Create("\"", 1843)
            
            #line 52 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
, Tuple.Create(Tuple.Create("", 1829), Tuple.Create<System.Object, System.Int32>(cfg.Pages-1
            
            #line default
            #line hidden
, 1829), false)
);

BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1844, 26, true);

WriteLiteral(">&raquo;&raquo;</button>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1844, 26, true);

            
            #line 53 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
        }

            
            #line default
            #line hidden
BeginContext("~/Views/Shared/_PaginationPartial.cshtml", 1881, 12, true);

WriteLiteral("    </div>\r\n");

EndContext("~/Views/Shared/_PaginationPartial.cshtml", 1881, 12, true);

            
            #line 55 "D:\JC MES2.0\trunk\General\ServiceCenter.Client.Mvc\Views\Shared\_PaginationPartial.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
