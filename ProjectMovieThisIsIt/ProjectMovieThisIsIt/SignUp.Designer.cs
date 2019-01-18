namespace ProjectMovieThisIsIt
{
    partial class SignUp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.textimie = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.textnazwisko = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.nazwa = new System.Windows.Forms.Label();
            this.textnazwa = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.texthaslo = new System.Windows.Forms.TextBox();
            this.haslo2 = new System.Windows.Forms.Label();
            this.texthaslo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rejestruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textimie
            // 
            this.textimie.Location = new System.Drawing.Point(146, 51);
            this.textimie.Name = "textimie";
            this.textimie.Size = new System.Drawing.Size(100, 20);
            this.textimie.TabIndex = 0;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.BackColor = System.Drawing.Color.Transparent;
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.imie.Location = new System.Drawing.Point(8, 61);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(30, 13);
            this.imie.TabIndex = 1;
            this.imie.Text = "Imię";
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.BackColor = System.Drawing.Color.Transparent;
            this.nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.nazwisko.Location = new System.Drawing.Point(8, 99);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(61, 13);
            this.nazwisko.TabIndex = 3;
            this.nazwisko.Text = "Nazwisko";
            // 
            // textnazwisko
            // 
            this.textnazwisko.Location = new System.Drawing.Point(146, 92);
            this.textnazwisko.Name = "textnazwisko";
            this.textnazwisko.Size = new System.Drawing.Size(100, 20);
            this.textnazwisko.TabIndex = 2;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(8, 135);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(76, 13);
            this.email.TabIndex = 5;
            this.email.Text = "Adres e-mail";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(146, 128);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 4;
            // 
            // nazwa
            // 
            this.nazwa.AutoSize = true;
            this.nazwa.BackColor = System.Drawing.Color.Transparent;
            this.nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.nazwa.Location = new System.Drawing.Point(8, 164);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(119, 13);
            this.nazwa.TabIndex = 7;
            this.nazwa.Text = "Nazwa użytkownika";
            // 
            // textnazwa
            // 
            this.textnazwa.Location = new System.Drawing.Point(146, 161);
            this.textnazwa.Name = "textnazwa";
            this.textnazwa.Size = new System.Drawing.Size(100, 20);
            this.textnazwa.TabIndex = 6;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.BackColor = System.Drawing.Color.Transparent;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.haslo.Location = new System.Drawing.Point(8, 200);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(41, 13);
            this.haslo.TabIndex = 9;
            this.haslo.Text = "Hasło";
            // 
            // texthaslo
            // 
            this.texthaslo.Location = new System.Drawing.Point(146, 193);
            this.texthaslo.Name = "texthaslo";
            this.texthaslo.PasswordChar = '*';
            this.texthaslo.Size = new System.Drawing.Size(100, 20);
            this.texthaslo.TabIndex = 8;
            // 
            // haslo2
            // 
            this.haslo2.AutoSize = true;
            this.haslo2.BackColor = System.Drawing.Color.Transparent;
            this.haslo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.haslo2.Location = new System.Drawing.Point(8, 235);
            this.haslo2.Name = "haslo2";
            this.haslo2.Size = new System.Drawing.Size(88, 13);
            this.haslo2.TabIndex = 11;
            this.haslo2.Text = "Powtórz hasło";
            // 
            // texthaslo2
            // 
            this.texthaslo2.Location = new System.Drawing.Point(146, 228);
            this.texthaslo2.Name = "texthaslo2";
            this.texthaslo2.PasswordChar = '*';
            this.texthaslo2.Size = new System.Drawing.Size(100, 20);
            this.texthaslo2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ZAREJESTRUJ SIĘ";
            // 
            // Rejestruj
            // 
            this.Rejestruj.BackColor = System.Drawing.Color.Black;
            this.Rejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Rejestruj.Location = new System.Drawing.Point(205, 280);
            this.Rejestruj.Name = "Rejestruj";
            this.Rejestruj.Size = new System.Drawing.Size(75, 23);
            this.Rejestruj.TabIndex = 12;
            this.Rejestruj.Text = "OK";
            this.Rejestruj.UseVisualStyleBackColor = false;
            this.Rejestruj.Click += new System.EventHandler(this.Rejestruj_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(328, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rejestruj);
            this.Controls.Add(this.haslo2);
            this.Controls.Add(this.texthaslo2);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.texthaslo);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.textnazwa);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.textnazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.textimie);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "SignUp";
            this.Text = "Zarejestruj się";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textimie;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.TextBox textnazwisko;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label nazwa;
        private System.Windows.Forms.TextBox textnazwa;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox texthaslo;
        private System.Windows.Forms.Label haslo2;
        private System.Windows.Forms.TextBox texthaslo2;
        private System.Windows.Forms.Button Rejestruj;
        private System.Windows.Forms.Label label1;
    }
}

