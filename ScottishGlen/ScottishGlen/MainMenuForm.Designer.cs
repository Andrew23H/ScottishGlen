namespace ScottishGlen
{
    partial class MainMenuForm
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
            AssetBtn = new Button();
            employeeBtn = new Button();
            SuspendLayout();
            // 
            // AssetBtn
            // 
            AssetBtn.Location = new Point(253, 232);
            AssetBtn.Name = "AssetBtn";
            AssetBtn.Size = new Size(127, 23);
            AssetBtn.TabIndex = 0;
            AssetBtn.Text = "Add / View Assets";
            AssetBtn.UseVisualStyleBackColor = true;
            AssetBtn.Click += button1_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.Location = new Point(428, 232);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(123, 23);
            employeeBtn.TabIndex = 1;
            employeeBtn.Text = "Manage Employees";
            employeeBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(employeeBtn);
            Controls.Add(AssetBtn);
            Name = "MainMenuForm";
            Text = "ScottishGlen Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button AssetBtn;
        private Button employeeBtn;
    }
}
