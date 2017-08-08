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
        int[] fib = new int[2];
        int aux = 0;
        fib[0] = 0;
        fib[1] = 1;
        //Há outras maneiras mais "dinâmicas" de se fazer!
        MessageBox.Show("Fibonacci: "+fib[0]);
        MessageBox.Show("Fibonacci: "+fib[1]);
        while(fib[1] < 100){
            aux = fib[0]+fib[1];
            fib[0] = fib[1];
            fib[1] = aux;
            MessageBox.Show("Fibonacci: "+fib[1]);
        }
       
    }
}