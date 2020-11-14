namespace ColumnsNumberByCoordinates
{
    partial class OptionsForm
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
            this.rbXthenY = new System.Windows.Forms.RadioButton();
            this.tbPref = new System.Windows.Forms.TextBox();
            this.labelXorY = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelPref = new System.Windows.Forms.Label();
            this.rbYthenX = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbXthenY
            // 
            this.rbXthenY.AutoSize = true;
            this.rbXthenY.Checked = true;
            this.rbXthenY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbXthenY.Location = new System.Drawing.Point(15, 28);
            this.rbXthenY.Name = "rbXthenY";
            this.rbXthenY.Size = new System.Drawing.Size(172, 19);
            this.rbXthenY.TabIndex = 0;
            this.rbXthenY.TabStop = true;
            this.rbXthenY.Text = "Сначала по X, потом по Y";
            this.rbXthenY.UseVisualStyleBackColor = true;
            // 
            // tbPref
            // 
            this.tbPref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPref.Location = new System.Drawing.Point(115, 85);
            this.tbPref.Name = "tbPref";
            this.tbPref.Size = new System.Drawing.Size(72, 20);
            this.tbPref.TabIndex = 2;
            this.tbPref.TextChanged += new System.EventHandler(this.tbPref_TextChanged);
            // 
            // labelXorY
            // 
            this.labelXorY.AutoSize = true;
            this.labelXorY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXorY.Location = new System.Drawing.Point(12, 9);
            this.labelXorY.Name = "labelXorY";
            this.labelXorY.Size = new System.Drawing.Size(216, 15);
            this.labelXorY.TabIndex = 3;
            this.labelXorY.Text = "Выберите вариант упорядочивания";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Location = new System.Drawing.Point(73, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelPref
            // 
            this.labelPref.AutoSize = true;
            this.labelPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPref.Location = new System.Drawing.Point(12, 85);
            this.labelPref.Name = "labelPref";
            this.labelPref.Size = new System.Drawing.Size(102, 15);
            this.labelPref.TabIndex = 5;
            this.labelPref.Text = "Префикс марки:";
            // 
            // rbYthenX
            // 
            this.rbYthenX.AutoSize = true;
            this.rbYthenX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbYthenX.Location = new System.Drawing.Point(15, 53);
            this.rbYthenX.Name = "rbYthenX";
            this.rbYthenX.Size = new System.Drawing.Size(172, 19);
            this.rbYthenX.TabIndex = 6;
            this.rbYthenX.Text = "Сначала по Y, потом по X";
            this.rbYthenX.UseVisualStyleBackColor = true;
            this.rbYthenX.CheckedChanged += new System.EventHandler(this.rbYthenX_CheckedChanged);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(242, 163);
            this.ControlBox = false;
            this.Controls.Add(this.rbYthenX);
            this.Controls.Add(this.labelPref);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelXorY);
            this.Controls.Add(this.tbPref);
            this.Controls.Add(this.rbXthenY);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры маркировки";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbXthenY;
        private System.Windows.Forms.TextBox tbPref;
        private System.Windows.Forms.Label labelXorY;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelPref;
        private System.Windows.Forms.RadioButton rbYthenX;
    }
}