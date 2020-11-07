namespace TallerInterfazz
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
            this.DataGridPersona = new System.Windows.Forms.DataGridView();
            this.Columna_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_pulsaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridPersona
            // 
            this.DataGridPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_nombre,
            this.Columna_cedula,
            this.Columna_genero,
            this.Columna_edad,
            this.Columna_pulsaciones});
            this.DataGridPersona.Location = new System.Drawing.Point(21, 74);
            this.DataGridPersona.Name = "DataGridPersona";
            this.DataGridPersona.Size = new System.Drawing.Size(541, 242);
            this.DataGridPersona.TabIndex = 0;
            this.DataGridPersona.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPersona_CellClick);
            // 
            // Columna_nombre
            // 
            this.Columna_nombre.HeaderText = "Nombre";
            this.Columna_nombre.Name = "Columna_nombre";
            // 
            // Columna_cedula
            // 
            this.Columna_cedula.HeaderText = "Cedula";
            this.Columna_cedula.Name = "Columna_cedula";
            // 
            // Columna_genero
            // 
            this.Columna_genero.HeaderText = "Genero";
            this.Columna_genero.Name = "Columna_genero";
            // 
            // Columna_edad
            // 
            this.Columna_edad.HeaderText = "Edad";
            this.Columna_edad.Name = "Columna_edad";
            // 
            // Columna_pulsaciones
            // 
            this.Columna_pulsaciones.HeaderText = "Pulsaciones";
            this.Columna_pulsaciones.Name = "Columna_pulsaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(656, 113);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(183, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(656, 150);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(183, 20);
            this.TxtCedula.TabIndex = 6;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(656, 184);
            this.TxtGenero.MaxLength = 1;
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(183, 20);
            this.TxtGenero.TabIndex = 7;
            this.TxtGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGenero_KeyPress);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(656, 224);
            this.TxtEdad.MaxLength = 3;
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(183, 20);
            this.TxtEdad.TabIndex = 8;
            this.TxtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdad_KeyPress);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(617, 293);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(112, 23);
            this.BtnRegistrar.TabIndex = 9;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(752, 293);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_pulsaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}

