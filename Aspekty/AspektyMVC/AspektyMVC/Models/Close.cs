using System;
using System.Diagnostics;


namespace AspektyMVC.Models
{
    public class Close : IClosable
    {
        public string CloseSomethink()
        {
            return String.Format("Close this item");
        }
    }
}