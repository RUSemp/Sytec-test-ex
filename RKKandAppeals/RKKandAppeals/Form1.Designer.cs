namespace RKKandAppeals
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеРККToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеОбращенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениОтветственногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рККToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обращениямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всемДокмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(591, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВToolStripMenuItem,
            this.загрузитьДанныеРККToolStripMenuItem,
            this.загрузитьДанныеОбращенийToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВToolStripMenuItem
            // 
            this.сохранитьВToolStripMenuItem.Name = "сохранитьВToolStripMenuItem";
            this.сохранитьВToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.сохранитьВToolStripMenuItem.Text = "Сохранить в txt";
            this.сохранитьВToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВToolStripMenuItem_Click);
            // 
            // загрузитьДанныеРККToolStripMenuItem
            // 
            this.загрузитьДанныеРККToolStripMenuItem.Name = "загрузитьДанныеРККToolStripMenuItem";
            this.загрузитьДанныеРККToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.загрузитьДанныеРККToolStripMenuItem.Text = "Загрузить данные РКК";
            this.загрузитьДанныеРККToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеРККToolStripMenuItem_Click);
            // 
            // загрузитьДанныеОбращенийToolStripMenuItem
            // 
            this.загрузитьДанныеОбращенийToolStripMenuItem.Name = "загрузитьДанныеОбращенийToolStripMenuItem";
            this.загрузитьДанныеОбращенийToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.загрузитьДанныеОбращенийToolStripMenuItem.Text = "Загрузить данные обращений";
            this.загрузитьДанныеОбращенийToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеОбращенийToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имениОтветственногоToolStripMenuItem,
            this.рККToolStripMenuItem,
            this.обращениямToolStripMenuItem,
            this.всемДокмToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по..";
            // 
            // имениОтветственногоToolStripMenuItem
            // 
            this.имениОтветственногоToolStripMenuItem.Name = "имениОтветственногоToolStripMenuItem";
            this.имениОтветственногоToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.имениОтветственногоToolStripMenuItem.Text = "Имени ответственного";
            this.имениОтветственногоToolStripMenuItem.Click += new System.EventHandler(this.имениОтветственногоToolStripMenuItem_Click);
            // 
            // рККToolStripMenuItem
            // 
            this.рККToolStripMenuItem.Name = "рККToolStripMenuItem";
            this.рККToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.рККToolStripMenuItem.Text = "РКК";
            this.рККToolStripMenuItem.Click += new System.EventHandler(this.рККToolStripMenuItem_Click);
            // 
            // обращениямToolStripMenuItem
            // 
            this.обращениямToolStripMenuItem.Name = "обращениямToolStripMenuItem";
            this.обращениямToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.обращениямToolStripMenuItem.Text = "Обращениям";
            this.обращениямToolStripMenuItem.Click += new System.EventHandler(this.обращениямToolStripMenuItem_Click);
            // 
            // всемДокмToolStripMenuItem
            // 
            this.всемДокмToolStripMenuItem.Name = "всемДокмToolStripMenuItem";
            this.всемДокмToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.всемДокмToolStripMenuItem.Text = "Всем док-м";
            this.всемДокмToolStripMenuItem.Click += new System.EventHandler(this.всемДокмToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Составить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(597, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 210);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 522);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "РКК и обращения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьВToolStripMenuItem;
        private ToolStripMenuItem загрузитьДанныеРККToolStripMenuItem;
        private ToolStripMenuItem загрузитьДанныеОбращенийToolStripMenuItem;
        private Button button1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private ToolStripMenuItem имениОтветственногоToolStripMenuItem;
        private ToolStripMenuItem рККToolStripMenuItem;
        private ToolStripMenuItem обращениямToolStripMenuItem;
        private ToolStripMenuItem всемДокмToolStripMenuItem;
    }
}