namespace Aula03_jaq
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN = new System.Windows.Forms.Label();
            this.txtbn = new System.Windows.Forms.TextBox();
            this.gbxP = new System.Windows.Forms.GroupBox();
            this.rdbPI = new System.Windows.Forms.RadioButton();
            this.rdbpf = new System.Windows.Forms.RadioButton();
            this.gbxC = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.gpbComp = new System.Windows.Forms.GroupBox();
            this.ckbM = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbP = new System.Windows.Forms.CheckBox();
            this.ckbT = new System.Windows.Forms.CheckBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.gbxP.SuspendLayout();
            this.gbxC.SuspendLayout();
            this.gpbComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(40, 33);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(100, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Nome do Cliente:";
            // 
            // txtbn
            // 
            this.txtbn.Location = new System.Drawing.Point(146, 30);
            this.txtbn.Name = "txtbn";
            this.txtbn.Size = new System.Drawing.Size(190, 23);
            this.txtbn.TabIndex = 1;
            // 
            // gbxP
            // 
            this.gbxP.Controls.Add(this.rdbPI);
            this.gbxP.Controls.Add(this.rdbpf);
            this.gbxP.Location = new System.Drawing.Point(46, 76);
            this.gbxP.Name = "gbxP";
            this.gbxP.Size = new System.Drawing.Size(290, 100);
            this.gbxP.TabIndex = 2;
            this.gbxP.TabStop = false;
            this.gbxP.Text = "Pão";
            // 
            // rdbPI
            // 
            this.rdbPI.AutoSize = true;
            this.rdbPI.Location = new System.Drawing.Point(152, 41);
            this.rdbPI.Name = "rdbPI";
            this.rdbPI.Size = new System.Drawing.Size(88, 19);
            this.rdbPI.TabIndex = 1;
            this.rdbPI.TabStop = true;
            this.rdbPI.Text = "Pão integral";
            this.rdbPI.UseVisualStyleBackColor = true;
            // 
            // rdbpf
            // 
            this.rdbpf.AutoSize = true;
            this.rdbpf.Location = new System.Drawing.Point(26, 41);
            this.rdbpf.Name = "rdbpf";
            this.rdbpf.Size = new System.Drawing.Size(98, 19);
            this.rdbpf.TabIndex = 0;
            this.rdbpf.TabStop = true;
            this.rdbpf.Text = "Pão de Forma";
            this.rdbpf.UseVisualStyleBackColor = true;
            // 
            // gbxC
            // 
            this.gbxC.Controls.Add(this.rdbF);
            this.gbxC.Controls.Add(this.rdbB);
            this.gbxC.Location = new System.Drawing.Point(46, 230);
            this.gbxC.Name = "gbxC";
            this.gbxC.Size = new System.Drawing.Size(290, 100);
            this.gbxC.TabIndex = 3;
            this.gbxC.TabStop = false;
            this.gbxC.Text = "Carne";
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(152, 41);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(62, 19);
            this.rdbF.TabIndex = 1;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "Frango";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(26, 41);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(61, 19);
            this.rdbB.TabIndex = 0;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "Bovina";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // gpbComp
            // 
            this.gpbComp.Controls.Add(this.ckbM);
            this.gpbComp.Controls.Add(this.ckbC);
            this.gpbComp.Controls.Add(this.ckbP);
            this.gpbComp.Controls.Add(this.ckbT);
            this.gpbComp.Location = new System.Drawing.Point(417, 76);
            this.gpbComp.Name = "gpbComp";
            this.gpbComp.Size = new System.Drawing.Size(170, 254);
            this.gpbComp.TabIndex = 4;
            this.gpbComp.TabStop = false;
            this.gpbComp.Text = "Complementos";
            // 
            // ckbM
            // 
            this.ckbM.AutoSize = true;
            this.ckbM.Location = new System.Drawing.Point(22, 196);
            this.ckbM.Name = "ckbM";
            this.ckbM.Size = new System.Drawing.Size(105, 19);
            this.ckbM.TabIndex = 3;
            this.ckbM.Text = "Molho da Casa";
            this.ckbM.UseVisualStyleBackColor = true;
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.Location = new System.Drawing.Point(22, 144);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(63, 19);
            this.ckbC.TabIndex = 2;
            this.ckbC.Text = "Cebola";
            this.ckbC.UseVisualStyleBackColor = true;
            // 
            // ckbP
            // 
            this.ckbP.AutoSize = true;
            this.ckbP.Location = new System.Drawing.Point(22, 94);
            this.ckbP.Name = "ckbP";
            this.ckbP.Size = new System.Drawing.Size(56, 19);
            this.ckbP.TabIndex = 1;
            this.ckbP.Text = "Picles";
            this.ckbP.UseVisualStyleBackColor = true;
            // 
            // ckbT
            // 
            this.ckbT.AutoSize = true;
            this.ckbT.Location = new System.Drawing.Point(22, 41);
            this.ckbT.Name = "ckbT";
            this.ckbT.Size = new System.Drawing.Size(65, 19);
            this.ckbT.TabIndex = 0;
            this.ckbT.Text = "Tomate";
            this.ckbT.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(617, 272);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(107, 58);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Pedido Fechado";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(46, 366);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(47, 15);
            this.lblP.TabIndex = 6;
            this.lblP.Text = "Pedido:";
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(617, 338);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(107, 43);
            this.btnP.TabIndex = 7;
            this.btnP.Text = "Pesquisa";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 414);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpbComp);
            this.Controls.Add(this.gbxC);
            this.Controls.Add(this.gbxP);
            this.Controls.Add(this.txtbn);
            this.Controls.Add(this.lblN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxP.ResumeLayout(false);
            this.gbxP.PerformLayout();
            this.gbxC.ResumeLayout(false);
            this.gbxC.PerformLayout();
            this.gpbComp.ResumeLayout(false);
            this.gpbComp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblN;
        private TextBox txtbn;
        private GroupBox gbxP;
        private RadioButton rdbPI;
        private RadioButton rdbpf;
        private GroupBox gbxC;
        private RadioButton rdbF;
        private RadioButton rdbB;
        private GroupBox gpbComp;
        private CheckBox ckbM;
        private CheckBox ckbC;
        private CheckBox ckbP;
        private CheckBox ckbT;
        private Button btnFechar;
        private Label lblP;
        private Button btnP;
    }
}