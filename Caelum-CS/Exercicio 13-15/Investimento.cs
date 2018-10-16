public abstract class Investimento{
   
    public string cpf {get; set;} 
    public string nome  {get; set;}
    public double saldo {get; set;}
    public static int numInvest;

    public Investimento(string cpf, string nome, double saldo){
        this.cpf = cpf;
        this.nome = nome;
        this.saldo = saldo;
        numInvest++;
    }

    public abstract void rendimento();

    public static int returnNumInvest(){
        return numInvest;
    }


  
}