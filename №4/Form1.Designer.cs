namespace _4
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
            this.Panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorForDrawingButton = new System.Windows.Forms.Button();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.ReproduceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorForDrawingDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Window;
            this.Panel.Location = new System.Drawing.Point(-1, 1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(800, 292);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorForDrawingButton);
            this.groupBox1.Controls.Add(this.SpeedTextBox);
            this.groupBox1.Controls.Add(this.ReproduceButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // ColorForDrawingButton
            // 
            this.ColorForDrawingButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorForDrawingButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ColorForDrawingButton.Location = new System.Drawing.Point(289, 16);
            this.ColorForDrawingButton.Name = "ColorForDrawingButton";
            this.ColorForDrawingButton.Size = new System.Drawing.Size(43, 41);
            this.ColorForDrawingButton.TabIndex = 4;
            this.ColorForDrawingButton.UseVisualStyleBackColor = false;
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(227, 66);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(125, 27);
            this.SpeedTextBox.TabIndex = 3;
            // 
            // ReproduceButton
            // 
            this.ReproduceButton.Location = new System.Drawing.Point(603, 26);
            this.ReproduceButton.Name = "ReproduceButton";
            this.ReproduceButton.Size = new System.Drawing.Size(138, 80);
            this.ReproduceButton.TabIndex = 2;
            this.ReproduceButton.Text = "Воспроизвести";
            this.ReproduceButton.UseVisualStyleBackColor = true;
            this.ReproduceButton.Click += new System.EventHandler(this.ReproduceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость воспроизведения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор цвета для воспроизведения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox SpeedTextBox;
        private Button ReproduceButton;
        private Button ColorForDrawingButton;
        private ColorDialog ColorForDrawingDialog;
    }
}