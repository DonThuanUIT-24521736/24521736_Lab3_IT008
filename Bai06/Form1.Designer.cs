namespace Bai06
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(572, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editToolStripMenuItem.Text = "&Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(6, 90);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(566, 102);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.btnClearEntry, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMemoryClear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMemoryRecall, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMemoryStore, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMemoryAdd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDot, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSqrt, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPerson, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnInverse, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSign, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 198);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.86395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 364);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEntry.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.ForeColor = System.Drawing.Color.Red;
            this.btnClearEntry.Location = new System.Drawing.Point(282, 3);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(86, 45);
            this.btnClearEntry.TabIndex = 0;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(458, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMemoryClear.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryClear.Location = new System.Drawing.Point(3, 54);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(87, 71);
            this.btnMemoryClear.TabIndex = 5;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMemoryRecall.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryRecall.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryRecall.Location = new System.Drawing.Point(3, 131);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(87, 70);
            this.btnMemoryRecall.TabIndex = 6;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMemoryStore.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryStore.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryStore.Location = new System.Drawing.Point(3, 207);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(87, 74);
            this.btnMemoryStore.TabIndex = 7;
            this.btnMemoryStore.Text = "MS";
            this.btnMemoryStore.UseVisualStyleBackColor = true;
            this.btnMemoryStore.Click += new System.EventHandler(this.btnMemoryStore_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMemoryAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryAdd.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryAdd.Location = new System.Drawing.Point(3, 287);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(87, 74);
            this.btnMemoryAdd.TabIndex = 8;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = true;
            this.btnMemoryAdd.Click += new System.EventHandler(this.btnMemoryAdd_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Location = new System.Drawing.Point(96, 54);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(87, 71);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Location = new System.Drawing.Point(189, 54);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(87, 71);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Location = new System.Drawing.Point(282, 54);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 71);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(282, 131);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 70);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(189, 131);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(87, 70);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(96, 131);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 70);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Location = new System.Drawing.Point(282, 207);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 74);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(189, 207);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(87, 74);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Location = new System.Drawing.Point(96, 207);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 74);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDot
            // 
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.Blue;
            this.btnDot.Location = new System.Drawing.Point(282, 287);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(86, 74);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(374, 54);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(78, 71);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.btnSqrt.Location = new System.Drawing.Point(458, 54);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(111, 71);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "SQRT";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPerson.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerson.ForeColor = System.Drawing.Color.Blue;
            this.btnPerson.Location = new System.Drawing.Point(458, 131);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(111, 70);
            this.btnPerson.TabIndex = 21;
            this.btnPerson.Text = "%";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(374, 131);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(78, 70);
            this.btnMultiply.TabIndex = 22;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.Location = new System.Drawing.Point(374, 207);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(78, 74);
            this.btnMinus.TabIndex = 23;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInverse.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.ForeColor = System.Drawing.Color.Blue;
            this.btnInverse.Location = new System.Drawing.Point(458, 207);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(111, 74);
            this.btnInverse.TabIndex = 24;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Red;
            this.btnEqual.Location = new System.Drawing.Point(458, 287);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(111, 74);
            this.btnEqual.TabIndex = 25;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.Location = new System.Drawing.Point(374, 287);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(78, 74);
            this.btnPlus.TabIndex = 26;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.Blue;
            this.btnZero.Location = new System.Drawing.Point(96, 287);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(87, 74);
            this.btnZero.TabIndex = 27;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSign
            // 
            this.btnSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSign.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.Blue;
            this.btnSign.Location = new System.Drawing.Point(189, 287);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(87, 74);
            this.btnSign.TabIndex = 28;
            this.btnSign.Text = "+/-\r\n";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.BackColor = System.Drawing.Color.Azure;
            this.lblExpression.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpression.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.ForeColor = System.Drawing.Color.SlateGray;
            this.lblExpression.Location = new System.Drawing.Point(0, 28);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(572, 57);
            this.lblExpression.TabIndex = 3;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(572, 562);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Máy Tính Tay";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

