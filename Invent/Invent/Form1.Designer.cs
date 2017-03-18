namespace Invent
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
            this.components = new System.ComponentModel.Container();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subdivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвентарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структурныеПодразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияНовогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрАктивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьНовоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьКорпусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявленияНаПеремещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.первичнаяРегистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актыСписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дефектныеВедомостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мОЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспертыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСведенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСведенийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subdivisionDataGridViewTextBoxColumn,
            this.iDInventoryDataGridViewTextBoxColumn,
            this.manufactNumDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.invNumberDataGridViewTextBoxColumn,
            this.receiveDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.objectNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryItemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // subdivisionDataGridViewTextBoxColumn
            // 
            this.subdivisionDataGridViewTextBoxColumn.DataPropertyName = "Subdivision";
            this.subdivisionDataGridViewTextBoxColumn.HeaderText = "Текущее положение";
            this.subdivisionDataGridViewTextBoxColumn.Name = "subdivisionDataGridViewTextBoxColumn";
            this.subdivisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDInventoryDataGridViewTextBoxColumn
            // 
            this.iDInventoryDataGridViewTextBoxColumn.DataPropertyName = "IDInventory";
            this.iDInventoryDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDInventoryDataGridViewTextBoxColumn.Name = "iDInventoryDataGridViewTextBoxColumn";
            this.iDInventoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufactNumDataGridViewTextBoxColumn
            // 
            this.manufactNumDataGridViewTextBoxColumn.DataPropertyName = "ManufactNum";
            this.manufactNumDataGridViewTextBoxColumn.HeaderText = "Заводской номер";
            this.manufactNumDataGridViewTextBoxColumn.Name = "manufactNumDataGridViewTextBoxColumn";
            this.manufactNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Полное наименование";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invNumberDataGridViewTextBoxColumn
            // 
            this.invNumberDataGridViewTextBoxColumn.DataPropertyName = "InvNumber";
            this.invNumberDataGridViewTextBoxColumn.HeaderText = "Инвентарный номер";
            this.invNumberDataGridViewTextBoxColumn.Name = "invNumberDataGridViewTextBoxColumn";
            this.invNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveDateDataGridViewTextBoxColumn
            // 
            this.receiveDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiveDate";
            this.receiveDateDataGridViewTextBoxColumn.HeaderText = "Дата установки";
            this.receiveDateDataGridViewTextBoxColumn.Name = "receiveDateDataGridViewTextBoxColumn";
            this.receiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectNameDataGridViewTextBoxColumn
            // 
            this.objectNameDataGridViewTextBoxColumn.DataPropertyName = "ObjectName";
            this.objectNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.objectNameDataGridViewTextBoxColumn.Name = "objectNameDataGridViewTextBoxColumn";
            this.objectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryItemBindingSource
            // 
            this.inventoryItemBindingSource.DataSource = typeof(Invent.Domain.InventoryItem);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.инвентарьToolStripMenuItem,
            this.структурныеПодразделенияToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.работникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // инвентарьToolStripMenuItem
            // 
            this.инвентарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияНовогоToolStripMenuItem});
            this.инвентарьToolStripMenuItem.Name = "инвентарьToolStripMenuItem";
            this.инвентарьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.инвентарьToolStripMenuItem.Text = "Инвентарь";
            // 
            // структурныеПодразделенияToolStripMenuItem
            // 
            this.структурныеПодразделенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрАктивовToolStripMenuItem,
            this.зарегистрироватьНовоеToolStripMenuItem,
            this.зарегистрироватьКорпусToolStripMenuItem});
            this.структурныеПодразделенияToolStripMenuItem.Name = "структурныеПодразделенияToolStripMenuItem";
            this.структурныеПодразделенияToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.структурныеПодразделенияToolStripMenuItem.Text = "Структурные подразделения";
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявленияНаПеремещениеToolStripMenuItem,
            this.первичнаяРегистрацияToolStripMenuItem,
            this.актыСписанияToolStripMenuItem,
            this.дефектныеВедомостиToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // регистрацияНовогоToolStripMenuItem
            // 
            this.регистрацияНовогоToolStripMenuItem.Name = "регистрацияНовогоToolStripMenuItem";
            this.регистрацияНовогоToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.регистрацияНовогоToolStripMenuItem.Text = "Регистрация нового";
            // 
            // просмотрАктивовToolStripMenuItem
            // 
            this.просмотрАктивовToolStripMenuItem.Name = "просмотрАктивовToolStripMenuItem";
            this.просмотрАктивовToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.просмотрАктивовToolStripMenuItem.Text = "Просмотр активов";
            // 
            // зарегистрироватьНовоеToolStripMenuItem
            // 
            this.зарегистрироватьНовоеToolStripMenuItem.Name = "зарегистрироватьНовоеToolStripMenuItem";
            this.зарегистрироватьНовоеToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.зарегистрироватьНовоеToolStripMenuItem.Text = "Зарегистрировать новое";
            // 
            // зарегистрироватьКорпусToolStripMenuItem
            // 
            this.зарегистрироватьКорпусToolStripMenuItem.Name = "зарегистрироватьКорпусToolStripMenuItem";
            this.зарегистрироватьКорпусToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.зарегистрироватьКорпусToolStripMenuItem.Text = "Зарегистрировать корпус";
            // 
            // заявленияНаПеремещениеToolStripMenuItem
            // 
            this.заявленияНаПеремещениеToolStripMenuItem.Name = "заявленияНаПеремещениеToolStripMenuItem";
            this.заявленияНаПеремещениеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.заявленияНаПеремещениеToolStripMenuItem.Text = "Заявления на перемещение";
            // 
            // первичнаяРегистрацияToolStripMenuItem
            // 
            this.первичнаяРегистрацияToolStripMenuItem.Name = "первичнаяРегистрацияToolStripMenuItem";
            this.первичнаяРегистрацияToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.первичнаяРегистрацияToolStripMenuItem.Text = "Первичная регистрация";
            // 
            // актыСписанияToolStripMenuItem
            // 
            this.актыСписанияToolStripMenuItem.Name = "актыСписанияToolStripMenuItem";
            this.актыСписанияToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.актыСписанияToolStripMenuItem.Text = "Акты списания";
            // 
            // дефектныеВедомостиToolStripMenuItem
            // 
            this.дефектныеВедомостиToolStripMenuItem.Name = "дефектныеВедомостиToolStripMenuItem";
            this.дефектныеВедомостиToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.дефектныеВедомостиToolStripMenuItem.Text = "Дефектные ведомости";
            // 
            // подключитьсяToolStripMenuItem
            // 
            this.подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            this.подключитьсяToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.подключитьсяToolStripMenuItem.Text = "Подключиться";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мОЛToolStripMenuItem,
            this.экспертыToolStripMenuItem});
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.работникиToolStripMenuItem.Text = "Работники";
            // 
            // мОЛToolStripMenuItem
            // 
            this.мОЛToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внестиToolStripMenuItem,
            this.просмотрСведенийToolStripMenuItem});
            this.мОЛToolStripMenuItem.Name = "мОЛToolStripMenuItem";
            this.мОЛToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.мОЛToolStripMenuItem.Text = "МОЛ";
            // 
            // экспертыToolStripMenuItem
            // 
            this.экспертыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внестиToolStripMenuItem1,
            this.просмотрСведенийToolStripMenuItem1});
            this.экспертыToolStripMenuItem.Name = "экспертыToolStripMenuItem";
            this.экспертыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.экспертыToolStripMenuItem.Text = "Эксперты";
            // 
            // внестиToolStripMenuItem
            // 
            this.внестиToolStripMenuItem.Name = "внестиToolStripMenuItem";
            this.внестиToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.внестиToolStripMenuItem.Text = "Внести";
            // 
            // просмотрСведенийToolStripMenuItem
            // 
            this.просмотрСведенийToolStripMenuItem.Name = "просмотрСведенийToolStripMenuItem";
            this.просмотрСведенийToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.просмотрСведенийToolStripMenuItem.Text = "Просмотр сведений";
            // 
            // внестиToolStripMenuItem1
            // 
            this.внестиToolStripMenuItem1.Name = "внестиToolStripMenuItem1";
            this.внестиToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.внестиToolStripMenuItem1.Text = "Внести";
            // 
            // просмотрСведенийToolStripMenuItem1
            // 
            this.просмотрСведенийToolStripMenuItem1.Name = "просмотрСведенийToolStripMenuItem1";
            this.просмотрСведенийToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.просмотрСведенийToolStripMenuItem1.Text = "Просмотр сведений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инвентарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияНовогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структурныеПодразделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрАктивовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьНовоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьКорпусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявленияНаПеремещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem первичнаяРегистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актыСписанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дефектныеВедомостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мОЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСведенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспертыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрСведенийToolStripMenuItem1;
    }
}

