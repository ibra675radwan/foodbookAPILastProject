using BLL.Services.GenericServices;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace foodbookAPILastProject.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class _GenericController<Dto> : Controller where Dto : class
    {
        private readonly iGenericServices<Dto> _genericService;

        public _GenericController(iGenericServices<Dto> genericService)
        {
            _genericService = genericService;
        }
        [HttpGet("GetAll")]
        public APIResponse<IEnumerable<Dto>> GetAll()
        {
            return _genericService.GetAll();
        }
        [HttpGet("GetById")]
        public APIResponse<Dto> GetById(int id)
        {
            return _genericService.GetByID(id);
        }

        [HttpPost("Add")]
        public APIResponse<Dto> Add(Dto dto)
        {
            return _genericService.Add(dto);
        }

        [HttpPut("Update")]
        public APIResponse<Dto> Update(Dto dto)
        {
            return _genericService.Update(dto);
        }

        [HttpDelete("DeleteById")]
        public APIResponse<bool> DeleteById(int id)
        {
            return _genericService.Delete(id);
        }

        [HttpDelete("Delete")]
        public APIResponse<bool> Delete(Dto dto)
        {
            return _genericService.Delete(dto);
        }   
    }


}
