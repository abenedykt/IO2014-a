using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Io_Aspekty.Models
{
    public class SomeModel : ISomeModel
    {
        public string[] Method()
        {
            return new string[] { "ATH", "WBMiI", "Informatyka" };
        }
    }
}