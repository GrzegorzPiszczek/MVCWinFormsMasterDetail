﻿namespace MVCWinFormsMasterDetail
{
    partial class FrmGrupyPracownicze
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
            this.gbGrupaPracowniczaEditButtons = new System.Windows.Forms.GroupBox();
            this.btnRemoveGrupaPracownicza = new System.Windows.Forms.Button();
            this.btnEditGrupaPracownicza = new System.Windows.Forms.Button();
            this.btnAddGrupaPracownicza = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.pnEditPracownik = new System.Windows.Forms.Panel();
            this.pnPracownikSaveButtons = new System.Windows.Forms.Panel();
            this.btnSaveEditPracownik = new System.Windows.Forms.Button();
            this.btnCancelEditPracownik = new System.Windows.Forms.Button();
            this.lblIDPracownika = new System.Windows.Forms.Label();
            this.tbIDPracownika = new System.Windows.Forms.TextBox();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.pnPracownikEditButtons = new System.Windows.Forms.Panel();
            this.btnRemovePracownik = new System.Windows.Forms.Button();
            this.btnEditPracownik = new System.Windows.Forms.Button();
            this.btnAddPracownik = new System.Windows.Forms.Button();
            this.lvPracownicy = new System.Windows.Forms.ListView();
            this.pnEditGrupaPracownicza = new System.Windows.Forms.Panel();
            this.lblIDGrupaPracownicza = new System.Windows.Forms.Label();
            this.tbIDGrupaPracownicza = new System.Windows.Forms.TextBox();
            this.tbNazwaGrupaPracownicza = new System.Windows.Forms.TextBox();
            this.lblNazwaGrupaPracownicza = new System.Windows.Forms.Label();
            this.pnGrupaPracowniczaSaveButtons = new System.Windows.Forms.Panel();
            this.btnCancelGrupaPracownicza = new System.Windows.Forms.Button();
            this.btnSaveGrupaPracownicza = new System.Windows.Forms.Button();
            this.lvGrupyPracownicze = new System.Windows.Forms.ListView();
            this.gbGrupaPracowniczaEditButtons.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.pnEditPracownik.SuspendLayout();
            this.pnPracownikSaveButtons.SuspendLayout();
            this.pnPracownikEditButtons.SuspendLayout();
            this.pnEditGrupaPracownicza.SuspendLayout();
            this.pnGrupaPracowniczaSaveButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrupaPracowniczaEditButtons
            // 
            this.gbGrupaPracowniczaEditButtons.Controls.Add(this.btnRemoveGrupaPracownicza);
            this.gbGrupaPracowniczaEditButtons.Controls.Add(this.btnEditGrupaPracownicza);
            this.gbGrupaPracowniczaEditButtons.Controls.Add(this.btnAddGrupaPracownicza);
            this.gbGrupaPracowniczaEditButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGrupaPracowniczaEditButtons.Location = new System.Drawing.Point(0, 0);
            this.gbGrupaPracowniczaEditButtons.Name = "gbGrupaPracowniczaEditButtons";
            this.gbGrupaPracowniczaEditButtons.Size = new System.Drawing.Size(960, 60);
            this.gbGrupaPracowniczaEditButtons.TabIndex = 0;
            this.gbGrupaPracowniczaEditButtons.TabStop = false;
            // 
            // btnRemoveGrupaPracownicza
            // 
            this.btnRemoveGrupaPracownicza.Location = new System.Drawing.Point(264, 15);
            this.btnRemoveGrupaPracownicza.Name = "btnRemoveGrupaPracownicza";
            this.btnRemoveGrupaPracownicza.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveGrupaPracownicza.TabIndex = 2;
            this.btnRemoveGrupaPracownicza.Text = "Remove";
            this.btnRemoveGrupaPracownicza.UseVisualStyleBackColor = true;
            this.btnRemoveGrupaPracownicza.Click += new System.EventHandler(this.btnRemoveGrupaPracownicza_Click);
            // 
            // btnEditGrupaPracownicza
            // 
            this.btnEditGrupaPracownicza.Location = new System.Drawing.Point(138, 15);
            this.btnEditGrupaPracownicza.Name = "btnEditGrupaPracownicza";
            this.btnEditGrupaPracownicza.Size = new System.Drawing.Size(120, 30);
            this.btnEditGrupaPracownicza.TabIndex = 1;
            this.btnEditGrupaPracownicza.Text = "Edit";
            this.btnEditGrupaPracownicza.UseVisualStyleBackColor = true;
            this.btnEditGrupaPracownicza.Click += new System.EventHandler(this.btnEditGrupaPracownicza_Click);
            // 
            // btnAddGrupaPracownicza
            // 
            this.btnAddGrupaPracownicza.Location = new System.Drawing.Point(12, 15);
            this.btnAddGrupaPracownicza.Name = "btnAddGrupaPracownicza";
            this.btnAddGrupaPracownicza.Size = new System.Drawing.Size(120, 30);
            this.btnAddGrupaPracownicza.TabIndex = 0;
            this.btnAddGrupaPracownicza.Text = "Add";
            this.btnAddGrupaPracownicza.UseVisualStyleBackColor = true;
            this.btnAddGrupaPracownicza.Click += new System.EventHandler(this.btnAddGrupaPracownicza_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.pnEditPracownik);
            this.gbEdit.Controls.Add(this.pnPracownikEditButtons);
            this.gbEdit.Controls.Add(this.lvPracownicy);
            this.gbEdit.Controls.Add(this.pnEditGrupaPracownicza);
            this.gbEdit.Controls.Add(this.pnGrupaPracowniczaSaveButtons);
            this.gbEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEdit.Location = new System.Drawing.Point(0, 60);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(960, 311);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Grupa Pracownicza:";
            this.gbEdit.Visible = false;
            // 
            // pnEditPracownik
            // 
            this.pnEditPracownik.Controls.Add(this.pnPracownikSaveButtons);
            this.pnEditPracownik.Controls.Add(this.lblIDPracownika);
            this.pnEditPracownik.Controls.Add(this.tbIDPracownika);
            this.pnEditPracownik.Controls.Add(this.lblNazwisko);
            this.pnEditPracownik.Controls.Add(this.tbNazwisko);
            this.pnEditPracownik.Controls.Add(this.tbImie);
            this.pnEditPracownik.Controls.Add(this.lblImie);
            this.pnEditPracownik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnEditPracownik.Location = new System.Drawing.Point(3, 146);
            this.pnEditPracownik.Name = "pnEditPracownik";
            this.pnEditPracownik.Size = new System.Drawing.Size(954, 84);
            this.pnEditPracownik.TabIndex = 3;
            this.pnEditPracownik.Visible = false;
            // 
            // pnPracownikSaveButtons
            // 
            this.pnPracownikSaveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPracownikSaveButtons.Controls.Add(this.btnSaveEditPracownik);
            this.pnPracownikSaveButtons.Controls.Add(this.btnCancelEditPracownik);
            this.pnPracownikSaveButtons.Location = new System.Drawing.Point(735, 45);
            this.pnPracownikSaveButtons.Name = "pnPracownikSaveButtons";
            this.pnPracownikSaveButtons.Size = new System.Drawing.Size(219, 36);
            this.pnPracownikSaveButtons.TabIndex = 12;
            // 
            // btnSaveEditPracownik
            // 
            this.btnSaveEditPracownik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEditPracownik.Location = new System.Drawing.Point(25, 10);
            this.btnSaveEditPracownik.Name = "btnSaveEditPracownik";
            this.btnSaveEditPracownik.Size = new System.Drawing.Size(90, 22);
            this.btnSaveEditPracownik.TabIndex = 10;
            this.btnSaveEditPracownik.Text = "Save";
            this.btnSaveEditPracownik.UseVisualStyleBackColor = true;
            this.btnSaveEditPracownik.Click += new System.EventHandler(this.btnSaveEditPracownik_Click);
            // 
            // btnCancelEditPracownik
            // 
            this.btnCancelEditPracownik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelEditPracownik.Location = new System.Drawing.Point(121, 10);
            this.btnCancelEditPracownik.Name = "btnCancelEditPracownik";
            this.btnCancelEditPracownik.Size = new System.Drawing.Size(90, 22);
            this.btnCancelEditPracownik.TabIndex = 11;
            this.btnCancelEditPracownik.Text = "Cancel";
            this.btnCancelEditPracownik.UseVisualStyleBackColor = true;
            this.btnCancelEditPracownik.Click += new System.EventHandler(this.btnCancelEditPracownik_Click);
            // 
            // lblIDPracownika
            // 
            this.lblIDPracownika.AutoSize = true;
            this.lblIDPracownika.Location = new System.Drawing.Point(51, 8);
            this.lblIDPracownika.Name = "lblIDPracownika";
            this.lblIDPracownika.Size = new System.Drawing.Size(21, 13);
            this.lblIDPracownika.TabIndex = 9;
            this.lblIDPracownika.Text = "ID:";
            // 
            // tbIDPracownika
            // 
            this.tbIDPracownika.Location = new System.Drawing.Point(78, 5);
            this.tbIDPracownika.Name = "tbIDPracownika";
            this.tbIDPracownika.Size = new System.Drawing.Size(137, 20);
            this.tbIDPracownika.TabIndex = 8;
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(16, 34);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(56, 13);
            this.lblNazwisko.TabIndex = 4;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(78, 31);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(137, 20);
            this.tbNazwisko.TabIndex = 5;
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(78, 57);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(137, 20);
            this.tbImie.TabIndex = 7;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(43, 60);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(29, 13);
            this.lblImie.TabIndex = 6;
            this.lblImie.Text = "Imie:";
            // 
            // pnPracownikEditButtons
            // 
            this.pnPracownikEditButtons.Controls.Add(this.btnRemovePracownik);
            this.pnPracownikEditButtons.Controls.Add(this.btnEditPracownik);
            this.pnPracownikEditButtons.Controls.Add(this.btnAddPracownik);
            this.pnPracownikEditButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPracownikEditButtons.Location = new System.Drawing.Point(3, 230);
            this.pnPracownikEditButtons.Name = "pnPracownikEditButtons";
            this.pnPracownikEditButtons.Size = new System.Drawing.Size(954, 35);
            this.pnPracownikEditButtons.TabIndex = 7;
            // 
            // btnRemovePracownik
            // 
            this.btnRemovePracownik.Location = new System.Drawing.Point(201, 6);
            this.btnRemovePracownik.Name = "btnRemovePracownik";
            this.btnRemovePracownik.Size = new System.Drawing.Size(90, 22);
            this.btnRemovePracownik.TabIndex = 5;
            this.btnRemovePracownik.Text = "Remove";
            this.btnRemovePracownik.UseVisualStyleBackColor = true;
            this.btnRemovePracownik.Click += new System.EventHandler(this.btnRemovePracownik_Click);
            // 
            // btnEditPracownik
            // 
            this.btnEditPracownik.Location = new System.Drawing.Point(105, 6);
            this.btnEditPracownik.Name = "btnEditPracownik";
            this.btnEditPracownik.Size = new System.Drawing.Size(90, 22);
            this.btnEditPracownik.TabIndex = 4;
            this.btnEditPracownik.Text = "Edit";
            this.btnEditPracownik.UseVisualStyleBackColor = true;
            this.btnEditPracownik.Click += new System.EventHandler(this.btnEditPracownik_Click);
            // 
            // btnAddPracownik
            // 
            this.btnAddPracownik.Location = new System.Drawing.Point(9, 6);
            this.btnAddPracownik.Name = "btnAddPracownik";
            this.btnAddPracownik.Size = new System.Drawing.Size(90, 22);
            this.btnAddPracownik.TabIndex = 3;
            this.btnAddPracownik.Text = "Add";
            this.btnAddPracownik.UseVisualStyleBackColor = true;
            this.btnAddPracownik.Click += new System.EventHandler(this.btnAddPracownik_Click);
            // 
            // lvPracownicy
            // 
            this.lvPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPracownicy.FullRowSelect = true;
            this.lvPracownicy.GridLines = true;
            this.lvPracownicy.HideSelection = false;
            this.lvPracownicy.Location = new System.Drawing.Point(3, 89);
            this.lvPracownicy.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.lvPracownicy.MultiSelect = false;
            this.lvPracownicy.Name = "lvPracownicy";
            this.lvPracownicy.Size = new System.Drawing.Size(954, 176);
            this.lvPracownicy.TabIndex = 4;
            this.lvPracownicy.UseCompatibleStateImageBehavior = false;
            this.lvPracownicy.View = System.Windows.Forms.View.Details;
            this.lvPracownicy.SelectedIndexChanged += new System.EventHandler(this.lvPracownicy_SelectedIndexChanged);
            // 
            // pnEditGrupaPracownicza
            // 
            this.pnEditGrupaPracownicza.Controls.Add(this.lblIDGrupaPracownicza);
            this.pnEditGrupaPracownicza.Controls.Add(this.tbIDGrupaPracownicza);
            this.pnEditGrupaPracownicza.Controls.Add(this.tbNazwaGrupaPracownicza);
            this.pnEditGrupaPracownicza.Controls.Add(this.lblNazwaGrupaPracownicza);
            this.pnEditGrupaPracownicza.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditGrupaPracownicza.Location = new System.Drawing.Point(3, 16);
            this.pnEditGrupaPracownicza.Name = "pnEditGrupaPracownicza";
            this.pnEditGrupaPracownicza.Size = new System.Drawing.Size(954, 73);
            this.pnEditGrupaPracownicza.TabIndex = 5;
            // 
            // lblIDGrupaPracownicza
            // 
            this.lblIDGrupaPracownicza.AutoSize = true;
            this.lblIDGrupaPracownicza.Location = new System.Drawing.Point(16, 20);
            this.lblIDGrupaPracownicza.Name = "lblIDGrupaPracownicza";
            this.lblIDGrupaPracownicza.Size = new System.Drawing.Size(21, 13);
            this.lblIDGrupaPracownicza.TabIndex = 0;
            this.lblIDGrupaPracownicza.Text = "ID:";
            // 
            // tbIDGrupaPracownicza
            // 
            this.tbIDGrupaPracownicza.Location = new System.Drawing.Point(65, 17);
            this.tbIDGrupaPracownicza.Name = "tbIDGrupaPracownicza";
            this.tbIDGrupaPracownicza.Size = new System.Drawing.Size(137, 20);
            this.tbIDGrupaPracownicza.TabIndex = 1;
            // 
            // tbNazwaGrupaPracownicza
            // 
            this.tbNazwaGrupaPracownicza.Location = new System.Drawing.Point(65, 43);
            this.tbNazwaGrupaPracownicza.Name = "tbNazwaGrupaPracownicza";
            this.tbNazwaGrupaPracownicza.Size = new System.Drawing.Size(137, 20);
            this.tbNazwaGrupaPracownicza.TabIndex = 3;
            // 
            // lblNazwaGrupaPracownicza
            // 
            this.lblNazwaGrupaPracownicza.AutoSize = true;
            this.lblNazwaGrupaPracownicza.Location = new System.Drawing.Point(16, 46);
            this.lblNazwaGrupaPracownicza.Name = "lblNazwaGrupaPracownicza";
            this.lblNazwaGrupaPracownicza.Size = new System.Drawing.Size(43, 13);
            this.lblNazwaGrupaPracownicza.TabIndex = 2;
            this.lblNazwaGrupaPracownicza.Text = "Nazwa:";
            // 
            // pnGrupaPracowniczaSaveButtons
            // 
            this.pnGrupaPracowniczaSaveButtons.Controls.Add(this.btnCancelGrupaPracownicza);
            this.pnGrupaPracowniczaSaveButtons.Controls.Add(this.btnSaveGrupaPracownicza);
            this.pnGrupaPracowniczaSaveButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnGrupaPracowniczaSaveButtons.Location = new System.Drawing.Point(3, 265);
            this.pnGrupaPracowniczaSaveButtons.Name = "pnGrupaPracowniczaSaveButtons";
            this.pnGrupaPracowniczaSaveButtons.Size = new System.Drawing.Size(954, 43);
            this.pnGrupaPracowniczaSaveButtons.TabIndex = 6;
            // 
            // btnCancelGrupaPracownicza
            // 
            this.btnCancelGrupaPracownicza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelGrupaPracownicza.Location = new System.Drawing.Point(825, 8);
            this.btnCancelGrupaPracownicza.Name = "btnCancelGrupaPracownicza";
            this.btnCancelGrupaPracownicza.Size = new System.Drawing.Size(120, 30);
            this.btnCancelGrupaPracownicza.TabIndex = 2;
            this.btnCancelGrupaPracownicza.Text = "Cancel";
            this.btnCancelGrupaPracownicza.UseVisualStyleBackColor = true;
            this.btnCancelGrupaPracownicza.Click += new System.EventHandler(this.btnCancelGrupaPracownicza_Click);
            // 
            // btnSaveGrupaPracownicza
            // 
            this.btnSaveGrupaPracownicza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveGrupaPracownicza.Location = new System.Drawing.Point(699, 8);
            this.btnSaveGrupaPracownicza.Name = "btnSaveGrupaPracownicza";
            this.btnSaveGrupaPracownicza.Size = new System.Drawing.Size(120, 30);
            this.btnSaveGrupaPracownicza.TabIndex = 1;
            this.btnSaveGrupaPracownicza.Text = "Save";
            this.btnSaveGrupaPracownicza.UseVisualStyleBackColor = true;
            this.btnSaveGrupaPracownicza.Click += new System.EventHandler(this.btnSaveGrupaPracownicza_Click);
            // 
            // lvGrupyPracownicze
            // 
            this.lvGrupyPracownicze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGrupyPracownicze.FullRowSelect = true;
            this.lvGrupyPracownicze.GridLines = true;
            this.lvGrupyPracownicze.HideSelection = false;
            this.lvGrupyPracownicze.Location = new System.Drawing.Point(0, 371);
            this.lvGrupyPracownicze.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.lvGrupyPracownicze.MultiSelect = false;
            this.lvGrupyPracownicze.Name = "lvGrupyPracownicze";
            this.lvGrupyPracownicze.Size = new System.Drawing.Size(960, 267);
            this.lvGrupyPracownicze.TabIndex = 2;
            this.lvGrupyPracownicze.UseCompatibleStateImageBehavior = false;
            this.lvGrupyPracownicze.View = System.Windows.Forms.View.Details;
            this.lvGrupyPracownicze.SelectedIndexChanged += new System.EventHandler(this.lvGrupyPracownicze_SelectedIndexChanged);
            // 
            // FrmGrupyPracownicze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 638);
            this.Controls.Add(this.lvGrupyPracownicze);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbGrupaPracowniczaEditButtons);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmGrupyPracownicze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupy Pracownicze";
            this.gbGrupaPracowniczaEditButtons.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.pnEditPracownik.ResumeLayout(false);
            this.pnEditPracownik.PerformLayout();
            this.pnPracownikSaveButtons.ResumeLayout(false);
            this.pnPracownikEditButtons.ResumeLayout(false);
            this.pnEditGrupaPracownicza.ResumeLayout(false);
            this.pnEditGrupaPracownicza.PerformLayout();
            this.pnGrupaPracowniczaSaveButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGrupaPracowniczaEditButtons;
        private System.Windows.Forms.Button btnAddGrupaPracownicza;
        private System.Windows.Forms.Button btnEditGrupaPracownicza;
        private System.Windows.Forms.Button btnRemoveGrupaPracownicza;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.ListView lvGrupyPracownicze;
        private System.Windows.Forms.ListView lvPracownicy;
        private System.Windows.Forms.Panel pnEditGrupaPracownicza;
        private System.Windows.Forms.Label lblIDGrupaPracownicza;
        private System.Windows.Forms.TextBox tbIDGrupaPracownicza;
        private System.Windows.Forms.TextBox tbNazwaGrupaPracownicza;
        private System.Windows.Forms.Label lblNazwaGrupaPracownicza;
        private System.Windows.Forms.Panel pnGrupaPracowniczaSaveButtons;
        private System.Windows.Forms.Button btnCancelGrupaPracownicza;
        private System.Windows.Forms.Button btnSaveGrupaPracownicza;
        private System.Windows.Forms.Panel pnPracownikEditButtons;
        private System.Windows.Forms.Button btnRemovePracownik;
        private System.Windows.Forms.Button btnEditPracownik;
        private System.Windows.Forms.Button btnAddPracownik;
        private System.Windows.Forms.Panel pnEditPracownik;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblIDPracownika;
        private System.Windows.Forms.TextBox tbIDPracownika;
        private System.Windows.Forms.Button btnCancelEditPracownik;
        private System.Windows.Forms.Button btnSaveEditPracownik;
        private System.Windows.Forms.Panel pnPracownikSaveButtons;
    }
}