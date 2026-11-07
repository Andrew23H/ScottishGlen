namespace ScottishGlen.Forms
{
    partial class ViewAssetsForm
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
            titleLbl = new Label();
            backBtn = new Button();
            assetsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)assetsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 20F);
            titleLbl.Location = new Point(327, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(155, 37);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "View Assets";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(24, 23);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // assetsDataGridView
            // 
            assetsDataGridView.AllowUserToAddRows = false;
            assetsDataGridView.AllowUserToDeleteRows = false;
            assetsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            assetsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assetsDataGridView.Location = new Point(24, 77);
            assetsDataGridView.MultiSelect = false;
            assetsDataGridView.Name = "assetsDataGridView";
            assetsDataGridView.ReadOnly = true;
            assetsDataGridView.RowHeadersVisible = false;
            assetsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            assetsDataGridView.Size = new Size(752, 319);
            assetsDataGridView.TabIndex = 2;
            // 
            // ViewAssetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(assetsDataGridView);
            Controls.Add(backBtn);
            Controls.Add(titleLbl);
            Name = "ViewAssetsForm";
            Text = "ViewAssetsForm";
            Load += ViewAssetsForm_Load;
            ((System.ComponentModel.ISupportInitialize)assetsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button backBtn;
        private DataGridView assetsDataGridView;
    }
}