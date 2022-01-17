namespace DesligarMeuPC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMinuto = new System.Windows.Forms.Label();
            this.lbSegundo = new System.Windows.Forms.Label();
            this.lbrefreshhora = new System.Windows.Forms.Label();
            this.lbfechar = new System.Windows.Forms.Label();
            this.arrowupSegundo = new System.Windows.Forms.PictureBox();
            this.arrowupMinuto = new System.Windows.Forms.PictureBox();
            this.arrowdownMinuto = new System.Windows.Forms.PictureBox();
            this.arrowdownSegundo = new System.Windows.Forms.PictureBox();
            this.arrowdownHora = new System.Windows.Forms.PictureBox();
            this.arrowupHora = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbrefreshminuto = new System.Windows.Forms.Label();
            this.lbrefreshsegundo = new System.Windows.Forms.Label();
            this.btnCancelar = new DesligarMeuPC.MyButton();
            this.btnIniciar = new DesligarMeuPC.MyButton();
            this.myButton3 = new DesligarMeuPC.MyButton();
            this.myButton2 = new DesligarMeuPC.MyButton();
            this.myButton1 = new DesligarMeuPC.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdownMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdownSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdownHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desligar meu computador";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.White;
            this.lbHora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(390, 87);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(21, 22);
            this.lbHora.TabIndex = 5;
            this.lbHora.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segundos";
            // 
            // lbMinuto
            // 
            this.lbMinuto.AutoSize = true;
            this.lbMinuto.BackColor = System.Drawing.Color.White;
            this.lbMinuto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinuto.Location = new System.Drawing.Point(390, 172);
            this.lbMinuto.Name = "lbMinuto";
            this.lbMinuto.Size = new System.Drawing.Size(21, 22);
            this.lbMinuto.TabIndex = 11;
            this.lbMinuto.Text = "0";
            // 
            // lbSegundo
            // 
            this.lbSegundo.AutoSize = true;
            this.lbSegundo.BackColor = System.Drawing.Color.White;
            this.lbSegundo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundo.Location = new System.Drawing.Point(390, 262);
            this.lbSegundo.Name = "lbSegundo";
            this.lbSegundo.Size = new System.Drawing.Size(21, 22);
            this.lbSegundo.TabIndex = 12;
            this.lbSegundo.Text = "0";
            // 
            // lbrefreshhora
            // 
            this.lbrefreshhora.AutoSize = true;
            this.lbrefreshhora.CausesValidation = false;
            this.lbrefreshhora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbrefreshhora.Image = global::DesligarMeuPC.Properties.Resources.refresh;
            this.lbrefreshhora.Location = new System.Drawing.Point(437, 50);
            this.lbrefreshhora.MinimumSize = new System.Drawing.Size(50, 20);
            this.lbrefreshhora.Name = "lbrefreshhora";
            this.lbrefreshhora.Size = new System.Drawing.Size(50, 20);
            this.lbrefreshhora.TabIndex = 20;
            this.lbrefreshhora.Click += new System.EventHandler(this.lbrefreshhora_Click);
            // 
            // lbfechar
            // 
            this.lbfechar.AutoSize = true;
            this.lbfechar.BackColor = System.Drawing.Color.White;
            this.lbfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbfechar.Image = global::DesligarMeuPC.Properties.Resources.close;
            this.lbfechar.Location = new System.Drawing.Point(507, 6);
            this.lbfechar.MaximumSize = new System.Drawing.Size(20, 0);
            this.lbfechar.MinimumSize = new System.Drawing.Size(50, 30);
            this.lbfechar.Name = "lbfechar";
            this.lbfechar.Size = new System.Drawing.Size(50, 30);
            this.lbfechar.TabIndex = 19;
            this.lbfechar.Click += new System.EventHandler(this.lbfechar_Click);
            // 
            // arrowupSegundo
            // 
            this.arrowupSegundo.BackColor = System.Drawing.Color.White;
            this.arrowupSegundo.BackgroundImage = global::DesligarMeuPC.Properties.Resources.arrowup;
            this.arrowupSegundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowupSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowupSegundo.Location = new System.Drawing.Point(331, 255);
            this.arrowupSegundo.Name = "arrowupSegundo";
            this.arrowupSegundo.Size = new System.Drawing.Size(50, 35);
            this.arrowupSegundo.TabIndex = 16;
            this.arrowupSegundo.TabStop = false;
            this.arrowupSegundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrowupSegundo_MouseClick);
            // 
            // arrowupMinuto
            // 
            this.arrowupMinuto.BackColor = System.Drawing.Color.White;
            this.arrowupMinuto.BackgroundImage = global::DesligarMeuPC.Properties.Resources.arrowup;
            this.arrowupMinuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowupMinuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowupMinuto.Location = new System.Drawing.Point(331, 165);
            this.arrowupMinuto.Name = "arrowupMinuto";
            this.arrowupMinuto.Size = new System.Drawing.Size(50, 35);
            this.arrowupMinuto.TabIndex = 15;
            this.arrowupMinuto.TabStop = false;
            this.arrowupMinuto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrowupMinuto_MouseClick);
            // 
            // arrowdownMinuto
            // 
            this.arrowdownMinuto.BackColor = System.Drawing.Color.White;
            this.arrowdownMinuto.BackgroundImage = global::DesligarMeuPC.Properties.Resources.arrowdown1;
            this.arrowdownMinuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowdownMinuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowdownMinuto.Location = new System.Drawing.Point(421, 165);
            this.arrowdownMinuto.Name = "arrowdownMinuto";
            this.arrowdownMinuto.Size = new System.Drawing.Size(50, 35);
            this.arrowdownMinuto.TabIndex = 14;
            this.arrowdownMinuto.TabStop = false;
            this.arrowdownMinuto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrowdownMinuto_MouseClick);
            // 
            // arrowdownSegundo
            // 
            this.arrowdownSegundo.BackColor = System.Drawing.Color.White;
            this.arrowdownSegundo.BackgroundImage = global::DesligarMeuPC.Properties.Resources.arrowdown;
            this.arrowdownSegundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowdownSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowdownSegundo.Location = new System.Drawing.Point(421, 255);
            this.arrowdownSegundo.Name = "arrowdownSegundo";
            this.arrowdownSegundo.Size = new System.Drawing.Size(50, 35);
            this.arrowdownSegundo.TabIndex = 13;
            this.arrowdownSegundo.TabStop = false;
            this.arrowdownSegundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrowdownSegundo_MouseClick);
            // 
            // arrowdownHora
            // 
            this.arrowdownHora.BackColor = System.Drawing.Color.White;
            this.arrowdownHora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowdownHora.BackgroundImage")));
            this.arrowdownHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowdownHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowdownHora.Location = new System.Drawing.Point(421, 79);
            this.arrowdownHora.Name = "arrowdownHora";
            this.arrowdownHora.Size = new System.Drawing.Size(50, 35);
            this.arrowdownHora.TabIndex = 4;
            this.arrowdownHora.TabStop = false;
            this.arrowdownHora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrowdownHora_MouseClick);
            // 
            // arrowupHora
            // 
            this.arrowupHora.BackColor = System.Drawing.Color.White;
            this.arrowupHora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowupHora.BackgroundImage")));
            this.arrowupHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowupHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowupHora.Location = new System.Drawing.Point(331, 79);
            this.arrowupHora.Name = "arrowupHora";
            this.arrowupHora.Size = new System.Drawing.Size(50, 35);
            this.arrowupHora.TabIndex = 3;
            this.arrowupHora.TabStop = false;
            this.arrowupHora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrowupHora_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbrefreshminuto
            // 
            this.lbrefreshminuto.AutoSize = true;
            this.lbrefreshminuto.CausesValidation = false;
            this.lbrefreshminuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbrefreshminuto.Image = global::DesligarMeuPC.Properties.Resources.refresh;
            this.lbrefreshminuto.Location = new System.Drawing.Point(437, 132);
            this.lbrefreshminuto.MinimumSize = new System.Drawing.Size(50, 20);
            this.lbrefreshminuto.Name = "lbrefreshminuto";
            this.lbrefreshminuto.Size = new System.Drawing.Size(50, 20);
            this.lbrefreshminuto.TabIndex = 21;
            this.lbrefreshminuto.Click += new System.EventHandler(this.lbrefreshminuto_Click);
            // 
            // lbrefreshsegundo
            // 
            this.lbrefreshsegundo.AutoSize = true;
            this.lbrefreshsegundo.CausesValidation = false;
            this.lbrefreshsegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbrefreshsegundo.Image = global::DesligarMeuPC.Properties.Resources.refresh;
            this.lbrefreshsegundo.Location = new System.Drawing.Point(437, 222);
            this.lbrefreshsegundo.MinimumSize = new System.Drawing.Size(50, 20);
            this.lbrefreshsegundo.Name = "lbrefreshsegundo";
            this.lbrefreshsegundo.Size = new System.Drawing.Size(50, 20);
            this.lbrefreshsegundo.TabIndex = 22;
            this.lbrefreshsegundo.Click += new System.EventHandler(this.lbrefreshsegundo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(82)))), ((int)(((byte)(106)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(286, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 45);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(209)))), ((int)(((byte)(210)))));
            this.btnIniciar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(209)))), ((int)(((byte)(210)))));
            this.btnIniciar.BorderColor = System.Drawing.Color.White;
            this.btnIniciar.BorderRadius = 20;
            this.btnIniciar.BorderSize = 0;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(124, 345);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(130, 45);
            this.btnIniciar.TabIndex = 17;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextColor = System.Drawing.Color.White;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.White;
            this.myButton3.BackgroundColor = System.Drawing.Color.White;
            this.myButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(209)))), ((int)(((byte)(210)))));
            this.myButton3.BorderRadius = 25;
            this.myButton3.BorderSize = 3;
            this.myButton3.Enabled = false;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.ForeColor = System.Drawing.Color.Black;
            this.myButton3.Location = new System.Drawing.Point(317, 245);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(170, 53);
            this.myButton3.TabIndex = 10;
            this.myButton3.TextColor = System.Drawing.Color.Black;
            this.myButton3.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.White;
            this.myButton2.BackgroundColor = System.Drawing.Color.White;
            this.myButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(209)))), ((int)(((byte)(210)))));
            this.myButton2.BorderRadius = 25;
            this.myButton2.BorderSize = 3;
            this.myButton2.Enabled = false;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.ForeColor = System.Drawing.Color.Black;
            this.myButton2.Location = new System.Drawing.Point(317, 155);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(170, 53);
            this.myButton2.TabIndex = 9;
            this.myButton2.TextColor = System.Drawing.Color.Black;
            this.myButton2.UseVisualStyleBackColor = false;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.White;
            this.myButton1.BackgroundColor = System.Drawing.Color.White;
            this.myButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(209)))), ((int)(((byte)(210)))));
            this.myButton1.BorderRadius = 25;
            this.myButton1.BorderSize = 3;
            this.myButton1.Enabled = false;
            this.myButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.Location = new System.Drawing.Point(317, 70);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(170, 53);
            this.myButton1.TabIndex = 2;
            this.myButton1.TextColor = System.Drawing.Color.Black;
            this.myButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 419);
            this.Controls.Add(this.lbrefreshsegundo);
            this.Controls.Add(this.lbrefreshminuto);
            this.Controls.Add(this.lbrefreshhora);
            this.Controls.Add(this.lbfechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.arrowupSegundo);
            this.Controls.Add(this.arrowupMinuto);
            this.Controls.Add(this.arrowdownMinuto);
            this.Controls.Add(this.arrowdownSegundo);
            this.Controls.Add(this.lbSegundo);
            this.Controls.Add(this.lbMinuto);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.arrowdownHora);
            this.Controls.Add(this.arrowupHora);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.arrowupSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdownMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdownSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdownHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyButton myButton1;
        public System.Windows.Forms.PictureBox arrowupHora;
        private System.Windows.Forms.PictureBox arrowdownHora;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MyButton myButton2;
        private MyButton myButton3;
        private System.Windows.Forms.Label lbMinuto;
        private System.Windows.Forms.Label lbSegundo;
        private System.Windows.Forms.PictureBox arrowdownSegundo;
        private System.Windows.Forms.PictureBox arrowdownMinuto;
        private System.Windows.Forms.PictureBox arrowupMinuto;
        private System.Windows.Forms.PictureBox arrowupSegundo;
        private MyButton btnIniciar;
        private MyButton btnCancelar;
        public System.Windows.Forms.Label lbfechar;
        public System.Windows.Forms.Label lbrefreshhora;
        public System.Windows.Forms.Label lbrefreshminuto;
        public System.Windows.Forms.Label lbrefreshsegundo;
    }
}

