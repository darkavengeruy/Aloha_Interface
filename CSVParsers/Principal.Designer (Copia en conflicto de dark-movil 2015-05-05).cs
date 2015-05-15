﻿namespace CSVParsers
{
    partial class Principal
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
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaElegida = new System.Windows.Forms.TextBox();
            this.TC_Configuracion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBaseDatosSQL = new System.Windows.Forms.TextBox();
            this.txtPasswordSQL = new System.Windows.Forms.TextBox();
            this.txtUsuarioSQL = new System.Windows.Forms.TextBox();
            this.txtServerSQL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDirectorioFTP = new System.Windows.Forms.TextBox();
            this.txtClaveFTP = new System.Windows.Forms.TextBox();
            this.txtUsuarioFTP = new System.Windows.Forms.TextBox();
            this.txtServerFTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTienda = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubirFtp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TC_Configuracion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(72, 50);
            this.dtpFechaVenta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 0;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escoga Fecha de Venta:";
            // 
            // txtFechaElegida
            // 
            this.txtFechaElegida.Enabled = false;
            this.txtFechaElegida.Location = new System.Drawing.Point(308, 50);
            this.txtFechaElegida.Name = "txtFechaElegida";
            this.txtFechaElegida.Size = new System.Drawing.Size(240, 20);
            this.txtFechaElegida.TabIndex = 2;
            // 
            // TC_Configuracion
            // 
            this.TC_Configuracion.Controls.Add(this.tabPage1);
            this.TC_Configuracion.Controls.Add(this.tabPage2);
            this.TC_Configuracion.Location = new System.Drawing.Point(12, 110);
            this.TC_Configuracion.Name = "TC_Configuracion";
            this.TC_Configuracion.SelectedIndex = 0;
            this.TC_Configuracion.Size = new System.Drawing.Size(789, 378);
            this.TC_Configuracion.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuracion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBaseDatosSQL);
            this.groupBox3.Controls.Add(this.txtPasswordSQL);
            this.groupBox3.Controls.Add(this.txtUsuarioSQL);
            this.groupBox3.Controls.Add(this.txtServerSQL);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(390, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 139);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuracion Centralizador";
            // 
            // txtBaseDatosSQL
            // 
            this.txtBaseDatosSQL.Location = new System.Drawing.Point(80, 102);
            this.txtBaseDatosSQL.Name = "txtBaseDatosSQL";
            this.txtBaseDatosSQL.Size = new System.Drawing.Size(300, 20);
            this.txtBaseDatosSQL.TabIndex = 6;
            // 
            // txtPasswordSQL
            // 
            this.txtPasswordSQL.Location = new System.Drawing.Point(80, 76);
            this.txtPasswordSQL.Name = "txtPasswordSQL";
            this.txtPasswordSQL.PasswordChar = '*';
            this.txtPasswordSQL.Size = new System.Drawing.Size(300, 20);
            this.txtPasswordSQL.TabIndex = 5;
            // 
            // txtUsuarioSQL
            // 
            this.txtUsuarioSQL.Location = new System.Drawing.Point(80, 50);
            this.txtUsuarioSQL.Name = "txtUsuarioSQL";
            this.txtUsuarioSQL.Size = new System.Drawing.Size(300, 20);
            this.txtUsuarioSQL.TabIndex = 4;
            // 
            // txtServerSQL
            // 
            this.txtServerSQL.Location = new System.Drawing.Point(80, 24);
            this.txtServerSQL.Name = "txtServerSQL";
            this.txtServerSQL.Size = new System.Drawing.Size(300, 20);
            this.txtServerSQL.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "BaseDatos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Clave:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Usuario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Servidor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDirectorioFTP);
            this.groupBox2.Controls.Add(this.txtClaveFTP);
            this.groupBox2.Controls.Add(this.txtUsuarioFTP);
            this.groupBox2.Controls.Add(this.txtServerFTP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(390, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de FTP";
            // 
            // txtDirectorioFTP
            // 
            this.txtDirectorioFTP.Location = new System.Drawing.Point(80, 102);
            this.txtDirectorioFTP.Name = "txtDirectorioFTP";
            this.txtDirectorioFTP.Size = new System.Drawing.Size(300, 20);
            this.txtDirectorioFTP.TabIndex = 6;
            // 
            // txtClaveFTP
            // 
            this.txtClaveFTP.Location = new System.Drawing.Point(80, 76);
            this.txtClaveFTP.Name = "txtClaveFTP";
            this.txtClaveFTP.PasswordChar = '*';
            this.txtClaveFTP.Size = new System.Drawing.Size(300, 20);
            this.txtClaveFTP.TabIndex = 5;
            // 
            // txtUsuarioFTP
            // 
            this.txtUsuarioFTP.Location = new System.Drawing.Point(80, 50);
            this.txtUsuarioFTP.Name = "txtUsuarioFTP";
            this.txtUsuarioFTP.Size = new System.Drawing.Size(300, 20);
            this.txtUsuarioFTP.TabIndex = 4;
            // 
            // txtServerFTP
            // 
            this.txtServerFTP.Location = new System.Drawing.Point(80, 24);
            this.txtServerFTP.Name = "txtServerFTP";
            this.txtServerFTP.Size = new System.Drawing.Size(300, 20);
            this.txtServerFTP.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Directorio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Clave:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Servidor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreTienda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdTienda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Instalacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tienda:";
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(66, 54);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(300, 20);
            this.txtNombreTienda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Tienda:";
            // 
            // txtIdTienda
            // 
            this.txtIdTienda.Location = new System.Drawing.Point(67, 20);
            this.txtIdTienda.Name = "txtIdTienda";
            this.txtIdTienda.Size = new System.Drawing.Size(299, 20);
            this.txtIdTienda.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdConsultar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos DBF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(32, 308);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(96, 32);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "&Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSubirFtp
            // 
            this.btnSubirFtp.Location = new System.Drawing.Point(641, 50);
            this.btnSubirFtp.Name = "btnSubirFtp";
            this.btnSubirFtp.Size = new System.Drawing.Size(104, 36);
            this.btnSubirFtp.TabIndex = 4;
            this.btnSubirFtp.Text = "Exportar Datos";
            this.btnSubirFtp.UseVisualStyleBackColor = true;
            this.btnSubirFtp.Click += new System.EventHandler(this.btnSubirFtp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Carpeta Origen:";
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(406, 503);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(88, 37);
            this.btnGuardarConfiguracion.TabIndex = 6;
            this.btnGuardarConfiguracion.Text = "Guardar Configuracion";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 552);
            this.Controls.Add(this.btnGuardarConfiguracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubirFtp);
            this.Controls.Add(this.TC_Configuracion);
            this.Controls.Add(this.txtFechaElegida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.TC_Configuracion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaElegida;
        private System.Windows.Forms.TabControl TC_Configuracion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTienda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubirFtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtClaveFTP;
        private System.Windows.Forms.TextBox txtUsuarioFTP;
        private System.Windows.Forms.TextBox txtServerFTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDirectorioFTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBaseDatosSQL;
        private System.Windows.Forms.TextBox txtPasswordSQL;
        private System.Windows.Forms.TextBox txtUsuarioSQL;
        private System.Windows.Forms.TextBox txtServerSQL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}