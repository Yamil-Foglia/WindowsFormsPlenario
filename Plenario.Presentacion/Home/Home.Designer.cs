
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGoToFormPeronsaAdd = new System.Windows.Forms.Button();
            this.btnGoToListPersona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoToFormPeronsaAdd
            // 
            this.btnGoToFormPeronsaAdd.Location = new System.Drawing.Point(14, 99);
            this.btnGoToFormPeronsaAdd.Name = "btnGoToFormPeronsaAdd";
            this.btnGoToFormPeronsaAdd.Size = new System.Drawing.Size(437, 36);
            this.btnGoToFormPeronsaAdd.TabIndex = 34;
            this.btnGoToFormPeronsaAdd.Text = "Agregar Persona";
            this.btnGoToFormPeronsaAdd.UseVisualStyleBackColor = true;
            this.btnGoToFormPeronsaAdd.Click += new System.EventHandler(this.btnGoToFormPeronsaAdd_Click);
            // 
            // btnGoToListPersona
            // 
            this.btnGoToListPersona.Location = new System.Drawing.Point(15, 141);
            this.btnGoToListPersona.Name = "btnGoToListPersona";
            this.btnGoToListPersona.Size = new System.Drawing.Size(437, 36);
            this.btnGoToListPersona.TabIndex = 33;
            this.btnGoToListPersona.Text = "Lista de Personas";
            this.btnGoToListPersona.UseVisualStyleBackColor = true;
            this.btnGoToListPersona.Click += new System.EventHandler(this.btnGoToListPersona_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 50);
            this.label4.TabIndex = 32;
            this.label4.Text = "Plenario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 193);
            this.Controls.Add(this.btnGoToFormPeronsaAdd);
            this.Controls.Add(this.btnGoToListPersona);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plenario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToFormPeronsaAdd;
        private System.Windows.Forms.Button btnGoToListPersona;
        private System.Windows.Forms.Label label4;
    }
}

