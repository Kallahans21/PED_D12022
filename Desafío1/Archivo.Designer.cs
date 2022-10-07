
namespace Desafío1
{
    partial class Archivo
    {

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archivo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.npresion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sangre = new System.Windows.Forms.ComboBox();
            this.tSangre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nPaciente = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Dibujarbtn = new System.Windows.Forms.Button();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.Añadirbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.npresion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Sangre);
            this.groupBox1.Controls.Add(this.tSangre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pGenero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nPaciente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(31, 445);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(616, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información general";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // npresion
            // 
            this.npresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.npresion.FormattingEnabled = true;
            this.npresion.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.npresion.Location = new System.Drawing.Point(54, 158);
            this.npresion.Margin = new System.Windows.Forms.Padding(4);
            this.npresion.Name = "npresion";
            this.npresion.Size = new System.Drawing.Size(160, 32);
            this.npresion.TabIndex = 7;
            this.npresion.SelectedIndexChanged += new System.EventHandler(this.npresion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Presión arterial";
            // 
            // Sangre
            // 
            this.Sangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sangre.FormattingEnabled = true;
            this.Sangre.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.Sangre.Location = new System.Drawing.Point(410, 158);
            this.Sangre.Margin = new System.Windows.Forms.Padding(4);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(160, 32);
            this.Sangre.TabIndex = 5;
            this.Sangre.SelectedIndexChanged += new System.EventHandler(this.Sangre_SelectedIndexChanged);
            // 
            // tSangre
            // 
            this.tSangre.AutoSize = true;
            this.tSangre.Location = new System.Drawing.Point(406, 118);
            this.tSangre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSangre.Name = "tSangre";
            this.tSangre.Size = new System.Drawing.Size(162, 24);
            this.tSangre.TabIndex = 4;
            this.tSangre.Text = "Grupo sanguíneo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Género";
            // 
            // pGenero
            // 
            this.pGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pGenero.FormattingEnabled = true;
            this.pGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.pGenero.Location = new System.Drawing.Point(408, 75);
            this.pGenero.Margin = new System.Windows.Forms.Padding(4);
            this.pGenero.Name = "pGenero";
            this.pGenero.Size = new System.Drawing.Size(160, 32);
            this.pGenero.TabIndex = 2;
            this.pGenero.SelectedIndexChanged += new System.EventHandler(this.pGenero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo";
            // 
            // nPaciente
            // 
            this.nPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPaciente.Location = new System.Drawing.Point(54, 75);
            this.nPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.nPaciente.Name = "nPaciente";
            this.nPaciente.Size = new System.Drawing.Size(257, 30);
            this.nPaciente.TabIndex = 0;
            this.nPaciente.TextChanged += new System.EventHandler(this.nPaciente_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(800, 587);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 61);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Dibujarbtn
            // 
            this.Dibujarbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Dibujarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dibujarbtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dibujarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dibujarbtn.Location = new System.Drawing.Point(761, 520);
            this.Dibujarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Dibujarbtn.Name = "Dibujarbtn";
            this.Dibujarbtn.Size = new System.Drawing.Size(200, 49);
            this.Dibujarbtn.TabIndex = 7;
            this.Dibujarbtn.Text = "Dibujar árbol";
            this.Dibujarbtn.UseVisualStyleBackColor = false;
            this.Dibujarbtn.Click += new System.EventHandler(this.Dibujarbtn_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminarbtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eliminarbtn.Location = new System.Drawing.Point(877, 456);
            this.Eliminarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(200, 49);
            this.Eliminarbtn.TabIndex = 6;
            this.Eliminarbtn.Text = "Borrar árbol";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // Añadirbtn
            // 
            this.Añadirbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Añadirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Añadirbtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadirbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Añadirbtn.Location = new System.Drawing.Point(655, 456);
            this.Añadirbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Añadirbtn.Name = "Añadirbtn";
            this.Añadirbtn.Size = new System.Drawing.Size(202, 49);
            this.Añadirbtn.TabIndex = 5;
            this.Añadirbtn.Text = "Añadir paciente";
            this.Añadirbtn.UseVisualStyleBackColor = false;
            this.Añadirbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 687);
            this.Controls.Add(this.Dibujarbtn);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.Añadirbtn);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Archivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Pacientes";
            this.Load += new System.EventHandler(this.archivo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.archivo_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Sangre;
        private System.Windows.Forms.Label tSangre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nPaciente;
        private System.Windows.Forms.ComboBox npresion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button Dibujarbtn;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button Añadirbtn;
    }
}

