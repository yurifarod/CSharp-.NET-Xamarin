using System;

public class RendaFixa : Investimento, IRendimento{
    //construtores não são herdados no C#
     
     public RendaFixa(string cpf, string nome, double saldo)
    :base(cpf, nome, saldo){
    }
    
    public override void rendimento(){
        this.saldo = saldo*(Math.Pow(1.15,11));
    }

    public double acumulaRendas(){
        return this.saldo;
    }

}