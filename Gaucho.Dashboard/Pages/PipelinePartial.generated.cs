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





WriteLiteral("\r\n<div class=\"pipeline-item\">\r\n    <div class=\"pipeline-item-container\">\r\n       " +
" <div class=\"pipeline-item-header\">\r\n            <h3>");


            
            #line 10 "..\..\Pages\PipelinePartial.cshtml"
           Write(Pipeline.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"pipeline-item-content\">\r\n            <" +
"div>\r\n                <div class=\"label\">Threads</div>\r\n                <div>");


            
            #line 15 "..\..\Pages\PipelinePartial.cshtml"
                Write(Pipeline.Threads);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                <div class=\"label\"" +
">Events in Queue</div>\r\n                <div>");


            
            #line 19 "..\..\Pages\PipelinePartial.cshtml"
                Write(Pipeline.QueueSize);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                <div class=\"label\"" +
">Processed Events</div>\r\n                <div>");


            
            #line 23 "..\..\Pages\PipelinePartial.cshtml"
                Write(Pipeline.ProcessedCount);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                <div class=\"label\"" +
">Handlers</div>\r\n                <div>");


            
            #line 27 "..\..\Pages\PipelinePartial.cshtml"
                Write(Pipeline.HandlerCount);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> \r\n ");


        }
    }
}
#pragma warning restore 1591
