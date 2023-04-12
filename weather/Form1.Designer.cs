namespace weather
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWater = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelFeels = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelCondition2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.labelWater);
            this.panel1.Controls.Add(this.labelPressure);
            this.panel1.Controls.Add(this.labelFeels);
            this.panel1.Controls.Add(this.labelWindSpeed);
            this.panel1.Controls.Add(this.labelHumidity);
            this.panel1.Controls.Add(this.labelMinTemp);
            this.panel1.Controls.Add(this.labelMaxTemp);
            this.panel1.Controls.Add(this.labelCondition2);
            this.panel1.Controls.Add(this.labelCity);
            this.panel1.Controls.Add(this.labelCondition);
            this.panel1.Controls.Add(this.labelTemp);
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 934);
            this.panel1.TabIndex = 0;
            // 
            // labelWater
            // 
            this.labelWater.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWater.Location = new System.Drawing.Point(853, 455);
            this.labelWater.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(200, 117);
            this.labelWater.TabIndex = 15;
            this.labelWater.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPressure
            // 
            this.labelPressure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressure.Location = new System.Drawing.Point(653, 455);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(200, 117);
            this.labelPressure.TabIndex = 14;
            this.labelPressure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFeels
            // 
            this.labelFeels.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFeels.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFeels.Location = new System.Drawing.Point(413, 455);
            this.labelFeels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeels.Name = "labelFeels";
            this.labelFeels.Size = new System.Drawing.Size(240, 117);
            this.labelFeels.TabIndex = 13;
            this.labelFeels.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeed.Location = new System.Drawing.Point(213, 455);
            this.labelWindSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(200, 117);
            this.labelWindSpeed.TabIndex = 12;
            this.labelWindSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHumidity
            // 
            this.labelHumidity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.Location = new System.Drawing.Point(0, 455);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(213, 117);
            this.labelHumidity.TabIndex = 11;
            this.labelHumidity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinTemp.Location = new System.Drawing.Point(533, 406);
            this.labelMinTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(200, 38);
            this.labelMinTemp.TabIndex = 10;
            this.labelMinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxTemp.Location = new System.Drawing.Point(333, 406);
            this.labelMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(200, 38);
            this.labelMaxTemp.TabIndex = 9;
            this.labelMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCondition2
            // 
            this.labelCondition2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCondition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition2.ForeColor = System.Drawing.Color.Black;
            this.labelCondition2.Location = new System.Drawing.Point(200, 223);
            this.labelCondition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCondition2.Name = "labelCondition2";
            this.labelCondition2.Size = new System.Drawing.Size(667, 38);
            this.labelCondition2.TabIndex = 8;
            this.labelCondition2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            this.labelCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.Black;
            this.labelCity.Location = new System.Drawing.Point(333, 80);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(400, 38);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "Город:";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCondition
            // 
            this.labelCondition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.ForeColor = System.Drawing.Color.Black;
            this.labelCondition.Location = new System.Drawing.Point(200, 185);
            this.labelCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(667, 38);
            this.labelCondition.TabIndex = 6;
            this.labelCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemp
            // 
            this.labelTemp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.ForeColor = System.Drawing.Color.Black;
            this.labelTemp.Location = new System.Drawing.Point(400, 260);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(267, 143);
            this.labelTemp.TabIndex = 5;
            this.labelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.White;
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(333, 123);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(400, 53);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCity_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 600);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 240);
            this.tableLayoutPanel1.TabIndex = 18;
            this.tableLayoutPanel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 934);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCondition2;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelFeels;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

