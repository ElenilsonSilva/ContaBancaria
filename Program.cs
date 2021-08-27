using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente(20);
            var contaI = new ContaInvestimento(30);

            var contaNova  = ConverteConta<ContaCorrente,ContaInvestimento>(conta);
            Console.WriteLine(contaNova.Saldo);
            
        }

        public static G ConverteConta<T, G>(T contaAtual) where T : Conta where G : Conta
        {
            G contaConvertida = Activator.CreateInstance<G>();
           
            contaConvertida.Saldo = contaAtual.Saldo;
            contaConvertida.Numero = contaAtual.Numero;
            contaConvertida.Agencia = contaAtual.Agencia;

            return contaConvertida;
        }
    }
}
