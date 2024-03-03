namespace NFSColorPicker
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
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            tbInputR = new FastTextBox();
            lbColorR = new Label();
            lbColorB = new Label();
            lbColorG = new Label();
            tbInputG = new FastTextBox();
            tbInputB = new FastTextBox();
            tbRGBHex = new FastTextBox();
            lbRGBHex = new Label();
            lbRGBDecimal = new Label();
            tbRGBDecimal = new FastTextBox();
            tbRGBHexSwap = new FastTextBox();
            tbRGBDecimalSwap = new FastTextBox();
            lbSwapLabel = new Label();
            lbNormalLabel = new Label();
            tbInputA = new FastTextBox();
            lbColorA = new Label();
            pbPreview = new PictureBox();
            tbResultValue = new TextBox();
            lbResult = new Label();
            lbCopyPasteNote = new Label();
            lbCopyPasteNote2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPreview).BeginInit();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.Color = Color.Red;
            colorDialog1.FullOpen = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 0;
            button1.Text = "Color Picker";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbInputR
            // 
            tbInputR.Hint = "";
            tbInputR.Location = new Point(35, 61);
            tbInputR.Name = "tbInputR";
            tbInputR.Size = new Size(42, 23);
            tbInputR.TabIndex = 1;
            tbInputR.TextAcceptor = null;
            tbInputR.Validated += tbInputR_Validated;
            // 
            // lbColorR
            // 
            lbColorR.AutoSize = true;
            lbColorR.Location = new Point(13, 64);
            lbColorR.Name = "lbColorR";
            lbColorR.Size = new Size(17, 15);
            lbColorR.TabIndex = 2;
            lbColorR.Text = "R:";
            // 
            // lbColorB
            // 
            lbColorB.AutoSize = true;
            lbColorB.Location = new Point(12, 122);
            lbColorB.Name = "lbColorB";
            lbColorB.Size = new Size(17, 15);
            lbColorB.TabIndex = 3;
            lbColorB.Text = "B:";
            // 
            // lbColorG
            // 
            lbColorG.AutoSize = true;
            lbColorG.Location = new Point(12, 93);
            lbColorG.Name = "lbColorG";
            lbColorG.Size = new Size(18, 15);
            lbColorG.TabIndex = 4;
            lbColorG.Text = "G:";
            // 
            // tbInputG
            // 
            tbInputG.Hint = "";
            tbInputG.Location = new Point(36, 90);
            tbInputG.Name = "tbInputG";
            tbInputG.Size = new Size(42, 23);
            tbInputG.TabIndex = 5;
            tbInputG.TextAcceptor = null;
            tbInputG.Validated += tbInputG_Validated;
            // 
            // tbInputB
            // 
            tbInputB.Hint = "";
            tbInputB.Location = new Point(36, 119);
            tbInputB.Name = "tbInputB";
            tbInputB.Size = new Size(42, 23);
            tbInputB.TabIndex = 6;
            tbInputB.TextAcceptor = null;
            tbInputB.Validated += tbInputB_Validated;
            // 
            // tbRGBHex
            // 
            tbRGBHex.Hint = "";
            tbRGBHex.Location = new Point(147, 61);
            tbRGBHex.Name = "tbRGBHex";
            tbRGBHex.Size = new Size(100, 23);
            tbRGBHex.TabIndex = 7;
            tbRGBHex.TextAcceptor = null;
            tbRGBHex.Validated += tbRGBHex_Validated;
            // 
            // lbRGBHex
            // 
            lbRGBHex.AutoSize = true;
            lbRGBHex.Location = new Point(113, 64);
            lbRGBHex.Name = "lbRGBHex";
            lbRGBHex.Size = new Size(28, 15);
            lbRGBHex.TabIndex = 8;
            lbRGBHex.Text = "Hex";
            // 
            // lbRGBDecimal
            // 
            lbRGBDecimal.AutoSize = true;
            lbRGBDecimal.Location = new Point(91, 93);
            lbRGBDecimal.Name = "lbRGBDecimal";
            lbRGBDecimal.Size = new Size(50, 15);
            lbRGBDecimal.TabIndex = 9;
            lbRGBDecimal.Text = "Decimal";
            // 
            // tbRGBDecimal
            // 
            tbRGBDecimal.Hint = "";
            tbRGBDecimal.Location = new Point(147, 90);
            tbRGBDecimal.Name = "tbRGBDecimal";
            tbRGBDecimal.Size = new Size(100, 23);
            tbRGBDecimal.TabIndex = 10;
            tbRGBDecimal.TextAcceptor = null;
            tbRGBDecimal.Validated += tbRGBDecimal_Validated;
            // 
            // tbRGBHexSwap
            // 
            tbRGBHexSwap.Hint = "";
            tbRGBHexSwap.Location = new Point(253, 61);
            tbRGBHexSwap.Name = "tbRGBHexSwap";
            tbRGBHexSwap.Size = new Size(100, 23);
            tbRGBHexSwap.TabIndex = 11;
            tbRGBHexSwap.TextAcceptor = null;
            tbRGBHexSwap.Validated += tbRGBHexSwap_Validated;
            // 
            // tbRGBDecimalSwap
            // 
            tbRGBDecimalSwap.Hint = "";
            tbRGBDecimalSwap.Location = new Point(253, 90);
            tbRGBDecimalSwap.Name = "tbRGBDecimalSwap";
            tbRGBDecimalSwap.Size = new Size(100, 23);
            tbRGBDecimalSwap.TabIndex = 12;
            tbRGBDecimalSwap.TextAcceptor = null;
            tbRGBDecimalSwap.Validated += tbRGBDecimalSwap_Validated;
            // 
            // lbSwapLabel
            // 
            lbSwapLabel.AutoSize = true;
            lbSwapLabel.Location = new Point(253, 43);
            lbSwapLabel.Name = "lbSwapLabel";
            lbSwapLabel.Size = new Size(40, 15);
            lbSwapLabel.TabIndex = 13;
            lbSwapLabel.Text = "RGBA:";
            // 
            // lbNormalLabel
            // 
            lbNormalLabel.AutoSize = true;
            lbNormalLabel.Location = new Point(147, 43);
            lbNormalLabel.Name = "lbNormalLabel";
            lbNormalLabel.Size = new Size(40, 15);
            lbNormalLabel.TabIndex = 14;
            lbNormalLabel.Text = "ARGB:";
            // 
            // tbInputA
            // 
            tbInputA.Hint = "";
            tbInputA.Location = new Point(36, 148);
            tbInputA.Name = "tbInputA";
            tbInputA.Size = new Size(41, 23);
            tbInputA.TabIndex = 15;
            tbInputA.TextAcceptor = null;
            tbInputA.Validated += tbInputA_Validated;
            // 
            // lbColorA
            // 
            lbColorA.AutoSize = true;
            lbColorA.Location = new Point(11, 151);
            lbColorA.Name = "lbColorA";
            lbColorA.Size = new Size(18, 15);
            lbColorA.TabIndex = 16;
            lbColorA.Text = "A:";
            // 
            // pbPreview
            // 
            pbPreview.Location = new Point(156, 8);
            pbPreview.Name = "pbPreview";
            pbPreview.Size = new Size(204, 27);
            pbPreview.TabIndex = 19;
            pbPreview.TabStop = false;
            // 
            // tbResultValue
            // 
            tbResultValue.Location = new Point(253, 119);
            tbResultValue.Name = "tbResultValue";
            tbResultValue.ReadOnly = true;
            tbResultValue.Size = new Size(100, 23);
            tbResultValue.TabIndex = 20;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(102, 122);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(145, 15);
            lbResult.TabIndex = 21;
            lbResult.Text = "Result (copy this to VltEd):";
            // 
            // lbCopyPasteNote
            // 
            lbCopyPasteNote.AutoSize = true;
            lbCopyPasteNote.Location = new Point(102, 148);
            lbCopyPasteNote.Name = "lbCopyPasteNote";
            lbCopyPasteNote.Size = new Size(229, 15);
            lbCopyPasteNote.TabIndex = 22;
            lbCopyPasteNote.Text = "NOTE: Ctrl+C is broken (except on Result).";
            // 
            // lbCopyPasteNote2
            // 
            lbCopyPasteNote2.AutoSize = true;
            lbCopyPasteNote2.Location = new Point(102, 163);
            lbCopyPasteNote2.Name = "lbCopyPasteNote2";
            lbCopyPasteNote2.Size = new Size(263, 15);
            lbCopyPasteNote2.TabIndex = 23;
            lbCopyPasteNote2.Text = "Use the context menu to copy from other boxes.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 188);
            Controls.Add(lbCopyPasteNote2);
            Controls.Add(lbCopyPasteNote);
            Controls.Add(lbResult);
            Controls.Add(tbResultValue);
            Controls.Add(pbPreview);
            Controls.Add(lbColorA);
            Controls.Add(tbInputA);
            Controls.Add(lbNormalLabel);
            Controls.Add(lbSwapLabel);
            Controls.Add(tbRGBDecimalSwap);
            Controls.Add(tbRGBHexSwap);
            Controls.Add(tbRGBDecimal);
            Controls.Add(lbRGBDecimal);
            Controls.Add(lbRGBHex);
            Controls.Add(tbRGBHex);
            Controls.Add(tbInputB);
            Controls.Add(tbInputG);
            Controls.Add(lbColorG);
            Controls.Add(lbColorB);
            Controls.Add(lbColorR);
            Controls.Add(tbInputR);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "NFS Color Picker";
            ((System.ComponentModel.ISupportInitialize)pbPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button button1;
        private FastTextBox tbInputR;
        private Label lbColorR;
        private Label lbColorB;
        private Label lbColorG;
        private FastTextBox tbInputG;
        private FastTextBox tbInputB;
        private FastTextBox tbRGBHex;
        private Label lbRGBHex;
        private Label lbRGBDecimal;
        private FastTextBox tbRGBDecimal;
        private FastTextBox tbRGBHexSwap;
        private FastTextBox tbRGBDecimalSwap;
        private Label lbSwapLabel;
        private Label lbNormalLabel;
        private FastTextBox tbInputA;
        private Label lbColorA;
        private PictureBox pbPreview;
        private TextBox tbResultValue;
        private Label lbResult;
        private Label lbCopyPasteNote;
        private Label lbCopyPasteNote2;
    }
}