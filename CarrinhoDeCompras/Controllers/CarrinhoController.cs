using CarrinhoDeCompras.Services;
using Grpc.Net.Client;
using grpcSample.Grpc;
using Microsoft.AspNetCore.Mvc;

namespace CarrinhoDeCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetValorCarrinho()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:44332");
            var service = new DescontosService(new DescontosGrpc.DescontosGrpcClient(channel));
            var result = await service.ObterDesconto();
            return Ok(result);
        }
    }
}
