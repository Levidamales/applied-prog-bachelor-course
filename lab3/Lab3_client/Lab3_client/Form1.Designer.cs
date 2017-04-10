namespace Lab3_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contentField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pathField
            // 
            this.pathField.Location = new System.Drawing.Point(12, 12);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(260, 20);
            this.pathField.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contentField
            // 
            this.contentField.Location = new System.Drawing.Point(12, 38);
            this.contentField.Multiline = true;
            this.contentField.Name = "contentField";
            this.contentField.Size = new System.Drawing.Size(339, 211);
            this.contentField.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.contentField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lab3 client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox contentField;
    }
}

