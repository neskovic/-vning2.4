namespace Övning2._4
{
    partial class FrmClipArt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLinje = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnTriangel = new System.Windows.Forms.Button();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFigurLista = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lbxFigurLista = new System.Windows.Forms.ListBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLinje);
            this.groupBox1.Controls.Add(this.btnCirkel);
            this.groupBox1.Controls.Add(this.btnTriangel);
            this.groupBox1.Controls.Add(this.tbxHöjd);
            this.groupBox1.Controls.Add(this.tbxBredd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa";
            // 
            // btnLinje
            // 
            this.btnLinje.Location = new System.Drawing.Point(63, 223);
            this.btnLinje.Name = "btnLinje";
            this.btnLinje.Size = new System.Drawing.Size(142, 29);
            this.btnLinje.TabIndex = 10;
            this.btnLinje.Text = "Skapa Linje";
            this.btnLinje.UseVisualStyleBackColor = true;
            this.btnLinje.Click += new System.EventHandler(this.BtnLinje_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(63, 181);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(142, 26);
            this.btnCirkel.TabIndex = 9;
            this.btnCirkel.Text = "Skapa Cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.BtnCirkel_Click);
            // 
            // btnTriangel
            // 
            this.btnTriangel.Location = new System.Drawing.Point(63, 137);
            this.btnTriangel.Name = "btnTriangel";
            this.btnTriangel.Size = new System.Drawing.Size(142, 28);
            this.btnTriangel.TabIndex = 8;
            this.btnTriangel.Text = "Skapa Triangel";
            this.btnTriangel.UseVisualStyleBackColor = true;
            this.btnTriangel.Click += new System.EventHandler(this.BtnTriangel_Click);
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(63, 83);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(142, 26);
            this.tbxHöjd.TabIndex = 6;
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(63, 38);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(142, 26);
            this.tbxBredd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Höjd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bredd";
            // 
            // lblFigurLista
            // 
            this.lblFigurLista.AutoSize = true;
            this.lblFigurLista.Location = new System.Drawing.Point(298, 38);
            this.lblFigurLista.Name = "lblFigurLista";
            this.lblFigurLista.Size = new System.Drawing.Size(79, 20);
            this.lblFigurLista.TabIndex = 3;
            this.lblFigurLista.Text = "FigurLista";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(298, 317);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(139, 20);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Sammanlagd area";
            // 
            // lbxFigurLista
            // 
            this.lbxFigurLista.FormattingEnabled = true;
            this.lbxFigurLista.ItemHeight = 20;
            this.lbxFigurLista.Location = new System.Drawing.Point(302, 66);
            this.lbxFigurLista.Name = "lbxFigurLista";
            this.lbxFigurLista.Size = new System.Drawing.Size(214, 244);
            this.lbxFigurLista.TabIndex = 5;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(302, 340);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(145, 26);
            this.tbxArea.TabIndex = 7;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(75, 340);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(152, 26);
            this.btnArea.TabIndex = 11;
            this.btnArea.Text = "Sammanlagd area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // frmClipArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 412);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.lbxFigurLista);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblFigurLista);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClipArt";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLinje;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Button btnTriangel;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFigurLista;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ListBox lbxFigurLista;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Button btnArea;
    }
}

