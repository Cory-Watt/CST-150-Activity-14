namespace Activity_14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.fillShape = new System.Windows.Forms.RadioButton();
            this.outlineShape = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.showName = new System.Windows.Forms.CheckBox();
            this.showDate = new System.Windows.Forms.CheckBox();
            this.dateBox = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listOfShapes = new System.Windows.Forms.ListBox();
            this.draw = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.showShapePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a shape:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fillShape, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outlineShape, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(106, 84);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Fill Mode:";
            // 
            // fillShape
            // 
            this.fillShape.AutoSize = true;
            this.fillShape.Location = new System.Drawing.Point(3, 31);
            this.fillShape.Name = "fillShape";
            this.fillShape.Size = new System.Drawing.Size(37, 17);
            this.fillShape.TabIndex = 1;
            this.fillShape.TabStop = true;
            this.fillShape.Text = "Fill";
            this.fillShape.UseVisualStyleBackColor = true;
            // 
            // outlineShape
            // 
            this.outlineShape.AutoSize = true;
            this.outlineShape.Location = new System.Drawing.Point(3, 59);
            this.outlineShape.Name = "outlineShape";
            this.outlineShape.Size = new System.Drawing.Size(58, 17);
            this.outlineShape.TabIndex = 2;
            this.outlineShape.TabStop = true;
            this.outlineShape.Text = "Outline";
            this.outlineShape.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.showName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.showDate, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(106, 75);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Details";
            // 
            // showName
            // 
            this.showName.AutoSize = true;
            this.showName.Location = new System.Drawing.Point(3, 27);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(54, 17);
            this.showName.TabIndex = 1;
            this.showName.Text = "Name";
            this.showName.UseVisualStyleBackColor = true;
            // 
            // showDate
            // 
            this.showDate.AutoSize = true;
            this.showDate.Location = new System.Drawing.Point(3, 51);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(49, 17);
            this.showDate.TabIndex = 2;
            this.showDate.Text = "Date";
            this.showDate.UseVisualStyleBackColor = true;
            // 
            // dateBox
            // 
            this.dateBox.AutoSize = true;
            this.dateBox.Location = new System.Drawing.Point(3, 0);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(0, 13);
            this.dateBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(3, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(0, 13);
            this.nameBox.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dateBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nameBox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(190, 219);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(73, 53);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // listOfShapes
            // 
            this.listOfShapes.FormattingEnabled = true;
            this.listOfShapes.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle"});
            this.listOfShapes.Location = new System.Drawing.Point(12, 39);
            this.listOfShapes.Name = "listOfShapes";
            this.listOfShapes.Size = new System.Drawing.Size(109, 56);
            this.listOfShapes.TabIndex = 7;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(151, 279);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 9;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(232, 280);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // showShapePanel
            // 
            this.showShapePanel.Location = new System.Drawing.Point(135, 39);
            this.showShapePanel.Name = "showShapePanel";
            this.showShapePanel.Size = new System.Drawing.Size(203, 174);
            this.showShapePanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 332);
            this.Controls.Add(this.showShapePanel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.listOfShapes);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity 14 - Cory Wattenberger";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton fillShape;
        private System.Windows.Forms.RadioButton outlineShape;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showName;
        private System.Windows.Forms.CheckBox showDate;
        private System.Windows.Forms.Label dateBox;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listOfShapes;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel showShapePanel;
    }
}

