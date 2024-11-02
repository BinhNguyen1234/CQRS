using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers.Abstract
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class ApiControllerBase : ControllerBase
    {
    }
}
