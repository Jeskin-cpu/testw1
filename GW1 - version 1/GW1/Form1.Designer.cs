namespace GW1
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
            this.Pokaz = new System.Windows.Forms.Button();
            this.Beach = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Beach)).BeginInit();
            this.SuspendLayout();
            // 
            // Pokaz
            // 
            this.Pokaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pokaz.Location = new System.Drawing.Point(280, 321);
            this.Pokaz.Name = "Pokaz";
            this.Pokaz.Size = new System.Drawing.Size(233, 78);
            this.Pokaz.TabIndex = 0;
            this.Pokaz.Text = "Показать фото";
            this.Pokaz.UseVisualStyleBackColor = true;
            this.Pokaz.Click += new System.EventHandler(this.Pokaz_Click);
            // 
            // Beach
            // 
            this.Beach.Image = global::GW1.Properties.Resources._5;
            this.Beach.Location = new System.Drawing.Point(180, 12);
            this.Beach.Name = "Beach";
            this.Beach.Size = new System.Drawing.Size(416, 226);
            this.Beach.TabIndex = 1;
            this.Beach.TabStop = false;
            this.Beach.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Beach);
            this.Controls.Add(this.Pokaz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Beach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pokaz;
        private System.Windows.Forms.PictureBox Beach;
    }
}

