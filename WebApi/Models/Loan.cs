using WebApi.Models.Base;

namespace WebApi.Models;

public class Loan: Model
{
    public int BookId {get; set;}

    public int UserId {get; set;}

    public DateTime LoanDate {get; set;}

    public DateTime ReturnDate {get; set;}

    public bool WasReturned {get; set;}

    public virtual Book? Book {get; set;} = default;

    public virtual User? User { get; set;} = default!;
}