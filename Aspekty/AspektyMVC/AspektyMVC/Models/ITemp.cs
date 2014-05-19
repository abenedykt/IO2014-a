namespace AspektyMVC.Models
{
    public interface ITemp : IOpenable, IClosable
    {
        string GetContent(string content);
        int CalculateSomethink(int amount);
    }
}
