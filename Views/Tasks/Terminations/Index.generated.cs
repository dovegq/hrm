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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Terminations/Index.cshtml")]
    public partial class _Views_Tasks_Terminations_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Terminations_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\Terminations\Index.cshtml"
  
    ViewBag.Title = "Terminations";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"Ter" +
"minations\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/hrm/termination-scrud-view" +
"\";\r\n    scrudFactory.viewTableName = \"hrm.termination_scrud_view\";\r\n\r\n    scrudF" +
"actory.formAPI = \"/api/forms/hrm/terminations\";\r\n    scrudFactory.formTableName " +
"= \"hrm.terminations\";\r\n\r\n    scrudFactory.excludedColumns = [\"AuditUserId\", \"Aud" +
"itTs\"];\r\n\r\n    scrudFactory.allowDelete = true;\r\n    scrudFactory.allowEdit = tr" +
"ue;\r\n\r\n    scrudFactory.live = \"Reason\";\r\n\r\n    scrudFactory.readonlyColumns = [" +
"\"EndedOn\"];\r\n    scrudFactory.hiddenColumns = [\"VerificationStatusId\", \"Verified" +
"ByUserId\", \"VerifiedOn\", \"VerificationReason\"];\r\n    scrudFactory.excludedColumn" +
"s = [\"Photo\"];\r\n\r\n    scrudFactory.keys = [\r\n        {\r\n            property: \"E" +
"mployeeId\",\r\n            url: \'/api/views/hrm/employee-view/display-fields\',\r\n  " +
"          data: null,\r\n            valueField: \"Key\",\r\n            textField: \"V" +
"alue\"\r\n        },\r\n        {\r\n            property: \"ChangeStatusTo\",\r\n         " +
"   url: \'/api/forms/hrm/employment-statuses/display-fields\',\r\n            data: " +
"null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        }" +
",\r\n        {\r\n            property: \"ForwardTo\",\r\n            url: \'/api/views/h" +
"rm/employee-view/display-fields\',\r\n            data: null,\r\n            valueFie" +
"ld: \"Key\",\r\n            textField: \"Value\"\r\n        }\r\n    ];\r\n\r\n    scrudFactor" +
"y.layout = [\r\n        {\r\n            tab: \"\",\r\n            fields: [\r\n          " +
"      [\"TerminationId\"],\r\n                [\"EmployeeId\", \"NoticeDate\"],\r\n       " +
"         [\"ForwardTo\", \"ServiceEndDate\"],\r\n                [\"ChangeStatusTo\"],\r\n" +
"                [\"Reason\"],\r\n                [\"Details\"]\r\n            ]\r\n       " +
" }\r\n    ];\r\n\r\n    $(document).on(\"formready\", function () {\r\n        $(\"#verific" +
"ation_status_id\").val(\"0\");\r\n    });\r\n\r\n    $.get(\'/ScrudFactory/View.html\', fun" +
"ction (view) {\r\n        $.get(\'/ScrudFactory/Form.html\', function (form) {\r\n    " +
"        $(\"#ScrudFactoryView\").html(view);\r\n            $(\"#ScrudFactoryForm\").h" +
"tml(form);\r\n            $.cachedScript(\"/assets/js/scrudfactory-view.js\");\r\n    " +
"        $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n        });\r\n    });" +
"\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>\r\n");

        }
    }
}
#pragma warning restore 1591
