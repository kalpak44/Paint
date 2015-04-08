namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.panelInstruments = new System.Windows.Forms.Panel();
            this.groupBoxElipse = new System.Windows.Forms.GroupBox();
            this.textBoxElipseHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxElipseWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelElipseFcolor = new System.Windows.Forms.Label();
            this.panelElipseFcolor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEliseBcolor = new System.Windows.Forms.Label();
            this.textBoxElipsePenSize = new System.Windows.Forms.TextBox();
            this.panelElipseBcolor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSqsuare = new System.Windows.Forms.GroupBox();
            this.textBoxSquareWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSquareFcolor = new System.Windows.Forms.Panel();
            this.buttonSquareDraw = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSquarePenSize = new System.Windows.Forms.TextBox();
            this.panelSquareBcolor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelWorkSpace = new System.Windows.Forms.Panel();
            this.panelImg = new System.Windows.Forms.Panel();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.textBoxCircleDiametr = new System.Windows.Forms.TextBox();
            this.labelDiametr = new System.Windows.Forms.Label();
            this.buttonCircleDraw = new System.Windows.Forms.Button();
            this.labelCircleBcolot = new System.Windows.Forms.Label();
            this.textBoxPenSize = new System.Windows.Forms.TextBox();
            this.panelCircleBcolor = new System.Windows.Forms.Panel();
            this.labelPenSize = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelInstruments.SuspendLayout();
            this.groupBoxElipse.SuspendLayout();
            this.groupBoxSqsuare.SuspendLayout();
            this.panelWorkSpace.SuspendLayout();
            this.groupBoxCircle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInstruments
            // 
            this.panelInstruments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInstruments.BackColor = System.Drawing.Color.Silver;
            this.panelInstruments.Controls.Add(this.groupBoxElipse);
            this.panelInstruments.Controls.Add(this.groupBoxSqsuare);
            this.panelInstruments.Controls.Add(this.panelWorkSpace);
            this.panelInstruments.Controls.Add(this.groupBoxCircle);
            this.panelInstruments.Location = new System.Drawing.Point(0, 27);
            this.panelInstruments.Name = "panelInstruments";
            this.panelInstruments.Size = new System.Drawing.Size(624, 402);
            this.panelInstruments.TabIndex = 0;
            // 
            // groupBoxElipse
            // 
            this.groupBoxElipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxElipse.Controls.Add(this.textBoxElipseHeight);
            this.groupBoxElipse.Controls.Add(this.label6);
            this.groupBoxElipse.Controls.Add(this.textBoxElipseWidth);
            this.groupBoxElipse.Controls.Add(this.label5);
            this.groupBoxElipse.Controls.Add(this.labelElipseFcolor);
            this.groupBoxElipse.Controls.Add(this.panelElipseFcolor);
            this.groupBoxElipse.Controls.Add(this.button1);
            this.groupBoxElipse.Controls.Add(this.labelEliseBcolor);
            this.groupBoxElipse.Controls.Add(this.textBoxElipsePenSize);
            this.groupBoxElipse.Controls.Add(this.panelElipseBcolor);
            this.groupBoxElipse.Controls.Add(this.label3);
            this.groupBoxElipse.Location = new System.Drawing.Point(542, 3);
            this.groupBoxElipse.Name = "groupBoxElipse";
            this.groupBoxElipse.Size = new System.Drawing.Size(79, 254);
            this.groupBoxElipse.TabIndex = 10;
            this.groupBoxElipse.TabStop = false;
            this.groupBoxElipse.Text = "properties";
            this.groupBoxElipse.Visible = false;
            // 
            // textBoxElipseHeight
            // 
            this.textBoxElipseHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElipseHeight.Location = new System.Drawing.Point(12, 190);
            this.textBoxElipseHeight.Name = "textBoxElipseHeight";
            this.textBoxElipseHeight.Size = new System.Drawing.Size(58, 20);
            this.textBoxElipseHeight.TabIndex = 13;
            this.textBoxElipseHeight.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Height:";
            // 
            // textBoxElipseWidth
            // 
            this.textBoxElipseWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElipseWidth.Location = new System.Drawing.Point(12, 151);
            this.textBoxElipseWidth.Name = "textBoxElipseWidth";
            this.textBoxElipseWidth.Size = new System.Drawing.Size(58, 20);
            this.textBoxElipseWidth.TabIndex = 11;
            this.textBoxElipseWidth.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Width:";
            // 
            // labelElipseFcolor
            // 
            this.labelElipseFcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElipseFcolor.AutoSize = true;
            this.labelElipseFcolor.Location = new System.Drawing.Point(9, 56);
            this.labelElipseFcolor.Name = "labelElipseFcolor";
            this.labelElipseFcolor.Size = new System.Drawing.Size(67, 13);
            this.labelElipseFcolor.TabIndex = 3;
            this.labelElipseFcolor.Text = "Border color:";
            // 
            // panelElipseFcolor
            // 
            this.panelElipseFcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelElipseFcolor.BackColor = System.Drawing.Color.Gray;
            this.panelElipseFcolor.Location = new System.Drawing.Point(12, 72);
            this.panelElipseFcolor.Name = "panelElipseFcolor";
            this.panelElipseFcolor.Size = new System.Drawing.Size(58, 21);
            this.panelElipseFcolor.TabIndex = 4;
            this.panelElipseFcolor.DoubleClick += new System.EventHandler(this.panelElipseFcolor_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEliseBcolor
            // 
            this.labelEliseBcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEliseBcolor.AutoSize = true;
            this.labelEliseBcolor.Location = new System.Drawing.Point(9, 16);
            this.labelEliseBcolor.Name = "labelEliseBcolor";
            this.labelEliseBcolor.Size = new System.Drawing.Size(67, 13);
            this.labelEliseBcolor.TabIndex = 1;
            this.labelEliseBcolor.Text = "Border color:";
            // 
            // textBoxElipsePenSize
            // 
            this.textBoxElipsePenSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElipsePenSize.Location = new System.Drawing.Point(12, 112);
            this.textBoxElipsePenSize.Name = "textBoxElipsePenSize";
            this.textBoxElipsePenSize.Size = new System.Drawing.Size(58, 20);
            this.textBoxElipsePenSize.TabIndex = 6;
            this.textBoxElipsePenSize.Text = "3";
            // 
            // panelElipseBcolor
            // 
            this.panelElipseBcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelElipseBcolor.BackColor = System.Drawing.Color.Black;
            this.panelElipseBcolor.Location = new System.Drawing.Point(12, 32);
            this.panelElipseBcolor.Name = "panelElipseBcolor";
            this.panelElipseBcolor.Size = new System.Drawing.Size(58, 21);
            this.panelElipseBcolor.TabIndex = 2;
            this.panelElipseBcolor.DoubleClick += new System.EventHandler(this.panelElipseBcolor_DoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pen size:";
            // 
            // groupBoxSqsuare
            // 
            this.groupBoxSqsuare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSqsuare.Controls.Add(this.textBoxSquareWidth);
            this.groupBoxSqsuare.Controls.Add(this.label2);
            this.groupBoxSqsuare.Controls.Add(this.label4);
            this.groupBoxSqsuare.Controls.Add(this.panelSquareFcolor);
            this.groupBoxSqsuare.Controls.Add(this.buttonSquareDraw);
            this.groupBoxSqsuare.Controls.Add(this.label7);
            this.groupBoxSqsuare.Controls.Add(this.textBoxSquarePenSize);
            this.groupBoxSqsuare.Controls.Add(this.panelSquareBcolor);
            this.groupBoxSqsuare.Controls.Add(this.label8);
            this.groupBoxSqsuare.Location = new System.Drawing.Point(542, 3);
            this.groupBoxSqsuare.Name = "groupBoxSqsuare";
            this.groupBoxSqsuare.Size = new System.Drawing.Size(79, 221);
            this.groupBoxSqsuare.TabIndex = 11;
            this.groupBoxSqsuare.TabStop = false;
            this.groupBoxSqsuare.Text = "properties";
            this.groupBoxSqsuare.Visible = false;
            // 
            // textBoxSquareWidth
            // 
            this.textBoxSquareWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSquareWidth.Location = new System.Drawing.Point(12, 151);
            this.textBoxSquareWidth.Name = "textBoxSquareWidth";
            this.textBoxSquareWidth.Size = new System.Drawing.Size(58, 20);
            this.textBoxSquareWidth.TabIndex = 11;
            this.textBoxSquareWidth.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Border color:";
            // 
            // panelSquareFcolor
            // 
            this.panelSquareFcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSquareFcolor.BackColor = System.Drawing.Color.Gray;
            this.panelSquareFcolor.Location = new System.Drawing.Point(12, 72);
            this.panelSquareFcolor.Name = "panelSquareFcolor";
            this.panelSquareFcolor.Size = new System.Drawing.Size(58, 21);
            this.panelSquareFcolor.TabIndex = 4;
            this.panelSquareFcolor.DoubleClick += new System.EventHandler(this.panelSquareFcolor_DoubleClick);
            // 
            // buttonSquareDraw
            // 
            this.buttonSquareDraw.Location = new System.Drawing.Point(12, 177);
            this.buttonSquareDraw.Name = "buttonSquareDraw";
            this.buttonSquareDraw.Size = new System.Drawing.Size(58, 23);
            this.buttonSquareDraw.TabIndex = 7;
            this.buttonSquareDraw.Text = "draw";
            this.buttonSquareDraw.UseVisualStyleBackColor = true;
            this.buttonSquareDraw.Click += new System.EventHandler(this.buttonSquareDraw_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Border color:";
            // 
            // textBoxSquarePenSize
            // 
            this.textBoxSquarePenSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSquarePenSize.Location = new System.Drawing.Point(12, 112);
            this.textBoxSquarePenSize.Name = "textBoxSquarePenSize";
            this.textBoxSquarePenSize.Size = new System.Drawing.Size(58, 20);
            this.textBoxSquarePenSize.TabIndex = 6;
            this.textBoxSquarePenSize.Text = "3";
            // 
            // panelSquareBcolor
            // 
            this.panelSquareBcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSquareBcolor.BackColor = System.Drawing.Color.Black;
            this.panelSquareBcolor.Location = new System.Drawing.Point(12, 32);
            this.panelSquareBcolor.Name = "panelSquareBcolor";
            this.panelSquareBcolor.Size = new System.Drawing.Size(58, 21);
            this.panelSquareBcolor.TabIndex = 2;
            this.panelSquareBcolor.DoubleClick += new System.EventHandler(this.panelSquareBcolor_DoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pen size:";
            // 
            // panelWorkSpace
            // 
            this.panelWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorkSpace.BackColor = System.Drawing.Color.Gray;
            this.panelWorkSpace.Controls.Add(this.panelImg);
            this.panelWorkSpace.Location = new System.Drawing.Point(3, 3);
            this.panelWorkSpace.Name = "panelWorkSpace";
            this.panelWorkSpace.Size = new System.Drawing.Size(533, 396);
            this.panelWorkSpace.TabIndex = 0;
            // 
            // panelImg
            // 
            this.panelImg.AutoScroll = true;
            this.panelImg.BackColor = System.Drawing.Color.White;
            this.panelImg.Location = new System.Drawing.Point(-3, -2);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(487, 355);
            this.panelImg.TabIndex = 0;
            this.panelImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelImg_MouseClick);
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCircle.Controls.Add(this.textBoxCircleDiametr);
            this.groupBoxCircle.Controls.Add(this.labelDiametr);
            this.groupBoxCircle.Controls.Add(this.buttonCircleDraw);
            this.groupBoxCircle.Controls.Add(this.labelCircleBcolot);
            this.groupBoxCircle.Controls.Add(this.textBoxPenSize);
            this.groupBoxCircle.Controls.Add(this.panelCircleBcolor);
            this.groupBoxCircle.Controls.Add(this.labelPenSize);
            this.groupBoxCircle.Location = new System.Drawing.Point(542, 3);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(79, 174);
            this.groupBoxCircle.TabIndex = 8;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "properties";
            this.groupBoxCircle.Visible = false;
            // 
            // textBoxCircleDiametr
            // 
            this.textBoxCircleDiametr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCircleDiametr.Location = new System.Drawing.Point(12, 111);
            this.textBoxCircleDiametr.Name = "textBoxCircleDiametr";
            this.textBoxCircleDiametr.Size = new System.Drawing.Size(58, 20);
            this.textBoxCircleDiametr.TabIndex = 9;
            this.textBoxCircleDiametr.Text = "100";
            // 
            // labelDiametr
            // 
            this.labelDiametr.AutoSize = true;
            this.labelDiametr.Location = new System.Drawing.Point(9, 95);
            this.labelDiametr.Name = "labelDiametr";
            this.labelDiametr.Size = new System.Drawing.Size(52, 13);
            this.labelDiametr.TabIndex = 8;
            this.labelDiametr.Text = "Diameter:";
            // 
            // buttonCircleDraw
            // 
            this.buttonCircleDraw.Location = new System.Drawing.Point(12, 137);
            this.buttonCircleDraw.Name = "buttonCircleDraw";
            this.buttonCircleDraw.Size = new System.Drawing.Size(58, 23);
            this.buttonCircleDraw.TabIndex = 7;
            this.buttonCircleDraw.Text = "draw";
            this.buttonCircleDraw.UseVisualStyleBackColor = true;
            this.buttonCircleDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCircleDraw_MouseClick);
            // 
            // labelCircleBcolot
            // 
            this.labelCircleBcolot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCircleBcolot.AutoSize = true;
            this.labelCircleBcolot.Location = new System.Drawing.Point(9, 16);
            this.labelCircleBcolot.Name = "labelCircleBcolot";
            this.labelCircleBcolot.Size = new System.Drawing.Size(67, 13);
            this.labelCircleBcolot.TabIndex = 1;
            this.labelCircleBcolot.Text = "Border color:";
            // 
            // textBoxPenSize
            // 
            this.textBoxPenSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPenSize.Location = new System.Drawing.Point(12, 72);
            this.textBoxPenSize.Name = "textBoxPenSize";
            this.textBoxPenSize.Size = new System.Drawing.Size(58, 20);
            this.textBoxPenSize.TabIndex = 6;
            this.textBoxPenSize.Text = "3";
            // 
            // panelCircleBcolor
            // 
            this.panelCircleBcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCircleBcolor.BackColor = System.Drawing.Color.Black;
            this.panelCircleBcolor.Location = new System.Drawing.Point(12, 32);
            this.panelCircleBcolor.Name = "panelCircleBcolor";
            this.panelCircleBcolor.Size = new System.Drawing.Size(58, 21);
            this.panelCircleBcolor.TabIndex = 2;
            this.panelCircleBcolor.DoubleClick += new System.EventHandler(this.panelCircleBcolor_DoubleClick);
            // 
            // labelPenSize
            // 
            this.labelPenSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPenSize.AutoSize = true;
            this.labelPenSize.Location = new System.Drawing.Point(9, 56);
            this.labelPenSize.Name = "labelPenSize";
            this.labelPenSize.Size = new System.Drawing.Size(50, 13);
            this.labelPenSize.TabIndex = 5;
            this.labelPenSize.Text = "Pen size:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.objectsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.objectsToolStripMenuItem.Text = "Drawing";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem1,
            this.elipseToolStripMenuItem,
            this.squareToolStripMenuItem});
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.circleToolStripMenuItem.Text = "Objects";
            // 
            // circleToolStripMenuItem1
            // 
            this.circleToolStripMenuItem1.Name = "circleToolStripMenuItem1";
            this.circleToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.circleToolStripMenuItem1.Text = "Circle";
            this.circleToolStripMenuItem1.Click += new System.EventHandler(this.circleToolStripMenuItem1_Click);
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelInstruments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.panelInstruments.ResumeLayout(false);
            this.groupBoxElipse.ResumeLayout(false);
            this.groupBoxElipse.PerformLayout();
            this.groupBoxSqsuare.ResumeLayout(false);
            this.groupBoxSqsuare.PerformLayout();
            this.panelWorkSpace.ResumeLayout(false);
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInstruments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelWorkSpace;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCircle;
        private System.Windows.Forms.Label labelCircleBcolot;
        private System.Windows.Forms.TextBox textBoxPenSize;
        private System.Windows.Forms.Panel panelCircleBcolor;
        private System.Windows.Forms.Label labelPenSize;
        private System.Windows.Forms.Button buttonCircleDraw;
        private System.Windows.Forms.Label labelDiametr;
        private System.Windows.Forms.TextBox textBoxCircleDiametr;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxElipse;
        private System.Windows.Forms.TextBox textBoxElipseHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxElipseWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelElipseFcolor;
        private System.Windows.Forms.Panel panelElipseFcolor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEliseBcolor;
        private System.Windows.Forms.TextBox textBoxElipsePenSize;
        private System.Windows.Forms.Panel panelElipseBcolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxSqsuare;
        private System.Windows.Forms.TextBox textBoxSquareWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSquareFcolor;
        private System.Windows.Forms.Button buttonSquareDraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSquarePenSize;
        private System.Windows.Forms.Panel panelSquareBcolor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

