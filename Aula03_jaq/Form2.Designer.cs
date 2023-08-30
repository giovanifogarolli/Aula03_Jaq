namespace Aula03_jaq
{
    partial class Form2
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
            this.txtbn = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbn
            // 
            this.txtbn.Location = new System.Drawing.Point(118, 17);
            this.txtbn.Name = "txtbn";
            this.txtbn.Size = new System.Drawing.Size(190, 23);
            this.txtbn.TabIndex = 3;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 20);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(100, 15);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Nome do Cliente:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 244);
            this.listBox1.TabIndex = 4;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(508, 203);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 5;
            this.btnP.Text = "Pesquisar";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtbn);
            this.Controls.Add(this.lblN);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbn;
        private Label lblN;
        private ListBox listBox1;
        private Button btnP;
    }
}