
namespace Programozok_new
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_Programozok = new System.Windows.Forms.ListBox();
            this.button_ujFrontend = new System.Windows.Forms.Button();
            this.button_ujBackend = new System.Windows.Forms.Button();
            this.button_ujFullstack = new System.Windows.Forms.Button();
            this.button_mentesCSV = new System.Windows.Forms.Button();
            this.button_mentesHTML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_mentesHTML);
            this.groupBox1.Controls.Add(this.button_mentesCSV);
            this.groupBox1.Controls.Add(this.button_ujFullstack);
            this.groupBox1.Controls.Add(this.button_ujBackend);
            this.groupBox1.Controls.Add(this.button_ujFrontend);
            this.groupBox1.Controls.Add(this.listBox_Programozok);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programozók";
            // 
            // listBox_Programozok
            // 
            this.listBox_Programozok.FormattingEnabled = true;
            this.listBox_Programozok.Location = new System.Drawing.Point(16, 20);
            this.listBox_Programozok.Name = "listBox_Programozok";
            this.listBox_Programozok.Size = new System.Drawing.Size(472, 225);
            this.listBox_Programozok.TabIndex = 0;
            this.listBox_Programozok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Programozok_MouseDoubleClick);
            // 
            // button_ujFrontend
            // 
            this.button_ujFrontend.Location = new System.Drawing.Point(16, 252);
            this.button_ujFrontend.Name = "button_ujFrontend";
            this.button_ujFrontend.Size = new System.Drawing.Size(472, 23);
            this.button_ujFrontend.TabIndex = 1;
            this.button_ujFrontend.Text = "Új Frontendes";
            this.button_ujFrontend.UseVisualStyleBackColor = true;
            this.button_ujFrontend.Click += new System.EventHandler(this.button_ujFrontend_Click);
            // 
            // button_ujBackend
            // 
            this.button_ujBackend.Location = new System.Drawing.Point(16, 282);
            this.button_ujBackend.Name = "button_ujBackend";
            this.button_ujBackend.Size = new System.Drawing.Size(472, 23);
            this.button_ujBackend.TabIndex = 2;
            this.button_ujBackend.Text = "Új Backendes";
            this.button_ujBackend.UseVisualStyleBackColor = true;
            this.button_ujBackend.Click += new System.EventHandler(this.button_ujBackend_Click);
            // 
            // button_ujFullstack
            // 
            this.button_ujFullstack.Location = new System.Drawing.Point(16, 312);
            this.button_ujFullstack.Name = "button_ujFullstack";
            this.button_ujFullstack.Size = new System.Drawing.Size(472, 23);
            this.button_ujFullstack.TabIndex = 3;
            this.button_ujFullstack.Text = "Új Fullstackes";
            this.button_ujFullstack.UseVisualStyleBackColor = true;
            this.button_ujFullstack.Click += new System.EventHandler(this.button_ujFullstack_Click);
            // 
            // button_mentesCSV
            // 
            this.button_mentesCSV.Location = new System.Drawing.Point(16, 342);
            this.button_mentesCSV.Name = "button_mentesCSV";
            this.button_mentesCSV.Size = new System.Drawing.Size(194, 23);
            this.button_mentesCSV.TabIndex = 4;
            this.button_mentesCSV.Text = "Mentés CSV";
            this.button_mentesCSV.UseVisualStyleBackColor = true;
            // 
            // button_mentesHTML
            // 
            this.button_mentesHTML.Location = new System.Drawing.Point(16, 372);
            this.button_mentesHTML.Name = "button_mentesHTML";
            this.button_mentesHTML.Size = new System.Drawing.Size(194, 23);
            this.button_mentesHTML.TabIndex = 5;
            this.button_mentesHTML.Text = "Exportálás HTML";
            this.button_mentesHTML.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_mentesHTML;
        private System.Windows.Forms.Button button_mentesCSV;
        private System.Windows.Forms.Button button_ujFullstack;
        private System.Windows.Forms.Button button_ujBackend;
        private System.Windows.Forms.Button button_ujFrontend;
        public System.Windows.Forms.ListBox listBox_Programozok;
    }
}

