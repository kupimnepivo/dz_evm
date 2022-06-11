namespace dz_evm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunButton = new System.Windows.Forms.Button();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChoiceBox = new System.Windows.Forms.ComboBox();
            this.AlphaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnterBox_1 = new System.Windows.Forms.TextBox();
            this.OKButton_1 = new System.Windows.Forms.Button();
            this.ResultBox_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnterBox_2 = new System.Windows.Forms.TextBox();
            this.OKButton_2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultBox_2 = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EntropyTextBox = new System.Windows.Forms.TextBox();
            this.MostOftenTextBox = new System.Windows.Forms.TextBox();
            this.LessOftenTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FrequancySumTextBox = new System.Windows.Forms.TextBox();
            this.CalculateLaba3Button = new System.Windows.Forms.Button();
            this.InputLaba3TextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LetterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrequancyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AlphaLaba4TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BettaLaba4TextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ResultLaba4TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.INCbutton = new System.Windows.Forms.Button();
            this.SUBbutton = new System.Windows.Forms.Button();
            this.DECbutton = new System.Windows.Forms.Button();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.ADCbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(9, 76);
            this.SeedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(156, 20);
            this.SeedTextBox.TabIndex = 0;
            this.SeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seed:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(363, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(285, 379);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.DarkOrange;
            this.RunButton.FlatAppearance.BorderSize = 0;
            this.RunButton.Location = new System.Drawing.Point(283, 118);
            this.RunButton.Margin = new System.Windows.Forms.Padding(2);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(56, 24);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(200, 76);
            this.MinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(57, 20);
            this.MinTextBox.TabIndex = 4;
            this.MinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(284, 76);
            this.MaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(53, 20);
            this.MaxTextBox.TabIndex = 5;
            this.MaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max:";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1248, 2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 21);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 157);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(327, 280);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChoiceBox.FormattingEnabled = true;
            this.ChoiceBox.Items.AddRange(new object[] {
            "Лог-кривая",
            "Уравнение Гудермана",
            "Уравнение Ферми",
            "Рациональная сигмоида"});
            this.ChoiceBox.Location = new System.Drawing.Point(9, 122);
            this.ChoiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(157, 21);
            this.ChoiceBox.TabIndex = 10;
            this.ChoiceBox.SelectedIndexChanged += new System.EventHandler(this.ChoiceBox_SelectedIndexChanged);
            // 
            // AlphaBox
            // 
            this.AlphaBox.BackColor = System.Drawing.Color.White;
            this.AlphaBox.Location = new System.Drawing.Point(200, 122);
            this.AlphaBox.Name = "AlphaBox";
            this.AlphaBox.Size = new System.Drawing.Size(57, 20);
            this.AlphaBox.TabIndex = 11;
            this.AlphaBox.Visible = false;
            this.AlphaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alpha:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Выберите уравнение";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 23);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // EnterBox_1
            // 
            this.EnterBox_1.Location = new System.Drawing.Point(9, 464);
            this.EnterBox_1.Multiline = true;
            this.EnterBox_1.Name = "EnterBox_1";
            this.EnterBox_1.Size = new System.Drawing.Size(248, 22);
            this.EnterBox_1.TabIndex = 15;
            this.EnterBox_1.Text = "Клуб любителей химии распался\r\n\r\n";
            // 
            // OKButton_1
            // 
            this.OKButton_1.Location = new System.Drawing.Point(265, 464);
            this.OKButton_1.Name = "OKButton_1";
            this.OKButton_1.Size = new System.Drawing.Size(74, 22);
            this.OKButton_1.TabIndex = 16;
            this.OKButton_1.Text = "Посчитать";
            this.OKButton_1.UseVisualStyleBackColor = true;
            this.OKButton_1.Click += new System.EventHandler(this.OKButton_1_Click);
            // 
            // ResultBox_1
            // 
            this.ResultBox_1.Location = new System.Drawing.Point(9, 492);
            this.ResultBox_1.Multiline = true;
            this.ResultBox_1.Name = "ResultBox_1";
            this.ResultBox_1.Size = new System.Drawing.Size(330, 156);
            this.ResultBox_1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Введите строку:";
            // 
            // EnterBox_2
            // 
            this.EnterBox_2.Location = new System.Drawing.Point(363, 464);
            this.EnterBox_2.Multiline = true;
            this.EnterBox_2.Name = "EnterBox_2";
            this.EnterBox_2.Size = new System.Drawing.Size(205, 22);
            this.EnterBox_2.TabIndex = 19;
            this.EnterBox_2.Text = "110";
            this.EnterBox_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterBox_2_KeyPress);
            // 
            // OKButton_2
            // 
            this.OKButton_2.Location = new System.Drawing.Point(574, 464);
            this.OKButton_2.Name = "OKButton_2";
            this.OKButton_2.Size = new System.Drawing.Size(74, 22);
            this.OKButton_2.TabIndex = 20;
            this.OKButton_2.Text = "Перевести";
            this.OKButton_2.UseVisualStyleBackColor = true;
            this.OKButton_2.Click += new System.EventHandler(this.OKButton_2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Введите двоичное число:";
            // 
            // ResultBox_2
            // 
            this.ResultBox_2.Location = new System.Drawing.Point(363, 492);
            this.ResultBox_2.Multiline = true;
            this.ResultBox_2.Name = "ResultBox_2";
            this.ResultBox_2.Size = new System.Drawing.Size(285, 156);
            this.ResultBox_2.TabIndex = 22;
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(799, 58);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(470, 379);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            // 
            // EntropyTextBox
            // 
            this.EntropyTextBox.Location = new System.Drawing.Point(663, 99);
            this.EntropyTextBox.Name = "EntropyTextBox";
            this.EntropyTextBox.Size = new System.Drawing.Size(100, 20);
            this.EntropyTextBox.TabIndex = 24;
            // 
            // MostOftenTextBox
            // 
            this.MostOftenTextBox.Location = new System.Drawing.Point(663, 157);
            this.MostOftenTextBox.Name = "MostOftenTextBox";
            this.MostOftenTextBox.Size = new System.Drawing.Size(100, 20);
            this.MostOftenTextBox.TabIndex = 25;
            // 
            // LessOftenTextBox
            // 
            this.LessOftenTextBox.Location = new System.Drawing.Point(663, 216);
            this.LessOftenTextBox.Name = "LessOftenTextBox";
            this.LessOftenTextBox.Size = new System.Drawing.Size(100, 20);
            this.LessOftenTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Entropy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Most often letter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(663, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Less often letter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(663, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total sum of frequancy";
            // 
            // FrequancySumTextBox
            // 
            this.FrequancySumTextBox.Location = new System.Drawing.Point(663, 292);
            this.FrequancySumTextBox.Name = "FrequancySumTextBox";
            this.FrequancySumTextBox.Size = new System.Drawing.Size(115, 20);
            this.FrequancySumTextBox.TabIndex = 31;
            // 
            // CalculateLaba3Button
            // 
            this.CalculateLaba3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CalculateLaba3Button.Location = new System.Drawing.Point(663, 318);
            this.CalculateLaba3Button.Name = "CalculateLaba3Button";
            this.CalculateLaba3Button.Size = new System.Drawing.Size(115, 23);
            this.CalculateLaba3Button.TabIndex = 32;
            this.CalculateLaba3Button.Text = "Посчитать";
            this.CalculateLaba3Button.UseVisualStyleBackColor = true;
            this.CalculateLaba3Button.Click += new System.EventHandler(this.CalculateLaba3Button_Click);
            // 
            // InputLaba3TextBox
            // 
            this.InputLaba3TextBox.Location = new System.Drawing.Point(669, 492);
            this.InputLaba3TextBox.Name = "InputLaba3TextBox";
            this.InputLaba3TextBox.Size = new System.Drawing.Size(251, 156);
            this.InputLaba3TextBox.TabIndex = 33;
            this.InputLaba3TextBox.Text = resources.GetString("InputLaba3TextBox.Text");
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LetterColumn,
            this.CountColumn,
            this.FrequancyColumn});
            this.dataGridView2.Location = new System.Drawing.Point(925, 492);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 156);
            this.dataGridView2.TabIndex = 34;
            // 
            // LetterColumn
            // 
            this.LetterColumn.HeaderText = "Letter";
            this.LetterColumn.Name = "LetterColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Count";
            this.CountColumn.Name = "CountColumn";
            // 
            // FrequancyColumn
            // 
            this.FrequancyColumn.HeaderText = "Frequancy";
            this.FrequancyColumn.Name = "FrequancyColumn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(666, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Input text: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(653, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 640);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-1, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 3);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(0, 655);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1282, 3);
            this.panel4.TabIndex = 38;
            // 
            // AlphaLaba4TextBox
            // 
            this.AlphaLaba4TextBox.Location = new System.Drawing.Point(9, 685);
            this.AlphaLaba4TextBox.Name = "AlphaLaba4TextBox";
            this.AlphaLaba4TextBox.Size = new System.Drawing.Size(285, 20);
            this.AlphaLaba4TextBox.TabIndex = 39;
            this.AlphaLaba4TextBox.Text = "1000";
            this.AlphaLaba4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(9, 669);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Alpha:";
            // 
            // BettaLaba4TextBox
            // 
            this.BettaLaba4TextBox.Location = new System.Drawing.Point(363, 684);
            this.BettaLaba4TextBox.Name = "BettaLaba4TextBox";
            this.BettaLaba4TextBox.Size = new System.Drawing.Size(285, 20);
            this.BettaLaba4TextBox.TabIndex = 41;
            this.BettaLaba4TextBox.Text = "100";
            this.BettaLaba4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(360, 669);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Betta:";
            // 
            // ResultLaba4TextBox
            // 
            this.ResultLaba4TextBox.Location = new System.Drawing.Point(717, 684);
            this.ResultLaba4TextBox.Name = "ResultLaba4TextBox";
            this.ResultLaba4TextBox.Size = new System.Drawing.Size(285, 20);
            this.ResultLaba4TextBox.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(714, 668);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Результат:";
            // 
            // INCbutton
            // 
            this.INCbutton.Location = new System.Drawing.Point(9, 712);
            this.INCbutton.Name = "INCbutton";
            this.INCbutton.Size = new System.Drawing.Size(75, 23);
            this.INCbutton.TabIndex = 46;
            this.INCbutton.Text = "INC";
            this.INCbutton.UseVisualStyleBackColor = true;
            this.INCbutton.Click += new System.EventHandler(this.INCbutton_Click);
            // 
            // SUBbutton
            // 
            this.SUBbutton.Location = new System.Drawing.Point(166, 712);
            this.SUBbutton.Name = "SUBbutton";
            this.SUBbutton.Size = new System.Drawing.Size(75, 23);
            this.SUBbutton.TabIndex = 47;
            this.SUBbutton.Text = "SUB";
            this.SUBbutton.UseVisualStyleBackColor = true;
            this.SUBbutton.Click += new System.EventHandler(this.SUBbutton_Click);
            // 
            // DECbutton
            // 
            this.DECbutton.Location = new System.Drawing.Point(363, 712);
            this.DECbutton.Name = "DECbutton";
            this.DECbutton.Size = new System.Drawing.Size(75, 23);
            this.DECbutton.TabIndex = 48;
            this.DECbutton.Text = "DEC";
            this.DECbutton.UseVisualStyleBackColor = true;
            this.DECbutton.Click += new System.EventHandler(this.DECbutton_Click);
            // 
            // ADDbutton
            // 
            this.ADDbutton.Location = new System.Drawing.Point(493, 712);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(75, 23);
            this.ADDbutton.TabIndex = 49;
            this.ADDbutton.Text = "ADD";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // ADCbutton
            // 
            this.ADCbutton.Location = new System.Drawing.Point(717, 711);
            this.ADCbutton.Name = "ADCbutton";
            this.ADCbutton.Size = new System.Drawing.Size(75, 23);
            this.ADCbutton.TabIndex = 50;
            this.ADCbutton.Text = "ADC";
            this.ADCbutton.UseVisualStyleBackColor = true;
            this.ADCbutton.Click += new System.EventHandler(this.ADCbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1281, 763);
            this.Controls.Add(this.ADCbutton);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.DECbutton);
            this.Controls.Add(this.SUBbutton);
            this.Controls.Add(this.INCbutton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ResultLaba4TextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BettaLaba4TextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AlphaLaba4TextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.InputLaba3TextBox);
            this.Controls.Add(this.CalculateLaba3Button);
            this.Controls.Add(this.FrequancySumTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LessOftenTextBox);
            this.Controls.Add(this.MostOftenTextBox);
            this.Controls.Add(this.EntropyTextBox);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.ResultBox_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OKButton_2);
            this.Controls.Add(this.EnterBox_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultBox_1);
            this.Controls.Add(this.OKButton_1);
            this.Controls.Add(this.EnterBox_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlphaBox);
            this.Controls.Add(this.ChoiceBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox ChoiceBox;
        private System.Windows.Forms.TextBox AlphaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EnterBox_1;
        private System.Windows.Forms.Button OKButton_1;
        private System.Windows.Forms.TextBox ResultBox_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnterBox_2;
        private System.Windows.Forms.Button OKButton_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ResultBox_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox EntropyTextBox;
        private System.Windows.Forms.TextBox MostOftenTextBox;
        private System.Windows.Forms.TextBox LessOftenTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FrequancySumTextBox;
        private System.Windows.Forms.Button CalculateLaba3Button;
        private System.Windows.Forms.RichTextBox InputLaba3TextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequancyColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox AlphaLaba4TextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BettaLaba4TextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ResultLaba4TextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button INCbutton;
        private System.Windows.Forms.Button SUBbutton;
        private System.Windows.Forms.Button DECbutton;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Button ADCbutton;
    }
}

