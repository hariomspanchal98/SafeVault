using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string Department { get; set; }
}
