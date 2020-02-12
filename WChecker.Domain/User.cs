using System;

namespace WChecker.Domain
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
