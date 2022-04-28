namespace ConversorMonedas;

public partial class Form1 : Form
{
    private ComboBox cmbTipoMoneda;
    private Label lblTipoMoneda;
    private Label lblMonto;
    private TextBox txtMonto;
    private Button btnCalcular;
    private Label lblConversioes;
    private Label lblPesosMxn;
    private Label lblDolarUsd;
    private Label lblDolarCad;
    private Label lblEuro;
    private Label lblYenJp;
    private TextBox txtPesosMxn;
    private TextBox txtDolarUsd;
    private TextBox txtDolarCad;
    private TextBox txtEuro;
    private TextBox txtYenJp;
    private string tipoMonedaElegida;
    
    public Form1()
    {
        cmbTipoMoneda = new ComboBox();
        lblTipoMoneda = new Label();
        lblMonto = new Label();
        txtMonto = new TextBox();
        btnCalcular = new Button();
        lblConversioes = new Label();
        lblPesosMxn = new Label();
        lblDolarUsd = new Label();
        lblDolarCad = new Label();
        lblEuro = new Label();
        lblYenJp = new Label();
        txtPesosMxn = new TextBox();
        txtDolarUsd = new TextBox();
        txtDolarCad = new TextBox();
        txtEuro = new TextBox();
        txtYenJp = new TextBox();
        tipoMonedaElegida = "";
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(400, 500);
        
        // Texto de la ventana
        this.Text = "Conversor de monedas";
        
        // Asignar Texto a los controles
        lblTipoMoneda.Text = "Moneda";
        lblMonto.Text = "Monto";
        btnCalcular.Text = "Calcular";
        lblConversioes.Text = "Conversiones";
        lblPesosMxn.Text = "MXN - Peso";
        lblDolarUsd.Text = "USD - Dolar";
        lblDolarCad.Text = "CAD - Dolar";
        lblEuro.Text = "EUR - Euro";
        lblYenJp.Text = "JPY - Yen Japonés";
        
        
        // Asignar posiciones
        lblTipoMoneda.Location = new Point(10, 10);
        cmbTipoMoneda.Location = new Point(10, 35);
        lblMonto.Location = new Point(245, 10);
        txtMonto.Location = new Point(245, 35);
        btnCalcular.Location = new Point(260, 70);
        lblConversioes.Location = new Point(10, 100);
        lblPesosMxn.Location = new Point(10, 140);
        txtPesosMxn.Location = new Point(150, 140);
        lblDolarUsd.Location = new Point(10, 180);
        txtDolarUsd.Location = new Point(150, 180);
        lblDolarCad.Location = new Point(10, 220);
        txtDolarCad.Location = new Point(150, 220);
        lblEuro.Location = new Point(10, 260);
        txtEuro.Location = new Point(150, 260);
        lblYenJp.Location = new Point(10, 300);
        txtYenJp.Location = new Point(150, 300);
        
        
        // Asignar items al comboBox de tipo de 
        cmbTipoMoneda.Items.Add("MXN - Peso mexicano");
        cmbTipoMoneda.Items.Add("USD - Dólar estadounidense");
        cmbTipoMoneda.Items.Add("CAD - Dólar canadiense");
        cmbTipoMoneda.Items.Add("EUR - Euro");
        cmbTipoMoneda.Items.Add("JPY - Yen japonés");

        // Asignar tamaños
        cmbTipoMoneda.Size = new Size(200, 20);
        lblTipoMoneda.AutoSize = true;
        lblMonto.AutoSize = true;
        btnCalcular.AutoSize = true;
        lblConversioes.AutoSize = true;
        lblPesosMxn.AutoSize = true;
        lblDolarUsd.AutoSize = true;
        lblDolarCad.AutoSize = true;
        lblEuro.AutoSize = true;
        lblYenJp.AutoSize = true;
        
        // ocultar Labels y TextBox de conversiones
        lblPesosMxn.Visible = false;
        txtPesosMxn.Visible = false;
        lblDolarUsd.Visible = false;
        txtDolarUsd.Visible = false;
        lblDolarCad.Visible = false;
        txtDolarCad.Visible = false;
        lblEuro.Visible = false;
        txtEuro.Visible = false;
        lblYenJp.Visible = false;
        txtYenJp.Visible = false;
        
        // no poder modificar el texto de los TextBox
        txtPesosMxn.ReadOnly = true;
        txtDolarUsd.ReadOnly = true;
        txtDolarCad.ReadOnly = true;
        txtEuro.ReadOnly = true;
        txtYenJp.ReadOnly = true;

        // Asignar eventos
        cmbTipoMoneda.SelectedIndexChanged += new EventHandler(cmbTipoMoneda_ValueChanged);
        btnCalcular.Click += new EventHandler(btnCalcular_Click);
        
        // Agregar controles al formulario
        this.Controls.Add(lblTipoMoneda);
        this.Controls.Add(cmbTipoMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblConversioes);
        this.Controls.Add(lblPesosMxn);
        this.Controls.Add(txtPesosMxn);
        this.Controls.Add(lblDolarUsd);
        this.Controls.Add(txtDolarUsd);
        this.Controls.Add(lblDolarCad);
        this.Controls.Add(txtDolarCad);
        this.Controls.Add(lblEuro);
        this.Controls.Add(txtEuro);
        this.Controls.Add(lblYenJp);
        this.Controls.Add(txtYenJp);
    }

