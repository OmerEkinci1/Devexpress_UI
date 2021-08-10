using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Models
{
    // JSON serializable yapabilmek için işaretliyoruz.
    public class Integration
    {
        public int ID { get; set; }
        public string JSON_TEXT { get; set; }
        public string PICTURE { get; set; }
        public DateTime INS_DT { get; set; }
        public string IS_PROCESSED { get; set; }
        public DateTime PROCESSED_DT { get; set; }
        public int PRODUCT_TYPE { get; set; }
    }
}
