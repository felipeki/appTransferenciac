using System;

namespace appTransferencia
{
    class Program
    {
        static void Main(string[] args)
        {
           Conta minhaConta = new Conta(tipoConta.PessoaFisica,0,0, "Felipe Rodrigues" );
           Console.WriteLine(minhaConta.ToString());
            
        }
    }
}
