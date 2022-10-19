using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class BorrowingController : ApiControllerBase<Borrow>
{
    public BorrowingController(DataContext context, ILogger<Borrow> logger) : base (context, logger){
        
    }
}