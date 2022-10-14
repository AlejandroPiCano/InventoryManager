using InventoryManager.Application.DTOs;
using InventoryManager.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryItemsController : ControllerBase
    { 
        private readonly IInventoryListService _service;
        private readonly ILogger<InventoryItemsController> _logger;

        public InventoryItemsController(IInventoryListService service, ILogger<InventoryItemsController> logger)
        {
            this._service = service;
            this._logger = logger;
        }

        // GET: api/<InventoryListController>
        [HttpGet]
        public IEnumerable<InventoryItemDTO> Get()
        {
            IEnumerable<InventoryItemDTO> result = null;

            try
            {
                result = _service.GetAllInventoryItems();
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }

            return result;
        }

        // GET: api/<InventoryListController>/GetAsync
        [HttpGet("GetAsync")]
        public async Task<IEnumerable<InventoryItemDTO>> GetAsync()
        {
            Task<List<InventoryItemDTO>> result = null;

            try
            {
                result = _service.GetAllInventoryItemsAsync();
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }

            return await result;
        }

        // GET api/<InventoryListController>/5
        [HttpGet("{id}")]

        public InventoryItemDTO Get(int id)
        {
            InventoryItemDTO result = null;

            try
            {
                result = _service.GetInventoryItem(id);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }

            return result;
        }

        // GET api/<InventoryListController>/BussinessInventoryItemExample
        [HttpGet("BussinessInventoryItemExample")]
        public InventoryItemDTO GetBussinessInventoryItemExample()
        {
            InventoryItemDTO result = null;

            try
            {
                result = _service.GetBussinessInventoryItemExample();
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }

            return result;
        }

        // POST api/<InventoryListController>
        [HttpPost]
        public ValidationResultDTO Post([FromBody] InventoryItemDTO value)
        {
            try
            {
                return _service.Create(value);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                return new ValidationResultDTO() { Result = ResultTypeDTO.Error, Errors = new List<string>() { e.Message } };
            }
        }

        // POST api/<InventoryListController>
        [HttpPost("/PostAsync")]
        public async Task<ValidationResultDTO> PostAsync([FromBody] InventoryItemDTO value)
        {
            try
            {
                return await _service.CreateAsync(value);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                return await new Task<ValidationResultDTO>(() => new ValidationResultDTO() { Result = ResultTypeDTO.Error, Errors = new List<string>() { e.Message } });
            }
        }

        // PUT api/<InventoryListController>/5
        [HttpPut("{id}")]
        public ValidationResultDTO Put(int id, [FromBody] InventoryItemDTO value)
        {
            try
            {
                return _service.Update(id, value);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
                return new ValidationResultDTO() { Result = ResultTypeDTO.Error, Errors = new List<string>() { e.Message } };
            }
        }

        // DELETE api/<InventoryListController>/5
        [HttpDelete("{id}")]
        public ValidationResultDTO Delete(int id)
        {
            try
            {
                return _service.Delete(id);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
                return new ValidationResultDTO() { Result = ResultTypeDTO.Error, Errors = new List<string>() { e.Message } };
            }
        }

        // DELETE api/<InventoryListController>/DeleteByName/name
        [HttpDelete("/DeleteByName/{name}")]
        public ValidationResultDTO DeleteByName(string name)
        {
            try
            {
                return _service.DeleteByName(name);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
                return new ValidationResultDTO() { Result = ResultTypeDTO.Error, Errors = new List<string>() { e.Message } };
            }
        }
    }
}
