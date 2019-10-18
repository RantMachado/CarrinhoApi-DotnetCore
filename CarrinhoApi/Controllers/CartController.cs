using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarrinhoApi.Domain.Entities;
using CarrinhoApi.Repositories.Interfaces;
using CarrinhoApi.UoW.Interfaces;
using CarrinhoApi.ViewModel;
using CarrinhoApi.Service.Interfaces;


namespace CarrinhoApi.Controllers
{
    [Route("api/[controller]")]    
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICartService _cartService;

        //Seriously!?
        public CartController(ICartRepository cartRepository, IUnitOfWork unitOfWork, ICartService cartService)
        {
            _cartRepository = cartRepository;
            _unitOfWork = unitOfWork;
            _cartService = cartService;
        }

        [HttpGet]        
        public async Task<ActionResult<IEnumerable<Cart>>> Get()
        {
            var cartItems = await _cartRepository.GetAll();
            return Ok(cartItems);
        }

        [HttpGet("{id:length(24)}", Name="GetCartItem")]        
        public async Task<ActionResult<Cart>> Get(string id)
        {
            var cartItem = await _cartRepository.GetById(id);
            return Ok(cartItem);
        }

        [HttpPost, Route("PostSimulatingError")]        
        public IActionResult PostSimulatingError([FromBody] CartViewModel cartVM)
        {
            var item = new Cart(cartVM);
            _cartRepository.Add(item);
            return BadRequest();
        }

        [HttpPost]        
        public async Task<ActionResult<Cart>> Post([FromBody] CartViewModel cartViewModel)
        {
            if(cartViewModel.Promocode != null)
                _cartService.ValidatePromo(cartViewModel);

            var cartItem = new Cart(cartViewModel);

            _cartRepository.Add(cartItem);

            var testCartitem = await _cartRepository.GetById(cartItem.Id);

            await _unitOfWork.Commit();

            testCartitem = await _cartRepository.GetById(cartItem.Id);

            return Ok(testCartitem);
        }

        [HttpPut("{id:length(24)}")]              
        public async Task<ActionResult<Cart>> Put([FromBody] CartViewModel cartViewModel)
        {
            var cartItem = new Cart(cartViewModel);

            _cartRepository.Update(cartItem);

            await _unitOfWork.Commit();

            return Ok(await _cartRepository.GetById(cartItem.Id));
        }

        [HttpDelete("{id:length(24)}")]        
        public async Task<ActionResult> Delete(string id)
        {
            _cartRepository.Remove(id);

            var testCartItem = await _cartRepository.GetById(id);

            await _unitOfWork.Commit();

            testCartItem = await _cartRepository.GetById(id);

            return Ok();
        }
    }
}
