
// Uma classe define os membros e a estrutura que os objetos deste tipo de classe devem seguir.

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor) //Toda função é um verbo no infitinitivo e em letra maiúscula e ter retorno
    {
        if(this.saldo < valor) //this utiliza a instância desse objeto
        {
            return false; //devolve um valor para quem chamou a função
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor) //isso é um método porque não ter retorno (método e função sao sinonimos)
    {
        this.saldo += valor;
    }

    public bool Transferir (double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;   
        }
    }
}