    private void cmbTipoMoneda_ValueChanged(object? sender, EventArgs e)
    {
        if (cmbTipoMoneda.SelectedItem != null && txtMonto != null)
        {
            if (cmbTipoMoneda.SelectedItem.ToString() == "USD - Dólar estadounidense")
            {
                tipoMonedaElegida = "USD";
            }
            else if (cmbTipoMoneda.SelectedItem.ToString() == "MXN - Peso mexicano")
            {
                tipoMonedaElegida = "MXN";
            }
            else if (cmbTipoMoneda.SelectedItem.ToString() == "CAD - Dólar canadiense")
            {
                tipoMonedaElegida = "CAD";
            }
            else if (cmbTipoMoneda.SelectedItem.ToString() == "EUR - Euro")
            {
                tipoMonedaElegida = "EUR";
            }
            else if (cmbTipoMoneda.SelectedItem.ToString() == "JPY - Yen japonés")
            {
                tipoMonedaElegida = "JPY";
            }
        }
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        try
        {
            double monto = Double.Parse(txtMonto.Text); 
            Form2 frmVentana = new Form2(tipoMonedaElegida);
            if (frmVentana.ShowDialog() == DialogResult.OK)
            {
                txtPesosMxn.Visible = false;
                txtDolarUsd.Visible = false;
                txtDolarCad.Visible = false;
                txtEuro.Visible = false;
                txtYenJp.Visible = false;
                lblPesosMxn.Visible = false;
                lblDolarUsd.Visible = false;
                lblDolarCad.Visible = false;
                lblEuro.Visible = false;
                lblYenJp.Visible = false;
                
                if (txtMonto.Text != null && monto > 0 && cmbTipoMoneda.SelectedItem.ToString() != "")
                {
                    if (frmVentana.MXN.Checked == true)
                    {
                        txtPesosMxn.Visible = true;
                        lblPesosMxn.Visible = true;
                        if (tipoMonedaElegida == "USD")
                        {
                            double pesosMxn = monto * 21.23;
                            pesosMxn = Math.Round(pesosMxn, 2);
                            txtPesosMxn.Text = "$ " + pesosMxn;
                        }
                        if (tipoMonedaElegida == "CAD")
                        {
                            double pesosMxn = monto * 16.55;
                            pesosMxn = Math.Round(pesosMxn, 2);
                            txtPesosMxn.Text = "$ " + pesosMxn;
                        }
                        if (tipoMonedaElegida == "EUR")
                        {
                            double pesosMxn = monto * 23.96;
                            pesosMxn = Math.Round(pesosMxn, 2);
                            txtPesosMxn.Text = "$ " + pesosMxn;
                        }
                        if (tipoMonedaElegida == "JPY")
                        {
                            double pesosMxn = monto * 0.1878;
                            pesosMxn = Math.Round(pesosMxn, 2);
                            txtPesosMxn.Text = "$ " + pesosMxn;
                        }
                    }

                    if (frmVentana.USD.Checked == true)
                    {
                        txtDolarUsd.Visible = true;
                        lblDolarUsd.Visible = true;
                        if (tipoMonedaElegida == "MXN")
                        {
                            double dolaresUsd = monto * 0.05;
                            dolaresUsd = Math.Round(dolaresUsd, 2);
                            txtDolarUsd.Text = "$ " + dolaresUsd;
                        }

                        if (tipoMonedaElegida == "CAD")
                        {
                            double dolaresUsd = monto * 0.78;
                            dolaresUsd = Math.Round(dolaresUsd, 2);
                            txtDolarUsd.Text = "$ " + dolaresUsd;
                        }

                        if (tipoMonedaElegida == "EUR")
                        {
                            double dolaresUsd = monto * 1.13;
                            dolaresUsd = Math.Round(dolaresUsd, 2);
                            txtDolarUsd.Text = "$ " + dolaresUsd;
                        }

                        if (tipoMonedaElegida == "JPY")
                        {
                            double dolaresUsd = monto * 0.0088;
                            dolaresUsd = Math.Round(dolaresUsd, 2);
                            txtDolarUsd.Text = "$ " + dolaresUsd;
                        }
                    }

                    if (frmVentana.CAD.Checked == true)
                    {
                        txtDolarCad.Visible = true;
                        lblDolarCad.Visible = true;
                        if (tipoMonedaElegida == "USD")
                        {
                            double dolaresCad = monto * 1.28;
                            dolaresCad = Math.Round(dolaresCad, 2);
                            txtDolarCad.Text = "$ " + dolaresCad;
                        }

                        if (tipoMonedaElegida == "MXN")
                        {
                            double dolaresCad = monto * 0.06;
                            dolaresCad = Math.Round(dolaresCad, 2);
                            txtDolarCad.Text = "$ " + dolaresCad;
                        }

                        if (tipoMonedaElegida == "EUR")
                        {
                            double dolaresCad = monto * 1.45;
                            dolaresCad = Math.Round(dolaresCad, 2);
                            txtDolarCad.Text = "$ " + dolaresCad;
                        }

                        if (tipoMonedaElegida == "JPY")
                        {
                            double dolaresCad = monto * 0.0113;
                            dolaresCad = Math.Round(dolaresCad, 2);
                            txtDolarCad.Text = "$ " + dolaresCad;
                        }
                    }

                    if (frmVentana.EUR.Checked == true)
                    {
                        txtEuro.Visible = true;
                        lblEuro.Visible = true;
                        if (tipoMonedaElegida == "USD")
                        {
                            double euros = monto * 0.89;
                            euros = Math.Round(euros, 2);
                            txtEuro.Text = "€ " + euros;
                        }

                        if (tipoMonedaElegida == "CAD")
                        {
                            double euros = monto * 0.69;
                            euros = Math.Round(euros, 2);
                            txtEuro.Text = "€ " + euros;
                        }

                        if (tipoMonedaElegida == "MXN")
                        {
                            double euros = monto * 0.04;
                            euros = Math.Round(euros, 2);
                            txtEuro.Text = "€ " + euros;
                        }

                        if (tipoMonedaElegida == "JPY")
                        {
                            double euros = monto * 0.0078;
                            // formato de 00.00
                            euros = Math.Round(euros, 2);
                            txtEuro.Text = "€ " + euros;
                        }
                    }

                    if (frmVentana.JPY.Checked == true)
                    {
                        txtYenJp.Visible = true;
                        lblYenJp.Visible = true;
                        if (tipoMonedaElegida == "USD")
                        {
                            double yensJpy = monto * 113.05;
                            yensJpy = Math.Round(yensJpy, 2);
                            txtYenJp.Text = "¥ " + yensJpy;
                        }

                        if (tipoMonedaElegida == "CAD")
                        {
                            double yensJpy = monto * 88.12;
                            yensJpy = Math.Round(yensJpy, 2);
                            txtYenJp.Text = "¥ " + yensJpy;
                        }

                        if (tipoMonedaElegida == "EUR")
                        {
                            double yensJpy = monto * 127.56;
                            yensJpy = Math.Round(yensJpy, 2);
                            txtYenJp.Text = "¥ " + yensJpy;
                        }

                        if (tipoMonedaElegida == "MXN")
                        {
                            double yensJpy = monto * 5.32;
                            yensJpy = Math.Round(yensJpy, 2);
                            txtYenJp.Text = "¥ " + yensJpy;
                        } 
                    }
                }
                else
                {
                    MessageBox.Show("El monto ingresado no es válido", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // mandar el foco al textbox de monto
                    txtMonto.Focus();
                    txtMonto.Text = "";
                }
            }
            else
            {
                txtPesosMxn.Visible = false;
                lblPesosMxn.Visible = false;
                txtDolarUsd.Visible = false;
                lblDolarUsd.Visible = false;
                txtDolarCad.Visible = false;
                lblDolarCad.Visible = false;
                txtEuro.Visible = false;
                lblEuro.Visible = false;
                txtYenJp.Visible = false;
                lblYenJp.Visible = false;
            }
        } catch (Exception exception)
        {
            MessageBox.Show("Error: Valor no válio o tipo de moneda no válido", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);    
        }
    }
}