

namespace MiniProject.Models.Common
{
    public class User
    {
        public int Id { get; set; }
        public List<Status> Statuses { get;set; }

        public string UserName { get; set; } 

        public User( string userName)
        {
            UserName = userName;
        }
    }
}
