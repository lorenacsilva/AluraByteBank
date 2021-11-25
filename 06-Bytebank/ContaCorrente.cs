
// Uma classe define os membros e a estrutura que os objetos deste tipo de classe devem seguir.

//Encapsulamento: Criar dois métodos para manipular um campo interno da classe

using System;

namespace _06_Bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; } //não tem lógica, por baixo dos panos é construido sozinho}
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo //Propiedade deve ter nome em maiúscula 
        {
            get { return _saldo;  }
            set
            {
                if (value < 0)
                {
                    return; //para de executar o método e volta o fluxo do programa 
                }

                _saldo = value;
            }
        }

        public bool Sacar(double valor) //Toda função é um verbo no infitinitivo e em letra maiúscula 
        {
            if(_saldo < valor) //this utiliza a instância desse objeto
            {
               return false; //devolve um valor para quem chamou a função
            }   
         else
            {
                _saldo -= valor;
                return true;
            }
         }

        public void Depositar(double valor) //isso é um método porque não ter retorno (método e função é mesma coisa)
        {
            _saldo += valor;
        }

        public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;   
            }
        }
    }
}

