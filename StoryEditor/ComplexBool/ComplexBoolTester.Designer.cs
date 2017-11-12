namespace StoryEditor.ComplexBool
{
    partial class ComplexBoolTester
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
            this.components = new System.ComponentModel.Container();
            this.tv = new System.Windows.Forms.TreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmAddOr = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAnd = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУсловиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTrue = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFalse = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bReCalc = new System.Windows.Forms.Button();
            this.добавитьКУзлуORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКУзлуANDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.ContextMenuStrip = this.contextMenu;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(284, 210);
            this.tv.TabIndex = 0;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmAddOr,
            this.AddAnd,
            this.DeleteBranch,
            this.добавитьУсловиеToolStripMenuItem,
            this.добавитьКУзлуORToolStripMenuItem,
            this.добавитьКУзлуANDToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(191, 136);
            // 
            // cmAddOr
            // 
            this.cmAddOr.Name = "cmAddOr";
            this.cmAddOr.Size = new System.Drawing.Size(190, 22);
            this.cmAddOr.Text = "Добавить выше ОR";
            this.cmAddOr.Click += new System.EventHandler(this.CmAddOr_Click);
            // 
            // AddAnd
            // 
            this.AddAnd.Name = "AddAnd";
            this.AddAnd.Size = new System.Drawing.Size(190, 22);
            this.AddAnd.Text = "Добавить выше AND";
            this.AddAnd.Click += new System.EventHandler(this.AddAnd_Click);
            // 
            // DeleteBranch
            // 
            this.DeleteBranch.Name = "DeleteBranch";
            this.DeleteBranch.Size = new System.Drawing.Size(190, 22);
            this.DeleteBranch.Text = "Удалить ветку";
            this.DeleteBranch.Click += new System.EventHandler(this.DeleteBranch_Click);
            // 
            // добавитьУсловиеToolStripMenuItem
            // 
            this.добавитьУсловиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTrue,
            this.AddFalse});
            this.добавитьУсловиеToolStripMenuItem.Name = "добавитьУсловиеToolStripMenuItem";
            this.добавитьУсловиеToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.добавитьУсловиеToolStripMenuItem.Text = "Добавить условие";
            // 
            // AddTrue
            // 
            this.AddTrue.Name = "AddTrue";
            this.AddTrue.Size = new System.Drawing.Size(100, 22);
            this.AddTrue.Text = "True";
            this.AddTrue.Click += new System.EventHandler(this.AddTrue_Click);
            // 
            // AddFalse
            // 
            this.AddFalse.Name = "AddFalse";
            this.AddFalse.Size = new System.Drawing.Size(100, 22);
            this.AddFalse.Text = "False";
            this.AddFalse.Click += new System.EventHandler(this.AddFalse_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(284, 261);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.bReCalc);
            this.splitContainer2.Size = new System.Drawing.Size(284, 47);
            this.splitContainer2.SplitterDistance = 149;
            this.splitContainer2.TabIndex = 1;
            // 
            // bReCalc
            // 
            this.bReCalc.ContextMenuStrip = this.contextMenu;
            this.bReCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bReCalc.Location = new System.Drawing.Point(0, 0);
            this.bReCalc.Name = "bReCalc";
            this.bReCalc.Size = new System.Drawing.Size(131, 47);
            this.bReCalc.TabIndex = 0;
            this.bReCalc.Text = "Тест";
            this.bReCalc.UseVisualStyleBackColor = true;
            this.bReCalc.Click += new System.EventHandler(this.bReCalc_Click);
            // 
            // добавитьКУзлуORToolStripMenuItem
            // 
            this.добавитьКУзлуORToolStripMenuItem.Name = "добавитьКУзлуORToolStripMenuItem";
            this.добавитьКУзлуORToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.добавитьКУзлуORToolStripMenuItem.Text = "Добавить к узлу OR";
            // 
            // добавитьКУзлуANDToolStripMenuItem
            // 
            this.добавитьКУзлуANDToolStripMenuItem.Name = "добавитьКУзлуANDToolStripMenuItem";
            this.добавитьКУзлуANDToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.добавитьКУзлуANDToolStripMenuItem.Text = "Добавить к узлу AND";
            // 
            // ComplexBoolTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ComplexBoolTester";
            this.Text = "ComplexBoolTester";
            this.contextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmAddOr;
        private System.Windows.Forms.ToolStripMenuItem AddAnd;
        private System.Windows.Forms.ToolStripMenuItem DeleteBranch;
        private System.Windows.Forms.ToolStripMenuItem добавитьУсловиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTrue;
        private System.Windows.Forms.ToolStripMenuItem AddFalse;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button bReCalc;
        private System.Windows.Forms.ToolStripMenuItem добавитьКУзлуORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКУзлуANDToolStripMenuItem;
    }
}