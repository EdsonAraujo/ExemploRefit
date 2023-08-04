using System.Threading.Tasks;
using Refit;






namespace ExemploRefit
{
	internal interface ICepApiService
	{
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAddressAsync(string cep);
	
		
	}

}

 