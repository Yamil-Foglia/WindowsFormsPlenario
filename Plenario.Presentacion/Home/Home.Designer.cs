﻿
namespace Plenario.Presentacion.Home
{
    partial class Home
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnListPersona
            // 
            this.btnReturnListPersona.Location = new System.Drawing.Point(21, 163);
            this.btnReturnListPersona.Name = "btnReturnListPersona";
            this.btnReturnListPersona.Size = new System.Drawing.Size(437, 36);
            this.btnReturnListPersona.TabIndex = 30;
            this.btnReturnListPersona.Text = "Lista de Personas";
            this.btnReturnListPersona.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 50);
            this.label4.TabIndex = 26;
            this.label4.Text = "Plenario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "Agregar Persona";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturnListPersona);
            this.Controls.Add(this.label4);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnListPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}