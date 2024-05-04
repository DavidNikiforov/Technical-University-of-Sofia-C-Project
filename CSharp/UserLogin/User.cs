using System;

namespace UserLogin
{
    public class User
    {
        // Декларация на свойства и други членове на класа
        public string Username { get; internal set; } = "Default Username";
        public string Password { get; internal set; } = "Default Password";
        public string FakNum { get; internal set; } = "Default FakNum";
        public UserRoles Role { get; internal set; } = UserRoles.ANONYMOUS;
        public DateTime CreationDate { get; internal set; }
        public DateTime ValidUntil { get; internal set; }
    }

    public class UserData
    {
        public static User? TestUser { get; set; }
    }
}
