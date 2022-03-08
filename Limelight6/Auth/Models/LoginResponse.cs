using Limelight6.Resources.Events.Models;
using Limelight6.Resources.Users;

namespace Limelight6.Auth.Models
{
    public class LoginResponse
    {
        public User User { get; set; }
        public IEnumerable<Event> Events { get; set; } = new List<Event>();
        public IEnumerable<string> Permissions { get; set; } = new List<string>();
    }
}
