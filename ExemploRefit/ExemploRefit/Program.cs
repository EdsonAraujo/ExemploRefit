using System.Threading.Tasks;
using Refit;
using System;


namespace ExemploRefit
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu cep"); 
                
                string cepInformado = Console.ReadLine().ToString();

                Console.WriteLine("Consultando informação do CEP informando" + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);  

                Console.WriteLine($"\nLogradouro: {address.Logradouro},\nBairro:{address.Bairro}, \nCidade:{address.Localidade}-{address.Uf}");
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro na consulta de cep" + e.Message);
            }

        }
    }
}