
namespace Plenario.Presentacion.Persona
{
    partial class PersonaDelete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre";
            // 
            // btnGoToListPersonas
            // 
            this.btnGoToListPersonas.Location = new System.Drawing.Point(21, 297);
            this.btnGoToListPersonas.Name = "btnGoToListPersonas";
            this.btnGoToListPersonas.Size = new System.Drawing.Size(638, 31);
            this.btnGoToListPersonas.TabIndex = 47;
            this.btnGoToListPersonas.Text = "Volver a la lista de personas";
            this.btnGoToListPersonas.UseVisualStyleBackColor = true;
            this.btnGoToListPersonas.Click += new System.EventHandler(this.btnGoToListPersonas_Click);
            // 
            // tbFechaDeNacimiento
            // 
            this.tbFechaDeNacimiento.Enabled = false;
            this.tbFechaDeNacimiento.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaDeNacimiento.Location = new System.Drawing.Point(222, 141);
            this.tbFechaDeNacimiento.Name = "tbFechaDeNacimiento";
            this.tbFechaDeNacimiento.Size = new System.Drawing.Size(437, 33);
            this.tbFechaDeNacimiento.TabIndex = 46;
            // 
            // tbCreditoMaximo
            // 
            this.tbCreditoMaximo.Enabled = false;
            this.tbCreditoMaximo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreditoMaximo.Location = new System.Drawing.Point(222, 184);
            this.tbCreditoMaximo.Name = "tbCreditoMaximo";
            this.tbCreditoMaximo.Size = new System.Drawing.Size(437, 33);
            this.tbCreditoMaximo.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Crédito máximo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 50);
            this.label4.TabIndex = 42;
            this.label4.Text = "Eliminar Persona";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(21, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(638, 31);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(222, 96);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(437, 33);
            this.tbNombre.TabIndex = 40;
            // 
            // PersonaDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGoToListPersonas);
            this.Controls.Add(this.tbFechaDeNacimiento);
            this.Controls.Add(this.tbCreditoMaximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbNombre);
            this.Name = "PersonaDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonaDelete";
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbNombre;
    }
}