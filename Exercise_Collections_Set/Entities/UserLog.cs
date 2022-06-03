

namespace Exercise_Collections_Set.Entities
{
    internal class UserLog
    {
        public string Username { get; private set; }
        public DateTime AccessDate { get; private set; }

        public UserLog(string username, DateTime accessDate)
        {
            Username = username;
            AccessDate = accessDate;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is UserLog))
            {
                return false;
            }

            UserLog other = obj as UserLog;

            return Username.Equals(other.Username);
        }
    }
}
