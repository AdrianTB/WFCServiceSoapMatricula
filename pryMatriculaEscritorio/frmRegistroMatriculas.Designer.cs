namespace pryMatriculaEscritorio
{
    partial class frmRegistroMatriculas
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
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDni = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNivel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTurno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApoderado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(142, 233);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(237, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "";
            this.txtApellido.Location = new System.Drawing.Point(142, 261);
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(237, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // txtDni
            // 
            this.txtDni.Depth = 0;
            this.txtDni.Hint = "";
            this.txtDni.Location = new System.Drawing.Point(142, 290);
            this.txtDni.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.SelectedText = "";
            this.txtDni.SelectionLength = 0;
            this.txtDni.SelectionStart = 0;
            this.txtDni.Size = new System.Drawing.Size(126, 23);
            this.txtDni.TabIndex = 3;
            this.txtDni.UseSystemPasswordChar = false;
            this.txtDni.Click += new System.EventHandler(this.txtDni_Click);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtNivel
            // 
            this.txtNivel.Depth = 0;
            this.txtNivel.Hint = "";
            this.txtNivel.Location = new System.Drawing.Point(142, 321);
            this.txtNivel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.PasswordChar = '\0';
            this.txtNivel.SelectedText = "";
            this.txtNivel.SelectionLength = 0;
            this.txtNivel.SelectionStart = 0;
            this.txtNivel.Size = new System.Drawing.Size(93, 23);
            this.txtNivel.TabIndex = 4;
            this.txtNivel.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(968, 252);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(133, 45);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "GESTION DE MATRICULAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nivel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Apoderado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Telef";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(144, 474);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(140, 23);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Turno";
            // 
            // txtTurno
            // 
            this.txtTurno.Depth = 0;
            this.txtTurno.Hint = "";
            this.txtTurno.Location = new System.Drawing.Point(143, 353);
            this.txtTurno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.PasswordChar = '\0';
            this.txtTurno.SelectedText = "";
            this.txtTurno.SelectionLength = 0;
            this.txtTurno.SelectionStart = 0;
            this.txtTurno.Size = new System.Drawing.Size(122, 23);
            this.txtTurno.TabIndex = 5;
            this.txtTurno.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Grado";
            // 
            // txtGrado
            // 
            this.txtGrado.Depth = 0;
            this.txtGrado.Hint = "";
            this.txtGrado.Location = new System.Drawing.Point(144, 384);
            this.txtGrado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.PasswordChar = '\0';
            this.txtGrado.SelectedText = "";
            this.txtGrado.SelectionLength = 0;
            this.txtGrado.SelectionStart = 0;
            this.txtGrado.Size = new System.Drawing.Size(43, 23);
            this.txtGrado.TabIndex = 6;
            this.txtGrado.UseSystemPasswordChar = false;
            this.txtGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrado_KeyPress);
            // 
            // txtApoderado
            // 
            this.txtApoderado.Depth = 0;
            this.txtApoderado.Hint = "";
            this.txtApoderado.Location = new System.Drawing.Point(144, 445);
            this.txtApoderado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApoderado.Name = "txtApoderado";
            this.txtApoderado.PasswordChar = '\0';
            this.txtApoderado.SelectedText = "";
            this.txtApoderado.SelectionLength = 0;
            this.txtApoderado.SelectionStart = 0;
            this.txtApoderado.Size = new System.Drawing.Size(235, 23);
            this.txtApoderado.TabIndex = 8;
            this.txtApoderado.UseSystemPasswordChar = false;
            this.txtApoderado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApoderado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sección";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Depth = 0;
            this.txtSeccion.Hint = "";
            this.txtSeccion.Location = new System.Drawing.Point(144, 414);
            this.txtSeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.PasswordChar = '\0';
            this.txtSeccion.SelectedText = "";
            this.txtSeccion.SelectionLength = 0;
            this.txtSeccion.SelectionStart = 0;
            this.txtSeccion.Size = new System.Drawing.Size(43, 23);
            this.txtSeccion.TabIndex = 7;
            this.txtSeccion.UseSystemPasswordChar = false;
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(399, 204);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.Size = new System.Drawing.Size(528, 293);
            this.dgvMatriculas.TabIndex = 35;
            this.dgvMatriculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculas_CellClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(968, 303);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(133, 45);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(968, 452);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(133, 45);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(968, 204);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(133, 38);
            this.btnNuevo.TabIndex = 38;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "ID Matricula";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtIdMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdMatricula.Font = new System.Drawing.Font("Arcon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMatricula.Location = new System.Drawing.Point(142, 200);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(69, 27);
            this.txtIdMatricula.TabIndex = 41;
            // 
            // frmRegistroMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1156, 568);
            this.Controls.Add(this.txtIdMatricula);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApoderado);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.Name = "frmRegistroMatriculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriculas";
            this.Load += new System.EventHandler(this.frmRegistroMatriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDni;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNivel;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTurno;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGrado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApoderado;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSeccion;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdMatricula;
    }
}