using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Models.Responses
{
    public interface ResponseModel
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
