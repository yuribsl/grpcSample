

using grpcSample.Grpc;

namespace CarrinhoDeCompras.Services
{
    public class DescontosService
    {
        private readonly DescontosGrpc.DescontosGrpcClient _grpcClient;

        public DescontosService(DescontosGrpc.DescontosGrpcClient grpcClient)
        {
            _grpcClient = grpcClient;
        }

        public async Task<GetCupomByIdResponse> ObterDesconto()
        {
            GetCupomByIdRequest request = new GetCupomByIdRequest();
            GetCupomByIdResponse response = await _grpcClient.GetCupomAsync(request);
            return response;
        }
    }
}
