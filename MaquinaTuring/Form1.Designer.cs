
namespace MaquinaTuring
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
            this.dtgCinta = new System.Windows.Forms.DataGridView();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.lblAlfabetoActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.btnInsertarActual = new System.Windows.Forms.Button();
            this.btnAgregarRandom = new System.Windows.Forms.Button();
            this.btnAgregarCaracteres = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadCaracteres = new System.Windows.Forms.TextBox();
            this.btnAgregarAlfabeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.grbComandos = new System.Windows.Forms.GroupBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtComandos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCinta)).BeginInit();
            this.grbControles.SuspendLayout();
            this.grbComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCinta
            // 
            this.dtgCinta.AllowUserToAddRows = false;
            this.dtgCinta.AllowUserToDeleteRows = false;
            this.dtgCinta.AllowUserToResizeColumns = false;
            this.dtgCinta.AllowUserToResizeRows = false;
            this.dtgCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCinta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCinta.Location = new System.Drawing.Point(569, 12);
            this.dtgCinta.Name = "dtgCinta";
            this.dtgCinta.RowHeadersVisible = false;
            this.dtgCinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgCinta.Size = new System.Drawing.Size(219, 426);
            this.dtgCinta.TabIndex = 11;
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.lblAlfabetoActual);
            this.grbControles.Controls.Add(this.label3);
            this.grbControles.Controls.Add(this.txtCaracter);
            this.grbControles.Controls.Add(this.btnInsertarActual);
            this.grbControles.Controls.Add(this.btnAgregarRandom);
            this.grbControles.Controls.Add(this.btnAgregarCaracteres);
            this.grbControles.Controls.Add(this.label2);
            this.grbControles.Controls.Add(this.txtCantidadCaracteres);
            this.grbControles.Controls.Add(this.btnAgregarAlfabeto);
            this.grbControles.Controls.Add(this.label1);
            this.grbControles.Controls.Add(this.txtAlfabeto);
            this.grbControles.Location = new System.Drawing.Point(12, 12);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(551, 172);
            this.grbControles.TabIndex = 12;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles";
            // 
            // lblAlfabetoActual
            // 
            this.lblAlfabetoActual.AutoSize = true;
            this.lblAlfabetoActual.Location = new System.Drawing.Point(357, 153);
            this.lblAlfabetoActual.Name = "lblAlfabetoActual";
            this.lblAlfabetoActual.Size = new System.Drawing.Size(81, 13);
            this.lblAlfabetoActual.TabIndex = 23;
            this.lblAlfabetoActual.Text = "Alfabeto actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Caracter";
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(357, 40);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(117, 20);
            this.txtCaracter.TabIndex = 21;
            // 
            // btnInsertarActual
            // 
            this.btnInsertarActual.Location = new System.Drawing.Point(357, 66);
            this.btnInsertarActual.Name = "btnInsertarActual";
            this.btnInsertarActual.Size = new System.Drawing.Size(117, 23);
            this.btnInsertarActual.TabIndex = 20;
            this.btnInsertarActual.Text = "Insertar celda actual";
            this.btnInsertarActual.UseVisualStyleBackColor = true;
            this.btnInsertarActual.Click += new System.EventHandler(this.btnInsertarActual_Click);
            // 
            // btnAgregarRandom
            // 
            this.btnAgregarRandom.Location = new System.Drawing.Point(6, 143);
            this.btnAgregarRandom.Name = "btnAgregarRandom";
            this.btnAgregarRandom.Size = new System.Drawing.Size(135, 23);
            this.btnAgregarRandom.TabIndex = 16;
            this.btnAgregarRandom.Text = "Agregar Random 30-100";
            this.btnAgregarRandom.UseVisualStyleBackColor = true;
            this.btnAgregarRandom.Click += new System.EventHandler(this.btnAgregarRandom_Click);
            // 
            // btnAgregarCaracteres
            // 
            this.btnAgregarCaracteres.Location = new System.Drawing.Point(129, 99);
            this.btnAgregarCaracteres.Name = "btnAgregarCaracteres";
            this.btnAgregarCaracteres.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarCaracteres.TabIndex = 15;
            this.btnAgregarCaracteres.Text = "Agregar Caracteres";
            this.btnAgregarCaracteres.UseVisualStyleBackColor = true;
            this.btnAgregarCaracteres.Click += new System.EventHandler(this.btnAgregarCaracteres_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad de caracteres";
            // 
            // txtCantidadCaracteres
            // 
            this.txtCantidadCaracteres.Location = new System.Drawing.Point(6, 101);
            this.txtCantidadCaracteres.Name = "txtCantidadCaracteres";
            this.txtCantidadCaracteres.Size = new System.Drawing.Size(117, 20);
            this.txtCantidadCaracteres.TabIndex = 13;
            // 
            // btnAgregarAlfabeto
            // 
            this.btnAgregarAlfabeto.Location = new System.Drawing.Point(129, 38);
            this.btnAgregarAlfabeto.Name = "btnAgregarAlfabeto";
            this.btnAgregarAlfabeto.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarAlfabeto.TabIndex = 12;
            this.btnAgregarAlfabeto.Text = "Aceptar Alfabeto";
            this.btnAgregarAlfabeto.UseVisualStyleBackColor = true;
            this.btnAgregarAlfabeto.Click += new System.EventHandler(this.btnAgregarAlfabeto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alfabeto";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(6, 40);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(117, 20);
            this.txtAlfabeto.TabIndex = 10;
            // 
            // grbComandos
            // 
            this.grbComandos.Controls.Add(this.btnEjecutar);
            this.grbComandos.Controls.Add(this.txtComandos);
            this.grbComandos.Location = new System.Drawing.Point(13, 191);
            this.grbComandos.Name = "grbComandos";
            this.grbComandos.Size = new System.Drawing.Size(550, 247);
            this.grbComandos.TabIndex = 13;
            this.grbComandos.TabStop = false;
            this.grbComandos.Text = "Caja de comandos";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(7, 47);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtComandos
            // 
            this.txtComandos.Location = new System.Drawing.Point(8, 20);
            this.txtComandos.Name = "txtComandos";
            this.txtComandos.Size = new System.Drawing.Size(132, 20);
            this.txtComandos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbComandos);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.dtgCinta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCinta)).EndInit();
            this.grbControles.ResumeLayout(false);
            this.grbControles.PerformLayout();
            this.grbComandos.ResumeLayout(false);
            this.grbComandos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgCinta;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Button btnInsertarActual;
        private System.Windows.Forms.Button btnAgregarRandom;
        private System.Windows.Forms.Button btnAgregarCaracteres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadCaracteres;
        private System.Windows.Forms.Button btnAgregarAlfabeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.GroupBox grbComandos;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtComandos;
        private System.Windows.Forms.Label lblAlfabetoActual;
    }
}

