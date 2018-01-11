namespace SimpleMDIExample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.粗体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.斜体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.下画线ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tSCbBoxFontName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCbBoxFontName,
            this.粗体ToolStripButton,
            this.斜体ToolStripButton,
            this.下画线ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 粗体ToolStripButton
            // 
            this.粗体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粗体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粗体ToolStripButton.Image")));
            this.粗体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粗体ToolStripButton.Name = "粗体ToolStripButton";
            this.粗体ToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.粗体ToolStripButton.Text = "toolStripButton1";
            this.粗体ToolStripButton.Click += new System.EventHandler(this.粗体ToolStripButton_Click);
            // 
            // 斜体ToolStripButton
            // 
            this.斜体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.斜体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("斜体ToolStripButton.Image")));
            this.斜体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.斜体ToolStripButton.Name = "斜体ToolStripButton";
            this.斜体ToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.斜体ToolStripButton.Text = "toolStripButton2";
            this.斜体ToolStripButton.Click += new System.EventHandler(this.斜体ToolStripButton_Click);
            // 
            // 下画线ToolStripButton
            // 
            this.下画线ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.下画线ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("下画线ToolStripButton.Image")));
            this.下画线ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.下画线ToolStripButton.Name = "下画线ToolStripButton";
            this.下画线ToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.下画线ToolStripButton.Text = "toolStripButton3";
            this.下画线ToolStripButton.Click += new System.EventHandler(this.下画线ToolStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem1.Text = "-";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口层叠ToolStripMenuItem,
            this.水平平铺ToolStripMenuItem,
            this.垂直平铺ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 窗口层叠ToolStripMenuItem
            // 
            this.窗口层叠ToolStripMenuItem.Name = "窗口层叠ToolStripMenuItem";
            this.窗口层叠ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.窗口层叠ToolStripMenuItem.Text = "窗口层叠";
            this.窗口层叠ToolStripMenuItem.Click += new System.EventHandler(this.窗口层叠ToolStripMenuItem_Click);
            // 
            // 水平平铺ToolStripMenuItem
            // 
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // tSCbBoxFontName
            // 
            this.tSCbBoxFontName.Name = "tSCbBoxFontName";
            this.tSCbBoxFontName.Size = new System.Drawing.Size(225, 28);
            this.tSCbBoxFontName.Text = "字体选择";
            this.tSCbBoxFontName.Click += new System.EventHandler(this.tSCbBoxFontName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 407);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 粗体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 斜体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 下画线ToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripComboBox tSCbBoxFontName;
    }
}

