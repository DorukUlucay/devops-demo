namespace devops_demo.Web.Models
{
    public class GreetingViewModel
    {
        public GreetingViewModel(string message, int count)
        {
            Message = message;
            Count = count;
        }

        public string Message { get; set; }
        public int Count { get; set; }
    }
}
