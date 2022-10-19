using WebApi.Models.Base;

namespace WebApi.Models;

public class Borrow: Model
{
    public int BookId {get; set;}

    public int UserId {get; set;}

    public DateTime BorrowingTime {get; set;}

    public DateTime BorrowingLimitTime {get; set;}

    public bool WasReturned {get; set;}

    public virtual User? User { get; set;} = default!;
}