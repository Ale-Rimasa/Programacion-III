namespace Ejemplo1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lwElemento = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lwTitulo = new System.Windows.Forms.Label();
            this.rbtMago = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColorFav = new System.Windows.Forms.ComboBox();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.lblNumPreferido = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(53, 456);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lwElemento
            // 
            this.lwElemento.HideSelection = false;
            this.lwElemento.Location = new System.Drawing.Point(53, 350);
            this.lwElemento.Name = "lwElemento";
            this.lwElemento.Size = new System.Drawing.Size(204, 91);
            this.lwElemento.TabIndex = 2;
            this.lwElemento.UseCompatibleStateImageBehavior = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(58, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nome:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 100);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Data di nascita:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(99, 100);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(99, 127);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(129, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Ti piace il cioccolato?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lwTitulo
            // 
            this.lwTitulo.AutoSize = true;
            this.lwTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwTitulo.Location = new System.Drawing.Point(61, 20);
            this.lwTitulo.Name = "lwTitulo";
            this.lwTitulo.Size = new System.Drawing.Size(220, 31);
            this.lwTitulo.TabIndex = 7;
            this.lwTitulo.Text = "Profilo Personale";
            // 
            // rbtMago
            // 
            this.rbtMago.AutoSize = true;
            this.rbtMago.Checked = true;
            this.rbtMago.Location = new System.Drawing.Point(32, 19);
            this.rbtMago.Name = "rbtMago";
            this.rbtMago.Size = new System.Drawing.Size(52, 17);
            this.rbtMago.TabIndex = 1;
            this.rbtMago.TabStop = true;
            this.rbtMago.Text = "Mago";
            this.rbtMago.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(147, 19);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 2;
            this.rbtMuggle.TabStop = true;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(271, 19);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 2;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtMago);
            this.gbxTipo.Controls.Add(this.rbtSquibs);
            this.gbxTipo.Controls.Add(this.rbtMuggle);
            this.gbxTipo.Location = new System.Drawing.Point(53, 163);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(353, 58);
            this.gbxTipo.TabIndex = 3;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(21, 230);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(82, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Colore Preferito:";
            // 
            // cboColorFav
            // 
            this.cboColorFav.FormattingEnabled = true;
            this.cboColorFav.Location = new System.Drawing.Point(99, 227);
            this.cboColorFav.Name = "cboColorFav";
            this.cboColorFav.Size = new System.Drawing.Size(200, 21);
            this.cboColorFav.TabIndex = 13;
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Location = new System.Drawing.Point(99, 255);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(120, 20);
            this.numNumeroFavorito.TabIndex = 14;
            // 
            // lblNumPreferido
            // 
            this.lblNumPreferido.AutoSize = true;
            this.lblNumPreferido.Location = new System.Drawing.Point(7, 257);
            this.lblNumPreferido.Name = "lblNumPreferido";
            this.lblNumPreferido.Size = new System.Drawing.Size(89, 13);
            this.lblNumPreferido.TabIndex = 16;
            this.lblNumPreferido.Text = "Numero Preferito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerPerfil.Location = new System.Drawing.Point(53, 305);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(138, 25);
            this.btnVerPerfil.TabIndex = 18;
            this.btnVerPerfil.Text = "Visualizza il profilio:";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 491);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumPreferido);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.cboColorFav);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lwTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElemento);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(463, 530);
            this.MinimumSize = new System.Drawing.Size(463, 530);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListView lwElemento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lwTitulo;
        private System.Windows.Forms.RadioButton rbtMago;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColorFav;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Label lblNumPreferido;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

