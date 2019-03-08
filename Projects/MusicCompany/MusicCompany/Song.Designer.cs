namespace MusicCompany
{
    partial class Song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Song));
            this.comboBoxSinger = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddSong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonSignout = new System.Windows.Forms.Button();
            this.dataGridViewSong = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSong)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSinger
            // 
            this.comboBoxSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSinger.FormattingEnabled = true;
            this.comboBoxSinger.Location = new System.Drawing.Point(244, 52);
            this.comboBoxSinger.Name = "comboBoxSinger";
            this.comboBoxSinger.Size = new System.Drawing.Size(423, 33);
            this.comboBoxSinger.TabIndex = 5;
            this.comboBoxSinger.SelectedIndexChanged += new System.EventHandler(this.comboBoxSinger_SelectedIndexChanged);
            this.comboBoxSinger.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSinger_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Singer";
            // 
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(244, 109);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(423, 33);
            this.comboBoxAlbum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(43, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(43, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Song";
            // 
            // textBoxAddSong
            // 
            this.textBoxAddSong.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAddSong.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddSong.Location = new System.Drawing.Point(244, 169);
            this.textBoxAddSong.Multiline = true;
            this.textBoxAddSong.Name = "textBoxAddSong";
            this.textBoxAddSong.Size = new System.Drawing.Size(423, 32);
            this.textBoxAddSong.TabIndex = 9;
            this.textBoxAddSong.TextChanged += new System.EventHandler(this.textBoxAddSong_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReport);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonADD);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 99);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.Black;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.ForeColor = System.Drawing.SystemColors.Control;
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
            this.buttonClear.BackColor = System.Drawing.Color.Black;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.Control;
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
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Control;
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
            this.buttonUpdate.BackColor = System.Drawing.Color.Black;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Control;
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
            this.buttonADD.BackColor = System.Drawing.Color.Black;
            this.buttonADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonADD.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonADD.Location = new System.Drawing.Point(30, 38);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(88, 31);
            this.buttonADD.TabIndex = 3;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.TextChanged += new System.EventHandler(this.buttonADD_TextChanged);
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonSignout
            // 
            this.buttonSignout.BackColor = System.Drawing.Color.Black;
            this.buttonSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignout.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignout.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSignout.Location = new System.Drawing.Point(600, 12);
            this.buttonSignout.Name = "buttonSignout";
            this.buttonSignout.Size = new System.Drawing.Size(88, 32);
            this.buttonSignout.TabIndex = 11;
            this.buttonSignout.Text = "Signout";
            this.buttonSignout.UseVisualStyleBackColor = false;
            this.buttonSignout.Click += new System.EventHandler(this.buttonSignout_Click);
            // 
            // dataGridViewSong
            // 
            this.dataGridViewSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSong.Location = new System.Drawing.Point(47, 377);
            this.dataGridViewSong.Name = "dataGridViewSong";
            this.dataGridViewSong.Size = new System.Drawing.Size(627, 201);
            this.dataGridViewSong.TabIndex = 12;
            this.dataGridViewSong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSong_CellClick);
            this.dataGridViewSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSong_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(532, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicCompany.Properties.Resources.song;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSong);
            this.Controls.Add(this.buttonSignout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxAddSong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSinger);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Song";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song";
            this.Load += new System.EventHandler(this.Song_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSinger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddSong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonSignout;
        private System.Windows.Forms.DataGridView dataGridViewSong;
        private System.Windows.Forms.Button button1;
    }
}