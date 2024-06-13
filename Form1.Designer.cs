namespace POO
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
            this.btnPOO = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEstablecerValores = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdadAnimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarValores = new System.Windows.Forms.Button();
            this.btnAgregarAnimal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtAnimales = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPOO
            // 
            this.btnPOO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOO.ForeColor = System.Drawing.Color.Green;
            this.btnPOO.Location = new System.Drawing.Point(80, 113);
            this.btnPOO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPOO.Name = "btnPOO";
            this.btnPOO.Size = new System.Drawing.Size(211, 54);
            this.btnPOO.TabIndex = 0;
            this.btnPOO.Text = "POO";
            this.btnPOO.UseVisualStyleBackColor = true;
            this.btnPOO.Click += new System.EventHandler(this.btnPOO_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Green;
            this.txtNombre.Location = new System.Drawing.Point(106, 173);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.ForeColor = System.Drawing.Color.Green;
            this.txtCedula.Location = new System.Drawing.Point(106, 203);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(185, 21);
            this.txtCedula.TabIndex = 2;
            // 
            // txtEdad
            // 
            this.txtEdad.ForeColor = System.Drawing.Color.Green;
            this.txtEdad.Location = new System.Drawing.Point(106, 233);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(185, 21);
            this.txtEdad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(22, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(25, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(25, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.Green;
            this.btnAsignar.Location = new System.Drawing.Point(106, 286);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(185, 44);
            this.btnAsignar.TabIndex = 7;
            this.btnAsignar.Text = "Establecer valores";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnPOO);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 406);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMostrarValores);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEstablecerValores);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtRaza);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEdadAnimal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(367, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 406);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(40, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "POO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEstablecerValores
            // 
            this.btnEstablecerValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecerValores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEstablecerValores.Location = new System.Drawing.Point(66, 288);
            this.btnEstablecerValores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEstablecerValores.Name = "btnEstablecerValores";
            this.btnEstablecerValores.Size = new System.Drawing.Size(198, 40);
            this.btnEstablecerValores.TabIndex = 7;
            this.btnEstablecerValores.Text = "Establecer valores";
            this.btnEstablecerValores.UseVisualStyleBackColor = true;
            this.btnEstablecerValores.Click += new System.EventHandler(this.btnEstablecerValores_Click);
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.Color.Silver;
            this.txtId.Location = new System.Drawing.Point(66, 173);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(198, 21);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "ID";
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // txtRaza
            // 
            this.txtRaza.ForeColor = System.Drawing.Color.Silver;
            this.txtRaza.Location = new System.Drawing.Point(66, 203);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(198, 21);
            this.txtRaza.TabIndex = 2;
            this.txtRaza.Text = "Raza";
            this.txtRaza.Click += new System.EventHandler(this.txtRaza_Click);
            this.txtRaza.TextChanged += new System.EventHandler(this.txtRaza_TextChanged);
            this.txtRaza.Leave += new System.EventHandler(this.txtRaza_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Raza";
            // 
            // txtEdadAnimal
            // 
            this.txtEdadAnimal.ForeColor = System.Drawing.Color.Silver;
            this.txtEdadAnimal.Location = new System.Drawing.Point(66, 233);
            this.txtEdadAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEdadAnimal.Name = "txtEdadAnimal";
            this.txtEdadAnimal.Size = new System.Drawing.Size(198, 21);
            this.txtEdadAnimal.TabIndex = 3;
            this.txtEdadAnimal.Text = "Edad";
            this.txtEdadAnimal.Click += new System.EventHandler(this.txtEdadAnimal_Click);
            this.txtEdadAnimal.TextChanged += new System.EventHandler(this.txtEdadAnimal_TextChanged);
            this.txtEdadAnimal.Leave += new System.EventHandler(this.txtEdadAnimal_Leave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(8, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(91, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Clase persona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(82, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Clase animal";
            // 
            // btnMostrarValores
            // 
            this.btnMostrarValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarValores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMostrarValores.Location = new System.Drawing.Point(66, 334);
            this.btnMostrarValores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarValores.Name = "btnMostrarValores";
            this.btnMostrarValores.Size = new System.Drawing.Size(198, 40);
            this.btnMostrarValores.TabIndex = 10;
            this.btnMostrarValores.Text = "Imprimir valores";
            this.btnMostrarValores.UseVisualStyleBackColor = true;
            this.btnMostrarValores.Click += new System.EventHandler(this.btnMostrarValores_Click);
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.Location = new System.Drawing.Point(389, 436);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(272, 33);
            this.btnAgregarAnimal.TabIndex = 10;
            this.btnAgregarAnimal.Text = "Agregar animal";
            this.btnAgregarAnimal.UseVisualStyleBackColor = true;
            this.btnAgregarAnimal.Click += new System.EventHandler(this.btnAgregarAnimal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Eliminar animal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtAnimales
            // 
            this.dtAnimales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Raza,
            this.Edad});
            this.dtAnimales.Location = new System.Drawing.Point(696, 24);
            this.dtAnimales.Name = "dtAnimales";
            this.dtAnimales.Size = new System.Drawing.Size(417, 399);
            this.dtAnimales.TabIndex = 12;
            this.dtAnimales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAnimales_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(815, 449);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1119, 519);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtAnimales);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarAnimal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPOO;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEstablecerValores;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdadAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMostrarValores;
        private System.Windows.Forms.Button btnAgregarAnimal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtAnimales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Button btnEliminar;
    }
}

