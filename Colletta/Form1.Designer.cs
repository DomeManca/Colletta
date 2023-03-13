namespace Colletta
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labTot = new System.Windows.Forms.Label();
            this.labDelta = new System.Windows.Forms.Label();
            this.butNewData = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 321);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // labTot
            // 
            this.labTot.AutoSize = true;
            this.labTot.Location = new System.Drawing.Point(266, 348);
            this.labTot.Name = "labTot";
            this.labTot.Size = new System.Drawing.Size(29, 13);
            this.labTot.TabIndex = 100;
            this.labTot.Text = "TOT";
            // 
            // labDelta
            // 
            this.labDelta.AutoSize = true;
            this.labDelta.Location = new System.Drawing.Point(12, 348);
            this.labDelta.Name = "labDelta";
            this.labDelta.Size = new System.Drawing.Size(15, 13);
            this.labDelta.TabIndex = 100;
            this.labDelta.Text = "D";
            // 
            // butNewData
            // 
            this.butNewData.Location = new System.Drawing.Point(286, 403);
            this.butNewData.Name = "butNewData";
            this.butNewData.Size = new System.Drawing.Size(71, 23);
            this.butNewData.TabIndex = 5;
            this.butNewData.Text = "INSERISCI ";
            this.butNewData.UseVisualStyleBackColor = true;
            this.butNewData.Click += new System.EventHandler(this.butNewUser_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(110, 406);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(170, 20);
            this.textName.TabIndex = 1;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(110, 458);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(104, 20);
            this.textPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Prezzo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "TOT DA PAGARE";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(286, 432);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(71, 46);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "ELIMINA";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Cognome";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(110, 432);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(170, 20);
            this.textSurname.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(286, 381);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 21);
            this.comboBox2.TabIndex = 101;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 102;
            this.button1.Text = "Ordina Nome";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 103;
            this.button2.Text = "Ordina Prezzo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 104;
            this.button3.Text = "Trova";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 520);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.butNewData);
            this.Controls.Add(this.labDelta);
            this.Controls.Add(this.labTot);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labTot;
        private System.Windows.Forms.Label labDelta;
        private System.Windows.Forms.Button butNewData;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}