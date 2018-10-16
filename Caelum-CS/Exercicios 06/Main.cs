using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public class Cap6 : Form{

        private TextBox txtValor, txtDestino, txtOrigem;
        private Button deposita, saca, transf, info;
        Conta a, b, c, d, e;

        static public void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cap6());
        }
        
        public Cap6(){
            IniatilizeComponent();
        }

        public void IniatilizeComponent(){

            this.a = new Conta();
            this.a.nome = "Ferenc Puskás";
            this.a.cpf = "12346";
            this.a.id = 1;
            this.a.saldo = 200;

            this.b = new Conta();
            this.b.nome = "Darcy Canário";
            this.b.cpf = "12545";
            this.b.id = 2;
            this.b.saldo = 500000;
            
            this.c = new Conta();
            this.c.nome = "Di Stéphano";
            this.c.cpf = "12555";
            this.c.id = 3;
            this.c.saldo = 5000;

            this.d = new Conta();
            this.d.nome = "Francesco Gento";
            this.d.cpf = "12355";
            this.d.id = 4;
            this.d.saldo = 6000;

            this.e = new Conta();
            this.e.nome = "Raymond Kopa";
            this.e.cpf = "52345";
            this.e.id = 5;
            this.e.saldo = 50050;

            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValor.Location = new Point(10, 10);
            this.txtValor.Size = new Size(75, 25);
            this.txtValor.Text = "Valor";

            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtDestino.Location = new Point(10, 50);
            this.txtDestino.Size = new Size(75, 25);
            this.txtDestino.Text = "C/C Destino";
            
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtOrigem.Location = new Point(10, 90);
            this.txtOrigem.Size = new Size(75, 25);
            this.txtOrigem.Text = "C/C Origem";

            this.deposita = new Button();
            this.deposita.Text = "DEPÓSITO";
            this.deposita.Location = new Point(110, 10);
            this.deposita.Click += new EventHandler(deposita_Click);

            this.saca = new Button();
            this.saca.Text = "SAQUE";
            this.saca.Location = new Point(110, 90);
            this.saca.Click += new EventHandler(saca_Click);

            this.transf = new Button();
            this.transf.Text = "TRANSF.";
            this.transf.Location = new Point(110, 50);
            this.transf.Click += new EventHandler(transf_Click);

            this.info = new Button();
            this.info.Text = "INFO";
            this.info.Location = new Point(110, 130);
            this.info.Click += new EventHandler(info_Click);

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.deposita);
            this.Controls.Add(this.saca);
            this.Controls.Add(this.transf);
            this.Controls.Add(this.info);
            this.Text = "REAL MADRID BANK!";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    
        private void deposita_Click(object sender, EventArgs e){
            Conta conta = this.a;
            int id = Convert.ToInt32(txtDestino.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            if(id == 1){
                conta = this.a;
            }
            if(id == 2){
                conta = this.b;
            }
            if(id == 3){
                conta = this.c;
            }
            if(id == 4){
                conta = this.d;
            }
            if(id == 5){
                conta = this.e;
            }
            conta.deposito(valor);
        }
    
        private void saca_Click(object sender, EventArgs e){
            Conta conta = this.a;
            int id = Convert.ToInt32(txtDestino.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            if(id == 1){
                conta = this.a;
            }
            if(id == 2){
                conta = this.b;
            }
            if(id == 3){
                conta = this.c;
            }
            if(id == 4){
                conta = this.d;
            }
            if(id == 5){
                conta = this.e;
            }
            conta.saca(valor);
        }
    
        private void transf_Click(object sender, EventArgs e){
            Conta conta, conta2;
            conta = this.a;
            conta2 = this.b;
            int id = Convert.ToInt32(txtDestino.Text);
            int id2 = Convert.ToInt32(txtOrigem.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            if(id == 1){
                conta = this.a;
            }
            if(id == 2){
                conta = this.b;
            }
            if(id == 3){
                conta = this.c;
            }
            if(id == 4){
                conta = this.d;
            }
            if(id == 5){
                conta = this.e;
            }
            if(id2 == 1){
                conta2 = this.a;
            }
            if(id2 == 2){
                conta2 = this.b;
            }
            if(id2 == 3){
                conta2 = this.c;
            }
            if(id2 == 4){
                conta2 = this.d;
            }
            if(id2 == 5){
                conta2 = this.e;
            }
            conta.transfere(valor, conta2);
        }

        private void info_Click(object sender, EventArgs e){
            Conta conta = this.a;
            int id = Convert.ToInt32(txtDestino.Text);
            if(id == 1){
                conta = this.a;
            }
            if(id == 2){
                conta = this.b;
            }
            if(id == 3){
                conta = this.c;
            }
            if(id == 4){
                conta = this.d;
            }
            if(id == 5){
                conta = this.e;
            }
            string inform;
            inform = " Informação do cliente "+conta.nome+
            "\n Id: "+conta.id+"\n CPF: "+conta.cpf+"\n Saldo: "+
            conta.saldo+"\n";
            MessageBox.Show(inform);
        }
 }