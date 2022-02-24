
namespace New_Dev_v
{
    partial class Form1
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_parametrage = new FontAwesome.Sharp.IconButton();
            this.btn_Historique = new FontAwesome.Sharp.IconButton();
            this.panel_inside_zone = new System.Windows.Forms.Panel();
            this.btn_lettre = new FontAwesome.Sharp.IconButton();
            this.btn_cheque = new FontAwesome.Sharp.IconButton();
            this.btn_ZonImprission = new FontAwesome.Sharp.IconButton();
            this.btn_aide = new FontAwesome.Sharp.IconButton();
            this.btn_quitter = new FontAwesome.Sharp.IconButton();
            this.panel_clear = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menu = new FontAwesome.Sharp.IconButton();
            this.panel_head = new System.Windows.Forms.Panel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Exit_Form = new FontAwesome.Sharp.IconButton();
            this.panel_body = new System.Windows.Forms.Panel();
            this.uC_Accueil1 = new New_Dev_v.UC_Accueil();
            this.uC_lettre1 = new New_Dev_v.User_control.UC_lettre();
            this.uC_cheque1 = new New_Dev_v.User_control.UC_cheque();
            this.uC_historique1 = new New_Dev_v.User_control_historique.UC_historique();
            this.uC_configuration1 = new New_Dev_v.UC_configuration.UC_configuration();
            this.uC_aide1 = new New_Dev_v.User_control_aide.UC_aide();
            this.panel_selectBtn = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_inside_zone.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.panel_Menu.Controls.Add(this.panel_selectBtn);
            this.panel_Menu.Controls.Add(this.btn_parametrage);
            this.panel_Menu.Controls.Add(this.btn_Historique);
            this.panel_Menu.Controls.Add(this.panel_inside_zone);
            this.panel_Menu.Controls.Add(this.btn_ZonImprission);
            this.panel_Menu.Controls.Add(this.btn_aide);
            this.panel_Menu.Controls.Add(this.btn_quitter);
            this.panel_Menu.Controls.Add(this.panel_clear);
            this.panel_Menu.Controls.Add(this.panel1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 518);
            this.panel_Menu.TabIndex = 0;
            this.panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Menu_Paint);
            // 
            // btn_parametrage
            // 
            this.btn_parametrage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_parametrage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_parametrage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_parametrage.FlatAppearance.BorderSize = 0;
            this.btn_parametrage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parametrage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parametrage.ForeColor = System.Drawing.Color.White;
            this.btn_parametrage.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.btn_parametrage.IconColor = System.Drawing.Color.White;
            this.btn_parametrage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_parametrage.IconSize = 35;
            this.btn_parametrage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_parametrage.Location = new System.Drawing.Point(0, 324);
            this.btn_parametrage.Name = "btn_parametrage";
            this.btn_parametrage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_parametrage.Size = new System.Drawing.Size(200, 43);
            this.btn_parametrage.TabIndex = 25;
            this.btn_parametrage.Tag = "Configuration";
            this.btn_parametrage.Text = "Configuration";
            this.btn_parametrage.UseVisualStyleBackColor = false;
            this.btn_parametrage.Click += new System.EventHandler(this.btn_parametrage_Click);
            // 
            // btn_Historique
            // 
            this.btn_Historique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_Historique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Historique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Historique.FlatAppearance.BorderSize = 0;
            this.btn_Historique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historique.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historique.ForeColor = System.Drawing.Color.White;
            this.btn_Historique.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btn_Historique.IconColor = System.Drawing.Color.White;
            this.btn_Historique.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Historique.IconSize = 35;
            this.btn_Historique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Historique.Location = new System.Drawing.Point(0, 281);
            this.btn_Historique.Name = "btn_Historique";
            this.btn_Historique.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Historique.Size = new System.Drawing.Size(200, 43);
            this.btn_Historique.TabIndex = 24;
            this.btn_Historique.Tag = "Historique";
            this.btn_Historique.Text = "Historique";
            this.btn_Historique.UseVisualStyleBackColor = false;
            this.btn_Historique.Click += new System.EventHandler(this.btn_Historique_Click);
            // 
            // panel_inside_zone
            // 
            this.panel_inside_zone.Controls.Add(this.btn_lettre);
            this.panel_inside_zone.Controls.Add(this.btn_cheque);
            this.panel_inside_zone.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_inside_zone.Location = new System.Drawing.Point(0, 201);
            this.panel_inside_zone.Name = "panel_inside_zone";
            this.panel_inside_zone.Size = new System.Drawing.Size(200, 80);
            this.panel_inside_zone.TabIndex = 23;
            // 
            // btn_lettre
            // 
            this.btn_lettre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lettre.FlatAppearance.BorderSize = 0;
            this.btn_lettre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lettre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lettre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_lettre.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btn_lettre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.btn_lettre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_lettre.IconSize = 30;
            this.btn_lettre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lettre.Location = new System.Drawing.Point(0, 40);
            this.btn_lettre.Name = "btn_lettre";
            this.btn_lettre.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_lettre.Size = new System.Drawing.Size(200, 40);
            this.btn_lettre.TabIndex = 1;
            this.btn_lettre.Tag = "LETTRE";
            this.btn_lettre.Text = "LETTRE";
            this.btn_lettre.UseVisualStyleBackColor = true;
            this.btn_lettre.Click += new System.EventHandler(this.btn_lettre_Click);
            // 
            // btn_cheque
            // 
            this.btn_cheque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cheque.FlatAppearance.BorderSize = 0;
            this.btn_cheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cheque.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_cheque.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btn_cheque.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.btn_cheque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cheque.IconSize = 30;
            this.btn_cheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cheque.Location = new System.Drawing.Point(0, 0);
            this.btn_cheque.Name = "btn_cheque";
            this.btn_cheque.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_cheque.Size = new System.Drawing.Size(200, 40);
            this.btn_cheque.TabIndex = 0;
            this.btn_cheque.Tag = "CHEQUE";
            this.btn_cheque.Text = "CHEQUE";
            this.btn_cheque.UseVisualStyleBackColor = true;
            this.btn_cheque.Click += new System.EventHandler(this.btn_cheque_Click);
            // 
            // btn_ZonImprission
            // 
            this.btn_ZonImprission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_ZonImprission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ZonImprission.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ZonImprission.FlatAppearance.BorderSize = 0;
            this.btn_ZonImprission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZonImprission.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZonImprission.ForeColor = System.Drawing.Color.White;
            this.btn_ZonImprission.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_ZonImprission.IconColor = System.Drawing.Color.White;
            this.btn_ZonImprission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ZonImprission.IconSize = 35;
            this.btn_ZonImprission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ZonImprission.Location = new System.Drawing.Point(0, 158);
            this.btn_ZonImprission.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btn_ZonImprission.Name = "btn_ZonImprission";
            this.btn_ZonImprission.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_ZonImprission.Size = new System.Drawing.Size(200, 43);
            this.btn_ZonImprission.TabIndex = 20;
            this.btn_ZonImprission.Tag = "Zone Impression";
            this.btn_ZonImprission.Text = "Zone Impression";
            this.btn_ZonImprission.UseVisualStyleBackColor = false;
            this.btn_ZonImprission.Click += new System.EventHandler(this.btn_ZonImprission_Click);
            // 
            // btn_aide
            // 
            this.btn_aide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_aide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_aide.FlatAppearance.BorderSize = 0;
            this.btn_aide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aide.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aide.ForeColor = System.Drawing.Color.White;
            this.btn_aide.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btn_aide.IconColor = System.Drawing.Color.White;
            this.btn_aide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_aide.IconSize = 35;
            this.btn_aide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aide.Location = new System.Drawing.Point(0, 432);
            this.btn_aide.Name = "btn_aide";
            this.btn_aide.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_aide.Size = new System.Drawing.Size(200, 43);
            this.btn_aide.TabIndex = 9;
            this.btn_aide.Tag = "Aide";
            this.btn_aide.Text = "Aide";
            this.btn_aide.UseVisualStyleBackColor = false;
            this.btn_aide.Click += new System.EventHandler(this.btn_aide_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_quitter.FlatAppearance.BorderSize = 0;
            this.btn_quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_quitter.IconColor = System.Drawing.Color.White;
            this.btn_quitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_quitter.IconSize = 35;
            this.btn_quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitter.Location = new System.Drawing.Point(0, 475);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(200, 43);
            this.btn_quitter.TabIndex = 8;
            this.btn_quitter.Tag = "Quitter";
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            // 
            // panel_clear
            // 
            this.panel_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.panel_clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_clear.Location = new System.Drawing.Point(0, 81);
            this.panel_clear.Name = "panel_clear";
            this.panel_clear.Size = new System.Drawing.Size(200, 77);
            this.panel_clear.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 81);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_menu.IconColor = System.Drawing.Color.White;
            this.btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menu.IconSize = 30;
            this.btn_menu.Location = new System.Drawing.Point(148, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(52, 81);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel_head.Controls.Add(this.btn_Minimize);
            this.panel_head.Controls.Add(this.btn_Exit_Form);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(200, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(710, 27);
            this.panel_head.TabIndex = 1;
            this.panel_head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_head_Paint);
            this.panel_head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_head_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 20;
            this.btn_Minimize.Location = new System.Drawing.Point(652, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(29, 27);
            this.btn_Minimize.TabIndex = 8;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit_Form
            // 
            this.btn_Exit_Form.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit_Form.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit_Form.FlatAppearance.BorderSize = 0;
            this.btn_Exit_Form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_Exit_Form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Exit_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit_Form.ForeColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconChar = FontAwesome.Sharp.IconChar.Napster;
            this.btn_Exit_Form.IconColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit_Form.IconSize = 1;
            this.btn_Exit_Form.Location = new System.Drawing.Point(681, 0);
            this.btn_Exit_Form.Name = "btn_Exit_Form";
            this.btn_Exit_Form.Size = new System.Drawing.Size(29, 27);
            this.btn_Exit_Form.TabIndex = 7;
            this.btn_Exit_Form.Text = "X";
            this.btn_Exit_Form.UseVisualStyleBackColor = false;
            this.btn_Exit_Form.Click += new System.EventHandler(this.btn_Exit_Form_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_body.Controls.Add(this.uC_Accueil1);
            this.panel_body.Controls.Add(this.uC_lettre1);
            this.panel_body.Controls.Add(this.uC_cheque1);
            this.panel_body.Controls.Add(this.uC_historique1);
            this.panel_body.Controls.Add(this.uC_configuration1);
            this.panel_body.Controls.Add(this.uC_aide1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(200, 27);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(710, 491);
            this.panel_body.TabIndex = 2;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // uC_Accueil1
            // 
            this.uC_Accueil1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Accueil1.Location = new System.Drawing.Point(0, 0);
            this.uC_Accueil1.Name = "uC_Accueil1";
            this.uC_Accueil1.Size = new System.Drawing.Size(710, 491);
            this.uC_Accueil1.TabIndex = 5;
            // 
            // uC_lettre1
            // 
            this.uC_lettre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uC_lettre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_lettre1.Location = new System.Drawing.Point(0, 0);
            this.uC_lettre1.Name = "uC_lettre1";
            this.uC_lettre1.Size = new System.Drawing.Size(710, 491);
            this.uC_lettre1.TabIndex = 4;
            // 
            // uC_cheque1
            // 
            this.uC_cheque1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_cheque1.Location = new System.Drawing.Point(0, 0);
            this.uC_cheque1.Name = "uC_cheque1";
            this.uC_cheque1.Size = new System.Drawing.Size(710, 491);
            this.uC_cheque1.TabIndex = 3;
            // 
            // uC_historique1
            // 
            this.uC_historique1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uC_historique1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_historique1.Location = new System.Drawing.Point(0, 0);
            this.uC_historique1.Name = "uC_historique1";
            this.uC_historique1.Size = new System.Drawing.Size(710, 491);
            this.uC_historique1.TabIndex = 2;
            // 
            // uC_configuration1
            // 
            this.uC_configuration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uC_configuration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_configuration1.Location = new System.Drawing.Point(0, 0);
            this.uC_configuration1.Name = "uC_configuration1";
            this.uC_configuration1.Size = new System.Drawing.Size(710, 491);
            this.uC_configuration1.TabIndex = 1;
            // 
            // uC_aide1
            // 
            this.uC_aide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uC_aide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_aide1.Location = new System.Drawing.Point(0, 0);
            this.uC_aide1.Name = "uC_aide1";
            this.uC_aide1.Size = new System.Drawing.Size(710, 491);
            this.uC_aide1.TabIndex = 0;
            // 
            // panel_selectBtn
            // 
            this.panel_selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.panel_selectBtn.Location = new System.Drawing.Point(0, 158);
            this.panel_selectBtn.Name = "panel_selectBtn";
            this.panel_selectBtn.Size = new System.Drawing.Size(10, 43);
            this.panel_selectBtn.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 518);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(910, 518);
            this.MinimumSize = new System.Drawing.Size(910, 518);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_Menu.ResumeLayout(false);
            this.panel_inside_zone.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_head.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_aide;
        private FontAwesome.Sharp.IconButton btn_quitter;
        private System.Windows.Forms.Panel panel_clear;
        private FontAwesome.Sharp.IconButton btn_menu;
        private FontAwesome.Sharp.IconButton btn_parametrage;
        private FontAwesome.Sharp.IconButton btn_Historique;
        private System.Windows.Forms.Panel panel_inside_zone;
        private FontAwesome.Sharp.IconButton btn_ZonImprission;
        private FontAwesome.Sharp.IconButton btn_lettre;
        private FontAwesome.Sharp.IconButton btn_cheque;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Exit_Form;
        private User_control_historique.UC_historique uC_historique1;
        private UC_configuration.UC_configuration uC_configuration1;
        private User_control_aide.UC_aide uC_aide1;
        private User_control.UC_lettre uC_lettre1;
        private User_control.UC_cheque uC_cheque1;
        private UC_Accueil uC_Accueil1;
        private System.Windows.Forms.Panel panel_selectBtn;
    }
}

