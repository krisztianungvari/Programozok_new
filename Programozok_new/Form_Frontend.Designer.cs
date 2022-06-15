
namespace Programozok_new
{
    partial class Form_Frontend
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_frontNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_frontTapasztalat = new System.Windows.Forms.NumericUpDown();
            this.num_frontFizetes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_frontHtml = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_frontCss = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_frontJavascript = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button_frontHozzaadas = new System.Windows.Forms.Button();
            this.button_toHTML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontTapasztalat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontFizetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontHtml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontCss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontJavascript)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_toHTML);
            this.groupBox1.Controls.Add(this.button_frontHozzaadas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.num_frontJavascript);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.num_frontCss);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_frontHtml);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_frontFizetes);
            this.groupBox1.Controls.Add(this.num_frontTapasztalat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_frontNev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frontendes hozzáadása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neve";
            // 
            // textBox_frontNev
            // 
            this.textBox_frontNev.Location = new System.Drawing.Point(207, 20);
            this.textBox_frontNev.Name = "textBox_frontNev";
            this.textBox_frontNev.Size = new System.Drawing.Size(120, 20);
            this.textBox_frontNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tapasztalat";
            // 
            // num_frontTapasztalat
            // 
            this.num_frontTapasztalat.Location = new System.Drawing.Point(207, 53);
            this.num_frontTapasztalat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_frontTapasztalat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_frontTapasztalat.Name = "num_frontTapasztalat";
            this.num_frontTapasztalat.Size = new System.Drawing.Size(120, 20);
            this.num_frontTapasztalat.TabIndex = 3;
            this.num_frontTapasztalat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_frontFizetes
            // 
            this.num_frontFizetes.Location = new System.Drawing.Point(207, 80);
            this.num_frontFizetes.Name = "num_frontFizetes";
            this.num_frontFizetes.ReadOnly = true;
            this.num_frontFizetes.Size = new System.Drawing.Size(120, 20);
            this.num_frontFizetes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Havi fizetés";
            // 
            // num_frontHtml
            // 
            this.num_frontHtml.Location = new System.Drawing.Point(207, 123);
            this.num_frontHtml.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_frontHtml.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_frontHtml.Name = "num_frontHtml";
            this.num_frontHtml.Size = new System.Drawing.Size(120, 20);
            this.num_frontHtml.TabIndex = 6;
            this.num_frontHtml.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HTML ismeret";
            // 
            // num_frontCss
            // 
            this.num_frontCss.Location = new System.Drawing.Point(207, 173);
            this.num_frontCss.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_frontCss.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_frontCss.Name = "num_frontCss";
            this.num_frontCss.Size = new System.Drawing.Size(120, 20);
            this.num_frontCss.TabIndex = 8;
            this.num_frontCss.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CSS ismeret";
            // 
            // num_frontJavascript
            // 
            this.num_frontJavascript.Location = new System.Drawing.Point(207, 217);
            this.num_frontJavascript.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_frontJavascript.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_frontJavascript.Name = "num_frontJavascript";
            this.num_frontJavascript.Size = new System.Drawing.Size(120, 20);
            this.num_frontJavascript.TabIndex = 10;
            this.num_frontJavascript.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "JavaScript ismeret";
            // 
            // button_frontHozzaadas
            // 
            this.button_frontHozzaadas.Location = new System.Drawing.Point(9, 269);
            this.button_frontHozzaadas.Name = "button_frontHozzaadas";
            this.button_frontHozzaadas.Size = new System.Drawing.Size(312, 23);
            this.button_frontHozzaadas.TabIndex = 12;
            this.button_frontHozzaadas.Text = "Új Frontendes felvitele";
            this.button_frontHozzaadas.UseVisualStyleBackColor = true;
            this.button_frontHozzaadas.Click += new System.EventHandler(this.button_frontHozzaadas_Click);
            // 
            // button_toHTML
            // 
            this.button_toHTML.Location = new System.Drawing.Point(9, 298);
            this.button_toHTML.Name = "button_toHTML";
            this.button_toHTML.Size = new System.Drawing.Size(312, 23);
            this.button_toHTML.TabIndex = 13;
            this.button_toHTML.Text = "Mentés HTML-be";
            this.button_toHTML.UseVisualStyleBackColor = true;
            this.button_toHTML.Click += new System.EventHandler(this.button_toHTML_Click);
            // 
            // Form_Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Frontend";
            this.Text = "Form_Frontend";
            this.Load += new System.EventHandler(this.Form_Frontend_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontTapasztalat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontFizetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontHtml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontCss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_frontJavascript)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_frontTapasztalat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_frontNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_toHTML;
        private System.Windows.Forms.Button button_frontHozzaadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_frontJavascript;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_frontCss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_frontHtml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_frontFizetes;
    }
}