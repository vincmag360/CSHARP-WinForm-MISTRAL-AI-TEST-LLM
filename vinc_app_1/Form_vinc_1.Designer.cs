﻿
namespace vinc_app_1
{
    partial class Form_vinc_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_vinc_1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bdDeletePrompt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBoxPrompts = new System.Windows.Forms.TextBox();
            this.chkBoxAuto = new System.Windows.Forms.CheckBox();
            this.btNewPrompts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPrompt = new System.Windows.Forms.ListBox();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.checkBoxChat = new System.Windows.Forms.CheckBox();
            this.checkBoxChatbotView = new System.Windows.Forms.CheckBox();
            this.btDeleteChat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 736);
            this.panel1.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 340;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(897, 736);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.SplitterIncrement = 13;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Panel1MinSize = 250;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtboxInput);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Panel2MinSize = 333;
            this.splitContainer3.Size = new System.Drawing.Size(348, 732);
            this.splitContainer3.SplitterDistance = 275;
            this.splitContainer3.SplitterWidth = 11;
            this.splitContainer3.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Panel1.Controls.Add(this.btDeleteChat);
            this.splitContainer4.Panel1.Controls.Add(this.checkBoxChatbotView);
            this.splitContainer4.Panel1.Controls.Add(this.checkBoxChat);
            this.splitContainer4.Panel1.Controls.Add(this.listBox1);
            this.splitContainer4.Panel1.Controls.Add(this.bdDeletePrompt);
            this.splitContainer4.Panel1.Controls.Add(this.textBox1);
            this.splitContainer4.Panel1.Controls.Add(this.txtBoxPrompts);
            this.splitContainer4.Panel1.Controls.Add(this.chkBoxAuto);
            this.splitContainer4.Panel1.Controls.Add(this.btNewPrompts);
            this.splitContainer4.Panel1.Controls.Add(this.button1);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Panel1MinSize = 180;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listBoxPrompt);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Size = new System.Drawing.Size(348, 275);
            this.splitContainer4.SplitterDistance = 198;
            this.splitContainer4.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 130);
            this.listBox1.TabIndex = 13;
            // 
            // bdDeletePrompt
            // 
            this.bdDeletePrompt.BackColor = System.Drawing.Color.DarkGray;
            this.bdDeletePrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdDeletePrompt.Location = new System.Drawing.Point(7, 140);
            this.bdDeletePrompt.Name = "bdDeletePrompt";
            this.bdDeletePrompt.Size = new System.Drawing.Size(334, 23);
            this.bdDeletePrompt.TabIndex = 7;
            this.bdDeletePrompt.Text = "Delete selected prompt";
            this.bdDeletePrompt.UseVisualStyleBackColor = false;
            this.bdDeletePrompt.Click += new System.EventHandler(this.bdDeletePrompt_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(147, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 74);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            // 
            // txtBoxPrompts
            // 
            this.txtBoxPrompts.Location = new System.Drawing.Point(101, 171);
            this.txtBoxPrompts.Name = "txtBoxPrompts";
            this.txtBoxPrompts.Size = new System.Drawing.Size(240, 20);
            this.txtBoxPrompts.TabIndex = 6;
            // 
            // chkBoxAuto
            // 
            this.chkBoxAuto.AutoSize = true;
            this.chkBoxAuto.Checked = true;
            this.chkBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAuto.Location = new System.Drawing.Point(256, 10);
            this.chkBoxAuto.Name = "chkBoxAuto";
            this.chkBoxAuto.Size = new System.Drawing.Size(81, 17);
            this.chkBoxAuto.TabIndex = 3;
            this.chkBoxAuto.Text = "Auto HTML";
            this.chkBoxAuto.UseVisualStyleBackColor = true;
            // 
            // btNewPrompts
            // 
            this.btNewPrompts.BackColor = System.Drawing.Color.DarkGray;
            this.btNewPrompts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewPrompts.Location = new System.Drawing.Point(7, 168);
            this.btNewPrompts.Name = "btNewPrompts";
            this.btNewPrompts.Size = new System.Drawing.Size(88, 23);
            this.btNewPrompts.TabIndex = 5;
            this.btNewPrompts.Text = "Save Prompt";
            this.btNewPrompts.UseVisualStyleBackColor = false;
            this.btNewPrompts.Click += new System.EventHandler(this.btNewPrompts_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(143, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxPrompt
            // 
            this.listBoxPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPrompt.FormattingEnabled = true;
            this.listBoxPrompt.Location = new System.Drawing.Point(0, 0);
            this.listBoxPrompt.Name = "listBoxPrompt";
            this.listBoxPrompt.Size = new System.Drawing.Size(348, 73);
            this.listBoxPrompt.TabIndex = 0;
            this.listBoxPrompt.SelectedIndexChanged += new System.EventHandler(this.listBoxPrompt_SelectedIndexChanged_1);
            // 
            // txtboxInput
            // 
            this.txtboxInput.BackColor = System.Drawing.Color.White;
            this.txtboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(0, 0);
            this.txtboxInput.Multiline = true;
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxInput.Size = new System.Drawing.Size(348, 446);
            this.txtboxInput.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(531, 732);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating_1);
            // 
            // checkBoxChat
            // 
            this.checkBoxChat.AutoSize = true;
            this.checkBoxChat.Location = new System.Drawing.Point(143, 37);
            this.checkBoxChat.Name = "checkBoxChat";
            this.checkBoxChat.Size = new System.Drawing.Size(63, 17);
            this.checkBoxChat.TabIndex = 14;
            this.checkBoxChat.Text = "Chatbot";
            this.checkBoxChat.UseVisualStyleBackColor = true;
            this.checkBoxChat.CheckedChanged += new System.EventHandler(this.checkBoxChat_CheckedChanged);
            // 
            // checkBoxChatbotView
            // 
            this.checkBoxChatbotView.AutoSize = true;
            this.checkBoxChatbotView.Enabled = false;
            this.checkBoxChatbotView.Location = new System.Drawing.Point(208, 36);
            this.checkBoxChatbotView.Name = "checkBoxChatbotView";
            this.checkBoxChatbotView.Size = new System.Drawing.Size(49, 17);
            this.checkBoxChatbotView.TabIndex = 15;
            this.checkBoxChatbotView.Text = "View";
            this.checkBoxChatbotView.UseVisualStyleBackColor = true;
            this.checkBoxChatbotView.CheckedChanged += new System.EventHandler(this.checkBoxChatbotView_CheckedChanged);
            // 
            // btDeleteChat
            // 
            this.btDeleteChat.BackColor = System.Drawing.Color.DarkGray;
            this.btDeleteChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteChat.Location = new System.Drawing.Point(256, 31);
            this.btDeleteChat.Name = "btDeleteChat";
            this.btDeleteChat.Size = new System.Drawing.Size(75, 23);
            this.btDeleteChat.TabIndex = 16;
            this.btDeleteChat.Text = "Delete";
            this.btDeleteChat.UseVisualStyleBackColor = false;
            this.btDeleteChat.Click += new System.EventHandler(this.btDeleteChat_Click);
            // 
            // Form_vinc_1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(897, 736);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 773);
            this.Name = "Form_vinc_1";
            this.Text = "Bienvenue sur le Chat Bot LLM de vincent propulsé par Mistral  AI !!!";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bdDeletePrompt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBoxPrompts;
        private System.Windows.Forms.CheckBox chkBoxAuto;
        private System.Windows.Forms.Button btNewPrompts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPrompt;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckBox checkBoxChat;
        private System.Windows.Forms.CheckBox checkBoxChatbotView;
        private System.Windows.Forms.Button btDeleteChat;
    }
}

