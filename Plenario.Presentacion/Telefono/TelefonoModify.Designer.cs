
namespace Plenario.Presentacion.Telefono
{
    partial class TelefonoModify
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
            this.btnGoToListTelefono = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.tbNumeroDeTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGoToListTelefono
            // 
            this.btnGoToListTelefono.Location = new System.Drawing.Point(12, 279);
            this.btnGoToListTelefono.Name = "btnGoToListTelefono";
            this.btnGoToListTelefono.Size = new System.Drawing.Size(437, 36);
            this.btnGoToListTelefono.TabIndex = 31;
            this.btnGoToListTelefono.Text = "Volver a la lista de teléfonos";
            this.btnGoToListTelefono.UseVisualStyleBackColor = true;
            this.btnGoToListTelefono.Click += new System.EventHandler(this.btnGoToListTelefono_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 50);
            this.label4.TabIndex = 30;
            this.label4.Text = "Modifcar Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Numero de teléfono";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(87, 200);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(292, 57);
            this.btnModify.TabIndex = 28;
            this.btnModify.Text = "Guardar cambios";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tbNumeroDeTelefono
            // 
            this.tbNumeroDeTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroDeTelefono.Location = new System.Drawing.Point(12, 135);
            this.tbNumeroDeTelefono.Name = "tbNumeroDeTelefono";
            this.tbNumeroDeTelefono.Size = new System.Drawing.Size(437, 33);
            this.tbNumeroDeTelefono.TabIndex = 27;
            // 
            // TelefonoModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 324);
            this.Controls.Add(this.btnGoToListTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbNumeroDeTelefono);
            this.Name = "TelefonoModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefonoModify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToListTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox tbNumeroDeTelefono;
    }
}