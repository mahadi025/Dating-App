// using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    // [Key] //To use as a primary key but not needed here because Id will be set as a primary key automatically
    public int Id { get; set; }
    public string UserName { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}
