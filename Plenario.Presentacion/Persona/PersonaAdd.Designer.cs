
namespace Plenario.Presentacion.Persona
{
    partial class PersonaAdd
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
            this.btnReturnListPersona = new System.Windows.Forms.Button();
            this.tbCreditoMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPeronaAdd = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnReturnListPersona
            // 
            this.btnReturnListPersona.Location = new System.Drawing.Point(12, 402);
            this.btnReturnListPersona.Name = "btnReturnListPersona";
            this.btnReturnListPersona.Size = new System.Drawing.Size(437, 36);
            this.btnReturnListPersona.TabIndex = 21;
            this.btnReturnListPersona.Text = "Volver a la lista de personas";
            this.btnReturnListPersona.UseVisualStyleBackColor = true;
            // 
            // tbCreditoMaximo
            // 
            this.tbCreditoMaximo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreditoMaximo.Location = new System.Drawing.Point(12, 257);
            this.tbCreditoMaximo.Name = "tbCreditoMaximo";
            this.tbCreditoMaximo.Size = new System.Drawing.Size(437, 33);
            this.tbCreditoMaximo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Crédito máximo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 50);
            this.label4.TabIndex = 16;
            this.label4.Text = "Agregar Persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // btnPeronaAdd
            // 
            this.btnPeronaAdd.Location = new System.Drawing.Point(84, 321);
            this.btnPeronaAdd.Name = "btnPeronaAdd";
            this.btnPeronaAdd.Size = new System.Drawing.Size(292, 57);
            this.btnPeronaAdd.TabIndex = 14;
            this.btnPeronaAdd.Text = "Agregar";
            this.btnPeronaAdd.UseVisualStyleBackColor = true;
            this.btnPeronaAdd.Click += new System.EventHandler(this.btnPeronaAdd_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(12, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(437, 33);
            this.tbNombre.TabIndex = 13;
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(12, 181);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(437, 33);
            this.dtpFechaDeNacimiento.TabIndex = 22;
            this.dtpFechaDeNacimiento.Value = new System.DateTime(2021, 3, 9, 17, 39, 26, 0);
            // 
            // PersonaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.btnReturnListPersona);
            this.Controls.Add(this.tbCreditoMaximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPeronaAdd);
            this.Controls.Add(this.tbNombre);
            this.Name = "PersonaAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonaAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnListPersona;
        private System.Windows.Forms.TextBox tbCreditoMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPeronaAdd;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
    }
}