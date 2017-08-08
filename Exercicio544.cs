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
        int resp = 0;
        for(int i = 0; i < 100; i++){
            if(i % 3 != 0){
                resp += i;
            }
        }
        MessageBox.Show("A soma é: "+resp);
    }
}