using Grpc.Core;
using grpcSample.Grpc;

namespace Descontos.Services
{
    public class DescontosService : DescontosGrpc.DescontosGrpcBase
    {
        public override async Task<GetCupomByIdResponse> GetCupom(GetCupomByIdRequest request, ServerCallContext context)
        {
            var result = await Task.FromResult(new GetCupomByIdResponse()
            {
                Cupom = new Cupom
                {
                    CupomId = "Cupom de id 1",
                    Codigo = "Codigo de 2",
                    JaFoiUsado = false,
                    Quantidade = 5
                }
            });

            return result;
        }
    }
}
