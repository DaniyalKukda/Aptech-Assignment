namespace MusicCompany
{
    partial class Album
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Album));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddAlbum = new System.Windows.Forms.TextBox();
            this.comboBoxSinger = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.dataGridViewAlbum = new System.Windows.Forms.DataGridView();
            this.buttonSignout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Singer";
            // 
            // textBoxAddAlbum
            // 
            this.textBoxAddAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAddAlbum.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddAlbum.Location = new System.Drawing.Point(258, 113);
            this.textBoxAddAlbum.Multiline = true;
            this.textBoxAddAlbum.Name = "textBoxAddAlbum";
            this.textBoxAddAlbum.Size = new System.Drawing.Size(423, 32);
            this.textBoxAddAlbum.TabIndex = 2;
            this.textBoxAddAlbum.TextChanged += new System.EventHandler(this.textBoxAddAlbum_TextChanged);
            // 
            // comboBoxSinger
            // 
            this.comboBoxSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSinger.FormattingEnabled = true;
            this.comboBoxSinger.Location = new System.Drawing.Point(258, 47);
            this.comboBoxSinger.Name = "comboBoxSinger";
            this.comboBoxSinger.Size = new System.Drawing.Size(423, 33);
            this.comboBoxSinger.TabIndex = 3;
            this.comboBoxSinger.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Album";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.buttonReport);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonADD);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.Location = new System.Drawing.Point(509, 38);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(88, 31);
            this.buttonReport.TabIndex = 7;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(392, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 31);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(267, 38);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 31);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Location = new System.Drawing.Point(150, 38);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 31);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonADD.Location = new System.Drawing.Point(30, 38);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(88, 31);
            this.buttonADD.TabIndex = 3;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // dataGridViewAlbum
            // 
            this.dataGridViewAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbum.Location = new System.Drawing.Point(54, 320);
            this.dataGridViewAlbum.Name = "dataGridViewAlbum";
            this.dataGridViewAlbum.Size = new System.Drawing.Size(627, 201);
            this.dataGridViewAlbum.TabIndex = 9;
            this.dataGridViewAlbum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlbum_CellClick);
            this.dataGridViewAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlbum_CellContentClick);
            // 
            // buttonSignout
            // 
            this.buttonSignout.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignout.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignout.Location = new System.Drawing.Point(619, 12);
            this.buttonSignout.Name = "buttonSignout";
            this.buttonSignout.Size = new System.Drawing.Size(88, 32);
            this.buttonSignout.TabIndex = 10;
            this.buttonSignout.Text = "Signout";
            this.buttonSignout.UseVisualStyleBackColor = false;
            this.buttonSignout.Click += new System.EventHandler(this.buttonSignout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicCompany.Properties.Resources.abum;
            this.ClientSize = new System.Drawing.Size(719, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSignout);
            this.Controls.Add(this.dataGridViewAlbum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSinger);
            this.Controls.Add(this.textBoxAddAlbum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.Load += new System.EventHandler(this.Album_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddAlbum;
        private System.Windows.Forms.ComboBox comboBoxSinger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.DataGridView dataGridViewAlbum;
        private System.Windows.Forms.Button buttonSignout;
        private System.Windows.Forms.Button button1;
    }
}