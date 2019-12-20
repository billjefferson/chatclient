namespace ChatClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.txtMessageList = new System.Windows.Forms.TextBox();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your chat name: ";
            // 
            // txtChatName
            // 
            this.txtChatName.Location = new System.Drawing.Point(133, 9);
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(296, 20);
            this.txtChatName.TabIndex = 1;
            // 
            // txtMessageList
            // 
            this.txtMessageList.Location = new System.Drawing.Point(15, 77);
            this.txtMessageList.Multiline = true;
            this.txtMessageList.Name = "txtMessageList";
            this.txtMessageList.Size = new System.Drawing.Size(414, 189);
            this.txtMessageList.TabIndex = 2;
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(133, 35);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(296, 23);
            this.btnConnectToServer.TabIndex = 6;
            this.btnConnectToServer.Text = "Connect";
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 273);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(333, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(354, 273);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 305);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnectToServer);
            this.Controls.Add(this.txtMessageList);
            this.Controls.Add(this.txtChatName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChatName;
        private System.Windows.Forms.TextBox txtMessageList;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;

    }
}

