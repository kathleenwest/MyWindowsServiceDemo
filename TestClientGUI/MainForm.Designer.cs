namespace TestClientGUI
{
    partial class frmMainScreen
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
            this.lblPositiveAffirmationsTitle = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAffirmMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPositiveAffirmationsTitle
            // 
            this.lblPositiveAffirmationsTitle.AutoSize = true;
            this.lblPositiveAffirmationsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositiveAffirmationsTitle.Location = new System.Drawing.Point(38, 22);
            this.lblPositiveAffirmationsTitle.Name = "lblPositiveAffirmationsTitle";
            this.lblPositiveAffirmationsTitle.Size = new System.Drawing.Size(592, 69);
            this.lblPositiveAffirmationsTitle.TabIndex = 0;
            this.lblPositiveAffirmationsTitle.Text = "Positive Affirmations";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(180, 104);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(278, 49);
            this.lblSignature.TabIndex = 1;
            this.lblSignature.Text = "by Kathleen West";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(125, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 37);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(243, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 44);
            this.txtName.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(57, 317);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(563, 93);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "Your positive affirmation will appear here after you click the button.";
            // 
            // btnAffirmMe
            // 
            this.btnAffirmMe.BackColor = System.Drawing.SystemColors.Info;
            this.btnAffirmMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffirmMe.Location = new System.Drawing.Point(243, 238);
            this.btnAffirmMe.Name = "btnAffirmMe";
            this.btnAffirmMe.Size = new System.Drawing.Size(185, 44);
            this.btnAffirmMe.TabIndex = 5;
            this.btnAffirmMe.Text = "Affirm Me";
            this.btnAffirmMe.UseVisualStyleBackColor = false;
            this.btnAffirmMe.Click += new System.EventHandler(this.btnAffirmMe_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnAffirmMe);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblPositiveAffirmationsTitle);
            this.Name = "frmMainScreen";
            this.Text = "Positive Affirmations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPositiveAffirmationsTitle;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAffirmMe;
    }
}

