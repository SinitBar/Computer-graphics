
namespace KompGraph1
{
    partial class FormMain
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPlaceObjectDots = new System.Windows.Forms.Button();
            this.buttonSelectInitObectColor = new System.Windows.Forms.Button();
            this.buttonSelectNewObjectColor = new System.Windows.Forms.Button();
            this.groupBoxMirror = new System.Windows.Forms.GroupBox();
            this.checkBoxMirrorOy = new System.Windows.Forms.CheckBox();
            this.checkBoxMirrorOx = new System.Windows.Forms.CheckBox();
            this.checkBoxScaling = new System.Windows.Forms.CheckBox();
            this.textBoxFactor = new System.Windows.Forms.TextBox();
            this.maskedTextBoxFactor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOyTo = new System.Windows.Forms.Label();
            this.labelOxTo = new System.Windows.Forms.Label();
            this.labelOyFrom = new System.Windows.Forms.Label();
            this.labelOxFrom = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.labelO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMoveCenter = new System.Windows.Forms.Button();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNewDotY = new System.Windows.Forms.TextBox();
            this.textBoxNewDotX = new System.Windows.Forms.TextBox();
            this.buttonAddDot = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelForClickedPoint = new System.Windows.Forms.Label();
            this.labelClickedPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxMirror.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.Location = new System.Drawing.Point(14, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(527, 527);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // buttonPlaceObjectDots
            // 
            this.buttonPlaceObjectDots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaceObjectDots.Location = new System.Drawing.Point(542, 211);
            this.buttonPlaceObjectDots.Name = "buttonPlaceObjectDots";
            this.buttonPlaceObjectDots.Size = new System.Drawing.Size(270, 32);
            this.buttonPlaceObjectDots.TabIndex = 9;
            this.buttonPlaceObjectDots.Text = "Place obect\'s dots";
            this.buttonPlaceObjectDots.UseVisualStyleBackColor = true;
            this.buttonPlaceObjectDots.Click += new System.EventHandler(this.buttonPlaceObjectDots_Click);
            // 
            // buttonSelectInitObectColor
            // 
            this.buttonSelectInitObectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectInitObectColor.Location = new System.Drawing.Point(542, 426);
            this.buttonSelectInitObectColor.Name = "buttonSelectInitObectColor";
            this.buttonSelectInitObectColor.Size = new System.Drawing.Size(270, 32);
            this.buttonSelectInitObectColor.TabIndex = 10;
            this.buttonSelectInitObectColor.Text = "Select initial object\'s color";
            this.buttonSelectInitObectColor.UseVisualStyleBackColor = true;
            this.buttonSelectInitObectColor.Click += new System.EventHandler(this.buttonSelectInitObectColor_Click);
            // 
            // buttonSelectNewObjectColor
            // 
            this.buttonSelectNewObjectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectNewObjectColor.Location = new System.Drawing.Point(542, 464);
            this.buttonSelectNewObjectColor.Name = "buttonSelectNewObjectColor";
            this.buttonSelectNewObjectColor.Size = new System.Drawing.Size(270, 32);
            this.buttonSelectNewObjectColor.TabIndex = 11;
            this.buttonSelectNewObjectColor.Text = "Select changed object\'s color";
            this.buttonSelectNewObjectColor.UseVisualStyleBackColor = true;
            this.buttonSelectNewObjectColor.Click += new System.EventHandler(this.buttonSelectNewObjectColor_Click);
            // 
            // groupBoxMirror
            // 
            this.groupBoxMirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMirror.Controls.Add(this.checkBoxMirrorOy);
            this.groupBoxMirror.Controls.Add(this.checkBoxMirrorOx);
            this.groupBoxMirror.Location = new System.Drawing.Point(548, 320);
            this.groupBoxMirror.Name = "groupBoxMirror";
            this.groupBoxMirror.Size = new System.Drawing.Size(145, 100);
            this.groupBoxMirror.TabIndex = 16;
            this.groupBoxMirror.TabStop = false;
            this.groupBoxMirror.Text = "Mirror regarding:";
            // 
            // checkBoxMirrorOy
            // 
            this.checkBoxMirrorOy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMirrorOy.AutoSize = true;
            this.checkBoxMirrorOy.Location = new System.Drawing.Point(39, 65);
            this.checkBoxMirrorOy.Name = "checkBoxMirrorOy";
            this.checkBoxMirrorOy.Size = new System.Drawing.Size(54, 24);
            this.checkBoxMirrorOy.TabIndex = 33;
            this.checkBoxMirrorOy.Text = "Oy";
            this.checkBoxMirrorOy.UseVisualStyleBackColor = true;
            this.checkBoxMirrorOy.CheckedChanged += new System.EventHandler(this.checkBoxMirrorOy_CheckedChanged);
            // 
            // checkBoxMirrorOx
            // 
            this.checkBoxMirrorOx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMirrorOx.AutoSize = true;
            this.checkBoxMirrorOx.Location = new System.Drawing.Point(39, 25);
            this.checkBoxMirrorOx.Name = "checkBoxMirrorOx";
            this.checkBoxMirrorOx.Size = new System.Drawing.Size(54, 24);
            this.checkBoxMirrorOx.TabIndex = 32;
            this.checkBoxMirrorOx.Text = "Ox";
            this.checkBoxMirrorOx.UseVisualStyleBackColor = true;
            this.checkBoxMirrorOx.CheckedChanged += new System.EventHandler(this.checkBoxMirrorOx_CheckedChanged);
            // 
            // checkBoxScaling
            // 
            this.checkBoxScaling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxScaling.AutoSize = true;
            this.checkBoxScaling.Location = new System.Drawing.Point(708, 330);
            this.checkBoxScaling.Name = "checkBoxScaling";
            this.checkBoxScaling.Size = new System.Drawing.Size(87, 24);
            this.checkBoxScaling.TabIndex = 17;
            this.checkBoxScaling.Text = "Scaling";
            this.checkBoxScaling.UseVisualStyleBackColor = true;
            this.checkBoxScaling.CheckedChanged += new System.EventHandler(this.checkBoxScaling_CheckedChanged);
            // 
            // textBoxFactor
            // 
            this.textBoxFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFactor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFactor.Location = new System.Drawing.Point(708, 360);
            this.textBoxFactor.Name = "textBoxFactor";
            this.textBoxFactor.ReadOnly = true;
            this.textBoxFactor.Size = new System.Drawing.Size(87, 19);
            this.textBoxFactor.TabIndex = 18;
            this.textBoxFactor.Text = "with factor:";
            // 
            // maskedTextBoxFactor
            // 
            this.maskedTextBoxFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxFactor.Location = new System.Drawing.Point(708, 385);
            this.maskedTextBoxFactor.Name = "maskedTextBoxFactor";
            this.maskedTextBoxFactor.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBoxFactor.TabIndex = 19;
            this.maskedTextBoxFactor.Text = "1";
            this.maskedTextBoxFactor.TextChanged += new System.EventHandler(this.maskedTextBoxFactor_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ox from:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Oy from:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "to:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "to:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelOyTo);
            this.groupBox1.Controls.Add(this.labelOxTo);
            this.groupBox1.Controls.Add(this.labelOyFrom);
            this.groupBox1.Controls.Add(this.labelOxFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(546, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axes settings";
            // 
            // labelOyTo
            // 
            this.labelOyTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOyTo.AutoSize = true;
            this.labelOyTo.Location = new System.Drawing.Point(198, 61);
            this.labelOyTo.Name = "labelOyTo";
            this.labelOyTo.Size = new System.Drawing.Size(34, 20);
            this.labelOyTo.TabIndex = 31;
            this.labelOyTo.Text = "y to";
            // 
            // labelOxTo
            // 
            this.labelOxTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOxTo.AutoSize = true;
            this.labelOxTo.Location = new System.Drawing.Point(198, 28);
            this.labelOxTo.Name = "labelOxTo";
            this.labelOxTo.Size = new System.Drawing.Size(34, 20);
            this.labelOxTo.TabIndex = 30;
            this.labelOxTo.Text = "x to";
            // 
            // labelOyFrom
            // 
            this.labelOyFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOyFrom.AutoSize = true;
            this.labelOyFrom.Location = new System.Drawing.Point(94, 61);
            this.labelOyFrom.Name = "labelOyFrom";
            this.labelOyFrom.Size = new System.Drawing.Size(52, 20);
            this.labelOyFrom.TabIndex = 29;
            this.labelOyFrom.Text = "y from";
            // 
            // labelOxFrom
            // 
            this.labelOxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOxFrom.AutoSize = true;
            this.labelOxFrom.Location = new System.Drawing.Point(94, 28);
            this.labelOxFrom.Name = "labelOxFrom";
            this.labelOxFrom.Size = new System.Drawing.Size(52, 20);
            this.labelOxFrom.TabIndex = 28;
            this.labelOxFrom.Text = "x from";
            // 
            // labelO
            // 
            this.labelO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(704, 117);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(51, 20);
            this.labelO.TabIndex = 32;
            this.labelO.Text = "label5";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Current Center O: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonMoveCenter);
            this.groupBox2.Controls.Add(this.textBoxCenterY);
            this.groupBox2.Controls.Add(this.textBoxCenterX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(546, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 65);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shift center on:";
            // 
            // buttonMoveCenter
            // 
            this.buttonMoveCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveCenter.Location = new System.Drawing.Point(189, 22);
            this.buttonMoveCenter.Name = "buttonMoveCenter";
            this.buttonMoveCenter.Size = new System.Drawing.Size(70, 32);
            this.buttonMoveCenter.TabIndex = 40;
            this.buttonMoveCenter.Text = "Move";
            this.buttonMoveCenter.UseVisualStyleBackColor = true;
            this.buttonMoveCenter.Click += new System.EventHandler(this.buttonMoveCenter_Click);
            // 
            // textBoxCenterY
            // 
            this.textBoxCenterY.Location = new System.Drawing.Point(125, 25);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(58, 26);
            this.textBoxCenterY.TabIndex = 37;
            this.textBoxCenterY.TextChanged += new System.EventHandler(this.textBoxCenterY_TextChanged);
            // 
            // textBoxCenterX
            // 
            this.textBoxCenterX.Location = new System.Drawing.Point(31, 25);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(58, 26);
            this.textBoxCenterX.TabIndex = 36;
            this.textBoxCenterX.TextChanged += new System.EventHandler(this.textBoxCenterX_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Y:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxNewDotY);
            this.groupBox3.Controls.Add(this.textBoxNewDotX);
            this.groupBox3.Controls.Add(this.buttonAddDot);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(548, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 65);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add new dot:";
            // 
            // textBoxNewDotY
            // 
            this.textBoxNewDotY.Location = new System.Drawing.Point(124, 25);
            this.textBoxNewDotY.Name = "textBoxNewDotY";
            this.textBoxNewDotY.Size = new System.Drawing.Size(58, 26);
            this.textBoxNewDotY.TabIndex = 39;
            this.textBoxNewDotY.TextChanged += new System.EventHandler(this.textBoxNewDotY_TextChanged);
            // 
            // textBoxNewDotX
            // 
            this.textBoxNewDotX.Location = new System.Drawing.Point(30, 25);
            this.textBoxNewDotX.Name = "textBoxNewDotX";
            this.textBoxNewDotX.Size = new System.Drawing.Size(58, 26);
            this.textBoxNewDotX.TabIndex = 38;
            this.textBoxNewDotX.TextChanged += new System.EventHandler(this.textBoxNewDotX_TextChanged);
            // 
            // buttonAddDot
            // 
            this.buttonAddDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDot.Location = new System.Drawing.Point(192, 22);
            this.buttonAddDot.Name = "buttonAddDot";
            this.buttonAddDot.Size = new System.Drawing.Size(60, 32);
            this.buttonAddDot.TabIndex = 36;
            this.buttonAddDot.Text = "Add";
            this.buttonAddDot.UseVisualStyleBackColor = true;
            this.buttonAddDot.Click += new System.EventHandler(this.buttonAddDot_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "X:";
            // 
            // labelForClickedPoint
            // 
            this.labelForClickedPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForClickedPoint.AutoSize = true;
            this.labelForClickedPoint.Location = new System.Drawing.Point(552, 499);
            this.labelForClickedPoint.Name = "labelForClickedPoint";
            this.labelForClickedPoint.Size = new System.Drawing.Size(161, 20);
            this.labelForClickedPoint.TabIndex = 36;
            this.labelForClickedPoint.Text = "Clicked object\'s point:";
            // 
            // labelClickedPoint
            // 
            this.labelClickedPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClickedPoint.AutoSize = true;
            this.labelClickedPoint.Location = new System.Drawing.Point(711, 499);
            this.labelClickedPoint.Name = "labelClickedPoint";
            this.labelClickedPoint.Size = new System.Drawing.Size(60, 20);
            this.labelClickedPoint.TabIndex = 37;
            this.labelClickedPoint.Text = "label12";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 551);
            this.Controls.Add(this.labelClickedPoint);
            this.Controls.Add(this.labelForClickedPoint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBoxFactor);
            this.Controls.Add(this.textBoxFactor);
            this.Controls.Add(this.checkBoxScaling);
            this.Controls.Add(this.groupBoxMirror);
            this.Controls.Add(this.buttonSelectNewObjectColor);
            this.Controls.Add(this.buttonSelectInitObectColor);
            this.Controls.Add(this.buttonPlaceObjectDots);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormMain";
            this.Text = "Mirror flat object regarding axes with scaling";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxMirror.ResumeLayout(false);
            this.groupBoxMirror.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPlaceObjectDots;
        private System.Windows.Forms.Button buttonSelectInitObectColor;
        private System.Windows.Forms.Button buttonSelectNewObjectColor;
        private System.Windows.Forms.GroupBox groupBoxMirror;
        private System.Windows.Forms.CheckBox checkBoxScaling;
        private System.Windows.Forms.TextBox textBoxFactor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox checkBoxMirrorOy;
        private System.Windows.Forms.CheckBox checkBoxMirrorOx;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddDot;
        private System.Windows.Forms.Label labelOyTo;
        private System.Windows.Forms.Label labelOxTo;
        private System.Windows.Forms.Label labelOyFrom;
        private System.Windows.Forms.Label labelOxFrom;
        private System.Windows.Forms.TextBox textBoxCenterY;
        private System.Windows.Forms.TextBox textBoxCenterX;
        private System.Windows.Forms.TextBox textBoxNewDotY;
        private System.Windows.Forms.TextBox textBoxNewDotX;
        private System.Windows.Forms.Button buttonMoveCenter;
        private System.Windows.Forms.Label labelForClickedPoint;
        private System.Windows.Forms.Label labelClickedPoint;
    }
}

