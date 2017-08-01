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
        bool brasileiro = true;
        int idade = 15;
        if(idade > 16 && brasileiro){
            MessageBox.Show("PODE VOTAR!");
        }
        else{
            MessageBox.Show("NÃO PODE VOTAR");
        }

    }
}