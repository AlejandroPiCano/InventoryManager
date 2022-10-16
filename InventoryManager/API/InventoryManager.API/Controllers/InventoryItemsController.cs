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
               
        /// <summary>
        /// The Get async operation
        /// </summary>
        /// <returns></returns>
        // GET: api/<InventoryListController>/GetAsync
        [HttpGet]
        public async Task<IEnumerable<InventoryItemDTO>> Get()
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
        public async Task<InventoryItemDTO> Get(int id)
        {
            InventoryItemDTO result = null;

            try
            {
                return await _service.GetInventoryItemAsync(id);
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
        /// Create an InventoryItemDTO async
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // POST api/<InventoryListController>
        [HttpPost]
        public async Task<ValidationResult> Post([FromBody] InventoryItemDTO value)
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
        public async Task<ValidationResult> Put(int id, [FromBody] InventoryItemDTO value)
        {
            try
            {
                return await _service.UpdateAsync(id, value);
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
        /// Delete an InventoryItemDTO by Id
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // DELETE api/<InventoryListController>/5
        [HttpDelete("{id}")]
        public async Task<ValidationResult> Delete(int id)
        {
            try
            {
                return await _service.DeleteAsync(id);
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
        /// Delete an InventoryItemDTO by name
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ValidationResult.</returns>
        // DELETE api/<InventoryListController>/DeleteByName/name
        [HttpDelete("DeleteByName/{name}")]
        public async Task<ValidationResult> DeleteByName(string name)
        {
            try
            {
                return await _service.DeleteByNameAsync(name);
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
    }
}
