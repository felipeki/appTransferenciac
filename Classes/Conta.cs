using System;
namespace appTransferencia


{
    public class Conta
    {
        private tipoConta tipoConta { get;set;}
        private string Nome  { get; set; }
        private double Saldo {get; set;}
        private double Credito {get; set;}

        public Conta (tipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.tipoConta = tipoConta;
            this.Saldo = saldo;
            this.Nome = nome;
            this.Credito = credito;

        }

        public bool Sacar (double valorSaque)
        {
            if(this.Saldo - valorSaque < this.Credito *-1) {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;

        }

        public void Depositar(double valorDeposito) 
        {

        this.Saldo += valorDeposito;
        Console.WriteLine("Saldo atual da conta é {0} {1}", this.Nome, this.Saldo);

        }

        public void Transferir (double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia)) {
                contaDestino.Depositar(valorTransferencia);
            }


        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo Conta " + this.tipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;            

        }
    }

} 