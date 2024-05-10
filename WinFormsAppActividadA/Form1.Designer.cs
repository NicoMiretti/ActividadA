namespace WinFormsAppActividadA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            txtNombreApellido = new TextBox();
            txtNum = new TextBox();
            lbl2 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnIngresar = new Button();
            txtCuentas = new TextBox();
            label3 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            txtNum2 = new TextBox();
            label5 = new Label();
            txtMonto = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            txtFecha = new TextBox();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtDeudor = new TextBox();
            btnDeudor = new Button();
            lblDeudor = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(317, 25);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(103, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Cuentas Bancarias";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(244, 69);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(100, 23);
            txtNombreApellido.TabIndex = 1;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(186, 69);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(43, 23);
            txtNum.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(43, 72);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(126, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Ingresar nueva cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 51);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre y Apellido";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(363, 68);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtCuentas
            // 
            txtCuentas.Location = new Point(519, 69);
            txtCuentas.Multiline = true;
            txtCuentas.Name = "txtCuentas";
            txtCuentas.ReadOnly = true;
            txtCuentas.Size = new Size(259, 242);
            txtCuentas.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 51);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 8;
            label3.Text = "Cuentas actuales";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(589, 317);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 130);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 10;
            label4.Text = "Agregar transacción:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(57, 180);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 162);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 12;
            label5.Text = "Numero de cuenta";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(57, 317);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 299);
            label6.Name = "label6";
            label6.Size = new Size(158, 15);
            label6.TabIndex = 14;
            label6.Text = "Monto: (negativo o positivo)";
            // 
            // button1
            // 
            button1.Location = new Point(62, 358);
            button1.Name = "button1";
            button1.Size = new Size(95, 59);
            button1.TabIndex = 15;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 206);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 17;
            label7.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(57, 224);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 250);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 19;
            label8.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(57, 268);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 130);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 20;
            label9.Text = "¿Es deudor?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(289, 162);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 22;
            label10.Text = "Numero de cuenta";
            // 
            // txtDeudor
            // 
            txtDeudor.Location = new Point(295, 180);
            txtDeudor.Name = "txtDeudor";
            txtDeudor.Size = new Size(100, 23);
            txtDeudor.TabIndex = 21;
            // 
            // btnDeudor
            // 
            btnDeudor.Location = new Point(299, 224);
            btnDeudor.Name = "btnDeudor";
            btnDeudor.Size = new Size(95, 59);
            btnDeudor.TabIndex = 23;
            btnDeudor.Text = "Consultar si es deudor";
            btnDeudor.UseVisualStyleBackColor = true;
            btnDeudor.Click += btnDeudor_Click;
            // 
            // lblDeudor
            // 
            lblDeudor.AutoSize = true;
            lblDeudor.Location = new Point(401, 183);
            lblDeudor.Name = "lblDeudor";
            lblDeudor.Size = new Size(0, 15);
            lblDeudor.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDeudor);
            Controls.Add(btnDeudor);
            Controls.Add(label10);
            Controls.Add(txtDeudor);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(txtFecha);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtMonto);
            Controls.Add(label5);
            Controls.Add(txtNum2);
            Controls.Add(label4);
            Controls.Add(btnActualizar);
            Controls.Add(label3);
            Controls.Add(txtCuentas);
            Controls.Add(btnIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl2);
            Controls.Add(txtNum);
            Controls.Add(txtNombreApellido);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtNombreApellido;
        private TextBox txtNum;
        private Label lbl2;
        private Label label1;
        private Label label2;
        private Button btnIngresar;
        private TextBox txtCuentas;
        private Label label3;
        private Button btnActualizar;
        private Label label4;
        private TextBox txtNum2;
        private Label label5;
        private TextBox txtMonto;
        private Label label6;
        private Button button1;
        private Label label7;
        private TextBox txtFecha;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label9;
        private Label label10;
        private TextBox txtDeudor;
        private Button btnDeudor;
        private Label lblDeudor;
    }
}
