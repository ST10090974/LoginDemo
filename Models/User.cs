namespace LoginDemo.Models
{
    public class User
    {
        public string? SupID { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public User(string? supID, string? name, string? phone)
        {
            SupID = supID;
            Name = name;
            Phone = phone;


        }

        public User(string? username, string? password)
        {
            Username = username;
            Password = password;
        }
    }
}
