namespace SmetaApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StroykaToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.объектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сметаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСметуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСметуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьТекущейСметыВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чтениеСметыИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСметуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортИмпортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опербазаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стройкаToolStripMenuItem,
            this.экспортИмпортToolStripMenuItem,
            this.редакторToolStripMenuItem,
            this.ценыToolStripMenuItem,
            this.опербазаToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.окнаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // стройкаToolStripMenuItem
            // 
            this.стройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьСметуToolStripMenuItem,
            this.сохранитьСметуToolStripMenuItem,
            this.записьТекущейСметыВФайлToolStripMenuItem,
            this.чтениеСметыИзФайлаToolStripMenuItem,
            this.удалитьСметуToolStripMenuItem});
            this.стройкаToolStripMenuItem.Name = "стройкаToolStripMenuItem";
            this.стройкаToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.стройкаToolStripMenuItem.Text = "Стройка";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StroykaToolStripMenu,
            this.объектToolStripMenuItem,
            this.сметаToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // StroykaToolStripMenu
            // 
            this.StroykaToolStripMenu.Name = "StroykaToolStripMenu";
            this.StroykaToolStripMenu.Size = new System.Drawing.Size(224, 26);
            this.StroykaToolStripMenu.Text = "Стройка";
            this.StroykaToolStripMenu.Click += new System.EventHandler(this.StroykaToolStripMenu_Click);
            // 
            // объектToolStripMenuItem
            // 
            this.объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            this.объектToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.объектToolStripMenuItem.Text = "Объект";
            
            // 
            // сметаToolStripMenuItem
            // 
            this.сметаToolStripMenuItem.Name = "сметаToolStripMenuItem";
            this.сметаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сметаToolStripMenuItem.Text = "Смета";
            // 
            // открытьСметуToolStripMenuItem
            // 
            this.открытьСметуToolStripMenuItem.Name = "открытьСметуToolStripMenuItem";
            this.открытьСметуToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.открытьСметуToolStripMenuItem.Text = "Открыть смету";
            // 
            // сохранитьСметуToolStripMenuItem
            // 
            this.сохранитьСметуToolStripMenuItem.Name = "сохранитьСметуToolStripMenuItem";
            this.сохранитьСметуToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.сохранитьСметуToolStripMenuItem.Text = "Сохранить смету";
            // 
            // записьТекущейСметыВФайлToolStripMenuItem
            // 
            this.записьТекущейСметыВФайлToolStripMenuItem.Name = "записьТекущейСметыВФайлToolStripMenuItem";
            this.записьТекущейСметыВФайлToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.записьТекущейСметыВФайлToolStripMenuItem.Text = "Запись текущей сметы в файл";
            // 
            // чтениеСметыИзФайлаToolStripMenuItem
            // 
            this.чтениеСметыИзФайлаToolStripMenuItem.Name = "чтениеСметыИзФайлаToolStripMenuItem";
            this.чтениеСметыИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.чтениеСметыИзФайлаToolStripMenuItem.Text = "Чтение сметы из файла";
            // 
            // удалитьСметуToolStripMenuItem
            // 
            this.удалитьСметуToolStripMenuItem.Name = "удалитьСметуToolStripMenuItem";
            this.удалитьСметуToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.удалитьСметуToolStripMenuItem.Text = "Удалить смету";
            // 
            // экспортИмпортToolStripMenuItem
            // 
            this.экспортИмпортToolStripMenuItem.Name = "экспортИмпортToolStripMenuItem";
            this.экспортИмпортToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.экспортИмпортToolStripMenuItem.Text = "Экспорт/Импорт";
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.редакторToolStripMenuItem.Text = "Редактор";
            // 
            // ценыToolStripMenuItem
            // 
            this.ценыToolStripMenuItem.Name = "ценыToolStripMenuItem";
            this.ценыToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ценыToolStripMenuItem.Text = "Цены";
            // 
            // опербазаToolStripMenuItem
            // 
            this.опербазаToolStripMenuItem.Name = "опербазаToolStripMenuItem";
            this.опербазаToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.опербазаToolStripMenuItem.Text = "Опербаза";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 792);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Программный комплекс USG_SMETA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСметуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСметуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьТекущейСметыВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортИмпортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опербазаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StroykaToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem объектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сметаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтениеСметыИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСметуToolStripMenuItem;
    }
}

