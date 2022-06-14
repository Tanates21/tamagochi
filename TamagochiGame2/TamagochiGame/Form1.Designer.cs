
namespace TamagochiGame
{
    partial class Tamagochi
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_playforAN = new System.Windows.Forms.Button();
            this.btn_sleep = new System.Windows.Forms.Button();
            this.btn_givefood = new System.Windows.Forms.Button();
            this.AnimalsPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progresbar_timer = new System.Windows.Forms.Timer(this.components);
            this.timer_sed = new System.Windows.Forms.Timer(this.components);
            this.timer_fatigue = new System.Windows.Forms.Timer(this.components);
            this.btn_wakeup = new System.Windows.Forms.Button();
            this.btn_wakeupp = new System.Windows.Forms.Button();
            this.fatigue_label = new System.Windows.Forms.Label();
            this.sad_labele = new System.Windows.Forms.Label();
            this.hangry_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_playforAN
            // 
            this.btn_playforAN.Location = new System.Drawing.Point(32, 22);
            this.btn_playforAN.Name = "btn_playforAN";
            this.btn_playforAN.Size = new System.Drawing.Size(75, 23);
            this.btn_playforAN.TabIndex = 1;
            this.btn_playforAN.Text = "Играть";
            this.btn_playforAN.UseVisualStyleBackColor = true;
            this.btn_playforAN.Click += new System.EventHandler(this.btn_playforAN_Click);
            // 
            // btn_sleep
            // 
            this.btn_sleep.Location = new System.Drawing.Point(32, 61);
            this.btn_sleep.Name = "btn_sleep";
            this.btn_sleep.Size = new System.Drawing.Size(75, 23);
            this.btn_sleep.TabIndex = 2;
            this.btn_sleep.Text = "Спать";
            this.btn_sleep.UseVisualStyleBackColor = true;
            this.btn_sleep.Click += new System.EventHandler(this.btn_sleep_Click);
            // 
            // btn_givefood
            // 
            this.btn_givefood.Location = new System.Drawing.Point(32, 100);
            this.btn_givefood.Name = "btn_givefood";
            this.btn_givefood.Size = new System.Drawing.Size(75, 23);
            this.btn_givefood.TabIndex = 3;
            this.btn_givefood.Text = "Покормить";
            this.btn_givefood.UseVisualStyleBackColor = true;
            this.btn_givefood.Click += new System.EventHandler(this.btn_givefood_Click);
            // 
            // AnimalsPB
            // 
            this.AnimalsPB.Location = new System.Drawing.Point(165, 124);
            this.AnimalsPB.Name = "AnimalsPB";
            this.AnimalsPB.Size = new System.Drawing.Size(190, 180);
            this.AnimalsPB.TabIndex = 4;
            this.AnimalsPB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox1.Location = new System.Drawing.Point(487, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 370);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(553, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Усталость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(564, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Грусть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(563, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Голод";
            // 
            // progresbar_timer
            // 
            this.progresbar_timer.Enabled = true;
            this.progresbar_timer.Interval = 1000;
            this.progresbar_timer.Tick += new System.EventHandler(this.progresbar_timer_Tick);
            // 
            // timer_sed
            // 
            this.timer_sed.Enabled = true;
            this.timer_sed.Interval = 2000;
            this.timer_sed.Tick += new System.EventHandler(this.timer_sed_Tick);
            // 
            // timer_fatigue
            // 
            this.timer_fatigue.Enabled = true;
            this.timer_fatigue.Tick += new System.EventHandler(this.timer_fatigue_Tick);
            // 
            // btn_wakeup
            // 
            this.btn_wakeup.Location = new System.Drawing.Point(32, 138);
            this.btn_wakeup.Name = "btn_wakeup";
            this.btn_wakeup.Size = new System.Drawing.Size(75, 23);
            this.btn_wakeup.TabIndex = 15;
            this.btn_wakeup.Text = "Разбудить";
            this.btn_wakeup.UseVisualStyleBackColor = true;
            // 
            // btn_wakeupp
            // 
            this.btn_wakeupp.Location = new System.Drawing.Point(32, 137);
            this.btn_wakeupp.Name = "btn_wakeupp";
            this.btn_wakeupp.Size = new System.Drawing.Size(75, 23);
            this.btn_wakeupp.TabIndex = 15;
            this.btn_wakeupp.Text = "Разбудить ";
            this.btn_wakeupp.UseVisualStyleBackColor = true;
            this.btn_wakeupp.Click += new System.EventHandler(this.btn_wakeupp_Click);
            // 
            // fatigue_label
            // 
            this.fatigue_label.AutoSize = true;
            this.fatigue_label.BackColor = System.Drawing.Color.MediumAquamarine;
            this.fatigue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatigue_label.ForeColor = System.Drawing.Color.Red;
            this.fatigue_label.Location = new System.Drawing.Point(535, 198);
            this.fatigue_label.Name = "fatigue_label";
            this.fatigue_label.Size = new System.Drawing.Size(98, 37);
            this.fatigue_label.TabIndex = 14;
            this.fatigue_label.Text = "0/350";
            this.fatigue_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sad_labele
            // 
            this.sad_labele.AutoSize = true;
            this.sad_labele.BackColor = System.Drawing.Color.MediumAquamarine;
            this.sad_labele.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sad_labele.ForeColor = System.Drawing.Color.Red;
            this.sad_labele.Location = new System.Drawing.Point(535, 124);
            this.sad_labele.Name = "sad_labele";
            this.sad_labele.Size = new System.Drawing.Size(98, 37);
            this.sad_labele.TabIndex = 13;
            this.sad_labele.Text = "0/300";
            // 
            // hangry_lable
            // 
            this.hangry_lable.AutoSize = true;
            this.hangry_lable.BackColor = System.Drawing.Color.MediumAquamarine;
            this.hangry_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hangry_lable.ForeColor = System.Drawing.Color.Red;
            this.hangry_lable.Location = new System.Drawing.Point(530, 61);
            this.hangry_lable.Name = "hangry_lable";
            this.hangry_lable.Size = new System.Drawing.Size(103, 39);
            this.hangry_lable.TabIndex = 12;
            this.hangry_lable.Text = "0/300";
            // 
            // Tamagochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 361);
            this.Controls.Add(this.btn_wakeupp);
            this.Controls.Add(this.fatigue_label);
            this.Controls.Add(this.sad_labele);
            this.Controls.Add(this.hangry_lable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnimalsPB);
            this.Controls.Add(this.btn_givefood);
            this.Controls.Add(this.btn_sleep);
            this.Controls.Add(this.btn_playforAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tamagochi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamagochi";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tamagochi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_playforAN;
        private System.Windows.Forms.Button btn_sleep;
        private System.Windows.Forms.Button btn_givefood;
        private System.Windows.Forms.PictureBox AnimalsPB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer progresbar_timer;
        private System.Windows.Forms.Timer timer_sed;
        private System.Windows.Forms.Timer timer_fatigue;
        private System.Windows.Forms.Button btn_wakeup;
        private System.Windows.Forms.Button btn_wakeupp;
        private System.Windows.Forms.Label fatigue_label;
        private System.Windows.Forms.Label sad_labele;
        public System.Windows.Forms.Label hangry_lable;
    }
}

