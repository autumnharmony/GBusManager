﻿namespace GBusManager
{
    partial class ToolsPanel
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsPanel));
            this.routesListBox = new System.Windows.Forms.ListBox();
            this.destPoint = new System.Windows.Forms.ComboBox();
            this.srcPoint = new System.Windows.Forms.ComboBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Button();
            this.removeRouteBtn = new System.Windows.Forms.Button();
            this.selectAllRoutesBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.pointBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // routesListBox
            // 
            this.routesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.routesListBox.FormattingEnabled = true;
            this.routesListBox.Location = new System.Drawing.Point(3, 28);
            this.routesListBox.Name = "routesListBox";
            this.routesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.routesListBox.Size = new System.Drawing.Size(78, 78);
            this.routesListBox.TabIndex = 6;
            this.routesListBox.SelectedIndexChanged += new System.EventHandler(this.routesListBox_SelectedIndexChanged);
            this.routesListBox.SelectedValueChanged += new System.EventHandler(this.routesListBox_SelectedValueChanged);
            // 
            // destPoint
            // 
            this.destPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.destPoint.FormattingEnabled = true;
            this.destPoint.Location = new System.Drawing.Point(4, 168);
            this.destPoint.Name = "destPoint";
            this.destPoint.Size = new System.Drawing.Size(77, 21);
            this.destPoint.TabIndex = 13;
            this.destPoint.Text = "куда";
            this.destPoint.SelectedIndexChanged += new System.EventHandler(this.destPoint_SelectedIndexChanged);
            // 
            // srcPoint
            // 
            this.srcPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srcPoint.FormattingEnabled = true;
            this.srcPoint.Location = new System.Drawing.Point(3, 141);
            this.srcPoint.Name = "srcPoint";
            this.srcPoint.Size = new System.Drawing.Size(78, 21);
            this.srcPoint.TabIndex = 14;
            this.srcPoint.Text = "откуда";
            this.srcPoint.SelectedIndexChanged += new System.EventHandler(this.srcPoint_SelectedIndexChanged);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(17, 200);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 15;
            // 
            // resultBtn
            // 
            this.resultBtn.AutoSize = true;
            this.resultBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultBtn.Location = new System.Drawing.Point(3, 113);
            this.resultBtn.Margin = new System.Windows.Forms.Padding(0);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(80, 25);
            this.resultBtn.TabIndex = 16;
            this.resultBtn.Text = "Кратчайший";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // removeRouteBtn
            // 
            this.removeRouteBtn.Location = new System.Drawing.Point(36, 206);
            this.removeRouteBtn.Name = "removeRouteBtn";
            this.removeRouteBtn.Size = new System.Drawing.Size(22, 23);
            this.removeRouteBtn.TabIndex = 17;
            this.removeRouteBtn.Text = "button1";
            this.removeRouteBtn.UseVisualStyleBackColor = true;
            this.removeRouteBtn.Visible = false;
            this.removeRouteBtn.Click += new System.EventHandler(this.removeRouteBtn_Click);
            // 
            // selectAllRoutesBtn
            // 
            this.selectAllRoutesBtn.Location = new System.Drawing.Point(64, 206);
            this.selectAllRoutesBtn.Name = "selectAllRoutesBtn";
            this.selectAllRoutesBtn.Size = new System.Drawing.Size(22, 23);
            this.selectAllRoutesBtn.TabIndex = 18;
            this.selectAllRoutesBtn.Text = "button2";
            this.selectAllRoutesBtn.UseVisualStyleBackColor = true;
            this.selectAllRoutesBtn.Visible = false;
            this.selectAllRoutesBtn.Click += new System.EventHandler(this.selectAllRoutesBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.AutoSize = true;
            this.lineBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.Image = global::GBusManager.Resource1.layer_shape_polyline;
            this.lineBtn.Location = new System.Drawing.Point(59, 0);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(24, 24);
            this.lineBtn.TabIndex = 2;
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSize = true;
            this.selectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectBtn.Image")));
            this.selectBtn.Location = new System.Drawing.Point(28, 0);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(24, 24);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pointBtn
            // 
            this.pointBtn.AutoSize = true;
            this.pointBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointBtn.Image = global::GBusManager.Resource1.pin__plus;
            this.pointBtn.Location = new System.Drawing.Point(0, 0);
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.Size = new System.Drawing.Size(24, 24);
            this.pointBtn.TabIndex = 0;
            this.pointBtn.UseVisualStyleBackColor = true;
            this.pointBtn.Click += new System.EventHandler(this.pointBtn_Click);
            // 
            // ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.selectAllRoutesBtn);
            this.Controls.Add(this.removeRouteBtn);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.srcPoint);
            this.Controls.Add(this.destPoint);
            this.Controls.Add(this.routesListBox);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.pointBtn);
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(89, 232);
            this.Load += new System.EventHandler(this.ToolsPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pointBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.ListBox routesListBox;
        private System.Windows.Forms.ComboBox destPoint;
        private System.Windows.Forms.ComboBox srcPoint;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button removeRouteBtn;
        private System.Windows.Forms.Button selectAllRoutesBtn;
    }
}
