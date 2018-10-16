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
        int fat = 1;
        
        for(int i = 1; i < 11; i++){
            fat *= i;
            MessageBox.Show("Fatorial de "+i+": "+fat);
        }
       
    }
}