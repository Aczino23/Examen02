using System.Windows.Forms;

namespace ConversorMonedas;

public partial class Form2 : Form
{
    public CheckBox MXN;
    public CheckBox USD;
    public CheckBox CAD;
    public CheckBox EUR;
    public CheckBox JPY;
    private string tipoMonedaElegida;
    private Button btnAceptar;
    private Button btnCancelar;

    public Form2(string tipoMonedaElegida)
    {
        MXN = new CheckBox();
        USD = new CheckBox();
        CAD = new CheckBox();
        EUR = new CheckBox();
        JPY = new CheckBox();
        this.tipoMonedaElegida = tipoMonedaElegida;
        btnAceptar = new Button();
        btnCancelar = new Button();
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        // tamaño de la ventana
        this.Size = new Size(300, 300);
        
        // título de la ventana
        this.Text = "Tipo Conversión";
        
        // Boton de aceptar
        btnAceptar.Text = "Aceptar";
        btnAceptar.AutoSize = true;
        btnAceptar.Location = new Point(10, 170);
        btnAceptar.Click += new EventHandler(btnAceptar_Click);
            
        // Boton de cancelar
        btnCancelar.Text = "Cancelar";
        btnCancelar.AutoSize = true;
        btnCancelar.Location = new Point(155, 170);
        btnCancelar.Click += new EventHandler(btnCancelar_Click);
        
        
        // peso mexicano MXN
        MXN.AutoSize = true;
        MXN.Location = new Point(10, 10);
        MXN.Text = "MXN - Peso mexicano";
        
        if (tipoMonedaElegida != "MXN") 
        {
            this.Controls.Add(MXN);
        }
        
        // dolar estadounidense USD
        USD.AutoSize = true;
        USD.Location = new Point(10, 40);
        USD.Text = "USD - Dólar estadounidense";
        
        if (tipoMonedaElegida != "USD")
        {
            this.Controls.Add(USD);
        }

        // dolar canadiense CAD
        CAD.AutoSize = true;
        CAD.Location = new Point(10, 70);
        CAD.Text = "CAD - Dólar canadiense";
        
        if (tipoMonedaElegida != "CAD")
        {
            this.Controls.Add(CAD);
        }
        // euro EUR
        EUR.AutoSize = true;
        EUR.Location = new Point(10, 100);
        EUR.Text = "EUR - Euro";
        
        if (tipoMonedaElegida != "EUR")
        {
            this.Controls.Add(EUR);
        }

        // yen japonés JPY
        JPY.AutoSize = true;
        JPY.Location = new Point(10, 130);
        JPY.Text = "JPY - Yen japonés";
        
        if (tipoMonedaElegida != "JPY")
        {
            this.Controls.Add(JPY);
        }
        
        // Se agregan los botones
        this.Controls.Add(btnAceptar);
        this.Controls.Add(btnCancelar);
    }
    
    private void btnAceptar_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        this.Close();
    }
    
    private void btnCancelar_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}