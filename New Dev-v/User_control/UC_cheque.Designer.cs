
namespace New_Dev_v.User_control
{
    partial class UC_cheque
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_btns = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.btn_etape2 = new FontAwesome.Sharp.IconButton();
            this.Btn_etap1 = new FontAwesome.Sharp.IconButton();
            this.panel_body_cheque = new System.Windows.Forms.Panel();
            this.uC_imprimer1 = new New_Dev_v.User_control.UC_imprimer();
            this.uC_cheque_info1 = new New_Dev_v.User_control.UC_cheque_info();
            this.panel_btns.SuspendLayout();
            this.panel_body_cheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_btns
            // 
            this.panel_btns.Controls.Add(this.panel_slide);
            this.panel_btns.Controls.Add(this.btn_etape2);
            this.panel_btns.Controls.Add(this.Btn_etap1);
            this.panel_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_btns.Location = new System.Drawing.Point(0, 0);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.Size = new System.Drawing.Size(710, 54);
            this.panel_btns.TabIndex = 0;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.panel_slide.Location = new System.Drawing.Point(0, 50);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(355, 4);
            this.panel_slide.TabIndex = 4;
            // 
            // btn_etape2
            // 
            this.btn_etape2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_etape2.FlatAppearance.BorderSize = 0;
            this.btn_etape2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_etape2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_etape2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.btn_etape2.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_etape2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.btn_etape2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_etape2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_etape2.Location = new System.Drawing.Point(355, 0);
            this.btn_etape2.Name = "btn_etape2";
            this.btn_etape2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_etape2.Size = new System.Drawing.Size(355, 54);
            this.btn_etape2.TabIndex = 3;
            this.btn_etape2.Text = "ETAPE 2\r\nImpression";
            this.btn_etape2.UseVisualStyleBackColor = true;
            this.btn_etape2.Click += new System.EventHandler(this.btn_etape2_Click);
            // 
            // Btn_etap1
            // 
            this.Btn_etap1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_etap1.FlatAppearance.BorderSize = 0;
            this.Btn_etap1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_etap1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_etap1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.Btn_etap1.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.Btn_etap1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.Btn_etap1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_etap1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_etap1.Location = new System.Drawing.Point(0, 0);
            this.Btn_etap1.Name = "Btn_etap1";
            this.Btn_etap1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_etap1.Size = new System.Drawing.Size(355, 54);
            this.Btn_etap1.TabIndex = 1;
            this.Btn_etap1.Text = "ETAPE 1\r\nLes informations";
            this.Btn_etap1.UseVisualStyleBackColor = true;
            this.Btn_etap1.Click += new System.EventHandler(this.Btn_etap1_Click);
            // 
            // panel_body_cheque
            // 
            this.panel_body_cheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_body_cheque.Controls.Add(this.uC_cheque_info1);
            this.panel_body_cheque.Controls.Add(this.uC_imprimer1);
            this.panel_body_cheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body_cheque.Location = new System.Drawing.Point(0, 54);
            this.panel_body_cheque.Name = "panel_body_cheque";
            this.panel_body_cheque.Size = new System.Drawing.Size(710, 437);
            this.panel_body_cheque.TabIndex = 1;
            // 
            // uC_imprimer1
            // 
            this.uC_imprimer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uC_imprimer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_imprimer1.Location = new System.Drawing.Point(0, 0);
            this.uC_imprimer1.Name = "uC_imprimer1";
            this.uC_imprimer1.Size = new System.Drawing.Size(710, 437);
            this.uC_imprimer1.TabIndex = 0;
            // 
            // uC_cheque_info1
            // 
            this.uC_cheque_info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uC_cheque_info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_cheque_info1.Location = new System.Drawing.Point(0, 0);
            this.uC_cheque_info1.Name = "uC_cheque_info1";
            this.uC_cheque_info1.Size = new System.Drawing.Size(710, 437);
            this.uC_cheque_info1.TabIndex = 1;
            // 
            // UC_cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_body_cheque);
            this.Controls.Add(this.panel_btns);
            this.Name = "UC_cheque";
            this.Size = new System.Drawing.Size(710, 491);
            this.panel_btns.ResumeLayout(false);
            this.panel_body_cheque.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_btns;
        private FontAwesome.Sharp.IconButton Btn_etap1;
        private System.Windows.Forms.Panel panel_body_cheque;
        private FontAwesome.Sharp.IconButton btn_etape2;
        private System.Windows.Forms.Panel panel_slide;
        private UC_cheque_info uC_cheque_info1;
        private UC_imprimer uC_imprimer1;
    }
}
