

using MiniProject.Models.Common;

namespace MiniProject.Services.Implementations
{
    public class UserService:User
    {
        public UserService(string userName) : base(userName)
        {
        }

        public void ShareStatus(Status status)
        {
            List<Status> statusList = new List<Status>();
            statusList.Add(status);
        }

        public Status GetStatusById(int? id)
        {
            Status status = Statuses.Find(status => status.Id == id);
            return status;
        }
        public List<Status> GetAllStatuses()
        {
            if (Statuses.Count != 0)
            {
                return Statuses;
            }
            return null;
        }

    }
}
