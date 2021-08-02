using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Models
{
    // JSON serializable yapabilmek için işaretliyoruz.
    [Serializable]
    public class Interpolation
    {
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public string ClassName { get; set; }
    }
}
