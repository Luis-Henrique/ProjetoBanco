public class Conta 
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta (int codigo)  
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        ValidarValor(valor);
        VerificarSaldo(valor);
        
        Saldo -= valor;  
    }

    public void Depositar(double valor)
    {
        ValidarValor(valor);    
        Saldo += valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        Sacar(valor);
        conta.Depositar(valor);  
    }

    private void ValidarValor(double valor)
    {
        if(valor <= 0) throw new ArgumentException("Valor invalido");
    }

    private void VerificarSaldo(double valor)
    {
        if(Saldo < valor) throw new ArgumentException("O saldo não é suficiente para realizar a operação");
    }
}