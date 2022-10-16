using FluentValidation.Results;
using InventoryManager.Application.DTOs;
using InventoryManager.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    /// <summary>
    ///  The inventory items controller.
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryItemsController : ControllerBase
    {
        /// <summary>
        ///  The IInventory List Service.
        /// </summary>
        private readonly IInventoryAppService _service;

        /// <summary>
        /// The Inventory Items Controller.
        /// </summary>
        private readonly ILogger<InventoryItemsController> _logger;

        /// <summary>
        /// The InventoryItemsController constructor.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="logger"></param>
        public InventoryItemsController(IInventoryAppService service, ILogger<InventoryItemsController> logger)
        {
            this._service = service;
            this._logger = logger;
        }

        // GET: api/<InventoryListController>
        /// <summary>
        /// The Get operation
        /// </summary>
        /// <returns>IEnumerable<InventoryItemDTO></returns>
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
        /// <summary>
        /// The Get async operation
        /// </summary>
        /// <returns></returns>
        // GET: api/<InventoryListController>/GetAsync
        [HttpGet("GetAsync")]
        public async Task<IEnumerable<InventoryItemDTO>> GetAsync()
        {
            Task<List<InventoryItemDTO>>? result = null;

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
        /// <summary>
        /// The get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the Bussiness Inventory Item example
        /// </summary>
        /// <returns>The InventoryItem DTO</returns>
        // GET api/<InventoryListController>/BussinessInventoryItemExample
        [HttpGet("BussinessInventoryItemExample")]
        public InventoryItemDTO GetBussinessInventoryItemExample()
        {
            try
            {
                return _service.GetBussinessInventoryItemExample();
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                return null;
            }
        }

        /// <summary>
        /// Create an InventoryItemDTO
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // POST api/<InventoryListController>
        [HttpPost]
        public ValidationResult Post([FromBody] InventoryItemDTO value)
        {
            try
            {
                return _service.Create(value);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                var result = new ValidationResult();
                result.Errors.Add(new ValidationFailure(String.Empty, e.Message));

                return result;
            }
        }

        /// <summary>
        /// Create an InventoryItemDTO async
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // POST api/<InventoryListController>
        [HttpPost("PostAsync")]
        public async Task<ValidationResult> PostAsync([FromBody] InventoryItemDTO value)
        {
            try
            {
                return await _service.CreateAsync(value);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                return await new Task<ValidationResult>(() =>
                {
                    var result = new ValidationResult();
                    result.Errors.Add(new ValidationFailure(String.Empty, e.Message));

                    return result;
                });
            }
        }

        /// <summary>
        /// Modify an InventoryItemDTO
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // PUT api/<InventoryListController>/5
        [HttpPut("{id}")]
        public ValidationResult Put(int id, [FromBody] InventoryItemDTO value)
        {
            try
            {
                return _service.Update(id, value);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                var result = new ValidationResult();
                result.Errors.Add(new ValidationFailure(String.Empty, e.Message));

                return result;
            }
        }

        /// <summary>
        /// Delete an InventoryItemDTO by Id
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // DELETE api/<InventoryListController>/5
        [HttpDelete("{id}")]
        public ValidationResult Delete(int id)
        {
            try
            {
                return _service.Delete(id);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                var result = new ValidationResult();
                result.Errors.Add(new ValidationFailure(String.Empty, e.Message));

                return result;
            }
        }

        /// <summary>
        /// Delete an InventoryItemDTO by name
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // DELETE api/<InventoryListController>/DeleteByName/name
        [HttpDelete("DeleteByName/{name}")]
        public ValidationResult DeleteByName(string name)
        {
            try
            {
                return _service.DeleteByName(name);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);

                var result = new ValidationResult();
                result.Errors.Add(new ValidationFailure(String.Empty, e.Message));

                return result;
            }
        }
    }
}
