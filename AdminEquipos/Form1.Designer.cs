namespace AdminEquipos
{
    partial class AdminEq
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsensor = new System.Windows.Forms.TextBox();
            this.txtequipo = new System.Windows.Forms.TextBox();
            this.txtlocacion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.lstvS = new System.Windows.Forms.ListView();
            this.Locacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensor Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipo Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Locacion Id";
            // 
            // txtsensor
            // 
            this.txtsensor.Location = new System.Drawing.Point(76, 28);
            this.txtsensor.Name = "txtsensor";
            this.txtsensor.Size = new System.Drawing.Size(100, 20);
            this.txtsensor.TabIndex = 4;
            // 
            // txtequipo
            // 
            this.txtequipo.Location = new System.Drawing.Point(76, 54);
            this.txtequipo.Name = "txtequipo";
            this.txtequipo.Size = new System.Drawing.Size(100, 20);
            this.txtequipo.TabIndex = 5;
            // 
            // txtlocacion
            // 
            this.txtlocacion.Location = new System.Drawing.Point(76, 80);
            this.txtlocacion.Name = "txtlocacion";
            this.txtlocacion.Size = new System.Drawing.Size(100, 20);
            this.txtlocacion.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(224, 361);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "cmdAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsensor);
            this.groupBox1.Controls.Add(this.txtequipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlocacion);
            this.groupBox1.Location = new System.Drawing.Point(26, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar de alta un nuevo equipo/locacion";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(408, 361);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(338, 23);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.Text = "Dar de baja el registro seleccionado";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // lstvS
            // 
            this.lstvS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Locacion});
            this.lstvS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstvS.Location = new System.Drawing.Point(26, 12);
            this.lstvS.Name = "lstvS";
            this.lstvS.Size = new System.Drawing.Size(741, 286);
            this.lstvS.TabIndex = 10;
            this.lstvS.UseCompatibleStateImageBehavior = false;
            // 
            // AdminEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvS);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminEq";
            this.Text = "Administracion de Equipos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsensor;
        private System.Windows.Forms.TextBox txtequipo;
        private System.Windows.Forms.TextBox txtlocacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.ListView lstvS;
        private System.Windows.Forms.ColumnHeader Locacion;
    }
}

