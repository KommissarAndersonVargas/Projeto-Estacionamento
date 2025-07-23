namespace Projeto_Estacionamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblArriveHour = new TextBox();
            lblArriveMin = new TextBox();
            lblLeftHour = new TextBox();
            lblLeftMin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            imageList1 = new ImageList(components);
            label9 = new Label();
            lblArrivePlot = new TextBox();
            lblLeftPlot = new TextBox();
            label10 = new Label();
            txtBoxGenerateCupon = new TextBox();
            label11 = new Label();
            search = new Button();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            recortarToolStripButton = new ToolStripButton();
            copiarToolStripButton = new ToolStripButton();
            colarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            button4 = new Button();
            button3 = new Button();
            txtSearchText = new TextBox();
            panel3 = new Panel();
            button5 = new Button();
            label17 = new Label();
            label7 = new Label();
            button8 = new Button();
            comboBox1 = new ComboBox();
            analise1 = new TextBox();
            label19 = new Label();
            Calendar = new MonthCalendar();
            label8 = new Label();
            label13 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label14 = new Label();
            label15 = new Label();
            button7 = new Button();
            label16 = new Label();
            label5 = new Label();
            DateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(532, 38);
            label1.Name = "label1";
            label1.Size = new Size(260, 42);
            label1.TabIndex = 0;
            label1.Text = "Parking Lot Super";
            // 
            // lblArriveHour
            // 
            lblArriveHour.Location = new Point(245, 218);
            lblArriveHour.Name = "lblArriveHour";
            lblArriveHour.Size = new Size(61, 23);
            lblArriveHour.TabIndex = 1;
            // 
            // lblArriveMin
            // 
            lblArriveMin.Location = new Point(331, 218);
            lblArriveMin.Name = "lblArriveMin";
            lblArriveMin.Size = new Size(61, 23);
            lblArriveMin.TabIndex = 2;
            // 
            // lblLeftHour
            // 
            lblLeftHour.Location = new Point(472, 218);
            lblLeftHour.Multiline = true;
            lblLeftHour.Name = "lblLeftHour";
            lblLeftHour.Size = new Size(61, 23);
            lblLeftHour.TabIndex = 3;
            // 
            // lblLeftMin
            // 
            lblLeftMin.Location = new Point(562, 218);
            lblLeftMin.Name = "lblLeftMin";
            lblLeftMin.Size = new Size(61, 23);
            lblLeftMin.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(245, 311);
            button1.Name = "button1";
            button1.Size = new Size(147, 31);
            button1.TabIndex = 5;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(472, 311);
            button2.Name = "button2";
            button2.Size = new Size(155, 31);
            button2.TabIndex = 6;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(245, 174);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 7;
            label2.Text = "Horário de entrada ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(481, 174);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Horário de Saida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(200, 221);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Horas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(427, 221);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "Horas";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "p3.jpg");
            imageList1.Images.SetKeyName(1, "avaliacao.png");
            imageList1.Images.SetKeyName(2, "imagepolice.png");
            imageList1.Images.SetKeyName(3, "p4.png");
            imageList1.Images.SetKeyName(4, "prop.png");
            imageList1.Images.SetKeyName(5, "message.png");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(200, 271);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 18;
            label9.Text = "Placa";
            // 
            // lblArrivePlot
            // 
            lblArrivePlot.Location = new Point(245, 268);
            lblArrivePlot.Name = "lblArrivePlot";
            lblArrivePlot.Size = new Size(147, 23);
            lblArrivePlot.TabIndex = 19;
            // 
            // lblLeftPlot
            // 
            lblLeftPlot.Location = new Point(472, 268);
            lblLeftPlot.Name = "lblLeftPlot";
            lblLeftPlot.Size = new Size(151, 23);
            lblLeftPlot.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(427, 271);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 21;
            label10.Text = "Placa";
            // 
            // txtBoxGenerateCupon
            // 
            txtBoxGenerateCupon.Location = new Point(761, 606);
            txtBoxGenerateCupon.Name = "txtBoxGenerateCupon";
            txtBoxGenerateCupon.Size = new Size(475, 23);
            txtBoxGenerateCupon.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(652, 604);
            label11.Name = "label11";
            label11.Size = new Size(103, 21);
            label11.TabIndex = 24;
            label11.Text = "Inserir placa";
            // 
            // search
            // 
            search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(1244, 604);
            search.Name = "search";
            search.Size = new Size(92, 25);
            search.TabIndex = 25;
            search.Text = "Imprimir";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(888, 166);
            label12.Name = "label12";
            label12.Size = new Size(287, 22);
            label12.TabIndex = 26;
            label12.Text = "Registro de Veículos  e Tarifas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(729, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(579, 234);
            dataGridView1.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 144);
            panel1.TabIndex = 28;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, imprimirToolStripButton, toolStripSeparator, recortarToolStripButton, copiarToolStripButton, colarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1374, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 27);
            novaToolStripButton.Text = "&Nova";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 27);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 27);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(23, 27);
            imprimirToolStripButton.Text = "&Imprimir";
            imprimirToolStripButton.Click += imprimirToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 30);
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = (Image)resources.GetObject("recortarToolStripButton.Image");
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 27);
            recortarToolStripButton.Text = "R&ecortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(23, 27);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            colarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colarToolStripButton.Image = (Image)resources.GetObject("colarToolStripButton.Image");
            colarToolStripButton.ImageTransparentColor = Color.Magenta;
            colarToolStripButton.Name = "colarToolStripButton";
            colarToolStripButton.Size = new Size(23, 27);
            colarToolStripButton.Text = "&Colar";
            colarToolStripButton.Click += colarToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 27);
            ajudaToolStripButton.Text = "Aju&da";
            ajudaToolStripButton.Click += ajudaToolStripButton_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources._9043885_automatic_icon;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(9, 60);
            button4.Name = "button4";
            button4.Size = new Size(185, 74);
            button4.TabIndex = 46;
            button4.Text = "Parking Lot Automatic";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1242, 519);
            button3.Name = "button3";
            button3.Size = new Size(94, 24);
            button3.TabIndex = 36;
            button3.Text = "Procurar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // txtSearchText
            // 
            txtSearchText.Location = new Point(761, 519);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.Size = new Size(475, 23);
            txtSearchText.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(analise1);
            panel3.Controls.Add(label19);
            panel3.Location = new Point(-2, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 606);
            panel3.TabIndex = 29;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = Properties.Resources._12052490_suggestion_feedback_rating_review_negative_icon;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(10, 49);
            button5.Name = "button5";
            button5.Size = new Size(184, 74);
            button5.TabIndex = 47;
            button5.Text = "Avaliações";
            button5.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(9, 245);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 49;
            label17.Text = "Filtro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 216);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 42;
            label7.Text = "Horas";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(60, 274);
            button8.Name = "button8";
            button8.Size = new Size(122, 31);
            button8.TabIndex = 44;
            button8.Text = "Aplicar Filtro\r\n";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tempo de Entrada: >", "Tempo de Entrada: <", "Tempo de Entrada: =" });
            comboBox1.Location = new Point(60, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(122, 23);
            comboBox1.TabIndex = 45;
            // 
            // analise1
            // 
            analise1.Location = new Point(60, 216);
            analise1.Name = "analise1";
            analise1.Size = new Size(122, 23);
            analise1.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(90, 181);
            label19.Name = "label19";
            label19.Size = new Size(66, 21);
            label19.TabIndex = 43;
            label19.Text = "Análise";
            // 
            // Calendar
            // 
            Calendar.Location = new Point(228, 479);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(280, 418);
            label8.Name = "label8";
            label8.Size = new Size(125, 22);
            label8.TabIndex = 32;
            label8.Text = "Date Control";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(947, 573);
            label13.Name = "label13";
            label13.Size = new Size(127, 22);
            label13.TabIndex = 33;
            label13.Text = "Gerar Cupon";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(652, 517);
            label14.Name = "label14";
            label14.Size = new Size(103, 21);
            label14.TabIndex = 37;
            label14.Text = "Inserir placa";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(888, 494);
            label15.Name = "label15";
            label15.Size = new Size(253, 22);
            label15.TabIndex = 38;
            label15.Text = "Procurar Placa no Sistema";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(729, 431);
            button7.Name = "button7";
            button7.Size = new Size(579, 38);
            button7.TabIndex = 39;
            button7.Text = "Deletar Item Selecionado";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(314, 221);
            label16.Name = "label16";
            label16.Size = new Size(10, 15);
            label16.TabIndex = 40;
            label16.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(543, 221);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 41;
            label5.Text = ":";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(228, 446);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(227, 23);
            DateTimePicker.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1370, 640);
            Controls.Add(DateTimePicker);
            Controls.Add(label5);
            Controls.Add(label16);
            Controls.Add(button7);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button3);
            Controls.Add(Calendar);
            Controls.Add(label13);
            Controls.Add(txtSearchText);
            Controls.Add(label8);
            Controls.Add(search);
            Controls.Add(label11);
            Controls.Add(txtBoxGenerateCupon);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(lblLeftPlot);
            Controls.Add(lblArrivePlot);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblLeftMin);
            Controls.Add(lblLeftHour);
            Controls.Add(lblArriveMin);
            Controls.Add(lblArriveHour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Parking Lot Super System ";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox lblArriveHour;
        private TextBox lblArriveMin;
        private TextBox lblLeftHour;
        private TextBox lblLeftMin;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label9;
        private TextBox lblArrivePlot;
        private TextBox lblLeftPlot;
        private Label label10;
        private TextBox txtBoxGenerateCupon;
        private Label label11;
        private Button search;
        private Label label12;
        public Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        public ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private Panel panel3;
        private MonthCalendar Calendar;
        private Label label8;
        private Label label13;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private TextBox txtSearchText;
        private Label label14;
        private Label label15;
        private ImageList imageList1;
        private Button button7;
        private TextBox analise1;
        private Label label19;
        private Button button8;
        private ComboBox comboBox1;
        private Button button4;
        private Label label16;
        private Label label5;
        private Label label17;
        private Label label7;
        private Button button5;
        private DateTimePicker DateTimePicker;
    }
}