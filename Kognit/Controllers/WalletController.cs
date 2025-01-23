using Kognit.DTOs;
using Kognit.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kognit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        private readonly IWalletService _walletService;

        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateWallet(WalletDTO walletDto)
        {
            if (walletDto == null) return BadRequest("Dados inválidos.");
            
            var res = await _walletService.Create(walletDto);

            if (res <= 0)
            {
                return StatusCode(500, "Erro ao criar a carteira.");
            }

            return Ok(res);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserWallets(int userId)
        {
            // Busca as carteiras do usuário
            var walletsDto = await _walletService.GetUserWallets(userId);

            if (walletsDto == null || !walletsDto.Any())
            {
                return NotFound("Nenhuma carteira encontrada do usuário.");
            }

            return Ok(walletsDto);
        }
    }

}
