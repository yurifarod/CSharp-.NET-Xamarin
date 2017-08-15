using System.Windows.Forms;


public class Conta{

    //O cap 06 não trabalha com construtores!

    public string nome, cpf;
    public double saldo, id;

    public void saca(double valor){
        if(valor <= this.saldo){
            this.saldo -= valor;
            MessageBox.Show("Sacado: "+ valor);
        }
    }

    public void deposito(double valor){
        this.saldo += valor;
    }

    public bool transfere(double valor, Conta c){
        if(valor <= this.saldo){
            this.saldo -= valor;
            c.saldo += valor;
            MessageBox.Show("Autorizado!");
            return true;
        }
        else{
            MessageBox.Show("Não Autorizado!");
            return false;
        }
    }

    
}