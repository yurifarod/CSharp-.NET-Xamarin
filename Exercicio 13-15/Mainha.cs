using System;

public class Mainha{
   public static void Main(){
    int flag = 1;
    int x = 0;
    int y = 0;
    Poupanca[] poup = new Poupanca[100];
    RendaFixa[] inv = new RendaFixa[100];
    AcumulaRendas cum = new AcumulaRendas();

    while(flag != 1){
        System.Console.WriteLine("Digite o tipo da conta");
        System.Console.WriteLine("1 - Poupança");
        System.Console.WriteLine("2 - Renda Fixa");
        int tipo = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("CPF?");
        string cpf = System.Console.ReadLine();
        System.Console.WriteLine("Nome?");
        string nome = System.Console.ReadLine();
        System.Console.WriteLine("Saldo?");
        double saldo = Convert.ToDouble(System.Console.ReadLine());

        System.Console.WriteLine("Rendimento desta conta em 1 ano!");

        if(tipo == 1){
            poup[x] = new Poupanca(cpf, nome, saldo);
            poup[x].rendimento();
            cum.acumula(poup[x]);
            x++;
        }
        else{
            inv[y] = new RendaFixa(cpf, nome, saldo);
            inv[y].rendimento();
            cum.acumula(inv[y]);
            y++;
        }

        System.Console.WriteLine("Contas abertas:");
        if(tipo == 1){
            Investimento.returnNumInvest();
        }
        else{
            Investimento.returnNumInvest();
        }
        
        System.Console.WriteLine("Rendimento total, 1 ano:");
        System.Console.WriteLine(cum.Total);
        System.Console.WriteLine("Para mais alguma conta, digite 1");
        flag = Convert.ToInt32(System.Console.ReadLine());
    }
   }
}