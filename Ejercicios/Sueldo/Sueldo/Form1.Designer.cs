namespace Sueldo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nphijos = new System.Windows.Forms.NumericUpDown();
            this.ckbonificacion = new System.Windows.Forms.CheckBox();
            this.txtpagohextra = new System.Windows.Forms.TextBox();
            this.txthextrastrabajadas = new System.Windows.Forms.TextBox();
            this.txtpagohnormal = new System.Windows.Forms.TextBox();
            this.txthnormalestrabajadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.txtbonificacion = new System.Windows.Forms.TextBox();
            this.txtsueldobruto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtpagohextra);
            this.groupBox1.Controls.Add(this.txthextrastrabajadas);
            this.groupBox1.Controls.Add(this.txtpagohnormal);
            this.groupBox1.Controls.Add(this.txthnormalestrabajadas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada Laboral";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(326, 231);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(88, 25);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(182, 231);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(88, 25);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(35, 231);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(88, 25);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nphijos);
            this.groupBox3.Controls.Add(this.ckbonificacion);
            this.groupBox3.Location = new System.Drawing.Point(79, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cant. de Hijos";
            // 
            // nphijos
            // 
            this.nphijos.Location = new System.Drawing.Point(93, 31);
            this.nphijos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nphijos.Name = "nphijos";
            this.nphijos.Size = new System.Drawing.Size(47, 20);
            this.nphijos.TabIndex = 1;
            // 
            // ckbonificacion
            // 
            this.ckbonificacion.AutoSize = true;
            this.ckbonificacion.Location = new System.Drawing.Point(189, 34);
            this.ckbonificacion.Name = "ckbonificacion";
            this.ckbonificacion.Size = new System.Drawing.Size(120, 17);
            this.ckbonificacion.TabIndex = 0;
            this.ckbonificacion.Text = "Recibir Bonificacion";
            this.ckbonificacion.UseVisualStyleBackColor = false;
            // 
            // txtpagohextra
            // 
            this.txtpagohextra.Location = new System.Drawing.Point(326, 115);
            this.txtpagohextra.Name = "txtpagohextra";
            this.txtpagohextra.Size = new System.Drawing.Size(101, 20);
            this.txtpagohextra.TabIndex = 7;
            // 
            // txthextrastrabajadas
            // 
            this.txthextrastrabajadas.Location = new System.Drawing.Point(40, 115);
            this.txthextrastrabajadas.Name = "txthextrastrabajadas";
            this.txthextrastrabajadas.Size = new System.Drawing.Size(104, 20);
            this.txthextrastrabajadas.TabIndex = 6;
            // 
            // txtpagohnormal
            // 
            this.txtpagohnormal.Location = new System.Drawing.Point(326, 47);
            this.txtpagohnormal.Name = "txtpagohnormal";
            this.txtpagohnormal.Size = new System.Drawing.Size(101, 20);
            this.txtpagohnormal.TabIndex = 5;
            // 
            // txthnormalestrabajadas
            // 
            this.txthnormalestrabajadas.Location = new System.Drawing.Point(40, 47);
            this.txthnormalestrabajadas.Name = "txthnormalestrabajadas";
            this.txthnormalestrabajadas.Size = new System.Drawing.Size(104, 20);
            this.txthnormalestrabajadas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pago por hora extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago por hora Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Extras Trabajadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas Normales Trabajadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsueldoneto);
            this.groupBox2.Controls.Add(this.txtbonificacion);
            this.groupBox2.Controls.Add(this.txtsueldobruto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(36, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.Location = new System.Drawing.Point(123, 90);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.Size = new System.Drawing.Size(104, 20);
            this.txtsueldoneto.TabIndex = 13;
            // 
            // txtbonificacion
            // 
            this.txtbonificacion.Location = new System.Drawing.Point(123, 66);
            this.txtbonificacion.Name = "txtbonificacion";
            this.txtbonificacion.Size = new System.Drawing.Size(104, 20);
            this.txtbonificacion.TabIndex = 12;
            // 
            // txtsueldobruto
            // 
            this.txtsueldobruto.Location = new System.Drawing.Point(123, 40);
            this.txtsueldobruto.Name = "txtsueldobruto";
            this.txtsueldobruto.Size = new System.Drawing.Size(104, 20);
            this.txtsueldobruto.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sueldo Neto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bonificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sueldo Bruto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtpagohextra;
        private System.Windows.Forms.TextBox txthextrastrabajadas;
        private System.Windows.Forms.TextBox txtpagohnormal;
        private System.Windows.Forms.TextBox txthnormalestrabajadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbonificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nphijos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.TextBox txtbonificacion;
        private System.Windows.Forms.TextBox txtsueldobruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

