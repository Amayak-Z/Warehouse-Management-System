namespace WindowsFormsApp2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearWarehousmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearJournalmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Information = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonSell = new System.Windows.Forms.Button();
            this.checkBoxfromreserv = new System.Windows.Forms.CheckBox();
            this.buttonUnreserve = new System.Windows.Forms.Button();
            this.dateTimePickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStorageInfo = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToMenu,
            this.ExitMenu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // SaveToMenu
            // 
            this.SaveToMenu.Name = "SaveToMenu";
            this.SaveToMenu.Size = new System.Drawing.Size(166, 26);
            this.SaveToMenu.Text = "Сохранить";
            this.SaveToMenu.Click += new System.EventHandler(this.SaveToMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(166, 26);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearWarehousmenu,
            this.ClearJournalmenu,
            this.ChangePassword});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem2.Text = "Данные";
            // 
            // ClearWarehousmenu
            // 
            this.ClearWarehousmenu.Name = "ClearWarehousmenu";
            this.ClearWarehousmenu.Size = new System.Drawing.Size(243, 26);
            this.ClearWarehousmenu.Text = "Очистить склад";
            this.ClearWarehousmenu.Click += new System.EventHandler(this.ClearWarehousmenu_Click);
            // 
            // ClearJournalmenu
            // 
            this.ClearJournalmenu.Name = "ClearJournalmenu";
            this.ClearJournalmenu.Size = new System.Drawing.Size(243, 26);
            this.ClearJournalmenu.Text = "Очистить журнал";
            this.ClearJournalmenu.Click += new System.EventHandler(this.ClearJournalmenu_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(243, 26);
            this.ChangePassword.Text = "Сменить пароль Адм.";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportReportMenu});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItem3.Text = "Отчет";
            // 
            // ExportReportMenu
            // 
            this.ExportReportMenu.Name = "ExportReportMenu";
            this.ExportReportMenu.Size = new System.Drawing.Size(236, 26);
            this.ExportReportMenu.Text = "Экспорт остатков txt.";
            this.ExportReportMenu.Click += new System.EventHandler(this.ExportReportMenu_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Information});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem4.Text = "Справка";
            // 
            // Information
            // 
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(187, 26);
            this.Information.Text = "О программе";
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.ColumnAvailable,
            this.Column4,
            this.ColumnArrival,
            this.ColumnExpiry,
            this.StatusColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.LightCyan;
            this.trackBar1.Location = new System.Drawing.Point(734, 300);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(120, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(741, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(12, 277);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 28);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseClick);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Продукты питания",
            "Напитки",
            "Молочные продукты",
            "Консервация"});
            this.comboBoxCategory.Location = new System.Drawing.Point(182, 277);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(183, 28);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.Text = "Категории";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(182, 481);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 60);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonReserve.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserve.Location = new System.Drawing.Point(12, 481);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(164, 60);
            this.buttonReserve.TabIndex = 7;
            this.buttonReserve.Text = "Зарезервировать";
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.Color.LightCyan;
            this.numericUpDownCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownCount.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(734, 362);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownCount.TabIndex = 8;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            this.numericUpDownCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownCount_KeyUp);
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSell.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSell.Location = new System.Drawing.Point(357, 481);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(153, 60);
            this.buttonSell.TabIndex = 9;
            this.buttonSell.Text = "Продать товар";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // checkBoxfromreserv
            // 
            this.checkBoxfromreserv.AutoSize = true;
            this.checkBoxfromreserv.BackColor = System.Drawing.Color.LightCyan;
            this.checkBoxfromreserv.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxfromreserv.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxfromreserv.Location = new System.Drawing.Point(745, 393);
            this.checkBoxfromreserv.Name = "checkBoxfromreserv";
            this.checkBoxfromreserv.Size = new System.Drawing.Size(98, 21);
            this.checkBoxfromreserv.TabIndex = 10;
            this.checkBoxfromreserv.Text = "Из резерва";
            this.checkBoxfromreserv.UseVisualStyleBackColor = false;
            this.checkBoxfromreserv.CheckedChanged += new System.EventHandler(this.checkBoxfromreserv_CheckedChanged);
            // 
            // buttonUnreserve
            // 
            this.buttonUnreserve.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonUnreserve.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnreserve.Location = new System.Drawing.Point(516, 481);
            this.buttonUnreserve.Name = "buttonUnreserve";
            this.buttonUnreserve.Size = new System.Drawing.Size(147, 59);
            this.buttonUnreserve.TabIndex = 11;
            this.buttonUnreserve.Text = "Снять с резерва";
            this.buttonUnreserve.UseVisualStyleBackColor = false;
            this.buttonUnreserve.Click += new System.EventHandler(this.buttonUnreserve_Click_1);
            // 
            // dateTimePickerExpiry
            // 
            this.dateTimePickerExpiry.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerExpiry.Location = new System.Drawing.Point(371, 277);
            this.dateTimePickerExpiry.Name = "dateTimePickerExpiry";
            this.dateTimePickerExpiry.Size = new System.Drawing.Size(189, 28);
            this.dateTimePickerExpiry.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 202);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1153, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // labelStorageInfo
            // 
            this.labelStorageInfo.AutoSize = true;
            this.labelStorageInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStorageInfo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelStorageInfo.Location = new System.Drawing.Point(272, 228);
            this.labelStorageInfo.Name = "labelStorageInfo";
            this.labelStorageInfo.Size = new System.Drawing.Size(238, 23);
            this.labelStorageInfo.TabIndex = 14;
            this.labelStorageInfo.Text = "Заполненность склада: 0%";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(834, 498);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 42);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить товар";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 370);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(164, 28);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Все категории",
            "Продукты питания",
            "Напитки",
            "Молочные продукты",
            "Консервация"});
            this.categoryComboBox.Location = new System.Drawing.Point(327, 370);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(183, 28);
            this.categoryComboBox.TabIndex = 17;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(322, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Быстрый поиск по категориям";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(8, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Быстрый поиск по буквам";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название товара";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 9.674878F;
            this.Column2.HeaderText = "Категории";
            this.Column2.MinimumWidth = 120;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 9.674878F;
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 112;
            // 
            // ColumnAvailable
            // 
            this.ColumnAvailable.FillWeight = 9.674878F;
            this.ColumnAvailable.HeaderText = "Доступно";
            this.ColumnAvailable.MinimumWidth = 6;
            this.ColumnAvailable.Name = "ColumnAvailable";
            this.ColumnAvailable.ReadOnly = true;
            this.ColumnAvailable.Width = 101;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 9.674878F;
            this.Column4.HeaderText = "В резерве";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // ColumnArrival
            // 
            this.ColumnArrival.FillWeight = 9.674878F;
            this.ColumnArrival.HeaderText = "Дата привоза";
            this.ColumnArrival.MinimumWidth = 6;
            this.ColumnArrival.Name = "ColumnArrival";
            this.ColumnArrival.ReadOnly = true;
            this.ColumnArrival.Width = 116;
            // 
            // ColumnExpiry
            // 
            this.ColumnExpiry.FillWeight = 9.674878F;
            this.ColumnExpiry.HeaderText = "Срок годности";
            this.ColumnExpiry.MinimumWidth = 6;
            this.ColumnExpiry.Name = "ColumnExpiry";
            this.ColumnExpiry.ReadOnly = true;
            this.ColumnExpiry.Width = 119;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusColumn.HeaderText = "Статус годности";
            this.StatusColumn.MinimumWidth = 120;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1161, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStorageInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dateTimePickerExpiry);
            this.Controls.Add(this.buttonUnreserve);
            this.Controls.Add(this.checkBoxfromreserv);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Мой склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.CheckBox checkBoxfromreserv;
        private System.Windows.Forms.Button buttonUnreserve;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiry;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelStorageInfo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem SaveToMenu;
        private System.Windows.Forms.ToolStripMenuItem Information;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearWarehousmenu;
        private System.Windows.Forms.ToolStripMenuItem ClearJournalmenu;
        private System.Windows.Forms.ToolStripMenuItem ExportReportMenu;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}

