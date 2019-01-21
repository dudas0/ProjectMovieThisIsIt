using System.Drawing;
using System.Windows.Forms;

namespace ProjectMovieThisIsIt
{
    partial class ListOfMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfMovies));
            this.searchLabel1 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.myListView = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reżyser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ocena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.przywitanie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Choice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.myRatecomboBox = new System.Windows.Forms.ComboBox();
            this.ThanksForVoting = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLabel1
            // 
            this.searchLabel1.AutoSize = true;
            this.searchLabel1.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel1.ForeColor = System.Drawing.Color.Gold;
            this.searchLabel1.Location = new System.Drawing.Point(52, 52);
            this.searchLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel1.Name = "searchLabel1";
            this.searchLabel1.Size = new System.Drawing.Size(145, 25);
            this.searchLabel1.TabIndex = 1;
            this.searchLabel1.Text = "Wyszukaj film";
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.Firebrick;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.ForeColor = System.Drawing.Color.Gold;
            this.searchTxt.Location = new System.Drawing.Point(221, 47);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(116, 30);
            this.searchTxt.TabIndex = 2;
            // 
            // myListView
            // 
            this.myListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.myListView.BackColor = System.Drawing.Color.Firebrick;
            this.myListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myListView.BackgroundImage")));
            this.myListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Reżyser,
            this.Rok,
            this.Ocena});
            this.myListView.ForeColor = System.Drawing.Color.Gold;
            this.myListView.FullRowSelect = true;
            this.myListView.Location = new System.Drawing.Point(13, 103);
            this.myListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(548, 353);
            this.myListView.TabIndex = 3;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            this.myListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.myListView_ColumnClick);
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Tytuł";
            this.Nazwa.Width = 206;
            // 
            // Reżyser
            // 
            this.Reżyser.Text = "Reżyser";
            this.Reżyser.Width = 192;
            // 
            // Rok
            // 
            this.Rok.Text = "Rok";
            this.Rok.Width = 63;
            // 
            // Ocena
            // 
            this.Ocena.Text = "Ocena";
            this.Ocena.Width = 69;
            // 
            // przywitanie
            // 
            this.przywitanie.AutoSize = true;
            this.przywitanie.BackColor = System.Drawing.Color.Transparent;
            this.przywitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.przywitanie.ForeColor = System.Drawing.Color.Gold;
            this.przywitanie.Location = new System.Drawing.Point(242, 12);
            this.przywitanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.przywitanie.Name = "przywitanie";
            this.przywitanie.Size = new System.Drawing.Size(68, 25);
            this.przywitanie.TabIndex = 22;
            this.przywitanie.Text = "Witaj!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(988, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(972, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 615);
            this.label8.TabIndex = 27;
            // 
            // Choice
            // 
            this.Choice.AutoSize = true;
            this.Choice.BackColor = System.Drawing.Color.Transparent;
            this.Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Choice.ForeColor = System.Drawing.Color.Gold;
            this.Choice.Location = new System.Drawing.Point(720, 83);
            this.Choice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(0, 13);
            this.Choice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(673, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(768, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(673, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(768, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(673, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(768, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 17;
            // 
            // myRatecomboBox
            // 
            this.myRatecomboBox.FormattingEnabled = true;
            this.myRatecomboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.myRatecomboBox.Location = new System.Drawing.Point(771, 351);
            this.myRatecomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.myRatecomboBox.Name = "myRatecomboBox";
            this.myRatecomboBox.Size = new System.Drawing.Size(145, 28);
            this.myRatecomboBox.TabIndex = 20;
            this.myRatecomboBox.Text = "Wybierz ocene";
            this.myRatecomboBox.Visible = false;
            this.myRatecomboBox.SelectedIndexChanged += new System.EventHandler(this.myRatecomboBox_SelectedIndexChanged);
            this.myRatecomboBox.SelectionChangeCommitted += new System.EventHandler(this.myRatecomboBox_SelectedIndexChanged);
            // 
            // ThanksForVoting
            // 
            this.ThanksForVoting.AutoSize = true;
            this.ThanksForVoting.BackColor = System.Drawing.Color.Transparent;
            this.ThanksForVoting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ThanksForVoting.ForeColor = System.Drawing.Color.Gold;
            this.ThanksForVoting.Location = new System.Drawing.Point(635, 354);
            this.ThanksForVoting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThanksForVoting.Name = "ThanksForVoting";
            this.ThanksForVoting.Size = new System.Drawing.Size(0, 25);
            this.ThanksForVoting.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(673, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(768, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 25;
            // 
            // ListOfMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1151, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ThanksForVoting);
            this.Controls.Add(this.przywitanie);
            this.Controls.Add(this.myRatecomboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListOfMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza Filmów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchLabel1;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ListView myListView;
        private ColumnHeader Nazwa;
        private ColumnHeader Reżyser;
        private ColumnHeader Rok;
        private ColumnHeader Ocena;
        private Label przywitanie;
        private Label label7;
        private Label label8;
        private Label Choice;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label12;
        private Label label11;
        private ComboBox myRatecomboBox;
        private Label ThanksForVoting;
        private Label label6;
        private Label label5;
    }
}
