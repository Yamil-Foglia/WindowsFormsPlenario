
namespace Plenario.Presentacion.Telefono
{
    partial class TelefonoAdd
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTelefonoAdd = new System.Windows.Forms.Button();
            this.tbNumeroDeTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(437, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "Volver a la lista de teléfonos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 50);
            this.label4.TabIndex = 35;
            this.label4.Text = "Agregar Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Numero de teléfono";
            // 
            // btnTelefonoAdd
            // 
            this.btnTelefonoAdd.Location = new System.Drawing.Point(87, 200);
            this.btnTelefonoAdd.Name = "btnTelefonoAdd";
            this.btnTelefonoAdd.Size = new System.Drawing.Size(292, 57);
            this.btnTelefonoAdd.TabIndex = 33;
            this.btnTelefonoAdd.Text = "Agregar";
            this.btnTelefonoAdd.UseVisualStyleBackColor = true;
            this.btnTelefonoAdd.Click += new System.EventHandler(this.btnTelefonoAdd_Click);
            // 
            // tbNumeroDeTelefono
            // 
            this.tbNumeroDeTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroDeTelefono.Location = new System.Drawing.Point(12, 135);
            this.tbNumeroDeTelefono.Name = "tbNumeroDeTelefono";
            this.tbNumeroDeTelefono.Size = new System.Drawing.Size(437, 33);
            this.tbNumeroDeTelefono.TabIndex = 32;
            // 
            // TelefonoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTelefonoAdd);
            this.Controls.Add(this.tbNumeroDeTelefono);
            this.Name = "TelefonoAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefonoAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTelefonoAdd;
        private System.Windows.Forms.TextBox tbNumeroDeTelefono;
    }
}