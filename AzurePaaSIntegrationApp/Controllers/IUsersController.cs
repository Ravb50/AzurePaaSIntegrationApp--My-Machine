using AzurePaaSIntegrationApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace AzurePaaSIntegrationApp.Controllers
{
    public interface IUsersController
    {
        Task<ActionResult<User>> CreateUser([FromBody] User user);
        Task<IActionResult> DeleteUser(int id);
        Task<ActionResult<IEnumerable<User>>> GetUsers();
        Task<IActionResult> UpdateUser(int id, [FromBody] User user);
    }
}