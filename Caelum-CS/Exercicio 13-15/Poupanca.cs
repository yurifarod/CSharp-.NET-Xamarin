using System;

public class Poupanca : Investimento, IRendimento{
    
    //construtores n são herdados no C# 
    public Poupanca(string cpf, string nome, double saldo)
    :base(cpf, nome, saldo){
    }

    public override void rendimento(){
        this.saldo = saldo*(Math.Pow(1.003,11));
    }

    public double acumulaRendas(){
        return this.saldo;
    }

}