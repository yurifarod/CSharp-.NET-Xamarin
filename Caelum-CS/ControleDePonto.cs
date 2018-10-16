using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public class Form1 : Form
{

    private TextBox entrada, almoco, retorno, saida, lblResultado;
    private Button calc;

    static public void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }

    public Form1()
    {
        IniatilizeComponent();
    }

    public void IniatilizeComponent()
    {

        this.entrada = new System.Windows.Forms.TextBox();
        this.entrada.Location = new Point(10, 10);
        this.entrada.Size = new Size(75, 25);
        this.entrada.Text = "Entrada";
        this.almoco = new System.Windows.Forms.TextBox();
        this.almoco.Location = new Point(10, 50);
        this.almoco.Size = new Size(75, 25);
        this.almoco.Text = "Almoço";
        this.retorno = new System.Windows.Forms.TextBox();
        this.retorno.Location = new Point(10, 90);
        this.retorno.Size = new Size(75, 25);
        this.retorno.Text = "Retorno";
        this.saida = new System.Windows.Forms.TextBox();
        this.saida.Location = new Point(10, 130);
        this.saida.Size = new Size(75, 25);
        this.saida.Text = "SAIDA";

        this.calc = new Button();
        this.calc.Text = "Cálculo";
        this.calc.Location = new Point(110, 10);
        this.calc.Click += new EventHandler(calc_Click);

        this.SuspendLayout();

        this.ClientSize = new System.Drawing.Size(200, 200);
        this.Controls.Add(this.entrada);
        this.Controls.Add(this.almoco);
        this.Controls.Add(this.retorno);
        this.Controls.Add(this.saida);
        this.Controls.Add(this.calc);;
        this.Text = "CÁLCULO DE HORÁRIO DE SAÍDA";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void calc_Click(object sender, EventArgs e)
    {
        DateTime ent, alm, ret, casa;
        ent = Convert.ToDateTime(entrada.Text);
        alm = Convert.ToDateTime(almoco.Text);
        ret = Convert.ToDateTime(retorno.Text);

        ent = alm - ent;
        casa = ret + ent;

        Saida.Text = casa.ToString();
    }
}