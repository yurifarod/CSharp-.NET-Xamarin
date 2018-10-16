using System;
using System.Drawing;
using System.Windows.Forms;
 
public class Exercicio : Form{

    static public void Main(){
        Application.Run(new Exercicio());
    }
 
    public Exercicio(){
        Button b = new Button();
        b.Text = "Click Me!";
        b.Click += new EventHandler(Button_Click);
        Controls.Add(b);
    }
 
    private void Button_Click(object sender, EventArgs e){ 
        double valor = 1543.21;

        if(valor < 999){
            valor = valor*1.02;
        }
        else if(valor < 3000){
            valor = valor*1.025;
        }
        else if(valor < 7000){
            valor = valor*1.028;
        }
        else{
            valor = valor*1.03;
        }
        MessageBox.Show("Valor após tarifa: "+valor);

    }
}