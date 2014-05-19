namespace AspektyMVC.Models
{
    public class Temp : ITemp
    {
        public string Content { get; set; }
        public int Amount { get; set; }

        public string GetContent(string content)
        {
            return string.Format("This content is {0}", content);
        }

        public int CalculateSomethink(int amount)
        {
            return amount*4;
        }

        public string OpenSomethink()
        {
            return string.Format("Open temporary file");
        }

        public string CloseSomethink()
        {
            return string.Format("Close somethink other in temp");
        }
    }
}