namespace _9_лаба_1_часть
{
    partial class mainForm
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbInput.Location = new System.Drawing.Point(13, 13);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "test.txt";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(13, 57);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(117, 13);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "Информация о файле";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(16, 85);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(339, 102);
            this.tbInfo.TabIndex = 2;
            this.tbInfo.TextChanged += new System.EventHandler(this.tbInfo_TextChanged);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(13, 201);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(106, 13);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "содержимое файла";
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(16, 228);
            this.tbEdit.Multiline = true;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.ReadOnly = true;
            this.tbEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEdit.Size = new System.Drawing.Size(339, 133);
            this.tbEdit.TabIndex = 4;
            this.tbEdit.WordWrap = false;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(211, 13);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(144, 29);
            this.btnGetInfo.TabIndex = 5;
            this.btnGetInfo.Text = "загрузить информацию";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(211, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.tbInput);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.Button btnGetInfo;
        public System.Windows.Forms.Button btnSave;
    }
}

