using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AgteksDemo_UI.Models
{
    public class Integration
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("JSON_TEXT")]
        public string JSON_TEXT { get; set; }

        [JsonProperty("PICTURE")]
        public byte[] PICTURE { get; set; } // normally it is a string variable on backend.

        [JsonProperty("INS_DT")]
        public DateTime INS_DT { get; set; }

        [JsonProperty("IS_PROCESSED")]
        public string IS_PROCESSED { get; set; }

        [JsonProperty("PROCESSED_DT")]
        public DateTime PROCESSED_DT { get; set; }

        [JsonProperty("PRODUCT_TYPE")]
        public int PRODUCT_TYPE { get; set; }
    }
}
