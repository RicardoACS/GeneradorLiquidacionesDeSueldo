namespace Informes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtRemImponible = new System.Windows.Forms.TextBox();
            this.cboxAño = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboxMes = new System.Windows.Forms.ComboBox();
            this.cboxTrabajador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnticipos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAlcanceLiquido = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSeguros = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalDescuentos = new System.Windows.Forms.TextBox();
            this.txtImpuesto2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtOtrosDescuentos = new System.Windows.Forms.TextBox();
            this.txtAFC = new System.Windows.Forms.TextBox();
            this.txtSalud = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalHaberes = new System.Windows.Forms.TextBox();
            this.txtTotalNoImponible = new System.Windows.Forms.TextBox();
            this.txtColacion = new System.Windows.Forms.TextBox();
            this.txtMovilizacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalImponible = new System.Windows.Forms.TextBox();
            this.txtGratificacion = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBonos = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAF = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtRemImponible);
            this.groupBox1.Controls.Add(this.cboxAño);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cboxMes);
            this.groupBox1.Controls.Add(this.cboxTrabajador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(291, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "Tope Imponible";
            // 
            // txtRemImponible
            // 
            this.txtRemImponible.Location = new System.Drawing.Point(399, 53);
            this.txtRemImponible.Name = "txtRemImponible";
            this.txtRemImponible.Size = new System.Drawing.Size(131, 20);
            this.txtRemImponible.TabIndex = 35;
            this.txtRemImponible.Text = "0";
            this.txtRemImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboxAño
            // 
            this.cboxAño.FormattingEnabled = true;
            this.cboxAño.Location = new System.Drawing.Point(71, 80);
            this.cboxAño.Name = "cboxAño";
            this.cboxAño.Size = new System.Drawing.Size(150, 21);
            this.cboxAño.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(291, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "Valor UF";
            // 
            // cboxMes
            // 
            this.cboxMes.FormattingEnabled = true;
            this.cboxMes.Location = new System.Drawing.Point(71, 53);
            this.cboxMes.Name = "cboxMes";
            this.cboxMes.Size = new System.Drawing.Size(150, 21);
            this.cboxMes.TabIndex = 4;
            // 
            // cboxTrabajador
            // 
            this.cboxTrabajador.FormattingEnabled = true;
            this.cboxTrabajador.Items.AddRange(new object[] {
            "Trabajadores"});
            this.cboxTrabajador.Location = new System.Drawing.Point(71, 25);
            this.cboxTrabajador.Name = "cboxTrabajador";
            this.cboxTrabajador.Size = new System.Drawing.Size(150, 21);
            this.cboxTrabajador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtTotalAPagar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAnticipos);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtAlcanceLiquido);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liquidación";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(358, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Total a Pagar";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(435, 368);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(94, 20);
            this.txtTotalAPagar.TabIndex = 22;
            this.txtTotalAPagar.Text = "0";
            this.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Anticipos";
            // 
            // txtAnticipos
            // 
            this.txtAnticipos.Location = new System.Drawing.Point(270, 368);
            this.txtAnticipos.Name = "txtAnticipos";
            this.txtAnticipos.Size = new System.Drawing.Size(82, 20);
            this.txtAnticipos.TabIndex = 20;
            this.txtAnticipos.Text = "0";
            this.txtAnticipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAnticipos.TextChanged += new System.EventHandler(this.txtAnticipos_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Alcance Liquido";
            // 
            // txtAlcanceLiquido
            // 
            this.txtAlcanceLiquido.Location = new System.Drawing.Point(130, 368);
            this.txtAlcanceLiquido.Name = "txtAlcanceLiquido";
            this.txtAlcanceLiquido.Size = new System.Drawing.Size(79, 20);
            this.txtAlcanceLiquido.TabIndex = 18;
            this.txtAlcanceLiquido.Text = "0";
            this.txtAlcanceLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAlcanceLiquido.TextChanged += new System.EventHandler(this.txtAlcanceLiquido_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtSeguros);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtTotalDescuentos);
            this.groupBox4.Controls.Add(this.txtImpuesto2);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtOtrosDescuentos);
            this.groupBox4.Controls.Add(this.txtAFC);
            this.groupBox4.Controls.Add(this.txtSalud);
            this.groupBox4.Controls.Add(this.txtAFP);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(285, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 328);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descuentos";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "APV";
            // 
            // txtSeguros
            // 
            this.txtSeguros.Location = new System.Drawing.Point(108, 102);
            this.txtSeguros.Name = "txtSeguros";
            this.txtSeguros.Size = new System.Drawing.Size(131, 20);
            this.txtSeguros.TabIndex = 34;
            this.txtSeguros.Text = "0";
            this.txtSeguros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeguros.TextChanged += new System.EventHandler(this.txtSeguros_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total Descuentos";
            // 
            // txtTotalDescuentos
            // 
            this.txtTotalDescuentos.Location = new System.Drawing.Point(108, 285);
            this.txtTotalDescuentos.Name = "txtTotalDescuentos";
            this.txtTotalDescuentos.Size = new System.Drawing.Size(131, 20);
            this.txtTotalDescuentos.TabIndex = 30;
            this.txtTotalDescuentos.Text = "0";
            this.txtTotalDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDescuentos.TextChanged += new System.EventHandler(this.txtTotalDescuentos_TextChanged);
            // 
            // txtImpuesto2
            // 
            this.txtImpuesto2.Location = new System.Drawing.Point(108, 155);
            this.txtImpuesto2.Name = "txtImpuesto2";
            this.txtImpuesto2.Size = new System.Drawing.Size(131, 20);
            this.txtImpuesto2.TabIndex = 27;
            this.txtImpuesto2.Text = "0";
            this.txtImpuesto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuesto2.TextChanged += new System.EventHandler(this.txtImpuesto2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Impuesto 2° Cat";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Otros Descuentos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "AFC";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Isapre/Fonasa";
            // 
            // txtOtrosDescuentos
            // 
            this.txtOtrosDescuentos.Location = new System.Drawing.Point(108, 129);
            this.txtOtrosDescuentos.Name = "txtOtrosDescuentos";
            this.txtOtrosDescuentos.Size = new System.Drawing.Size(131, 20);
            this.txtOtrosDescuentos.TabIndex = 22;
            this.txtOtrosDescuentos.Text = "0";
            this.txtOtrosDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtrosDescuentos.TextChanged += new System.EventHandler(this.txtOtrosDescuentos_TextChanged);
            // 
            // txtAFC
            // 
            this.txtAFC.Location = new System.Drawing.Point(108, 76);
            this.txtAFC.Name = "txtAFC";
            this.txtAFC.Size = new System.Drawing.Size(131, 20);
            this.txtAFC.TabIndex = 21;
            this.txtAFC.Text = "0";
            this.txtAFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAFC.TextChanged += new System.EventHandler(this.txtAFC_TextChanged);
            // 
            // txtSalud
            // 
            this.txtSalud.Location = new System.Drawing.Point(108, 50);
            this.txtSalud.Name = "txtSalud";
            this.txtSalud.Size = new System.Drawing.Size(131, 20);
            this.txtSalud.TabIndex = 20;
            this.txtSalud.Text = "0";
            this.txtSalud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalud.TextChanged += new System.EventHandler(this.txtSalud_TextChanged);
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(108, 24);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(131, 20);
            this.txtAFP.TabIndex = 19;
            this.txtAFP.Text = "0";
            this.txtAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAFP.TextChanged += new System.EventHandler(this.txtAFP_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "AFP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtAF);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtBonos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTotalHaberes);
            this.groupBox3.Controls.Add(this.txtTotalNoImponible);
            this.groupBox3.Controls.Add(this.txtColacion);
            this.groupBox3.Controls.Add(this.txtMovilizacion);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTotalImponible);
            this.groupBox3.Controls.Add(this.txtGratificacion);
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.txtSueldoBase);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 328);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haberes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Haberes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total No Imponible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Colación";
            // 
            // txtTotalHaberes
            // 
            this.txtTotalHaberes.Location = new System.Drawing.Point(111, 285);
            this.txtTotalHaberes.Name = "txtTotalHaberes";
            this.txtTotalHaberes.Size = new System.Drawing.Size(131, 20);
            this.txtTotalHaberes.TabIndex = 14;
            this.txtTotalHaberes.Text = "0";
            this.txtTotalHaberes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalHaberes.TextChanged += new System.EventHandler(this.txtTotalHaberes_TextChanged);
            // 
            // txtTotalNoImponible
            // 
            this.txtTotalNoImponible.Location = new System.Drawing.Point(111, 252);
            this.txtTotalNoImponible.Name = "txtTotalNoImponible";
            this.txtTotalNoImponible.Size = new System.Drawing.Size(131, 20);
            this.txtTotalNoImponible.TabIndex = 13;
            this.txtTotalNoImponible.Text = "0";
            this.txtTotalNoImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalNoImponible.TextChanged += new System.EventHandler(this.txtTotalNoImponible_TextChanged);
            // 
            // txtColacion
            // 
            this.txtColacion.Location = new System.Drawing.Point(111, 202);
            this.txtColacion.Name = "txtColacion";
            this.txtColacion.Size = new System.Drawing.Size(131, 20);
            this.txtColacion.TabIndex = 12;
            this.txtColacion.Text = "0";
            this.txtColacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtColacion.TextChanged += new System.EventHandler(this.txtColacion_TextChanged);
            // 
            // txtMovilizacion
            // 
            this.txtMovilizacion.Location = new System.Drawing.Point(111, 176);
            this.txtMovilizacion.Name = "txtMovilizacion";
            this.txtMovilizacion.Size = new System.Drawing.Size(131, 20);
            this.txtMovilizacion.TabIndex = 11;
            this.txtMovilizacion.Text = "0";
            this.txtMovilizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMovilizacion.TextChanged += new System.EventHandler(this.txtMovilizacion_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Movilización";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Imponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gratificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descuentos";
            // 
            // txtTotalImponible
            // 
            this.txtTotalImponible.Location = new System.Drawing.Point(111, 132);
            this.txtTotalImponible.Name = "txtTotalImponible";
            this.txtTotalImponible.Size = new System.Drawing.Size(131, 20);
            this.txtTotalImponible.TabIndex = 5;
            this.txtTotalImponible.Text = "0";
            this.txtTotalImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalImponible.TextChanged += new System.EventHandler(this.txtTotalImponible_TextChanged);
            // 
            // txtGratificacion
            // 
            this.txtGratificacion.Location = new System.Drawing.Point(111, 106);
            this.txtGratificacion.Name = "txtGratificacion";
            this.txtGratificacion.Size = new System.Drawing.Size(131, 20);
            this.txtGratificacion.TabIndex = 4;
            this.txtGratificacion.Text = "0";
            this.txtGratificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGratificacion.TextChanged += new System.EventHandler(this.txtGratificacion_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(111, 53);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(131, 20);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Location = new System.Drawing.Point(111, 27);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(131, 20);
            this.txtSueldoBase.TabIndex = 2;
            this.txtSueldoBase.Text = "0";
            this.txtSueldoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldoBase.TextChanged += new System.EventHandler(this.txtSueldoBase_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sueldo Base";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(218, 572);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(166, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Liquidación";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Bonos";
            // 
            // txtBonos
            // 
            this.txtBonos.Location = new System.Drawing.Point(111, 79);
            this.txtBonos.Name = "txtBonos";
            this.txtBonos.Size = new System.Drawing.Size(131, 20);
            this.txtBonos.TabIndex = 18;
            this.txtBonos.Text = "0";
            this.txtBonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBonos.TextChanged += new System.EventHandler(this.txtBonos_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 231);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Asig. Familiar";
            // 
            // txtAF
            // 
            this.txtAF.Location = new System.Drawing.Point(111, 228);
            this.txtAF.Name = "txtAF";
            this.txtAF.Size = new System.Drawing.Size(131, 20);
            this.txtAF.TabIndex = 20;
            this.txtAF.Text = "0";
            this.txtAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAF.TextChanged += new System.EventHandler(this.txtAF_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 617);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxAño;
        private System.Windows.Forms.ComboBox cboxMes;
        private System.Windows.Forms.ComboBox cboxTrabajador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalImponible;
        private System.Windows.Forms.TextBox txtGratificacion;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSueldoBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalHaberes;
        private System.Windows.Forms.TextBox txtTotalNoImponible;
        private System.Windows.Forms.TextBox txtColacion;
        private System.Windows.Forms.TextBox txtMovilizacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalDescuentos;
        private System.Windows.Forms.TextBox txtImpuesto2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOtrosDescuentos;
        private System.Windows.Forms.TextBox txtAFC;
        private System.Windows.Forms.TextBox txtSalud;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAnticipos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAlcanceLiquido;
        private System.Windows.Forms.TextBox txtRemImponible;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSeguros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtAF;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBonos;
    }
}

