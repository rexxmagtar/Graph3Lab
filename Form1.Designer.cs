
namespace Graph3
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DialateButton = new System.Windows.Forms.Button();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckbox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.matrixSizeUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EroseButton = new System.Windows.Forms.Button();
            this.CloseMorphologyButton = new System.Windows.Forms.Button();
            this.OpenMorphologyButton = new System.Windows.Forms.Button();
            this.LinearConstrantButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixSizeUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(41, 31);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(88, 28);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(41, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DialateButton
            // 
            this.DialateButton.Location = new System.Drawing.Point(904, 38);
            this.DialateButton.Name = "DialateButton";
            this.DialateButton.Size = new System.Drawing.Size(89, 23);
            this.DialateButton.TabIndex = 3;
            this.DialateButton.Text = "Dialate";
            this.DialateButton.UseVisualStyleBackColor = true;
            this.DialateButton.Click += new System.EventHandler(this.DialateButton_Click);
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Checked = true;
            this.redCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redCheckBox.Location = new System.Drawing.Point(503, 35);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(78, 21);
            this.redCheckBox.TabIndex = 4;
            this.redCheckBox.Text = "use red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            // 
            // greenCheckbox
            // 
            this.greenCheckbox.AutoSize = true;
            this.greenCheckbox.Checked = true;
            this.greenCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenCheckbox.Location = new System.Drawing.Point(587, 35);
            this.greenCheckbox.Name = "greenCheckbox";
            this.greenCheckbox.Size = new System.Drawing.Size(94, 21);
            this.greenCheckbox.TabIndex = 5;
            this.greenCheckbox.Text = "use green";
            this.greenCheckbox.UseVisualStyleBackColor = true;
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Checked = true;
            this.blueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueCheckBox.Location = new System.Drawing.Point(687, 36);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(84, 21);
            this.blueCheckBox.TabIndex = 6;
            this.blueCheckBox.Text = "use blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            // 
            // matrixSizeUpAndDown
            // 
            this.matrixSizeUpAndDown.Location = new System.Drawing.Point(777, 35);
            this.matrixSizeUpAndDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.matrixSizeUpAndDown.Name = "matrixSizeUpAndDown";
            this.matrixSizeUpAndDown.Size = new System.Drawing.Size(41, 22);
            this.matrixSizeUpAndDown.TabIndex = 7;
            this.matrixSizeUpAndDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matrix size";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EroseButton
            // 
            this.EroseButton.Location = new System.Drawing.Point(1012, 38);
            this.EroseButton.Name = "EroseButton";
            this.EroseButton.Size = new System.Drawing.Size(102, 23);
            this.EroseButton.TabIndex = 9;
            this.EroseButton.Text = "Erosion";
            this.EroseButton.UseVisualStyleBackColor = true;
            this.EroseButton.Click += new System.EventHandler(this.EroseButton_Click);
            // 
            // CloseMorphologyButton
            // 
            this.CloseMorphologyButton.Location = new System.Drawing.Point(1012, 82);
            this.CloseMorphologyButton.Name = "CloseMorphologyButton";
            this.CloseMorphologyButton.Size = new System.Drawing.Size(144, 30);
            this.CloseMorphologyButton.TabIndex = 11;
            this.CloseMorphologyButton.Text = "Close morphology";
            this.CloseMorphologyButton.UseVisualStyleBackColor = true;
            this.CloseMorphologyButton.Click += new System.EventHandler(this.CloseMorphologyButton_Click);
            // 
            // OpenMorphologyButton
            // 
            this.OpenMorphologyButton.Location = new System.Drawing.Point(827, 82);
            this.OpenMorphologyButton.Name = "OpenMorphologyButton";
            this.OpenMorphologyButton.Size = new System.Drawing.Size(178, 30);
            this.OpenMorphologyButton.TabIndex = 10;
            this.OpenMorphologyButton.Text = "Open morphology";
            this.OpenMorphologyButton.UseVisualStyleBackColor = true;
            this.OpenMorphologyButton.Click += new System.EventHandler(this.OpenMorphologyButton_Click);
            // 
            // LinearConstrantButton
            // 
            this.LinearConstrantButton.Location = new System.Drawing.Point(886, 214);
            this.LinearConstrantButton.Name = "LinearConstrantButton";
            this.LinearConstrantButton.Size = new System.Drawing.Size(228, 92);
            this.LinearConstrantButton.TabIndex = 12;
            this.LinearConstrantButton.Text = "Linear contrast";
            this.LinearConstrantButton.UseVisualStyleBackColor = true;
            this.LinearConstrantButton.Click += new System.EventHandler(this.LinearConstrantButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 639);
            this.Controls.Add(this.LinearConstrantButton);
            this.Controls.Add(this.CloseMorphologyButton);
            this.Controls.Add(this.OpenMorphologyButton);
            this.Controls.Add(this.EroseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixSizeUpAndDown);
            this.Controls.Add(this.blueCheckBox);
            this.Controls.Add(this.greenCheckbox);
            this.Controls.Add(this.redCheckBox);
            this.Controls.Add(this.DialateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "monarch_in_may1.jpg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixSizeUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DialateButton;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox greenCheckbox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.NumericUpDown matrixSizeUpAndDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button EroseButton;
        private System.Windows.Forms.Button CloseMorphologyButton;
        private System.Windows.Forms.Button OpenMorphologyButton;
        private System.Windows.Forms.Button LinearConstrantButton;
    }
}

