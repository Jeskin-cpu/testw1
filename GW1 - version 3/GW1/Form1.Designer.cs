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
            this.Pokaz2 = new System.Windows.Forms.Button();
            this.Finkipp = new System.Windows.Forms.PictureBox();
            this.Beach = new System.Windows.Forms.PictureBox();
            this.Cyberpunk = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Finkipp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyberpunk)).BeginInit();
            this.SuspendLayout();
            // 
            // Pokaz
            // 
            this.Pokaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pokaz.Location = new System.Drawing.Point(120, 339);
            this.Pokaz.Name = "Pokaz";
            this.Pokaz.Size = new System.Drawing.Size(233, 78);
            this.Pokaz.TabIndex = 0;
            this.Pokaz.Text = "Показать первое фото";
            this.Pokaz.UseVisualStyleBackColor = true;
            this.Pokaz.Click += new System.EventHandler(this.Pokaz_Click);
            // 
            // Pokaz2
            // 
            this.Pokaz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pokaz2.Location = new System.Drawing.Point(592, 339);
            this.Pokaz2.Name = "Pokaz2";
            this.Pokaz2.Size = new System.Drawing.Size(233, 78);
            this.Pokaz2.TabIndex = 4;
            this.Pokaz2.Text = "Показать второе фото";
            this.Pokaz2.UseVisualStyleBackColor = true;
            this.Pokaz2.Click += new System.EventHandler(this.Pokaz2_Click);
            // 
            // Finkipp
            // 
            this.Finkipp.Image = global::GW1.Properties.Resources.IMG_20230909_092013;
            this.Finkipp.Location = new System.Drawing.Point(975, 22);
            this.Finkipp.Name = "Finkipp";
            this.Finkipp.Size = new System.Drawing.Size(338, 413);
            this.Finkipp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Finkipp.TabIndex = 5;
            this.Finkipp.TabStop = false;
            this.Finkipp.Visible = false;
            // 
            // Beach
            // 
            this.Beach.Image = global::GW1.Properties.Resources._5;
            this.Beach.Location = new System.Drawing.Point(38, 57);
            this.Beach.Name = "Beach";
            this.Beach.Size = new System.Drawing.Size(416, 226);
            this.Beach.TabIndex = 3;
            this.Beach.TabStop = false;
            this.Beach.Visible = false;
            // 
            // Cyberpunk
            // 
            this.Cyberpunk.Image = global::GW1.Properties.Resources._1653584733_1_celes_club_p_neonovii_fon_kiberpank_krasivie_1;
            this.Cyberpunk.Location = new System.Drawing.Point(495, 57);
            this.Cyberpunk.Name = "Cyberpunk";
            this.Cyberpunk.Size = new System.Drawing.Size(407, 226);
            this.Cyberpunk.TabIndex = 2;
            this.Cyberpunk.TabStop = false;
            this.Cyberpunk.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1029, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 106);
            this.button1.TabIndex = 6;
            this.button1.Text = "Показать третье фото (Финкипп Edition)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Finkipp);
            this.Controls.Add(this.Pokaz2);
            this.Controls.Add(this.Beach);
            this.Controls.Add(this.Cyberpunk);
            this.Controls.Add(this.Pokaz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Finkipp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyberpunk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pokaz;
        private System.Windows.Forms.PictureBox Cyberpunk;
        private System.Windows.Forms.PictureBox Beach;
        private System.Windows.Forms.Button Pokaz2;
        private System.Windows.Forms.PictureBox Finkipp;
        private System.Windows.Forms.Button button1;
    }
}

