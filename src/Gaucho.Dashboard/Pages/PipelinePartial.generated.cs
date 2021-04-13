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

namespace Gaucho.Dashboard.Pages
{
    using System;
    
    #line 3 "..\..\Pages\PipelinePartial.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\PipelinePartial.cshtml"
    using Gaucho.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\PipelinePartial.cshtml"
    using Gaucho.Dashboard.Monitoring;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\PipelinePartial.cshtml"
    using Gaucho.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class PipelinePartial : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






WriteLiteral("\r\n<div class=\"pipeline-item\" id=\"");


            
            #line 8 "..\..\Pages\PipelinePartial.cshtml"
                          Write(Pipeline.PipelineId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <div class=\"pipeline-item-container\">\r\n        <div class=\"pipeline-item-" +
"header\">\r\n            <h3>");


            
            #line 11 "..\..\Pages\PipelinePartial.cshtml"
           Write(Pipeline.PipelineId);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n\t    <div class=\"pipeline-item-content\">\r\n");


            
            #line 14 "..\..\Pages\PipelinePartial.cshtml"
 		    foreach (var m in Pipeline.Metrics)
		    {
			    var id = Pipeline.PipelineId + "-" + m.Key;
			    var labelId = id + "-label";


            
            #line default
            #line hidden
WriteLiteral("\t\t\t    <div>\r\n\t\t\t\t    <div class=\"label\" id=\"");


            
            #line 20 "..\..\Pages\PipelinePartial.cshtml"
                          Write(labelId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 20 "..\..\Pages\PipelinePartial.cshtml"
                                    Write(m.Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t\t    <div id=\"");


            
            #line 21 "..\..\Pages\PipelinePartial.cshtml"
            Write(id);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 21 "..\..\Pages\PipelinePartial.cshtml"
                 Write(m.Value);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t    </div>\r\n");


            
            #line 23 "..\..\Pages\PipelinePartial.cshtml"
		    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\t    </div>\r\n\t    \r\n\t    <div class=\"pipeline-item-log-container\">\r\n");


            
            #line 28 "..\..\Pages\PipelinePartial.cshtml"
 		    if (Pipeline.Elements.ContainsKey("WorkersLog"))
		    {
			    var element = Pipeline.Elements["WorkersLog"];
			    var id = Pipeline.PipelineId + "-" + element.Key.ToLower();

            
            #line default
            #line hidden
WriteLiteral("\t\t\t    <div class=\"toggler-section is-open\">\r\n\t\t\t\t    <span class=\"toggler-button" +
"\"></span>\r\n\t\t\t\t    <div class=\"label\" id=\"logs-label\">Workers Timeline</div>\r\n\t\t" +
"\t    </div>\r\n");


            
            #line 36 "..\..\Pages\PipelinePartial.cshtml"
                    

            
            #line default
            #line hidden
WriteLiteral("\t\t\t    <div id=\"");


            
            #line 37 "..\..\Pages\PipelinePartial.cshtml"
           Write(id);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"pipeline-item-log-list toggle-wrapper\">\r\n");


            
            #line 38 "..\..\Pages\PipelinePartial.cshtml"
 				    foreach (TimelineLog<int> e in element.Elements)
				    {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t    <div class=\"pipeline-item-log-item\">\r\n\t\t\t\t\t\t    <span class=\"pipeline-it" +
"em-log-element pipeline-log-debug\">");


            
            #line 41 "..\..\Pages\PipelinePartial.cshtml"
                                                                Write(e.Timestamp.ToString("o"));

            
            #line default
            #line hidden
WriteLiteral("</span><span class=\"pipeline-item-log-element\">");


            
            #line 41 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                         Write(e.Value);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t    </div>\r\n");


            
            #line 43 "..\..\Pages\PipelinePartial.cshtml"
				    }

            
            #line default
            #line hidden
WriteLiteral("\t\t\t    </div>\r\n");


            
            #line 45 "..\..\Pages\PipelinePartial.cshtml"
		    }

            
            #line default
            #line hidden
WriteLiteral("\t    </div>\r\n\t    <div class=\"pipeline-item-log-container\">\r\n");


            
            #line 48 "..\..\Pages\PipelinePartial.cshtml"
 		    if (Pipeline.Elements.ContainsKey("EventLog"))
		    {
			    var element = Pipeline.Elements["EventLog"];
			    var id = Pipeline.PipelineId + "-" + element.Key.ToLower();

            
            #line default
            #line hidden
WriteLiteral("\t\t\t    <div class=\"toggler-section\">\r\n\t\t\t\t    <span class=\"toggler-button\"></span" +
">\r\n\t\t\t\t    <div class=\"label\" id=\"logs-label\">Events</div>\r\n\t\t\t    </div>\r\n");


            
            #line 56 "..\..\Pages\PipelinePartial.cshtml"
                    

            
            #line default
            #line hidden
WriteLiteral("\t\t\t    <div id=\"");


            
            #line 57 "..\..\Pages\PipelinePartial.cshtml"
           Write(id);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"pipeline-item-log-list toggle-wrapper\">\r\n");


            
            #line 58 "..\..\Pages\PipelinePartial.cshtml"
 				    foreach (DashboardLog e in element.Elements)
				    {
					    var levelClass = $"pipeline-log-{e.Level.ToLower()}";

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t    <div class=\"pipeline-item-log-item\">\r\n\t\t\t\t\t\t    <span class=\"pipeline-it" +
"em-log-element ");


            
            #line 62 "..\..\Pages\PipelinePartial.cshtml"
                                            Write(levelClass);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 62 "..\..\Pages\PipelinePartial.cshtml"
                                                         Write(e.Timestamp.ToString("o"));

            
            #line default
            #line hidden
WriteLiteral("</span><span class=\"pipeline-item-log-element\">[");


            
            #line 62 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                   Write(e.Source);

            
            #line default
            #line hidden
WriteLiteral("]</span><span class=\"pipeline-item-log-element\">[");


            
            #line 62 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                                                                             Write(e.Level);

            
            #line default
            #line hidden
WriteLiteral("]</span><span class=\"pipeline-item-log-element\">");


            
            #line 62 "..\..\Pages\PipelinePartial.cshtml"
                                                                                                                                                                                                                                                     Write(e.Message);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t    </div>\r\n");


            
            #line 64 "..\..\Pages\PipelinePartial.cshtml"
				    }

            
            #line default
            #line hidden
WriteLiteral("\t\t\t    </div>\r\n");


            
            #line 66 "..\..\Pages\PipelinePartial.cshtml"
		    }

            
            #line default
            #line hidden
WriteLiteral("\t    </div>\r\n    </div>\r\n</div> \r\n ");


        }
    }
}
#pragma warning restore 1591
