
namespace Plenario.Presentacion.Persona
{
    partial class PersonaList
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
            this.components = new System.ComponentModel.Container();
            this.tbNombreFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListSinFiltros = new System.Windows.Forms.Button();
            this.btnPersonaAdd = new System.Windows.Forms.Button();
            this.btnGoToHome = new System.Windows.Forms.Button();
            this.dgListPersona = new System.Windows.Forms.DataGridView();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCreditoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTelefonos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgListPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombreFiltro
            // 
            this.tbNombreFiltro.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreFiltro.Location = new System.Drawing.Point(168, 6);
            this.tbNombreFiltro.Name = "tbNombreFiltro";
            this.tbNombreFiltro.Size = new System.Drawing.Size(336, 29);
            this.tbNombreFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por nombre :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(510, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 29);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListSinFiltros
            // 
            this.btnListSinFiltros.BackColor = System.Drawing.SystemColors.Control;
            this.btnListSinFiltros.Location = new System.Drawing.Point(653, 7);
            this.btnListSinFiltros.Name = "btnListSinFiltros";
            this.btnListSinFiltros.Size = new System.Drawing.Size(208, 29);
            this.btnListSinFiltros.TabIndex = 5;
            this.btnListSinFiltros.Text = "Mostrar lista sin filtros";
            this.btnListSinFiltros.UseVisualStyleBackColor = false;
            this.btnListSinFiltros.Click += new System.EventHandler(this.btnListSinFiltros_Click);
            // 
            // btnPersonaAdd
            // 
            this.btnPersonaAdd.Location = new System.Drawing.Point(16, 305);
            this.btnPersonaAdd.Name = "btnPersonaAdd";
            this.btnPersonaAdd.Size = new System.Drawing.Size(577, 29);
            this.btnPersonaAdd.TabIndex = 6;
            this.btnPersonaAdd.Text = "Agregar una persona";
            this.btnPersonaAdd.UseVisualStyleBackColor = true;
            this.btnPersonaAdd.Click += new System.EventHandler(this.btnPersonaAdd_Click);
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.Location = new System.Drawing.Point(599, 305);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(262, 29);
            this.btnGoToHome.TabIndex = 7;
            this.btnGoToHome.Text = "Volver al inico";
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // dgListPersona
            // 
            this.dgListPersona.AllowUserToDeleteRows = false;
            this.dgListPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNombre,
            this.columnFechaDeNacimiento,
            this.columnCreditoMaximo,
            this.btnTelefonos,
            this.btnDelete,
            this.btnModify});
            this.dgListPersona.Location = new System.Drawing.Point(16, 41);
            this.dgListPersona.Name = "dgListPersona";
            this.dgListPersona.Size = new System.Drawing.Size(845, 258);
            this.dgListPersona.TabIndex = 8;
            this.dgListPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListPersona_CellContentClick);
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.Width = 150;
            // 
            // columnFechaDeNacimiento
            // 
            this.columnFechaDeNacimiento.HeaderText = "Fecha de nacimiento";
            this.columnFechaDeNacimiento.Name = "columnFechaDeNacimiento";
            this.columnFechaDeNacimiento.Width = 150;
            // 
            // columnCreditoMaximo
            // 
            this.columnCreditoMaximo.HeaderText = "CéditoMáximo";
            this.columnCreditoMaximo.Name = "columnCreditoMaximo";
            this.columnCreditoMaximo.Width = 150;
            // 
            // btnTelefonos
            // 
            this.btnTelefonos.HeaderText = "Administrar Teléfonos";
            this.btnTelefonos.Name = "btnTelefonos";
            this.btnTelefonos.Text = "Administrar Teléfonos";
            this.btnTelefonos.UseColumnTextForButtonValue = true;
            this.btnTelefonos.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Eliminar";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnModify
            // 
            this.btnModify.HeaderText = "Modificar";
            this.btnModify.Name = "btnModify";
            this.btnModify.Text = "Modificar";
            this.btnModify.UseColumnTextForButtonValue = true;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Plenario.Entidad.Persona);
            // 
            // personaBindingSource1
            // 
            this.personaBindingSource1.DataSource = typeof(Plenario.Entidad.Persona);
            // 
            // PersonaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 343);
            this.Controls.Add(this.dgListPersona);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.btnPersonaAdd);
            this.Controls.Add(this.btnListSinFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreFiltro);
            this.Name = "PersonaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonaList";
            ((System.ComponentModel.ISupportInitialize)(this.dgListPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNombreFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListSinFiltros;
        private System.Windows.Forms.Button btnPersonaAdd;
        private System.Windows.Forms.Button btnGoToHome;
        private System.Windows.Forms.DataGridView dgListPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCreditoMaximo;
        private System.Windows.Forms.DataGridViewButtonColumn btnTelefonos;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnModify;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.BindingSource personaBindingSource1;
    }
}