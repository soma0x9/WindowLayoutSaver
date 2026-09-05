namespace WindowLayoutSaver
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            layoutListPanel = new TableLayoutPanel();
            lstLayouts = new ListBox();
            lblLayoutsTitle = new Label();
            actionPanel = new TableLayoutPanel();
            btnSaveLayout = new Button();
            btnRestoreLayout = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            layoutListPanel.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(layoutListPanel);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(actionPanel);
            splitMain.Size = new Size(884, 561);
            splitMain.SplitterDistance = 573;
            splitMain.TabIndex = 0;
            // 
            // layoutListPanel
            // 
            layoutListPanel.ColumnCount = 1;
            layoutListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutListPanel.Controls.Add(lstLayouts, 0, 1);
            layoutListPanel.Controls.Add(lblLayoutsTitle, 0, 0);
            layoutListPanel.Dock = DockStyle.Fill;
            layoutListPanel.Location = new Point(0, 0);
            layoutListPanel.Name = "layoutListPanel";
            layoutListPanel.RowCount = 2;
            layoutListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutListPanel.RowStyles.Add(new RowStyle());
            layoutListPanel.Size = new Size(573, 561);
            layoutListPanel.TabIndex = 2;
            // 
            // lstLayouts
            // 
            lstLayouts.Dock = DockStyle.Fill;
            lstLayouts.FormattingEnabled = true;
            lstLayouts.IntegralHeight = false;
            lstLayouts.Location = new Point(3, 53);
            lstLayouts.Name = "lstLayouts";
            lstLayouts.Size = new Size(567, 505);
            lstLayouts.TabIndex = 0;
            // 
            // lblLayoutsTitle
            // 
            lblLayoutsTitle.AutoSize = true;
            lblLayoutsTitle.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblLayoutsTitle.Location = new Point(3, 0);
            lblLayoutsTitle.Name = "lblLayoutsTitle";
            lblLayoutsTitle.Size = new Size(221, 45);
            lblLayoutsTitle.TabIndex = 1;
            lblLayoutsTitle.Text = "Saved Layouts";
            // 
            // actionPanel
            // 
            actionPanel.ColumnCount = 1;
            actionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            actionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            actionPanel.Controls.Add(btnSaveLayout, 0, 1);
            actionPanel.Controls.Add(btnRestoreLayout, 0, 2);
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Location = new Point(0, 0);
            actionPanel.Name = "actionPanel";
            actionPanel.RowCount = 3;
            actionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            actionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            actionPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            actionPanel.Size = new Size(307, 561);
            actionPanel.TabIndex = 0;
            // 
            // btnSaveLayout
            // 
            btnSaveLayout.Dock = DockStyle.Fill;
            btnSaveLayout.Location = new Point(15, 446);
            btnSaveLayout.Margin = new Padding(15, 5, 15, 5);
            btnSaveLayout.Name = "btnSaveLayout";
            btnSaveLayout.Size = new Size(277, 50);
            btnSaveLayout.TabIndex = 0;
            btnSaveLayout.Text = "Save Current Layout";
            btnSaveLayout.UseVisualStyleBackColor = true;
            // 
            // btnRestoreLayout
            // 
            btnRestoreLayout.Dock = DockStyle.Fill;
            btnRestoreLayout.Location = new Point(15, 506);
            btnRestoreLayout.Margin = new Padding(15, 5, 15, 5);
            btnRestoreLayout.Name = "btnRestoreLayout";
            btnRestoreLayout.Size = new Size(277, 50);
            btnRestoreLayout.TabIndex = 1;
            btnRestoreLayout.Text = "Restore Selected Layout";
            btnRestoreLayout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(splitMain);
            MinimumSize = new Size(700, 450);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Window Layout Saver";
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            layoutListPanel.ResumeLayout(false);
            layoutListPanel.PerformLayout();
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private ListBox lstLayouts;
        private TableLayoutPanel layoutListPanel;
        private Label lblLayoutsTitle;
        private TableLayoutPanel actionPanel;
        private Button btnSaveLayout;
        private Button btnRestoreLayout;
    }
}
