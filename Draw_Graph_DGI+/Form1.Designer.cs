namespace Draw_Graph_DGI_.Naima_Shamilievna
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScalingBar = new System.Windows.Forms.TrackBar();
            this.chckDrawAxiswithValue = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckDrawAxis = new System.Windows.Forms.CheckBox();
            this.chckDrawGrid = new System.Windows.Forms.CheckBox();
            this.TransformFigureX = new System.Windows.Forms.TrackBar();
            this.TransformFigureY = new System.Windows.Forms.TrackBar();
            this.chckDrawFigure = new System.Windows.Forms.CheckBox();
            this.gpBoxFigure = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetCoordsFigure = new System.Windows.Forms.Button();
            this.RotateFigure = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clFigure = new System.Windows.Forms.ComboBox();
            this.clGrid = new System.Windows.Forms.ComboBox();
            this.clAxes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.ColorDialog();
            this.lblZoom = new System.Windows.Forms.Label();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScalingBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransformFigureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransformFigureY)).BeginInit();
            this.gpBoxFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateFigure)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 503);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ScalingBar
            // 
            this.ScalingBar.Location = new System.Drawing.Point(510, 400);
            this.ScalingBar.Maximum = 100;
            this.ScalingBar.Minimum = -25;
            this.ScalingBar.Name = "ScalingBar";
            this.ScalingBar.Size = new System.Drawing.Size(226, 45);
            this.ScalingBar.SmallChange = 5;
            this.ScalingBar.TabIndex = 2;
            this.ScalingBar.TickFrequency = 5;
            this.ScalingBar.Scroll += new System.EventHandler(this.ScalingBar_Scroll);
            this.ScalingBar.MouseLeave += new System.EventHandler(this.ScalingBar_MouseLeave);
            // 
            // chckDrawAxiswithValue
            // 
            this.chckDrawAxiswithValue.AutoSize = true;
            this.chckDrawAxiswithValue.Checked = true;
            this.chckDrawAxiswithValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckDrawAxiswithValue.Location = new System.Drawing.Point(6, 42);
            this.chckDrawAxiswithValue.Name = "chckDrawAxiswithValue";
            this.chckDrawAxiswithValue.Size = new System.Drawing.Size(180, 17);
            this.chckDrawAxiswithValue.TabIndex = 7;
            this.chckDrawAxiswithValue.Text = "Отобразить оси с нумерацией";
            this.chckDrawAxiswithValue.UseVisualStyleBackColor = true;
            this.chckDrawAxiswithValue.CheckedChanged += new System.EventHandler(this.chckDrawAxiswithValue_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckDrawAxis);
            this.groupBox1.Controls.Add(this.chckDrawAxiswithValue);
            this.groupBox1.Location = new System.Drawing.Point(510, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оси";
            // 
            // chckDrawAxis
            // 
            this.chckDrawAxis.AutoSize = true;
            this.chckDrawAxis.Location = new System.Drawing.Point(6, 19);
            this.chckDrawAxis.Name = "chckDrawAxis";
            this.chckDrawAxis.Size = new System.Drawing.Size(107, 17);
            this.chckDrawAxis.TabIndex = 9;
            this.chckDrawAxis.Text = "Отобразить оси";
            this.chckDrawAxis.UseVisualStyleBackColor = true;
            this.chckDrawAxis.CheckedChanged += new System.EventHandler(this.chckDrawAxis_CheckedChanged);
            // 
            // chckDrawGrid
            // 
            this.chckDrawGrid.AutoSize = true;
            this.chckDrawGrid.Location = new System.Drawing.Point(515, 377);
            this.chckDrawGrid.Name = "chckDrawGrid";
            this.chckDrawGrid.Size = new System.Drawing.Size(117, 17);
            this.chckDrawGrid.TabIndex = 9;
            this.chckDrawGrid.Text = "Отобразить сетку";
            this.chckDrawGrid.UseVisualStyleBackColor = true;
            this.chckDrawGrid.CheckedChanged += new System.EventHandler(this.chckDrawGrid_CheckedChanged);
            // 
            // TransformFigureX
            // 
            this.TransformFigureX.Location = new System.Drawing.Point(80, 40);
            this.TransformFigureX.Maximum = 250;
            this.TransformFigureX.Minimum = -250;
            this.TransformFigureX.Name = "TransformFigureX";
            this.TransformFigureX.Size = new System.Drawing.Size(140, 45);
            this.TransformFigureX.TabIndex = 10;
            this.TransformFigureX.TickFrequency = 0;
            this.TransformFigureX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TransformFigureX.Value = 50;
            this.TransformFigureX.Scroll += new System.EventHandler(this.TransformFigureX_Scroll);
            // 
            // TransformFigureY
            // 
            this.TransformFigureY.Location = new System.Drawing.Point(6, 35);
            this.TransformFigureY.Maximum = 250;
            this.TransformFigureY.Minimum = -250;
            this.TransformFigureY.Name = "TransformFigureY";
            this.TransformFigureY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TransformFigureY.RightToLeftLayout = true;
            this.TransformFigureY.Size = new System.Drawing.Size(45, 114);
            this.TransformFigureY.TabIndex = 11;
            this.TransformFigureY.TickFrequency = 0;
            this.TransformFigureY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TransformFigureY.Value = 50;
            this.TransformFigureY.Scroll += new System.EventHandler(this.TransformFigureY_Scroll);
            // 
            // chckDrawFigure
            // 
            this.chckDrawFigure.AutoSize = true;
            this.chckDrawFigure.Location = new System.Drawing.Point(515, 80);
            this.chckDrawFigure.Name = "chckDrawFigure";
            this.chckDrawFigure.Size = new System.Drawing.Size(125, 17);
            this.chckDrawFigure.TabIndex = 12;
            this.chckDrawFigure.Text = "Нарисовать фиругу";
            this.chckDrawFigure.UseVisualStyleBackColor = true;
            this.chckDrawFigure.CheckedChanged += new System.EventHandler(this.chckDrawFigure_CheckedChanged);
            // 
            // gpBoxFigure
            // 
            this.gpBoxFigure.Controls.Add(this.label6);
            this.gpBoxFigure.Controls.Add(this.btnResetCoordsFigure);
            this.gpBoxFigure.Controls.Add(this.RotateFigure);
            this.gpBoxFigure.Controls.Add(this.label2);
            this.gpBoxFigure.Controls.Add(this.label1);
            this.gpBoxFigure.Controls.Add(this.TransformFigureY);
            this.gpBoxFigure.Controls.Add(this.TransformFigureX);
            this.gpBoxFigure.Enabled = false;
            this.gpBoxFigure.Location = new System.Drawing.Point(510, 82);
            this.gpBoxFigure.Name = "gpBoxFigure";
            this.gpBoxFigure.Size = new System.Drawing.Size(226, 169);
            this.gpBoxFigure.TabIndex = 13;
            this.gpBoxFigure.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Поворот";
            // 
            // btnResetCoordsFigure
            // 
            this.btnResetCoordsFigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetCoordsFigure.Location = new System.Drawing.Point(156, 144);
            this.btnResetCoordsFigure.Name = "btnResetCoordsFigure";
            this.btnResetCoordsFigure.Size = new System.Drawing.Size(68, 23);
            this.btnResetCoordsFigure.TabIndex = 14;
            this.btnResetCoordsFigure.Text = "Сброс";
            this.btnResetCoordsFigure.UseVisualStyleBackColor = true;
            this.btnResetCoordsFigure.Click += new System.EventHandler(this.btnResetCoordsFigure_Click);
            // 
            // RotateFigure
            // 
            this.RotateFigure.Location = new System.Drawing.Point(81, 97);
            this.RotateFigure.Maximum = 360;
            this.RotateFigure.Minimum = -360;
            this.RotateFigure.Name = "RotateFigure";
            this.RotateFigure.Size = new System.Drawing.Size(139, 45);
            this.RotateFigure.TabIndex = 15;
            this.RotateFigure.TickFrequency = 0;
            this.RotateFigure.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RotateFigure.Scroll += new System.EventHandler(this.RotateFigure_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ось Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ось Х";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clFigure);
            this.groupBox2.Controls.Add(this.clGrid);
            this.groupBox2.Controls.Add(this.clAxes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(510, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 105);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка цветов";
            // 
            // clFigure
            // 
            this.clFigure.BackColor = System.Drawing.Color.Red;
            this.clFigure.FormattingEnabled = true;
            this.clFigure.Location = new System.Drawing.Point(87, 78);
            this.clFigure.Name = "clFigure";
            this.clFigure.Size = new System.Drawing.Size(37, 21);
            this.clFigure.TabIndex = 5;
            this.clFigure.Click += new System.EventHandler(this.clChange_SelectedColor);
            // 
            // clGrid
            // 
            this.clGrid.BackColor = System.Drawing.Color.RosyBrown;
            this.clGrid.FormattingEnabled = true;
            this.clGrid.Location = new System.Drawing.Point(87, 51);
            this.clGrid.Name = "clGrid";
            this.clGrid.Size = new System.Drawing.Size(37, 21);
            this.clGrid.TabIndex = 4;
            this.clGrid.Click += new System.EventHandler(this.clChange_SelectedColor);
            // 
            // clAxes
            // 
            this.clAxes.BackColor = System.Drawing.Color.Black;
            this.clAxes.FormattingEnabled = true;
            this.clAxes.Location = new System.Drawing.Point(87, 24);
            this.clAxes.Name = "clAxes";
            this.clAxes.Size = new System.Drawing.Size(37, 21);
            this.clAxes.TabIndex = 3;
            this.clAxes.Click += new System.EventHandler(this.clChange_SelectedColor);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цвет фиругы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цвет сетки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цвет Осей:";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(651, 378);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(79, 13);
            this.lblZoom.TabIndex = 17;
            this.lblZoom.Text = "Маштаб: 100%";
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetZoom.Location = new System.Drawing.Point(622, 440);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(108, 23);
            this.btnResetZoom.TabIndex = 15;
            this.btnResetZoom.Text = "Сбросить маштаб";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.Click += new System.EventHandler(this.btnResetZoom_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 527);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 50);
            this.tableLayoutPanel1.TabIndex = 18;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Матрица аффинных преобразований";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 589);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnResetZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chckDrawFigure);
            this.Controls.Add(this.gpBoxFigure);
            this.Controls.Add(this.chckDrawGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScalingBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "йынчотевц";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScalingBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransformFigureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransformFigureY)).EndInit();
            this.gpBoxFigure.ResumeLayout(false);
            this.gpBoxFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateFigure)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar ScalingBar;
        private System.Windows.Forms.CheckBox chckDrawAxiswithValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckDrawAxis;
        private System.Windows.Forms.CheckBox chckDrawGrid;
        private System.Windows.Forms.TrackBar TransformFigureX;
        private System.Windows.Forms.TrackBar TransformFigureY;
        private System.Windows.Forms.GroupBox gpBoxFigure;
        private System.Windows.Forms.CheckBox chckDrawFigure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetCoordsFigure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clFigure;
        private System.Windows.Forms.ComboBox clGrid;
        private System.Windows.Forms.ComboBox clAxes;
        private System.Windows.Forms.ColorDialog cl;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnResetZoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar RotateFigure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

