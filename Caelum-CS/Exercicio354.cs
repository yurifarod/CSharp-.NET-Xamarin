using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
 
public class Baskara : Form{
    private TextBox inA, inB, inC;
    private Button b;

    static public void Main(){
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Baskara());
    }
 
    public Baskara(){
        
        this.inA = new System.Windows.Forms.TextBox();
        this.inA.Location = new Point(10, 10);
        this.inA.Size = new Size(75, 25);
        this.inA.Text = "Valor A";
        this.inB = new System.Windows.Forms.TextBox();
        this.inB.Location = new Point(10, 50);
        this.inB.Size = new Size(75, 25);
        this.inB.Text = "Valor B";
        this.inC = new System.Windows.Forms.TextBox();
        this.inC.Location = new Point(10, 90);
        this.inC.Size = new Size(75, 25);
        this.inC.Text = "Valor C";

        b = new Button();
        b.Text = "Clica Ai Pai!!!";
        b.Click += new EventHandler(Button_Click);
        this.b.Location = new Point(10, 130);
        
        this.SuspendLayout();
        this.ClientSize = new System.Drawing.Size(200, 200);
        this.Controls.Add(b);
        this.Controls.Add(inA);
        this.Controls.Add(inB);
        this.Controls.Add(inC);
        this.Text = "BASKARA";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
 
    private void Button_Click(object sender, EventArgs e){ 
        int a = Convert.ToInt32(inA.Text);
        int b = Convert.ToInt32(inB.Text);
        int c = Convert.ToInt32(inC.Text);
        int delta = (b*b)-(4*a*c);
        double raiz1 = (-b+Math.Sqrt(delta))/(2*a);
        double raiz2 = (-b-Math.Sqrt(delta))/(2*a);
        MessageBox.Show("Raizes: "+raiz1+" e "+raiz2);
    }
}