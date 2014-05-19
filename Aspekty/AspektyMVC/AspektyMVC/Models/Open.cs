using System;

namespace AspektyMVC.Models
{
    public class Open : IOpenable
    {
        public string OpenSomethink()
        {
            return string.Format("Cos tam open!");
        }
    }
}