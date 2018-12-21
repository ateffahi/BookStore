using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Tracing;

namespace BookStore.Tracing
{
    public class MyTrace : ITraceWriter
    {
        public void Trace(HttpRequestMessage request, string category, TraceLevel level, Action<TraceRecord> traceAction)
        {
            TraceRecord traceRec = new TraceRecord(request, category, level);
            traceAction(traceRec); // Fill in the rest of the TraceRecord

            var message = $"My Operation : {traceRec.Operation} My Operator : {traceRec.Operator} My Message : {traceRec.Message}";
            System.Diagnostics.Trace.WriteLine(message, traceRec.Category);
            
        }
    }
}