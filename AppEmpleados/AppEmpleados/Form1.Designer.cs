namespace AppEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblFIngreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtipFechaN = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalcularE = new System.Windows.Forms.Button();
            this.btnCalcularA = new System.Windows.Forms.Button();
            this.btnCalcularP = new System.Windows.Forms.Button();
            this.txtCalcularE = new System.Windows.Forms.TextBox();
            this.txtCalcularA = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtpFechaI);
            this.panel1.Controls.Add(this.dtipFechaN);
            this.panel1.Controls.Add(this.cmbSexo);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblFIngreso);
            this.panel1.Controls.Add(this.lblFNacimiento);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.txtSalario);
            this.panel2.Controls.Add(this.lblSalario);
            this.panel2.Location = new System.Drawing.Point(12, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 78);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.txtCalcularA);
            this.panel3.Controls.Add(this.txtCalcularE);
            this.panel3.Controls.Add(this.btnCalcularP);
            this.panel3.Controls.Add(this.btnCalcularA);
            this.panel3.Controls.Add(this.btnCalcularE);
            this.panel3.Location = new System.Drawing.Point(13, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 135);
            this.panel3.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(3, 37);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(4, 65);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.Location = new System.Drawing.Point(4, 92);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFNacimiento.TabIndex = 3;
            this.lblFNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.AutoSize = true;
            this.lblFIngreso.Location = new System.Drawing.Point(4, 119);
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFIngreso.TabIndex = 4;
            this.lblFIngreso.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Datos Personales";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(172, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(172, 57);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(76, 21);
            this.cmbSexo.TabIndex = 7;
            // 
            // dtipFechaN
            // 
            this.dtipFechaN.Location = new System.Drawing.Point(172, 85);
            this.dtipFechaN.Name = "dtipFechaN";
            this.dtipFechaN.Size = new System.Drawing.Size(200, 20);
            this.dtipFechaN.TabIndex = 8;
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Location = new System.Drawing.Point(172, 113);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaI.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salario";
            // 
            // lblSalario
            // 
            this.lblSalario.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(103, 32);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(173, 29);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(120, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(330, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCalcularE
            // 
            this.btnCalcularE.Location = new System.Drawing.Point(116, 28);
            this.btnCalcularE.Name = "btnCalcularE";
            this.btnCalcularE.Size = new System.Drawing.Size(132, 23);
            this.btnCalcularE.TabIndex = 0;
            this.btnCalcularE.Text = "Calcular Edad";
            this.btnCalcularE.UseVisualStyleBackColor = true;
            // 
            // btnCalcularA
            // 
            this.btnCalcularA.Location = new System.Drawing.Point(116, 60);
            this.btnCalcularA.Name = "btnCalcularA";
            this.btnCalcularA.Size = new System.Drawing.Size(132, 23);
            this.btnCalcularA.TabIndex = 1;
            this.btnCalcularA.Text = "Calcular Antiguedad";
            this.btnCalcularA.UseVisualStyleBackColor = true;
            // 
            // btnCalcularP
            // 
            this.btnCalcularP.Location = new System.Drawing.Point(116, 89);
            this.btnCalcularP.Name = "btnCalcularP";
            this.btnCalcularP.Size = new System.Drawing.Size(132, 23);
            this.btnCalcularP.TabIndex = 2;
            this.btnCalcularP.Text = "Calcular Prestaciones";
            this.btnCalcularP.UseVisualStyleBackColor = true;
            // 
            // txtCalcularE
            // 
            this.txtCalcularE.Location = new System.Drawing.Point(278, 31);
            this.txtCalcularE.Name = "txtCalcularE";
            this.txtCalcularE.Size = new System.Drawing.Size(140, 20);
            this.txtCalcularE.TabIndex = 3;
            // 
            // txtCalcularA
            // 
            this.txtCalcularA.Location = new System.Drawing.Point(278, 60);
            this.txtCalcularA.Name = "txtCalcularA";
            this.txtCalcularA.Size = new System.Drawing.Size(140, 20);
            this.txtCalcularA.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prestaciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppEmpleados.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(397, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.DateTimePicker dtipFechaN;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFIngreso;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalcularE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularP;
        private System.Windows.Forms.Button btnCalcularA;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtCalcularA;
        private System.Windows.Forms.TextBox txtCalcularE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

