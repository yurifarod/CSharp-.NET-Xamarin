using System.Windows.Forms;


public class Conta{

    //O cap 06 não trabalha com construtores!

    public string nome {get; private set;}
    public string cpf {get; private set;}
    public int id {get; private set;}
    public double saldo {get; private set;}

    public Conta(int id, double saldo, string nome, string cpf){
        this.id = id;
        this.cpf = cpf;
        this.saldo = saldo;
        this.nome = nome;

    }



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