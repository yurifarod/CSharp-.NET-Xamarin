using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public class Cap9 : Form{

        //Janela de manipulação
        private TextBox txtValor, txtDestino, txtOrigem;
        private Button deposita, saca, transf, info;
        Conta[] conta = new Conta[100];
        
        //Janela de criação
        private TextBox txtNome, txtCpf, txtSaldo, txtInfo;
        private Button cria;
        int index = 0;
        int id = 10000;

        static public void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cap9());
        }
        
        public Cap9(){
            IniatilizeComponent();
        }

        public void IniatilizeComponent(){

            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNome.Location = new Point(10, 10);
            this.txtNome.Size = new Size(75, 25);
            this.txtNome.Text = "Nome";

            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCpf.Location = new Point(10, 50);
            this.txtCpf.Size = new Size(75, 25);
            this.txtCpf.Text = "CPF";
            
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtSaldo.Location = new Point(10, 90);
            this.txtSaldo.Size = new Size(75, 25);
            this.txtSaldo.Text = "Inicial";

            this.cria = new Button();
            this.cria.Text = "CRIAR";
            this.cria.Location = new Point(110, 10);
            this.cria.Click += new EventHandler(cria_Click);

            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValor.Location = new Point(10, 310);
            this.txtValor.Size = new Size(75, 25);
            this.txtValor.Text = "Valor";

            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtDestino.Location = new Point(10, 350);
            this.txtDestino.Size = new Size(75, 25);
            this.txtDestino.Text = "C/C Destino";
            
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtOrigem.Location = new Point(10, 390);
            this.txtOrigem.Size = new Size(75, 25);
            this.txtOrigem.Text = "C/C Origem";

            this.deposita = new Button();
            this.deposita.Text = "DEPÓSITO";
            this.deposita.Location = new Point(110, 310);
            this.deposita.Click += new EventHandler(deposita_Click);

            this.saca = new Button();
            this.saca.Text = "SAQUE";
            this.saca.Location = new Point(110, 390);
            this.saca.Click += new EventHandler(saca_Click);

            this.transf = new Button();
            this.transf.Text = "TRANSF.";
            this.transf.Location = new Point(110, 350);
            this.transf.Click += new EventHandler(transf_Click);

            this.info = new Button();
            this.info.Text = "INFO";
            this.info.Location = new Point(110, 200);
            this.info.Click += new EventHandler(info_Click);

            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtInfo.Location = new Point(10, 200);
            this.txtInfo.Size = new Size(75, 25);
            this.txtInfo.Text = "Informação";

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.deposita);
            this.Controls.Add(this.saca);
            this.Controls.Add(this.transf);
            this.Controls.Add(this.info);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.cria);
            this.Text = "REAL MADRID BANK!";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void cria_Click(object sender, EventArgs e){
            double saldo = Convert.ToDouble(txtSaldo.Text);
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            
            this.conta[index] = new Conta(id, saldo, nome, cpf);
            this.index++;
            this.id = 10000+index;
        }

        private Conta returnConta(int y){
            Conta a = null;
            for(int i = 0; i < this.index; i++){
                if(this.conta[i].id == y){
                    a = this.conta[i];
                }
            }
            return a;
        }

        private void deposita_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtDestino.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            Conta aux = returnConta(id);
            aux.deposito(valor);
        }
    
        private void saca_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtDestino.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            Conta aux = returnConta(id);
            aux.saca(valor);
        }
    
        private void transf_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtDestino.Text);
            int id2 = Convert.ToInt32(txtOrigem.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            Conta aux = returnConta(id);
            Conta aux2 = returnConta(id2);
            aux.transfere(valor, aux2);
        }

        private void info_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtInfo.Text);
            Conta aux = returnConta(id);
            string inform;
            inform = " Informação do cliente "+aux.nome+
            "\n Id: "+aux.id+"\n CPF: "+aux.cpf+"\n Saldo: "+
            aux.saldo+"\n";
            MessageBox.Show(inform);
        }
 }