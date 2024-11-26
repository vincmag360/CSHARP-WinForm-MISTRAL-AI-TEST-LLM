
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxAuto = new System.Windows.Forms.CheckBox();
            this.bdDeletePrompt = new System.Windows.Forms.Button();
            this.txtBoxPrompts = new System.Windows.Forms.TextBox();
            this.btNewPrompts = new System.Windows.Forms.Button();
            this.listBoxPrompt = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(91, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(668, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.chkBoxAuto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // chkBoxAuto
            // 
            this.chkBoxAuto.AutoSize = true;
            this.chkBoxAuto.Checked = true;
            this.chkBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAuto.Location = new System.Drawing.Point(8, 30);
            this.chkBoxAuto.Name = "chkBoxAuto";
            this.chkBoxAuto.Size = new System.Drawing.Size(81, 17);
            this.chkBoxAuto.TabIndex = 3;
            this.chkBoxAuto.Text = "Auto HTML";
            this.chkBoxAuto.UseVisualStyleBackColor = true;
            // 
            // bdDeletePrompt
            // 
            this.bdDeletePrompt.Location = new System.Drawing.Point(3, 30);
            this.bdDeletePrompt.Name = "bdDeletePrompt";
            this.bdDeletePrompt.Size = new System.Drawing.Size(258, 25);
            this.bdDeletePrompt.TabIndex = 7;
            this.bdDeletePrompt.Text = "Delete selected prompt";
            this.bdDeletePrompt.UseVisualStyleBackColor = true;
            this.bdDeletePrompt.Click += new System.EventHandler(this.bdDeletePrompt_Click);
            // 
            // txtBoxPrompts
            // 
            this.txtBoxPrompts.Location = new System.Drawing.Point(88, 4);
            this.txtBoxPrompts.Name = "txtBoxPrompts";
            this.txtBoxPrompts.Size = new System.Drawing.Size(173, 20);
            this.txtBoxPrompts.TabIndex = 6;
            // 
            // btNewPrompts
            // 
            this.btNewPrompts.Location = new System.Drawing.Point(5, 3);
            this.btNewPrompts.Name = "btNewPrompts";
            this.btNewPrompts.Size = new System.Drawing.Size(82, 21);
            this.btNewPrompts.TabIndex = 5;
            this.btNewPrompts.Text = "Save Prompt";
            this.btNewPrompts.UseVisualStyleBackColor = true;
            this.btNewPrompts.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listBoxPrompt
            // 
            this.listBoxPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPrompt.FormattingEnabled = true;
            this.listBoxPrompt.Location = new System.Drawing.Point(0, 0);
            this.listBoxPrompt.Name = "listBoxPrompt";
            this.listBoxPrompt.Size = new System.Drawing.Size(264, 180);
            this.listBoxPrompt.TabIndex = 0;
            this.listBoxPrompt.SelectedIndexChanged += new System.EventHandler(this.listBoxPrompt_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(939, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 68);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
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
            this.splitContainer1.Panel1MinSize = 268;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 803);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.SplitterIncrement = 13;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 13;
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
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtboxInput);
            this.splitContainer3.Size = new System.Drawing.Size(264, 799);
            this.splitContainer3.SplitterDistance = 246;
            this.splitContainer3.SplitterWidth = 11;
            this.splitContainer3.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.bdDeletePrompt);
            this.splitContainer4.Panel1.Controls.Add(this.txtBoxPrompts);
            this.splitContainer4.Panel1.Controls.Add(this.btNewPrompts);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listBoxPrompt);
            this.splitContainer4.Size = new System.Drawing.Size(264, 246);
            this.splitContainer4.SplitterDistance = 62;
            this.splitContainer4.TabIndex = 8;
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
            this.txtboxInput.Size = new System.Drawing.Size(264, 542);
            this.txtboxInput.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(954, 799);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 882);
            this.panel1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1236, 882);
            this.splitContainer2.SplitterDistance = 77;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 73);
            this.panel2.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(774, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 69);
            this.listBox1.TabIndex = 13;
            // 
            // Form_vinc_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1236, 882);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_vinc_1";
            this.Text = "Bienvenue sur le Chat Bot LLM de vincent propulsé par Mistral  AI !!!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chkBoxAuto;
        private System.Windows.Forms.ListBox listBoxPrompt;
        private System.Windows.Forms.Button btNewPrompts;
        private System.Windows.Forms.TextBox txtBoxPrompts;
        private System.Windows.Forms.Button bdDeletePrompt;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}

