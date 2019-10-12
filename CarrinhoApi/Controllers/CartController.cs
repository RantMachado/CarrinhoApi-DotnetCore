using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Repositories.Interfaces;
using CarrinhoApi.UoW.Interfaces;
using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("aplication/json")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUnitOfWork _unitOfWork;

        //Seriously!?
        public CartController(ICartRepository cartRepository, IUnitOfWork unitOfWork)
        {
            _cartRepository = cartRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]        
        public async Task<ActionResult<List<Cart>>> Get()
        {
            var cartItems = await _cartRepository.GetAll();
            return Ok(cartItems);
        }

        [HttpGet("{id:length(24)}", Name = "Get")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Cart>> Get(Guid id)
        {
            var cartItems = await _cartRepository.GetById(id);
            return Ok(cartItems);
        }

        [HttpPost, Route("PostSimulatingError")]
        [ValidateAntiForgeryToken]
        public IActionResult PostSimulatingError([FromBody] CartViewModel value)
        {
            var cartItem = new Cart(value);
            _cartRepository.Add(cartItem);

            return BadRequest();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Cart>> Post([FromBody] CartViewModel value)
        {
            var cartItem = new Cart(value);
            _cartRepository.Add(cartItem);

            var testCartItem = await _cartRepository.GetById(cartItem.Id);

            await _unitOfWork.Commit();

            testCartItem = await _cartRepository.GetById(cartItem.Id);

            return Ok(testCartItem);
        }

        [HttpPut("{id:length(24)}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Cart>> Put(Guid id, [FromBody] CartViewModel value)
        {
            var cartItem = new Cart(value, id);
            _cartRepository.Update(cartItem);

            await _unitOfWork.Commit();

            return Ok(await _cartRepository.GetById(id));
        }

        [HttpDelete("{id:length(24)}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id)
        {
            _cartRepository.Remove(id);
            var testCartItem = await _cartRepository.GetById(id);

            await _unitOfWork.Commit();

            testCartItem = await _cartRepository.GetById(id);

            return Ok();

        }
    }
}
