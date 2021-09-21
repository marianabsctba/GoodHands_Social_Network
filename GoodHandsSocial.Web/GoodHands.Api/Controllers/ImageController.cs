using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodHands.Domain.Model.Interfaces.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace GoodHands.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IEnumerable<string>> Upload([FromServices] IBlobService blobService)
        {
           
            if (!Request.HasFormContentType)
                BadRequest();

           
            var tasks = Request.Form.Files.Select(file =>
            {
                return blobService.UploadAsync(file.OpenReadStream());
            });

           
            return await Task.WhenAll(tasks);
        }
    }
}
