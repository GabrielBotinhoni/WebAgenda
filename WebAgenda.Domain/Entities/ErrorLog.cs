using System;
using System.Collections.Generic;
using System.Text;

namespace WebAgenda.Domain.Entities
{
     public class ErrorLog
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Details { get; set; }

        public string SystemMessage { get; set; }

        public string StackTrace { get; set; }

        public ErrorLog(DateTime date, string details, string systemMessage, string stackTrace)
        {
            Date = date;
            Details = details;
            SystemMessage = systemMessage;
            StackTrace = stackTrace;
        }
    }
}
