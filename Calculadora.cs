using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public class Form1 : Form{

        private TextBox txtValor1, txtValor2, lblResultado;
        private Button soma, sub, mult, div;

        static public void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
        public Form1(){
            IniatilizeComponent();
        }

        public void IniatilizeComponent(){

            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor1.Location = new Point(10, 10);
            this.txtValor1.Size = new Size(75, 25);
            this.txtValor1.Text = "Valor 1";
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor2.Location = new Point(10, 50);
            this.txtValor2.Size = new Size(75, 25);
            this.txtValor2.Text = "Valor 2";
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.lblResultado.Location = new Point(10, 90);
            this.lblResultado.Size = new Size(75, 25);
            this.lblResultado.Text = "Resultado";

            this.soma = new Button();
            this.soma.Text = "Soma";
            this.soma.Location = new Point(110, 10);
            this.soma.Click += new EventHandler(soma_Click);

            this.sub = new Button();
            this.sub.Text = "Subtração";
            this.sub.Location = new Point(110, 130);
            this.sub.Click += new EventHandler(sub_Click);

            this.div = new Button();
            this.div.Text = "Divisão";
            this.div.Location = new Point(110, 50);
            this.div.Click += new EventHandler(div_Click);

            this.mult = new Button();
            this.mult.Text = "Multiplicação";
            this.mult.Location = new Point(110, 90);
            this.mult.Click += new EventHandler(mult_Click);


            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Text = "CALCULADEIRA";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    
        private void soma_Click(object sender, EventArgs e){
            int valor1, valor2, resultado;
            
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            
            resultado = valor1 + valor2;
            
            lblResultado.Text = resultado.ToString();
        }
    
        private void sub_Click(object sender, EventArgs e){
            int valor1, valor2, resultado;
            
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            
            resultado = valor1 - valor2;
            
            lblResultado.Text = resultado.ToString();
        }
    
        private void mult_Click(object sender, EventArgs e){
            int valor1, valor2, resultado;
            
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            
            resultado = valor1 * valor2;
            
            lblResultado.Text = resultado.ToString();
        }
    
        private void div_Click(object sender, EventArgs e){
            int valor1, valor2, resultado;
            
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            
            resultado = valor1 / valor2;
            
            lblResultado.Text = resultado.ToString();
        }
 }