namespace ScottishGlen.Forms
{
    partial class AssetForm
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
            BtnCollectHardware = new Button();
            systemNameLbl = new Label();
            systemNameTxt = new TextBox();
            maufacturerLbl = new Label();
            manufacturerTxt = new TextBox();
            modelTxt = new TextBox();
            assetTypeTxt = new TextBox();
            ipAddressTxt = new TextBox();
            modelLbl = new Label();
            assetTypeLbl = new Label();
            ipAddressLbl = new Label();
            purchasseDateDTP = new DateTimePicker();
            label1 = new Label();
            notesLbl = new Label();
            notesTxt = new TextBox();
            SuspendLayout();
            // 
            // BtnCollectHardware
            // 
            BtnCollectHardware.Location = new Point(81, 58);
            BtnCollectHardware.Name = "BtnCollectHardware";
            BtnCollectHardware.Size = new Size(123, 23);
            BtnCollectHardware.TabIndex = 0;
            BtnCollectHardware.Text = "Collect Hardware";
            BtnCollectHardware.UseVisualStyleBackColor = true;
            BtnCollectHardware.Click += BtnCollectHardware_Click;
            // 
            // systemNameLbl
            // 
            systemNameLbl.AutoSize = true;
            systemNameLbl.Location = new Point(244, 58);
            systemNameLbl.Name = "systemNameLbl";
            systemNameLbl.Size = new Size(86, 15);
            systemNameLbl.TabIndex = 1;
            systemNameLbl.Text = "System Name :";
            // 
            // systemNameTxt
            // 
            systemNameTxt.Location = new Point(339, 58);
            systemNameTxt.Name = "systemNameTxt";
            systemNameTxt.ReadOnly = true;
            systemNameTxt.Size = new Size(207, 23);
            systemNameTxt.TabIndex = 2;
            // 
            // maufacturerLbl
            // 
            maufacturerLbl.AutoSize = true;
            maufacturerLbl.Location = new Point(244, 98);
            maufacturerLbl.Name = "maufacturerLbl";
            maufacturerLbl.Size = new Size(85, 15);
            maufacturerLbl.TabIndex = 3;
            maufacturerLbl.Text = "Manufacturer :";
            // 
            // manufacturerTxt
            // 
            manufacturerTxt.Location = new Point(339, 98);
            manufacturerTxt.Name = "manufacturerTxt";
            manufacturerTxt.ReadOnly = true;
            manufacturerTxt.Size = new Size(207, 23);
            manufacturerTxt.TabIndex = 4;
            // 
            // modelTxt
            // 
            modelTxt.Location = new Point(339, 137);
            modelTxt.Name = "modelTxt";
            modelTxt.ReadOnly = true;
            modelTxt.Size = new Size(207, 23);
            modelTxt.TabIndex = 5;
            // 
            // assetTypeTxt
            // 
            assetTypeTxt.Location = new Point(339, 178);
            assetTypeTxt.Name = "assetTypeTxt";
            assetTypeTxt.ReadOnly = true;
            assetTypeTxt.Size = new Size(207, 23);
            assetTypeTxt.TabIndex = 6;
            // 
            // ipAddressTxt
            // 
            ipAddressTxt.Location = new Point(339, 219);
            ipAddressTxt.Name = "ipAddressTxt";
            ipAddressTxt.ReadOnly = true;
            ipAddressTxt.Size = new Size(207, 23);
            ipAddressTxt.TabIndex = 7;
            // 
            // modelLbl
            // 
            modelLbl.AutoSize = true;
            modelLbl.Location = new Point(282, 137);
            modelLbl.Name = "modelLbl";
            modelLbl.Size = new Size(47, 15);
            modelLbl.TabIndex = 8;
            modelLbl.Text = "Model :";
            // 
            // assetTypeLbl
            // 
            assetTypeLbl.AutoSize = true;
            assetTypeLbl.Location = new Point(258, 178);
            assetTypeLbl.Name = "assetTypeLbl";
            assetTypeLbl.Size = new Size(71, 15);
            assetTypeLbl.TabIndex = 9;
            assetTypeLbl.Text = "Asset Type : ";
            // 
            // ipAddressLbl
            // 
            ipAddressLbl.AutoSize = true;
            ipAddressLbl.Location = new Point(258, 219);
            ipAddressLbl.Name = "ipAddressLbl";
            ipAddressLbl.Size = new Size(68, 15);
            ipAddressLbl.TabIndex = 10;
            ipAddressLbl.Text = "IP Address :";
            // 
            // purchasseDateDTP
            // 
            purchasseDateDTP.Format = DateTimePickerFormat.Short;
            purchasseDateDTP.Location = new Point(339, 262);
            purchasseDateDTP.Name = "purchasseDateDTP";
            purchasseDateDTP.Size = new Size(207, 23);
            purchasseDateDTP.TabIndex = 11;
            purchasseDateDTP.Value = new DateTime(2026, 11, 5, 13, 51, 49, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 262);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 12;
            label1.Text = "Purchase Date :\r\n   (If known)";
            label1.Click += label1_Click;
            // 
            // notesLbl
            // 
            notesLbl.AutoSize = true;
            notesLbl.Location = new Point(282, 308);
            notesLbl.Name = "notesLbl";
            notesLbl.Size = new Size(44, 15);
            notesLbl.TabIndex = 13;
            notesLbl.Text = "Notes :";
            // 
            // notesTxt
            // 
            notesTxt.Location = new Point(339, 308);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(207, 99);
            notesTxt.TabIndex = 14;
            // 
            // AssetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notesTxt);
            Controls.Add(notesLbl);
            Controls.Add(label1);
            Controls.Add(purchasseDateDTP);
            Controls.Add(ipAddressLbl);
            Controls.Add(assetTypeLbl);
            Controls.Add(modelLbl);
            Controls.Add(ipAddressTxt);
            Controls.Add(assetTypeTxt);
            Controls.Add(modelTxt);
            Controls.Add(manufacturerTxt);
            Controls.Add(maufacturerLbl);
            Controls.Add(systemNameTxt);
            Controls.Add(systemNameLbl);
            Controls.Add(BtnCollectHardware);
            Name = "AssetForm";
            Text = "Asset Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCollectHardware;
        private Label systemNameLbl;
        private TextBox systemNameTxt;
        private Label maufacturerLbl;
        private TextBox manufacturerTxt;
        private TextBox modelTxt;
        private TextBox assetTypeTxt;
        private TextBox ipAddressTxt;
        private Label modelLbl;
        private Label assetTypeLbl;
        private Label ipAddressLbl;
        private DateTimePicker purchasseDateDTP;
        private Label label1;
        private Label notesLbl;
        private TextBox notesTxt;
    }
}