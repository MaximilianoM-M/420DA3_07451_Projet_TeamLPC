﻿namespace _420DA3_07451_Projet_Initial.Presentation;

partial class FournisseurWindow {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        ControlLayout = new TableLayoutPanel();
        label1 = new Label();
        Datapanel = new Panel();
        label8 = new Label();
        AdressecomboBox = new ComboBox();
        BtnControlpanel = new Panel();
        ActionBtn = new Button();
        ExitBtn = new Button();
        FournisseurNomtextBox = new TextBox();
        label7 = new Label();
        EmailContacttextBox = new TextBox();
        label6 = new Label();
        label5 = new Label();
        AdresseContacttextBox = new TextBox();
        NomContacttextBox = new TextBox();
        label4 = new Label();
        PrenomContacttextBox1 = new TextBox();
        label3 = new Label();
        ControlLayout.SuspendLayout();
        Datapanel.SuspendLayout();
        BtnControlpanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // ControlLayout
        // 
        ControlLayout.ColumnCount = 3;
        ControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        ControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        ControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        ControlLayout.Controls.Add(label1, 2, 0);
        ControlLayout.Controls.Add(Datapanel, 1, 0);
        ControlLayout.Dock = DockStyle.Fill;
        ControlLayout.Location = new Point(0, 0);
        ControlLayout.Name = "ControlLayout";
        ControlLayout.RowCount = 1;
        ControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ControlLayout.Size = new Size(800, 450);
        ControlLayout.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Location = new Point(723, 0);
        label1.Name = "label1";
        label1.Size = new Size(74, 15);
        label1.TabIndex = 0;
        // 
        // Datapanel
        // 
        Datapanel.Controls.Add(label8);
        Datapanel.Controls.Add(AdressecomboBox);
        Datapanel.Controls.Add(BtnControlpanel);
        Datapanel.Controls.Add(FournisseurNomtextBox);
        Datapanel.Controls.Add(label7);
        Datapanel.Controls.Add(EmailContacttextBox);
        Datapanel.Controls.Add(label6);
        Datapanel.Controls.Add(label5);
        Datapanel.Controls.Add(AdresseContacttextBox);
        Datapanel.Controls.Add(NomContacttextBox);
        Datapanel.Controls.Add(label4);
        Datapanel.Controls.Add(PrenomContacttextBox1);
        Datapanel.Controls.Add(label3);
        Datapanel.Dock = DockStyle.Fill;
        Datapanel.Location = new Point(83, 3);
        Datapanel.Name = "Datapanel";
        Datapanel.Size = new Size(634, 444);
        Datapanel.TabIndex = 2;
        // 
        // label8
        // 
        label8.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        label8.AutoSize = true;
        label8.Location = new Point(381, 151);
        label8.Name = "label8";
        label8.Size = new Size(133, 15);
        label8.TabIndex = 15;
        label8.Text = "Adresse du fournisseur :";
        // 
        // AdressecomboBox
        // 
        AdressecomboBox.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        AdressecomboBox.FormattingEnabled = true;
        AdressecomboBox.Location = new Point(381, 169);
        AdressecomboBox.Name = "AdressecomboBox";
        AdressecomboBox.Size = new Size(250, 23);
        AdressecomboBox.TabIndex = 14;
        // 
        // BtnControlpanel
        // 
        BtnControlpanel.Controls.Add(ActionBtn);
        BtnControlpanel.Controls.Add(ExitBtn);
        BtnControlpanel.Dock = DockStyle.Bottom;
        BtnControlpanel.Location = new Point(0, 344);
        BtnControlpanel.Name = "BtnControlpanel";
        BtnControlpanel.Size = new Size(634, 100);
        BtnControlpanel.TabIndex = 13;
        // 
        // ActionBtn
        // 
        ActionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        ActionBtn.Location = new Point(381, 24);
        ActionBtn.Name = "ActionBtn";
        ActionBtn.Size = new Size(122, 43);
        ActionBtn.TabIndex = 1;
        ActionBtn.Text = "ACTION";
        ActionBtn.UseVisualStyleBackColor = true;
        ActionBtn.Click += this.ActionBtn_Click;
        // 
        // ExitBtn
        // 
        ExitBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        ExitBtn.Location = new Point(509, 24);
        ExitBtn.Name = "ExitBtn";
        ExitBtn.Size = new Size(122, 43);
        ExitBtn.TabIndex = 0;
        ExitBtn.Text = "Quitter";
        ExitBtn.UseVisualStyleBackColor = true;
        ExitBtn.Click += this.ExitBtn_Click;
        // 
        // FournisseurNomtextBox
        // 
        FournisseurNomtextBox.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        FournisseurNomtextBox.Location = new Point(381, 125);
        FournisseurNomtextBox.Name = "FournisseurNomtextBox";
        FournisseurNomtextBox.PlaceholderText = "Nom du fournisseur";
        FournisseurNomtextBox.Size = new Size(250, 23);
        FournisseurNomtextBox.TabIndex = 12;
        // 
        // label7
        // 
        label7.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
        label7.AutoSize = true;
        label7.Location = new Point(381, 107);
        label7.Name = "label7";
        label7.Size = new Size(119, 15);
        label7.TabIndex = 11;
        label7.Text = "Nom du fournisseur :";
        // 
        // EmailContacttextBox
        // 
        EmailContacttextBox.Location = new Point(3, 257);
        EmailContacttextBox.Name = "EmailContacttextBox";
        EmailContacttextBox.PlaceholderText = "Email du contact";
        EmailContacttextBox.Size = new Size(250, 23);
        EmailContacttextBox.TabIndex = 10;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(3, 239);
        label6.Name = "label6";
        label6.Size = new Size(158, 15);
        label6.TabIndex = 9;
        label6.Text = "Email du contact d'urgence :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(3, 195);
        label5.Name = "label5";
        label5.Size = new Size(183, 15);
        label5.TabIndex = 8;
        label5.Text = "Téléphone du contact d'urgence :";
        // 
        // AdresseContacttextBox
        // 
        AdresseContacttextBox.Location = new Point(3, 213);
        AdresseContacttextBox.Name = "AdresseContacttextBox";
        AdresseContacttextBox.PlaceholderText = "Telephone du contact";
        AdresseContacttextBox.Size = new Size(250, 23);
        AdresseContacttextBox.TabIndex = 7;
        // 
        // NomContacttextBox
        // 
        NomContacttextBox.Location = new Point(3, 169);
        NomContacttextBox.Name = "NomContacttextBox";
        NomContacttextBox.PlaceholderText = "Nom du contact";
        NomContacttextBox.Size = new Size(250, 23);
        NomContacttextBox.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(3, 151);
        label4.Name = "label4";
        label4.Size = new Size(156, 15);
        label4.TabIndex = 5;
        label4.Text = "Nom du contact d'urgence :";
        // 
        // PrenomContacttextBox1
        // 
        PrenomContacttextBox1.Location = new Point(3, 125);
        PrenomContacttextBox1.Name = "PrenomContacttextBox1";
        PrenomContacttextBox1.PlaceholderText = "Prénom du contact";
        PrenomContacttextBox1.Size = new Size(250, 23);
        PrenomContacttextBox1.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 107);
        label3.Name = "label3";
        label3.Size = new Size(171, 15);
        label3.TabIndex = 3;
        label3.Text = "Prénom du contact d'urgence :";
        // 
        // FournisseurWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(ControlLayout);
        this.Name = "FournisseurWindow";
        this.Text = "FournisseurWindow";
        ControlLayout.ResumeLayout(false);
        ControlLayout.PerformLayout();
        Datapanel.ResumeLayout(false);
        Datapanel.PerformLayout();
        BtnControlpanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel ControlLayout;
    private Label label1;
    private Panel Datapanel;
    private Label label4;
    private TextBox PrenomContacttextBox1;
    private Label label3;
    private Label label5;
    private TextBox AdresseContacttextBox;
    private TextBox NomContacttextBox;
    private TextBox FournisseurNomtextBox;
    private Label label7;
    private TextBox EmailContacttextBox;
    private Label label6;
    private Panel BtnControlpanel;
    private Button ActionBtn;
    private Button ExitBtn;
    private Label label8;
    private ComboBox AdressecomboBox;
}