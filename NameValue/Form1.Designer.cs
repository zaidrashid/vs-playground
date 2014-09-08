namespace NameValuePairTestProgram
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
            this.save_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.insert_txtbx = new System.Windows.Forms.TextBox();
            this.key_value_lstbx = new System.Windows.Forms.ListBox();
            this.sort_key_btn = new System.Windows.Forms.Button();
            this.sort_val_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_xml_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.AllowDrop = true;
            this.save_btn.Location = new System.Drawing.Point(280, 34);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(104, 23);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "&Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // insert_txtbx
            // 
            this.insert_txtbx.Location = new System.Drawing.Point(12, 37);
            this.insert_txtbx.Name = "insert_txtbx";
            this.insert_txtbx.Size = new System.Drawing.Size(262, 20);
            this.insert_txtbx.TabIndex = 0;
            this.insert_txtbx.Text = "Enter your \"name=value\" pair here...";
            this.insert_txtbx.Click += new System.EventHandler(this.insert_txtbx_Click);
            this.insert_txtbx.TextChanged += new System.EventHandler(this.insert_txtbx_TextChange);
            // 
            // key_value_lstbx
            // 
            this.key_value_lstbx.FormattingEnabled = true;
            this.key_value_lstbx.Location = new System.Drawing.Point(13, 96);
            this.key_value_lstbx.Name = "key_value_lstbx";
            this.key_value_lstbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.key_value_lstbx.Size = new System.Drawing.Size(262, 186);
            this.key_value_lstbx.TabIndex = 2;
            // 
            // sort_key_btn
            // 
            this.sort_key_btn.Location = new System.Drawing.Point(281, 94);
            this.sort_key_btn.Name = "sort_key_btn";
            this.sort_key_btn.Size = new System.Drawing.Size(104, 23);
            this.sort_key_btn.TabIndex = 3;
            this.sort_key_btn.Text = "Sort by &Name";
            this.sort_key_btn.UseVisualStyleBackColor = true;
            this.sort_key_btn.Click += new System.EventHandler(this.sort_name_btn_Click);
            // 
            // sort_val_btn
            // 
            this.sort_val_btn.Location = new System.Drawing.Point(281, 123);
            this.sort_val_btn.Name = "sort_val_btn";
            this.sort_val_btn.Size = new System.Drawing.Size(104, 23);
            this.sort_val_btn.TabIndex = 4;
            this.sort_val_btn.Text = "Sort by &Value";
            this.sort_val_btn.UseVisualStyleBackColor = true;
            this.sort_val_btn.Click += new System.EventHandler(this.sort_val_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(281, 152);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 23);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "&Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name/Value Pair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name/Value Pair List";
            // 
            // save_xml_btn
            // 
            this.save_xml_btn.Location = new System.Drawing.Point(281, 181);
            this.save_xml_btn.Name = "save_xml_btn";
            this.save_xml_btn.Size = new System.Drawing.Size(103, 23);
            this.save_xml_btn.TabIndex = 8;
            this.save_xml_btn.Text = "Save as &XML";
            this.save_xml_btn.UseVisualStyleBackColor = true;
            this.save_xml_btn.Click += new System.EventHandler(this.save_xml_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(281, 259);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(103, 23);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "&Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 295);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.save_xml_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.sort_val_btn);
            this.Controls.Add(this.sort_key_btn);
            this.Controls.Add(this.key_value_lstbx);
            this.Controls.Add(this.insert_txtbx);
            this.Controls.Add(this.save_btn);
            this.Name = "Form1";
            this.Text = "Key Value Pair Entry Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox insert_txtbx;
        private System.Windows.Forms.ListBox key_value_lstbx;
        private System.Windows.Forms.Button sort_key_btn;
        private System.Windows.Forms.Button sort_val_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_xml_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

