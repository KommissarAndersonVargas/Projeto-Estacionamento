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
            staticLblMainTitle = new Label();
            txtbArriveHour = new TextBox();
            txtbArriveMin = new TextBox();
            txtbLeftHour = new TextBox();
            txtbLeftMin = new TextBox();
            staticLblTitleIn = new Label();
            staticLblTitleOut = new Label();
            staticLblHoursIn = new Label();
            staticLblHoursOut = new Label();
            imageList1 = new ImageList(components);
            staticLblPlotIn = new Label();
            txtbrrivePlot = new TextBox();
            txtbLeftPlot = new TextBox();
            staticLblPlotOut = new Label();
            txtBoxGenerateCupon = new TextBox();
            staticLblInsertPlot2 = new Label();
            search = new Button();
            staticLblDatagridTitle = new Label();
            dataGridView1 = new DataGridView();
            mainPnl = new Panel();
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
            AutomaticParkingLot = new Button();
            txtSearchText = new TextBox();
            menuPnl = new Panel();
            staticLblTitleDate = new Label();
            Calendar = new MonthCalendar();
            DateTimePicker = new DateTimePicker();
            staticLblGenerateTicktTile = new Label();
            openFileDialog1 = new OpenFileDialog();
            staticLblInsertPlot1 = new Label();
            staticLblSearchPlotTitle = new Label();
            staticLblSymbolHourIn = new Label();
            staticLblSymbolHourOut = new Label();
            addsMainInfo = new Button();
            calculateHours = new Button();
            DeleteItemButton = new Button();
            SerachButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            mainPnl.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuPnl.SuspendLayout();
            SuspendLayout();
            // 
            // staticLblMainTitle
            // 
            staticLblMainTitle.AutoSize = true;
            staticLblMainTitle.BackColor = Color.Transparent;
            staticLblMainTitle.Font = new Font("Sitka Text", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            staticLblMainTitle.ForeColor = Color.Black;
            staticLblMainTitle.Location = new Point(532, 38);
            staticLblMainTitle.Name = "staticLblMainTitle";
            staticLblMainTitle.Size = new Size(260, 42);
            staticLblMainTitle.TabIndex = 0;
            staticLblMainTitle.Text = "Parking Lot Super";
            // 
            // txtbArriveHour
            // 
            txtbArriveHour.Location = new Point(309, 235);
            txtbArriveHour.Name = "txtbArriveHour";
            txtbArriveHour.Size = new Size(61, 23);
            txtbArriveHour.TabIndex = 1;
            // 
            // txtbArriveMin
            // 
            txtbArriveMin.Location = new Point(395, 235);
            txtbArriveMin.Name = "txtbArriveMin";
            txtbArriveMin.Size = new Size(61, 23);
            txtbArriveMin.TabIndex = 2;
            // 
            // txtbLeftHour
            // 
            txtbLeftHour.Location = new Point(536, 235);
            txtbLeftHour.Multiline = true;
            txtbLeftHour.Name = "txtbLeftHour";
            txtbLeftHour.Size = new Size(61, 23);
            txtbLeftHour.TabIndex = 3;
            // 
            // txtbLeftMin
            // 
            txtbLeftMin.Location = new Point(626, 235);
            txtbLeftMin.Name = "txtbLeftMin";
            txtbLeftMin.Size = new Size(61, 23);
            txtbLeftMin.TabIndex = 4;
            // 
            // staticLblTitleIn
            // 
            staticLblTitleIn.AutoSize = true;
            staticLblTitleIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblTitleIn.Location = new Point(309, 191);
            staticLblTitleIn.Name = "staticLblTitleIn";
            staticLblTitleIn.Size = new Size(145, 20);
            staticLblTitleIn.TabIndex = 7;
            staticLblTitleIn.Text = "Horário de entrada ";
            // 
            // staticLblTitleOut
            // 
            staticLblTitleOut.AutoSize = true;
            staticLblTitleOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblTitleOut.Location = new Point(545, 191);
            staticLblTitleOut.Name = "staticLblTitleOut";
            staticLblTitleOut.Size = new Size(124, 20);
            staticLblTitleOut.TabIndex = 8;
            staticLblTitleOut.Text = "Horário de Saida";
            // 
            // staticLblHoursIn
            // 
            staticLblHoursIn.AutoSize = true;
            staticLblHoursIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblHoursIn.Location = new Point(264, 238);
            staticLblHoursIn.Name = "staticLblHoursIn";
            staticLblHoursIn.Size = new Size(39, 15);
            staticLblHoursIn.TabIndex = 10;
            staticLblHoursIn.Text = "Horas";
            // 
            // staticLblHoursOut
            // 
            staticLblHoursOut.AutoSize = true;
            staticLblHoursOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblHoursOut.Location = new Point(491, 238);
            staticLblHoursOut.Name = "staticLblHoursOut";
            staticLblHoursOut.Size = new Size(39, 15);
            staticLblHoursOut.TabIndex = 12;
            staticLblHoursOut.Text = "Horas";
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
            // staticLblPlotIn
            // 
            staticLblPlotIn.AutoSize = true;
            staticLblPlotIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblPlotIn.Location = new Point(264, 288);
            staticLblPlotIn.Name = "staticLblPlotIn";
            staticLblPlotIn.Size = new Size(35, 15);
            staticLblPlotIn.TabIndex = 18;
            staticLblPlotIn.Text = "Placa";
            // 
            // txtbrrivePlot
            // 
            txtbrrivePlot.Location = new Point(309, 285);
            txtbrrivePlot.Name = "txtbrrivePlot";
            txtbrrivePlot.Size = new Size(147, 23);
            txtbrrivePlot.TabIndex = 19;
            // 
            // txtbLeftPlot
            // 
            txtbLeftPlot.Location = new Point(536, 285);
            txtbLeftPlot.Name = "txtbLeftPlot";
            txtbLeftPlot.Size = new Size(151, 23);
            txtbLeftPlot.TabIndex = 20;
            // 
            // staticLblPlotOut
            // 
            staticLblPlotOut.AutoSize = true;
            staticLblPlotOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblPlotOut.Location = new Point(491, 288);
            staticLblPlotOut.Name = "staticLblPlotOut";
            staticLblPlotOut.Size = new Size(35, 15);
            staticLblPlotOut.TabIndex = 21;
            staticLblPlotOut.Text = "Placa";
            // 
            // txtBoxGenerateCupon
            // 
            txtBoxGenerateCupon.Location = new Point(761, 606);
            txtBoxGenerateCupon.Name = "txtBoxGenerateCupon";
            txtBoxGenerateCupon.Size = new Size(475, 23);
            txtBoxGenerateCupon.TabIndex = 23;
            // 
            // staticLblInsertPlot2
            // 
            staticLblInsertPlot2.AutoSize = true;
            staticLblInsertPlot2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblInsertPlot2.Location = new Point(652, 604);
            staticLblInsertPlot2.Name = "staticLblInsertPlot2";
            staticLblInsertPlot2.Size = new Size(103, 21);
            staticLblInsertPlot2.TabIndex = 24;
            staticLblInsertPlot2.Text = "Inserir placa";
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
            // staticLblDatagridTitle
            // 
            staticLblDatagridTitle.AutoSize = true;
            staticLblDatagridTitle.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            staticLblDatagridTitle.Location = new Point(888, 166);
            staticLblDatagridTitle.Name = "staticLblDatagridTitle";
            staticLblDatagridTitle.Size = new Size(287, 22);
            staticLblDatagridTitle.TabIndex = 26;
            staticLblDatagridTitle.Text = "Registro de Veículos  e Tarifas";
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
            // mainPnl
            // 
            mainPnl.BackColor = SystemColors.ControlDarkDark;
            mainPnl.Controls.Add(toolStrip1);
            mainPnl.Controls.Add(staticLblMainTitle);
            mainPnl.Location = new Point(-2, 2);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(1374, 144);
            mainPnl.TabIndex = 28;
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
            // AutomaticParkingLot
            // 
            AutomaticParkingLot.FlatAppearance.BorderSize = 2;
            AutomaticParkingLot.FlatStyle = FlatStyle.Flat;
            AutomaticParkingLot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AutomaticParkingLot.Image = Properties.Resources._9043885_automatic_icon;
            AutomaticParkingLot.ImageAlign = ContentAlignment.MiddleLeft;
            AutomaticParkingLot.Location = new Point(5, 6);
            AutomaticParkingLot.Name = "AutomaticParkingLot";
            AutomaticParkingLot.Size = new Size(236, 74);
            AutomaticParkingLot.TabIndex = 46;
            AutomaticParkingLot.Text = "Parking Lot Automatic";
            AutomaticParkingLot.TextAlign = ContentAlignment.MiddleRight;
            AutomaticParkingLot.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            txtSearchText.Location = new Point(761, 519);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.Size = new Size(475, 23);
            txtSearchText.TabIndex = 36;
            // 
            // menuPnl
            // 
            menuPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menuPnl.BackColor = SystemColors.ControlDarkDark;
            menuPnl.Controls.Add(AutomaticParkingLot);
            menuPnl.Controls.Add(staticLblTitleDate);
            menuPnl.Controls.Add(Calendar);
            menuPnl.Controls.Add(DateTimePicker);
            menuPnl.Location = new Point(-2, 142);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(247, 548);
            menuPnl.TabIndex = 29;
            // 
            // staticLblTitleDate
            // 
            staticLblTitleDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            staticLblTitleDate.AutoSize = true;
            staticLblTitleDate.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            staticLblTitleDate.Location = new Point(40, 317);
            staticLblTitleDate.Name = "staticLblTitleDate";
            staticLblTitleDate.Size = new Size(164, 22);
            staticLblTitleDate.TabIndex = 32;
            staticLblTitleDate.Text = "Controle de Data";
            // 
            // Calendar
            // 
            Calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Calendar.Location = new Point(9, 377);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 31;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DateTimePicker.Location = new Point(9, 342);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(227, 23);
            DateTimePicker.TabIndex = 42;
            // 
            // staticLblGenerateTicktTile
            // 
            staticLblGenerateTicktTile.AutoSize = true;
            staticLblGenerateTicktTile.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            staticLblGenerateTicktTile.Location = new Point(947, 573);
            staticLblGenerateTicktTile.Name = "staticLblGenerateTicktTile";
            staticLblGenerateTicktTile.Size = new Size(127, 22);
            staticLblGenerateTicktTile.TabIndex = 33;
            staticLblGenerateTicktTile.Text = "Gerar Cupon";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // staticLblInsertPlot1
            // 
            staticLblInsertPlot1.AutoSize = true;
            staticLblInsertPlot1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblInsertPlot1.Location = new Point(652, 517);
            staticLblInsertPlot1.Name = "staticLblInsertPlot1";
            staticLblInsertPlot1.Size = new Size(103, 21);
            staticLblInsertPlot1.TabIndex = 37;
            staticLblInsertPlot1.Text = "Inserir placa";
            // 
            // staticLblSearchPlotTitle
            // 
            staticLblSearchPlotTitle.AutoSize = true;
            staticLblSearchPlotTitle.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            staticLblSearchPlotTitle.Location = new Point(888, 494);
            staticLblSearchPlotTitle.Name = "staticLblSearchPlotTitle";
            staticLblSearchPlotTitle.Size = new Size(253, 22);
            staticLblSearchPlotTitle.TabIndex = 38;
            staticLblSearchPlotTitle.Text = "Procurar Placa no Sistema";
            // 
            // staticLblSymbolHourIn
            // 
            staticLblSymbolHourIn.AutoSize = true;
            staticLblSymbolHourIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblSymbolHourIn.Location = new Point(378, 238);
            staticLblSymbolHourIn.Name = "staticLblSymbolHourIn";
            staticLblSymbolHourIn.Size = new Size(10, 15);
            staticLblSymbolHourIn.TabIndex = 40;
            staticLblSymbolHourIn.Text = ":";
            // 
            // staticLblSymbolHourOut
            // 
            staticLblSymbolHourOut.AutoSize = true;
            staticLblSymbolHourOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            staticLblSymbolHourOut.Location = new Point(607, 238);
            staticLblSymbolHourOut.Name = "staticLblSymbolHourOut";
            staticLblSymbolHourOut.Size = new Size(10, 15);
            staticLblSymbolHourOut.TabIndex = 41;
            staticLblSymbolHourOut.Text = ":";
            // 
            // addsMainInfo
            // 
            addsMainInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addsMainInfo.Location = new Point(309, 328);
            addsMainInfo.Name = "addsMainInfo";
            addsMainInfo.Size = new Size(147, 31);
            addsMainInfo.TabIndex = 43;
            addsMainInfo.Text = "Registrar";
            addsMainInfo.UseVisualStyleBackColor = true;
            addsMainInfo.Click += addsMainInfo_Click;
            // 
            // calculateHours
            // 
            calculateHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            calculateHours.Location = new Point(536, 328);
            calculateHours.Name = "calculateHours";
            calculateHours.Size = new Size(151, 31);
            calculateHours.TabIndex = 44;
            calculateHours.Text = "Registrar";
            calculateHours.UseVisualStyleBackColor = true;
            calculateHours.Click += calculateHours_Click;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteItemButton.Location = new Point(729, 439);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(579, 38);
            DeleteItemButton.TabIndex = 45;
            DeleteItemButton.Text = "Deletar Seleção\r\n";
            DeleteItemButton.UseVisualStyleBackColor = true;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // SerachButton
            // 
            SerachButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SerachButton.Location = new Point(1242, 517);
            SerachButton.Name = "SerachButton";
            SerachButton.Size = new Size(94, 24);
            SerachButton.TabIndex = 46;
            SerachButton.Text = "Procurar";
            SerachButton.UseVisualStyleBackColor = true;
            SerachButton.Click += SerachButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1370, 687);
            Controls.Add(SerachButton);
            Controls.Add(DeleteItemButton);
            Controls.Add(menuPnl);
            Controls.Add(calculateHours);
            Controls.Add(addsMainInfo);
            Controls.Add(staticLblSymbolHourOut);
            Controls.Add(staticLblSymbolHourIn);
            Controls.Add(staticLblSearchPlotTitle);
            Controls.Add(staticLblInsertPlot1);
            Controls.Add(staticLblGenerateTicktTile);
            Controls.Add(txtSearchText);
            Controls.Add(search);
            Controls.Add(staticLblInsertPlot2);
            Controls.Add(txtBoxGenerateCupon);
            Controls.Add(mainPnl);
            Controls.Add(dataGridView1);
            Controls.Add(staticLblDatagridTitle);
            Controls.Add(staticLblPlotOut);
            Controls.Add(txtbLeftPlot);
            Controls.Add(txtbrrivePlot);
            Controls.Add(staticLblPlotIn);
            Controls.Add(staticLblHoursOut);
            Controls.Add(staticLblHoursIn);
            Controls.Add(staticLblTitleOut);
            Controls.Add(staticLblTitleIn);
            Controls.Add(txtbLeftMin);
            Controls.Add(txtbLeftHour);
            Controls.Add(txtbArriveMin);
            Controls.Add(txtbArriveHour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Parking Lot Super System ";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            mainPnl.ResumeLayout(false);
            mainPnl.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuPnl.ResumeLayout(false);
            menuPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtbArriveHour;
        private TextBox txtbArriveMin;
        private TextBox txtbLeftHour;
        private TextBox txtbLeftMin;
        private Label staticLblTitleIn;
        private Label staticLblTitleOut;
        private Label staticLblHoursIn;
        private Label staticLblHoursOut;
        private Label staticLblPlotIn;
        private TextBox txtbrrivePlot;
        private TextBox txtbLeftPlot;
        private Label staticLblPlotOut;
        private TextBox txtBoxGenerateCupon;
        private Label staticLblInsertPlot2;
        private Button search;
        private Label staticLblDatagridTitle;
        public Label staticLblMainTitle;
        private DataGridView dataGridView1;
        private Panel mainPnl;
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
        private Panel menuPnl;
        private MonthCalendar Calendar;
        private Label staticLblTitleDate;
        private Label staticLblGenerateTicktTile;
        private OpenFileDialog openFileDialog1;
        private TextBox txtSearchText;
        private Label staticLblInsertPlot1;
        private Label staticLblSearchPlotTitle;
        private ImageList imageList1;
        private Button AutomaticParkingLot;
        private Label staticLblSymbolHourIn;
        private Label staticLblSymbolHourOut;
        private DateTimePicker DateTimePicker;
        private Button addsMainInfo;
        private Button calculateHours;
        private Button DeleteItemButton;
        private Button SerachButton;
    }
}