namespace CSVParsers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDatosOriginales = new System.Windows.Forms.Button();
            this.btnDatosAlterados = new System.Windows.Forms.Button();
            this.btnDatosSalvados = new System.Windows.Forms.Button();
            this.brnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.btndestino = new System.Windows.Forms.Button();
            this.btnDatosBoletas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBoletas = new System.Windows.Forms.RadioButton();
            this.rbCuentas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDatosOriginales
            // 
            this.btnDatosOriginales.Location = new System.Drawing.Point(47, 501);
            this.btnDatosOriginales.Name = "btnDatosOriginales";
            this.btnDatosOriginales.Size = new System.Drawing.Size(96, 35);
            this.btnDatosOriginales.TabIndex = 1;
            this.btnDatosOriginales.Text = "Datos Cuentas";
            this.btnDatosOriginales.UseVisualStyleBackColor = true;
            this.btnDatosOriginales.Click += new System.EventHandler(this.btnDatosOriginales_Click);
            // 
            // btnDatosAlterados
            // 
            this.btnDatosAlterados.Location = new System.Drawing.Point(297, 501);
            this.btnDatosAlterados.Name = "btnDatosAlterados";
            this.btnDatosAlterados.Size = new System.Drawing.Size(102, 35);
            this.btnDatosAlterados.TabIndex = 2;
            this.btnDatosAlterados.Text = "Ver Datos Alterados";
            this.btnDatosAlterados.UseVisualStyleBackColor = true;
            this.btnDatosAlterados.Click += new System.EventHandler(this.btnDatosAlterados_Click);
            // 
            // btnDatosSalvados
            // 
            this.btnDatosSalvados.Location = new System.Drawing.Point(445, 501);
            this.btnDatosSalvados.Name = "btnDatosSalvados";
            this.btnDatosSalvados.Size = new System.Drawing.Size(98, 35);
            this.btnDatosSalvados.TabIndex = 2;
            this.btnDatosSalvados.Text = "Datos Salvados";
            this.btnDatosSalvados.UseVisualStyleBackColor = true;
            this.btnDatosSalvados.Click += new System.EventHandler(this.btnDatosSalvados_Click);
            // 
            // brnSalir
            // 
            this.brnSalir.Location = new System.Drawing.Point(701, 501);
            this.brnSalir.Name = "brnSalir";
            this.brnSalir.Size = new System.Drawing.Size(98, 35);
            this.brnSalir.TabIndex = 3;
            this.brnSalir.Text = "&Salir";
            this.brnSalir.UseVisualStyleBackColor = true;
            this.brnSalir.Click += new System.EventHandler(this.brnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origen de Datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destino de Datos:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Location = new System.Drawing.Point(121, 20);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(347, 20);
            this.txtOrigen.TabIndex = 6;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(121, 66);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(345, 20);
            this.txtDestino.TabIndex = 7;
            // 
            // btnOrigen
            // 
            this.btnOrigen.Location = new System.Drawing.Point(474, 18);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(44, 23);
            this.btnOrigen.TabIndex = 8;
            this.btnOrigen.Text = "...";
            this.btnOrigen.UseVisualStyleBackColor = true;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // btndestino
            // 
            this.btndestino.Location = new System.Drawing.Point(474, 63);
            this.btndestino.Name = "btndestino";
            this.btndestino.Size = new System.Drawing.Size(44, 23);
            this.btndestino.TabIndex = 8;
            this.btndestino.Text = "...";
            this.btndestino.UseVisualStyleBackColor = true;
            this.btndestino.Click += new System.EventHandler(this.btndestino_Click);
            // 
            // btnDatosBoletas
            // 
            this.btnDatosBoletas.Location = new System.Drawing.Point(171, 501);
            this.btnDatosBoletas.Name = "btnDatosBoletas";
            this.btnDatosBoletas.Size = new System.Drawing.Size(96, 35);
            this.btnDatosBoletas.TabIndex = 9;
            this.btnDatosBoletas.Text = "Datos Boletas";
            this.btnDatosBoletas.UseVisualStyleBackColor = true;
            this.btnDatosBoletas.Click += new System.EventHandler(this.btnDatosBoletas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCuentas);
            this.groupBox1.Controls.Add(this.rbBoletas);
            this.groupBox1.Location = new System.Drawing.Point(629, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos a Importar";
            // 
            // rbBoletas
            // 
            this.rbBoletas.AutoSize = true;
            this.rbBoletas.Location = new System.Drawing.Point(16, 42);
            this.rbBoletas.Name = "rbBoletas";
            this.rbBoletas.Size = new System.Drawing.Size(141, 17);
            this.rbBoletas.TabIndex = 0;
            this.rbBoletas.TabStop = true;
            this.rbBoletas.Text = "Importar Detalle Cuentas";
            this.rbBoletas.UseVisualStyleBackColor = true;
            this.rbBoletas.CheckedChanged += new System.EventHandler(this.rbBoletas_CheckedChanged);
            // 
            // rbCuentas
            // 
            this.rbCuentas.AutoSize = true;
            this.rbCuentas.Location = new System.Drawing.Point(16, 19);
            this.rbCuentas.Name = "rbCuentas";
            this.rbCuentas.Size = new System.Drawing.Size(105, 17);
            this.rbCuentas.TabIndex = 1;
            this.rbCuentas.TabStop = true;
            this.rbCuentas.Text = "Importar Cuentas";
            this.rbCuentas.UseVisualStyleBackColor = true;
            this.rbCuentas.CheckedChanged += new System.EventHandler(this.rbCuentas_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDatosBoletas);
            this.Controls.Add(this.btndestino);
            this.Controls.Add(this.btnOrigen);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnSalir);
            this.Controls.Add(this.btnDatosSalvados);
            this.Controls.Add(this.btnDatosAlterados);
            this.Controls.Add(this.btnDatosOriginales);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Interfase Bonafide";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDatosOriginales;
        private System.Windows.Forms.Button btnDatosAlterados;
        private System.Windows.Forms.Button btnDatosSalvados;
        private System.Windows.Forms.Button brnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.Button btndestino;
        private System.Windows.Forms.Button btnDatosBoletas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCuentas;
        private System.Windows.Forms.RadioButton rbBoletas;
    }
}

