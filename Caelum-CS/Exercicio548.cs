using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
 
public class Exercicio : Form{

    private Label lblResultado;

    static public void Main(){
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Exercicio());
    }
 
    public Exercicio(){
        Button b = new Button();
        b.Text = "Click Me!";
        b.Click += new EventHandler(Button_Click);
        Controls.Add(b);

        this.lblResultado = new System.Windows.Forms.Label();
        this.lblResultado.Location = new Point(0, 30);
        this.lblResultado.Size = new Size(500, 300);
        this.lblResultado.Text = "Resultado";
        this.Controls.Add(this.lblResultado);
    }
 
    private void Button_Click(object sender, EventArgs e){ 
        string resultado = "1 \n";
        for(int i = 2; i < 10; i++){
            int j = i;
            for(int k = 2; j <= i*i; k++){
                resultado = resultado+j+" ";
                j = i*k;
            }
            resultado = resultado+"\n";
        }

        lblResultado.Text = resultado;
       
    }
}