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
        string mensage = "Media das idades: ";
        int mae = 57;
        int pai = 61;
        int yago = 21;
        int igor = 29;
        int eu = 26;
        float media = (mae+pai+yago+igor+eu)/5;
        MessageBox.Show(mensage+media);
    }
}