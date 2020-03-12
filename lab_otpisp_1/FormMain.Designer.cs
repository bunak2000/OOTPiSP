namespace lab_otpisp_1
{
    partial class FormMain
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
            this.PictureBoxDrawField = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelInfo5 = new System.Windows.Forms.Label();
            this.labelIndo4 = new System.Windows.Forms.Label();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxPenWidth = new System.Windows.Forms.TextBox();
            this.textBoxInput4 = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxInput3 = new System.Windows.Forms.TextBox();
            this.labelInfoFigure = new System.Windows.Forms.Label();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDrawField)).BeginInit();
            this.panelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxDrawField
            // 
            this.PictureBoxDrawField.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxDrawField.Location = new System.Drawing.Point(0, 24);
            this.PictureBoxDrawField.Name = "PictureBoxDrawField";
            this.PictureBoxDrawField.Size = new System.Drawing.Size(1167, 679);
            this.PictureBoxDrawField.TabIndex = 0;
            this.PictureBoxDrawField.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.buttonPrev);
            this.panelMain.Controls.Add(this.labelType);
            this.panelMain.Controls.Add(this.buttonAdd);
            this.panelMain.Controls.Add(this.labelInfo5);
            this.panelMain.Controls.Add(this.labelIndo4);
            this.panelMain.Controls.Add(this.labelInfo3);
            this.panelMain.Controls.Add(this.labelInfo2);
            this.panelMain.Controls.Add(this.labelInfo1);
            this.panelMain.Controls.Add(this.buttonColor);
            this.panelMain.Controls.Add(this.textBoxPenWidth);
            this.panelMain.Controls.Add(this.textBoxInput4);
            this.panelMain.Controls.Add(this.textBoxY);
            this.panelMain.Controls.Add(this.textBoxX);
            this.panelMain.Controls.Add(this.textBoxInput3);
            this.panelMain.Controls.Add(this.labelInfoFigure);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(925, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(275, 679);
            this.panelMain.TabIndex = 1;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(172, 47);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(25, 25);
            this.buttonNext.TabIndex = 19;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(52, 47);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(25, 25);
            this.buttonPrev.TabIndex = 17;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(83, 55);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(56, 13);
            this.labelType.TabIndex = 16;
            this.labelType.Text = "Rectangle";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(95, 331);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Цвет пера";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelInfo5
            // 
            this.labelInfo5.AutoSize = true;
            this.labelInfo5.Location = new System.Drawing.Point(15, 229);
            this.labelInfo5.Name = "labelInfo5";
            this.labelInfo5.Size = new System.Drawing.Size(119, 13);
            this.labelInfo5.TabIndex = 14;
            this.labelInfo5.Text = "Введите ширину пера:";
            // 
            // labelIndo4
            // 
            this.labelIndo4.AutoSize = true;
            this.labelIndo4.Location = new System.Drawing.Point(167, 148);
            this.labelIndo4.Name = "labelIndo4";
            this.labelIndo4.Size = new System.Drawing.Size(92, 13);
            this.labelIndo4.TabIndex = 13;
            this.labelIndo4.Text = "Доп параметр 2:";
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Location = new System.Drawing.Point(15, 148);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(92, 13);
            this.labelInfo3.TabIndex = 12;
            this.labelInfo3.Text = "Доп параметр 1:";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Location = new System.Drawing.Point(167, 89);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(62, 13);
            this.labelInfo2.TabIndex = 11;
            this.labelInfo2.Text = "Введите Y:";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(15, 89);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(62, 13);
            this.labelInfo1.TabIndex = 10;
            this.labelInfo1.Text = "Введите X:";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(170, 242);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(92, 23);
            this.buttonColor.TabIndex = 9;
            this.buttonColor.Text = "Цвет пера";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxPenWidth
            // 
            this.textBoxPenWidth.Location = new System.Drawing.Point(18, 245);
            this.textBoxPenWidth.Name = "textBoxPenWidth";
            this.textBoxPenWidth.Size = new System.Drawing.Size(92, 20);
            this.textBoxPenWidth.TabIndex = 8;
            // 
            // textBoxInput4
            // 
            this.textBoxInput4.Location = new System.Drawing.Point(170, 164);
            this.textBoxInput4.Name = "textBoxInput4";
            this.textBoxInput4.Size = new System.Drawing.Size(92, 20);
            this.textBoxInput4.TabIndex = 7;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(170, 105);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(92, 20);
            this.textBoxY.TabIndex = 6;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(18, 105);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(92, 20);
            this.textBoxX.TabIndex = 5;
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.Location = new System.Drawing.Point(18, 164);
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(92, 20);
            this.textBoxInput3.TabIndex = 4;
            // 
            // labelInfoFigure
            // 
            this.labelInfoFigure.AutoSize = true;
            this.labelInfoFigure.Location = new System.Drawing.Point(74, 30);
            this.labelInfoFigure.Name = "labelInfoFigure";
            this.labelInfoFigure.Size = new System.Drawing.Size(98, 13);
            this.labelInfoFigure.TabIndex = 1;
            this.labelInfoFigure.Text = "Выберите фигуру:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSave,
            this.MenuLoad});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(180, 22);
            this.MenuSave.Text = "Сохранить";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuLoad
            // 
            this.MenuLoad.Name = "MenuLoad";
            this.MenuLoad.Size = new System.Drawing.Size(180, 22);
            this.MenuLoad.Text = "Загрузить";
            this.MenuLoad.Click += new System.EventHandler(this.MenuLoad_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.PictureBoxDrawField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDrawField)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxDrawField;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelInfoFigure;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxInput3;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TextBox textBoxPenWidth;
        private System.Windows.Forms.TextBox textBoxInput4;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Label labelInfo5;
        private System.Windows.Forms.Label labelIndo4;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuLoad;
    }
}