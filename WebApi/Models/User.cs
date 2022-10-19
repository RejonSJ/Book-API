using WebApi.Models.Base;

namespace WebApi.Models;

public class User: Model
{
    public string? Name {get; set;}

    public string? LastName {get; set;}
    
    public int? TelephoneNumber {get; set;}

    public string? Address {get; set;}

    public virtual IList<Loan>? Loans { get; set; } = default!;
    
    
}