
namespace Plenario.Presentacion.Persona
{
    partial class PersonaModify
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoToListPersonas = new System.Windows.Forms.Button();
            this.tbFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.tbCreditoMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre";
            // 
            // btnGoToListPersonas
            // 
            this.btnGoToListPersonas.Location = new System.Drawing.Point(12, 402);
            this.btnGoToListPersonas.Name = "btnGoToListPersonas";
            this.btnGoToListPersonas.Size = new System.Drawing.Size(437, 36);
            this.btnGoToListPersonas.TabIndex = 29;
            this.btnGoToListPersonas.Text = "Volver a la lista de personas";
            this.btnGoToListPersonas.UseVisualStyleBackColor = true;
            this.btnGoToListPersonas.Click += new System.EventHandler(this.btnGoToListPersonas_Click);
            // 
            // tbFechaDeNacimiento
            // 
            this.tbFechaDeNacimiento.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaDeNacimiento.Location = new System.Drawing.Point(12, 181);
            this.tbFechaDeNacimiento.Name = "tbFechaDeNacimiento";
            this.tbFechaDeNacimiento.Size = new System.Drawing.Size(437, 33);
            this.tbFechaDeNacimiento.TabIndex = 28;
            // 
            // tbCreditoMaximo
            // 
            this.tbCreditoMaximo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreditoMaximo.Location = new System.Drawing.Point(12, 257);
            this.tbCreditoMaximo.Name = "tbCreditoMaximo";
            this.tbCreditoMaximo.Size = new System.Drawing.Size(437, 33);
            this.tbCreditoMaximo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Crédito máximo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 50);
            this.label4.TabIndex = 24;
            this.label4.Text = "Modificar Persona";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(84, 321);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(292, 57);
            this.btnGuardarCambios.TabIndex = 23;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(12, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(437, 33);
            this.tbNombre.TabIndex = 22;
            // 
            // PersonaModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGoToListPersonas);
            this.Controls.Add(this.tbFechaDeNacimiento);
            this.Controls.Add(this.tbCreditoMaximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.tbNombre);
            this.Name = "PersonaModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonaModify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoToListPersonas;
        private System.Windows.Forms.TextBox tbFechaDeNacimiento;
        private System.Windows.Forms.TextBox tbCreditoMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox tbNombre;
    }
}