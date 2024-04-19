using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._1
{
    public class Error
    {
        public Guid AlterId { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public string Request { get; set; }
        public StatusCode Status { get; set; }

        public Error(string message, DateTime time, string request, StatusCode status)
        {
            Message = message;
            Time = time;
            Request = request;
            Status = status;
        }
    }
}
