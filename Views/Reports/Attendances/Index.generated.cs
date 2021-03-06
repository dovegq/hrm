﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.HRM;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Reports/Attendances/Index.cshtml")]
    public partial class _Views_Reports_Attendances_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Reports_Attendances_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Reports\Attendances\Index.cshtml"
  
    ViewBag.Title = "Attendances";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<style>\r\n    .red.vis-box {\r\n        background-color: #F6D5E7;\r\n        colo" +
"r: #8A0F88;\r\n        border-color: #8A0F88;\r\n    }\r\n</style>\r\n<script");

WriteLiteral(" src=\"https://cdnjs.cloudflare.com/ajax/libs/vis/4.8.2/vis.min.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"https://cdnjs.cloudflare.com/ajax/libs/vis/4.8.2/vis.min.css\"");

WriteLiteral(" />\r\n\r\n\r\n<div");

WriteLiteral(" class=\"ui huge grey header\"");

WriteLiteral(">\r\n    <span");

WriteLiteral(" data-localize=\"Titles.Attendances\"");

WriteLiteral("></span>\r\n</div>\r\n<div");

WriteLiteral(" class=\"ui active large inline loader\"");

WriteLiteral("></div>\r\n\r\n<div");

WriteLiteral(" id=\"visualization\"");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral("></div>\r\n\r\n<script>\r\n    function getAttendance() {\r\n        var url = \"/api/view" +
"s/hrm/attendance-view/all\";\r\n\r\n        return window.getAjaxRequest(url);\r\n    }" +
";\r\n\r\n    function show() {\r\n    };\r\n    var employeeId = $(\"#EmployeeSelect\").va" +
"l();\r\n\r\n    var getAttendanceAjax = getAttendance(employeeId);\r\n\r\n    getAttenda" +
"nceAjax.success(function (msg) {\r\n        if (msg.length) {\r\n            createT" +
"imeLine(msg);\r\n        };\r\n    });\r\n\r\n</script>\r\n<script>\r\n    function createTi" +
"meLine(data) {\r\n        var employeeGroup = window.Enumerable.From(data).GroupBy" +
"(function (x) { return x.EmployeeId; }).ToArray();\r\n        var min = window.Enu" +
"merable.From(data).MinBy(function (x) { return x.AttendanceDate; }).AttendanceDa" +
"te;\r\n        var max = window.Enumerable.From(data).MaxBy(function (x) { return " +
"x.AttendanceDate; }).AttendanceDate;\r\n\r\n\r\n        var groups = new window.vis.Da" +
"taSet();\r\n\r\n        for (var g = 0; g < employeeGroup.length; g++) {\r\n          " +
"  groups.add(\r\n                {\r\n                    id: employeeGroup[g].sourc" +
"e[0].EmployeeId,\r\n                    content: employeeGroup[g].source[0].Employ" +
"ee,\r\n                    title: employeeGroup[g].source[0].Photo\r\n              " +
"  });\r\n        };\r\n\r\n        // create a dataset with items\r\n        var items =" +
" new window.vis.DataSet();\r\n\r\n        for (var i = 0; i < data.length / employee" +
"Group.length; i++) {\r\n            var content = data[i].WasPresent ? \"P\" : \"A\";\r" +
"\n            var className = data[i].WasPresent ? \"\" : \"red\";\r\n\r\n            ite" +
"ms.add({\r\n                id: i,\r\n                group: data[i].EmployeeId,\r\n  " +
"              content: content,\r\n                start: data[i].AttendanceDate,\r" +
"\n                type: \'box\',\r\n                className: className\r\n           " +
" });\r\n        };\r\n\r\n        // create visualization\r\n        var container = doc" +
"ument.getElementById(\'visualization\');\r\n        $(container).html(\"\");\r\n\r\n      " +
"  var options = {\r\n            groupOrder: \'content\',  // groupOrder can be a pr" +
"operty name or a sorting function\r\n            orientation: {\r\n                a" +
"xis: \'both\',\r\n                item: \'top\'\r\n            },\r\n            min: min," +
"\r\n            max: max,\r\n            zoomMin: 1000 * 60 * 60 * 24,             /" +
"/ one day in milliseconds\r\n            zoomMax: 1000 * 60 * 60 * 24 * 31 * 3    " +
" // about three months in milliseconds\r\n        };\r\n\r\n        var timeline = new" +
" window.vis.Timeline(container);\r\n        timeline.setOptions(options);\r\n       " +
" timeline.setGroups(groups);\r\n        timeline.setItems(items);\r\n\r\n        var l" +
"abels = $(\".vis-label\");\r\n        labels.each(function () {\r\n            var el " +
"= $(this);\r\n            var inner = el.find(\".vis-inner\");\r\n\r\n            var ph" +
"oto = el.attr(\"title\");\r\n            el.removeAttr(\"title\");\r\n\r\n            var " +
"header = $(\"<div class=\'ui big grey header\' />\");\r\n            header.html(inner" +
".html());\r\n\r\n            var img = $(\"<img />\");\r\n\r\n            img.attr(\"class\"" +
", \"ui small centered rounded circular bordered image\");\r\n            img.attr(\"t" +
"itle\", inner.html());\r\n            img.attr(\"src\", \"/api/core/attachment/documen" +
"t/400/400/\" + photo);\r\n\r\n            inner.addClass(\"ui attached secondary segme" +
"nt\");\r\n            inner.prepend(img);\r\n        });\r\n\r\n        $(\".loader\").remo" +
"veClass(\"active\");\r\n        $(container).fadeIn(1000);\r\n    };\r\n\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
