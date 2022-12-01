

namespace MiniProject.Models.Common
{
    public class Status
    {
        public int Id;
        public string Title;
        public string Content;

        public DateTime SharedDate { get; set; }

        public Status( string title, string content)
        {
         
            Title = title;
            Content = content;
            SharedDate = DateTime.Now;  
           
        }
        public void GetStatusInfo()
        {
            Console.WriteLine($"Title: {Title} Content: {Content} Shared{(DateTime.Now.Ticks-SharedDate.Ticks)/10000000} second ego");
        }
    }
}
