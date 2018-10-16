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
        //O Exercicio pede o uso de um laço o(n)
        //A solução apresentada tem tempo de execução constante O(1)
        int resposta = ((1+1000)*1000)/2;
        MessageBox.Show("A soma é: "+resposta);
    }
}