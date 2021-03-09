
namespace Plenario.Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoToFormPersonaAdd = new System.Windows.Forms.Button();
            this.btnReturnListPersona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoToFormPersonaAdd
            // 
            this.btnGoToFormPersonaAdd.Location = new System.Drawing.Point(15, 99);
            this.btnGoToFormPersonaAdd.Name = "btnGoToFormPersonaAdd";
            this.btnGoToFormPersonaAdd.Size = new System.Drawing.Size(437, 36);
            this.btnGoToFormPersonaAdd.TabIndex = 34;
            this.btnGoToFormPersonaAdd.Text = "Agregar Persona";
            this.btnGoToFormPersonaAdd.UseVisualStyleBackColor = true;
            this.btnGoToFormPersonaAdd.Click += new System.EventHandler(this.btnGoToFormPersonaAdd_Click);
            // 
            // btnReturnListPersona
            // 
            this.btnReturnListPersona.Location = new System.Drawing.Point(15, 153);
            this.btnReturnListPersona.Name = "btnReturnListPersona";
            this.btnReturnListPersona.Size = new System.Drawing.Size(437, 36);
            this.btnReturnListPersona.TabIndex = 33;
            this.btnReturnListPersona.Text = "Lista de Personas";
            this.btnReturnListPersona.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 50);
            this.label4.TabIndex = 32;
            this.label4.Text = "Plenario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 202);
            this.Controls.Add(this.btnGoToFormPersonaAdd);
            this.Controls.Add(this.btnReturnListPersona);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToFormPersonaAdd;
        private System.Windows.Forms.Button btnReturnListPersona;
        private System.Windows.Forms.Label label4;
    }
}

