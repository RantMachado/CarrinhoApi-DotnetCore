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
        public async Task<ActionResult<IEnumerable<Cart>>> Get()
        {
            var cartItems = await _cartRepository.GetAll();
            return Ok(cartItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> Get(Guid id)
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

    }
}
