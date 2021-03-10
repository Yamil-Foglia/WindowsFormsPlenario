
namespace Plenario.Presentacion.Telefono
{
    partial class TelefonoList
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
            this.dgListTelefono = new System.Windows.Forms.DataGridView();
            this.columnNumerDeTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTelefonoAdd = new System.Windows.Forms.Button();
            this.btnGoToListPersonas = new System.Windows.Forms.Button();
            this.btnGoToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListTelefono
            // 
            this.dgListTelefono.AllowUserToDeleteRows = false;
            this.dgListTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumerDeTelefono,
            this.btnModify,
            this.btnDelete});
            this.dgListTelefono.Location = new System.Drawing.Point(12, 12);
            this.dgListTelefono.Name = "dgListTelefono";
            this.dgListTelefono.Size = new System.Drawing.Size(443, 150);
            this.dgListTelefono.TabIndex = 0;
            this.dgListTelefono.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListTelefono_CellContentClick);
            // 
            // columnNumerDeTelefono
            // 
            this.columnNumerDeTelefono.HeaderText = "Numero de Telefono";
            this.columnNumerDeTelefono.Name = "columnNumerDeTelefono";
            this.columnNumerDeTelefono.Width = 200;
            // 
            // btnModify
            // 
            this.btnModify.HeaderText = "Modificar";
            this.btnModify.Name = "btnModify";
            this.btnModify.Text = "Modificar";
            this.btnModify.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Eliminar";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnTelefonoAdd
            // 
            this.btnTelefonoAdd.Location = new System.Drawing.Point(12, 168);
            this.btnTelefonoAdd.Name = "btnTelefonoAdd";
            this.btnTelefonoAdd.Size = new System.Drawing.Size(443, 29);
            this.btnTelefonoAdd.TabIndex = 1;
            this.btnTelefonoAdd.Text = "Agregar teléfono";
            this.btnTelefonoAdd.UseVisualStyleBackColor = true;
            this.btnTelefonoAdd.Click += new System.EventHandler(this.btnTelefonoAdd_Click);
            // 
            // btnGoToListPersonas
            // 
            this.btnGoToListPersonas.Location = new System.Drawing.Point(12, 205);
            this.btnGoToListPersonas.Name = "btnGoToListPersonas";
            this.btnGoToListPersonas.Size = new System.Drawing.Size(303, 29);
            this.btnGoToListPersonas.TabIndex = 2;
            this.btnGoToListPersonas.Text = "Volver a la lista de personas";
            this.btnGoToListPersonas.UseVisualStyleBackColor = true;
            this.btnGoToListPersonas.Click += new System.EventHandler(this.btnGoToListPersonas_Click);
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.Location = new System.Drawing.Point(321, 205);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(137, 29);
            this.btnGoToHome.TabIndex = 3;
            this.btnGoToHome.Text = "Volver al Inicio";
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // TelefonoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 246);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.btnGoToListPersonas);
            this.Controls.Add(this.btnTelefonoAdd);
            this.Controls.Add(this.dgListTelefono);
            this.Name = "TelefonoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefonoList";
            ((System.ComponentModel.ISupportInitialize)(this.dgListTelefono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumerDeTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn btnModify;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.Button btnTelefonoAdd;
        private System.Windows.Forms.Button btnGoToListPersonas;
        private System.Windows.Forms.Button btnGoToHome;
    }
}