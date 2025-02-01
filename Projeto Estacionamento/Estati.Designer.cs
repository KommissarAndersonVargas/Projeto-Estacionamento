namespace Projeto_Estacionamento
{
    partial class Estati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estati));
            listBox1 = new ListBox();
            panel1 = new Panel();
            button2 = new Button();
            label3 = new Label();
            export_to_pdf = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            percentLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ButtonShadow;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(453, 454);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(export_to_pdf);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 74);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.excel;
            button2.Location = new Point(99, 12);
            button2.Name = "button2";
            button2.Size = new Size(68, 50);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(234, 9);
            label3.Name = "label3";
            label3.Size = new Size(306, 26);
            label3.TabIndex = 4;
            label3.Text = "Parking Lot System Analisys";
            // 
            // export_to_pdf
            // 
            export_to_pdf.FlatAppearance.BorderSize = 0;
            export_to_pdf.FlatStyle = FlatStyle.Flat;
            export_to_pdf.Image = Properties.Resources._4373076_adobe_file_logo_logos_pdf_icon;
            export_to_pdf.Location = new Point(3, 9);
            export_to_pdf.Name = "export_to_pdf";
            export_to_pdf.Size = new Size(81, 55);
            export_to_pdf.TabIndex = 0;
            export_to_pdf.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(471, 151);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 5;
            label2.Text = "value";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Gray;
            progressBar1.Location = new Point(471, 107);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(247, 41);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(471, 81);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 7;
            label4.Text = "Analise de caso";
            // 
            // percentLabel
            // 
            percentLabel.AutoSize = true;
            percentLabel.BackColor = Color.Transparent;
            percentLabel.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            percentLabel.Location = new Point(586, 167);
            percentLabel.Name = "percentLabel";
            percentLabel.Size = new Size(40, 16);
            percentLabel.TabIndex = 8;
            percentLabel.Text = "0,0%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(471, 167);
            label1.Name = "label1";
            label1.Size = new Size(109, 16);
            label1.TabIndex = 9;
            label1.Text = "Valor percentual:\r\n";
            // 
            // Estati
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(770, 552);
            Controls.Add(label1);
            Controls.Add(percentLabel);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Estati";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estati";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private ProgressBar progressBar1;
        private Label label4;
        private Button button2;
        private Button export_to_pdf;
        private Label percentLabel;
        private Label label1;
    }
}