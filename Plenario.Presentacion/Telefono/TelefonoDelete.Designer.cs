
namespace Plenario.Presentacion.Telefono
{
    partial class TelefonoDelete
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbNumeroDeTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Numero de teléfono";
            // 
            // btnGoToListPersonas
            // 
            this.btnGoToListPersonas.Location = new System.Drawing.Point(21, 200);
            this.btnGoToListPersonas.Name = "btnGoToListPersonas";
            this.btnGoToListPersonas.Size = new System.Drawing.Size(451, 31);
            this.btnGoToListPersonas.TabIndex = 43;
            this.btnGoToListPersonas.Text = "Volver a la lista de personas";
            this.btnGoToListPersonas.UseVisualStyleBackColor = true;
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
            this.btnDelete.Location = new System.Drawing.Point(21, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(451, 31);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbNumeroDeTelefono
            // 
            this.tbNumeroDeTelefono.Enabled = false;
            this.tbNumeroDeTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroDeTelefono.Location = new System.Drawing.Point(204, 96);
            this.tbNumeroDeTelefono.Name = "tbNumeroDeTelefono";
            this.tbNumeroDeTelefono.Size = new System.Drawing.Size(268, 33);
            this.tbNumeroDeTelefono.TabIndex = 40;
            // 
            // TelefonoDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGoToListPersonas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbNumeroDeTelefono);
            this.Name = "TelefonoDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefonoDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoToListPersonas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbNumeroDeTelefono;
    }
}