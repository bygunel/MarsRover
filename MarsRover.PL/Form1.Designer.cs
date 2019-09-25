namespace MarsRover.PL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdo_E = new System.Windows.Forms.RadioButton();
            this.rdo_W = new System.Windows.Forms.RadioButton();
            this.rdo_N = new System.Windows.Forms.RadioButton();
            this.rdo_S = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_MovementDirectives = new System.Windows.Forms.RichTextBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.txt_MapMaxX = new System.Windows.Forms.NumericUpDown();
            this.txt_MapMaxY = new System.Windows.Forms.NumericUpDown();
            this.txt_RbtFirstX = new System.Windows.Forms.NumericUpDown();
            this.txt_RbtFirstY = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MapMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MapMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RbtFirstX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RbtFirstY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MapMaxY);
            this.groupBox1.Controls.Add(this.txt_MapMaxX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The upper-right coordinates ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_S);
            this.groupBox2.Controls.Add(this.txt_RbtFirstY);
            this.groupBox2.Controls.Add(this.txt_RbtFirstX);
            this.groupBox2.Controls.Add(this.rdo_N);
            this.groupBox2.Controls.Add(this.rdo_W);
            this.groupBox2.Controls.Add(this.rdo_E);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First location of robot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "X :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Y :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direction :";
            // 
            // rdo_E
            // 
            this.rdo_E.AutoSize = true;
            this.rdo_E.Checked = true;
            this.rdo_E.Location = new System.Drawing.Point(99, 82);
            this.rdo_E.Name = "rdo_E";
            this.rdo_E.Size = new System.Drawing.Size(35, 23);
            this.rdo_E.TabIndex = 7;
            this.rdo_E.TabStop = true;
            this.rdo_E.Text = "E";
            this.rdo_E.UseVisualStyleBackColor = true;
            // 
            // rdo_W
            // 
            this.rdo_W.AutoSize = true;
            this.rdo_W.Location = new System.Drawing.Point(140, 82);
            this.rdo_W.Name = "rdo_W";
            this.rdo_W.Size = new System.Drawing.Size(41, 23);
            this.rdo_W.TabIndex = 8;
            this.rdo_W.Text = "W";
            this.rdo_W.UseVisualStyleBackColor = true;
            // 
            // rdo_N
            // 
            this.rdo_N.AutoSize = true;
            this.rdo_N.Location = new System.Drawing.Point(187, 82);
            this.rdo_N.Name = "rdo_N";
            this.rdo_N.Size = new System.Drawing.Size(37, 23);
            this.rdo_N.TabIndex = 9;
            this.rdo_N.Text = "N";
            this.rdo_N.UseVisualStyleBackColor = true;
            // 
            // rdo_S
            // 
            this.rdo_S.AutoSize = true;
            this.rdo_S.Location = new System.Drawing.Point(230, 82);
            this.rdo_S.Name = "rdo_S";
            this.rdo_S.Size = new System.Drawing.Size(34, 23);
            this.rdo_S.TabIndex = 10;
            this.rdo_S.Text = "S";
            this.rdo_S.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_MovementDirectives);
            this.groupBox3.Location = new System.Drawing.Point(340, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 185);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movement Directives";
            // 
            // txt_MovementDirectives
            // 
            this.txt_MovementDirectives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MovementDirectives.Location = new System.Drawing.Point(3, 23);
            this.txt_MovementDirectives.Name = "txt_MovementDirectives";
            this.txt_MovementDirectives.ShortcutsEnabled = false;
            this.txt_MovementDirectives.Size = new System.Drawing.Size(316, 159);
            this.txt_MovementDirectives.TabIndex = 12;
            this.txt_MovementDirectives.Text = "";
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(343, 205);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(319, 42);
            this.btn_Result.TabIndex = 13;
            this.btn_Result.Text = "RESULT";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // txt_MapMaxX
            // 
            this.txt_MapMaxX.Location = new System.Drawing.Point(48, 41);
            this.txt_MapMaxX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_MapMaxX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_MapMaxX.Name = "txt_MapMaxX";
            this.txt_MapMaxX.Size = new System.Drawing.Size(100, 27);
            this.txt_MapMaxX.TabIndex = 2;
            this.txt_MapMaxX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_MapMaxY
            // 
            this.txt_MapMaxY.Location = new System.Drawing.Point(200, 41);
            this.txt_MapMaxY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_MapMaxY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_MapMaxY.Name = "txt_MapMaxY";
            this.txt_MapMaxY.Size = new System.Drawing.Size(100, 27);
            this.txt_MapMaxY.TabIndex = 3;
            this.txt_MapMaxY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_RbtFirstX
            // 
            this.txt_RbtFirstX.Location = new System.Drawing.Point(48, 41);
            this.txt_RbtFirstX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_RbtFirstX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_RbtFirstX.Name = "txt_RbtFirstX";
            this.txt_RbtFirstX.Size = new System.Drawing.Size(100, 27);
            this.txt_RbtFirstX.TabIndex = 5;
            this.txt_RbtFirstX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_RbtFirstY
            // 
            this.txt_RbtFirstY.Location = new System.Drawing.Point(200, 41);
            this.txt_RbtFirstY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_RbtFirstY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_RbtFirstY.Name = "txt_RbtFirstY";
            this.txt_RbtFirstY.Size = new System.Drawing.Size(100, 27);
            this.txt_RbtFirstY.TabIndex = 6;
            this.txt_RbtFirstY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 260);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(692, 299);
            this.MinimumSize = new System.Drawing.Size(692, 299);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mars Rover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MapMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MapMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RbtFirstX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RbtFirstY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_S;
        private System.Windows.Forms.RadioButton rdo_N;
        private System.Windows.Forms.RadioButton rdo_W;
        private System.Windows.Forms.RadioButton rdo_E;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txt_MovementDirectives;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.NumericUpDown txt_MapMaxY;
        private System.Windows.Forms.NumericUpDown txt_MapMaxX;
        private System.Windows.Forms.NumericUpDown txt_RbtFirstY;
        private System.Windows.Forms.NumericUpDown txt_RbtFirstX;
    }
}

