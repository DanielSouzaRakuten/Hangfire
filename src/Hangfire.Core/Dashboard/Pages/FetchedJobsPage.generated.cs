﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 5 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class FetchedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");









            
            #line 9 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
  
    Layout = new LayoutPage(Queue.ToUpperInvariant());

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.FetchedCount(Queue))
    {
        BasePageUrl = LinkTo("/jobs/enqueued/fetched/" + Queue)
    };

    var fetchedJobs = monitor.FetchedJobs(Queue, pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 28 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
   Write(RenderPartial(new SidebarMenu(JobsSidebarMenu.Items)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        ");


            
            #line 31 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
   Write(RenderPartial(new Breadcrumbs(Queue.ToUpperInvariant(), new Dictionary<string, string>
        {
            { "Queues", LinkTo("/jobs/enqueued") },
            { Queue.ToUpperInvariant(), LinkTo("/jobs/enqueued/" + Queue) }
        })));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <h1 class=\"page-header\">");


            
            #line 37 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                           Write(Queue.ToUpperInvariant());

            
            #line default
            #line hidden
WriteLiteral(" <small>Fetched jobs</small></h1>\r\n\r\n");


            
            #line 39 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                The queue is empty.\r\n" +
"            </div>\r\n");


            
            #line 44 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-primary\"\r\n                            data-url=\"");


            
            #line 50 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                 Write(LinkTo("/jobs/enqueued/requeue"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                            data-loading-text=""Enqueueing..."">
                        <span class=""glyphicon glyphicon-repeat""></span>
                        Requeue jobs
                    </button>

                    <button class=""js-jobs-list-command btn btn-sm btn-default""
                            data-url=""");


            
            #line 57 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                 Write(LinkTo("/jobs/enqueued/delete"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                            data-loading-text=""Deleting...""
                            data-confirm=""Do you really want to DELETE ALL selected jobs?"">
                        <span class=""glyphicon glyphicon-remove""></span>
                        Delete selected
                    </button>

                    ");


            
            #line 64 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
               Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>

                <table class=""table"">
                    <thead>
                    <tr>
                        <th class=""min-width"">
                            <input type=""checkbox"" class=""js-jobs-list-select-all""/>
                        </th>
                        <th class=""min-width"">Id</th>
                        <th class=""min-width"">State</th>
                        <th>Job</th>
                        <th class=""align-right"">Fetched</th>
                    </tr>
                    </thead>
                    <tbody>
");


            
            #line 80 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                     foreach (var job in fetchedJobs)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr class=\"js-jobs-list-row hover\">\r\n                    " +
"        <td>\r\n                                <input type=\"checkbox\" class=\"js-j" +
"obs-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 84 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                                                                     Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n                            </td>\r\n                            <td class=\"mi" +
"n-width\">\r\n                                <a href=\"");


            
            #line 87 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                    Write(LinkTo("/jobs/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 87 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                                 Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            </td>\r\n                            <td class=\"m" +
"in-width\">\r\n                                <span class=\"label label-default\" st" +
"yle=\"");


            
            #line 90 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                                    Write(String.Format("background-color: {0};", JobHistoryRenderer.GetForegroundStateColor(job.Value.State)));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        ");


            
            #line 91 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                   Write(job.Value.State);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </span>\r\n                            </td>\r" +
"\n                            <td>\r\n                                <a class=\"job" +
"-method\" href=\"");


            
            #line 95 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                       Write(LinkTo("/jobs/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 96 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                               Write(HtmlHelper.DisplayJob(job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n      " +
"                      <td class=\"align-right\">\r\n");


            
            #line 100 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                 if (job.Value.FetchedAt.HasValue)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span data-moment=\"");


            
            #line 102 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                  Write(JobHelper.ToTimestamp(job.Value.FetchedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                            ");


            
            #line 103 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                       Write(job.Value.FetchedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </span>\r\n");


            
            #line 105 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                        </tr>\r\n");


            
            #line 108 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");


            
            #line 112 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 112 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
       Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 112 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
