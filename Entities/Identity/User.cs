namespace AuctionApp.Entities.Identity;
public class User{
    public string Username {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}  
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public List<UserRole> UserRoles {get; set;} = new List<UserRoles>();
}