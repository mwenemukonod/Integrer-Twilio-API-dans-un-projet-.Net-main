namespace WindowsFormsApp1
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
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btn_envoyermessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(2, 25);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(327, 91);
            this.txtmessage.TabIndex = 0;
            // 
            // btn_envoyermessage
            // 
            this.btn_envoyermessage.Location = new System.Drawing.Point(64, 122);
            this.btn_envoyermessage.Name = "btn_envoyermessage";
            this.btn_envoyermessage.Size = new System.Drawing.Size(208, 23);
            this.btn_envoyermessage.TabIndex = 1;
            this.btn_envoyermessage.Text = "Envoyer message";
            this.btn_envoyermessage.UseVisualStyleBackColor = true;
            this.btn_envoyermessage.Click += new System.EventHandler(this.btn_envoyermessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Votre message ici:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_envoyermessage);
            this.Controls.Add(this.txtmessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Envoi SMS ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button btn_envoyermessage;
        private System.Windows.Forms.Label label1;
    }
}

