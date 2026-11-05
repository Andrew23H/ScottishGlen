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
            purchaseDateDTP = new DateTimePicker();
            label1 = new Label();
            notesLbl = new Label();
            notesTxt = new TextBox();
            employeeBox = new ComboBox();
            employeeLbl = new Label();
            addAssetBtn = new Button();
            cancelBtn = new Button();
            viewAssetBtn = new Button();
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
            systemNameLbl.Location = new Point(223, 30);
            systemNameLbl.Name = "systemNameLbl";
            systemNameLbl.Size = new Size(86, 15);
            systemNameLbl.TabIndex = 1;
            systemNameLbl.Text = "System Name :";
            // 
            // systemNameTxt
            // 
            systemNameTxt.Location = new Point(318, 30);
            systemNameTxt.Name = "systemNameTxt";
            systemNameTxt.ReadOnly = true;
            systemNameTxt.Size = new Size(207, 23);
            systemNameTxt.TabIndex = 2;
            // 
            // maufacturerLbl
            // 
            maufacturerLbl.AutoSize = true;
            maufacturerLbl.Location = new Point(224, 59);
            maufacturerLbl.Name = "maufacturerLbl";
            maufacturerLbl.Size = new Size(85, 15);
            maufacturerLbl.TabIndex = 3;
            maufacturerLbl.Text = "Manufacturer :";
            // 
            // manufacturerTxt
            // 
            manufacturerTxt.Location = new Point(318, 59);
            manufacturerTxt.Name = "manufacturerTxt";
            manufacturerTxt.ReadOnly = true;
            manufacturerTxt.Size = new Size(207, 23);
            manufacturerTxt.TabIndex = 4;
            // 
            // modelTxt
            // 
            modelTxt.Location = new Point(318, 88);
            modelTxt.Name = "modelTxt";
            modelTxt.ReadOnly = true;
            modelTxt.Size = new Size(207, 23);
            modelTxt.TabIndex = 5;
            // 
            // assetTypeTxt
            // 
            assetTypeTxt.Location = new Point(318, 117);
            assetTypeTxt.Name = "assetTypeTxt";
            assetTypeTxt.ReadOnly = true;
            assetTypeTxt.Size = new Size(207, 23);
            assetTypeTxt.TabIndex = 6;
            // 
            // ipAddressTxt
            // 
            ipAddressTxt.Location = new Point(318, 146);
            ipAddressTxt.Name = "ipAddressTxt";
            ipAddressTxt.ReadOnly = true;
            ipAddressTxt.Size = new Size(207, 23);
            ipAddressTxt.TabIndex = 7;
            // 
            // modelLbl
            // 
            modelLbl.AutoSize = true;
            modelLbl.Location = new Point(261, 88);
            modelLbl.Name = "modelLbl";
            modelLbl.Size = new Size(47, 15);
            modelLbl.TabIndex = 8;
            modelLbl.Text = "Model :";
            // 
            // assetTypeLbl
            // 
            assetTypeLbl.AutoSize = true;
            assetTypeLbl.Location = new Point(241, 117);
            assetTypeLbl.Name = "assetTypeLbl";
            assetTypeLbl.Size = new Size(71, 15);
            assetTypeLbl.TabIndex = 9;
            assetTypeLbl.Text = "Asset Type : ";
            // 
            // ipAddressLbl
            // 
            ipAddressLbl.AutoSize = true;
            ipAddressLbl.Location = new Point(241, 146);
            ipAddressLbl.Name = "ipAddressLbl";
            ipAddressLbl.Size = new Size(68, 15);
            ipAddressLbl.TabIndex = 10;
            ipAddressLbl.Text = "IP Address :";
            // 
            // purchaseDateDTP
            // 
            purchaseDateDTP.Format = DateTimePickerFormat.Short;
            purchaseDateDTP.Location = new Point(318, 175);
            purchaseDateDTP.Name = "purchaseDateDTP";
            purchaseDateDTP.ShowCheckBox = true;
            purchaseDateDTP.Size = new Size(207, 23);
            purchaseDateDTP.TabIndex = 11;
            purchaseDateDTP.Value = new DateTime(2026, 11, 5, 13, 51, 49, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 175);
            label1.Name = "label1";
            label1.Size = new Size(88, 45);
            label1.TabIndex = 12;
            label1.Text = "Purchase Date :\r\n     (Uncheck if \r\n       unknown)";
            label1.Click += label1_Click;
            // 
            // notesLbl
            // 
            notesLbl.AutoSize = true;
            notesLbl.Location = new Point(265, 269);
            notesLbl.Name = "notesLbl";
            notesLbl.Size = new Size(44, 15);
            notesLbl.TabIndex = 13;
            notesLbl.Text = "Notes :";
            // 
            // notesTxt
            // 
            notesTxt.Location = new Point(318, 269);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(207, 99);
            notesTxt.TabIndex = 14;
            // 
            // employeeBox
            // 
            employeeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeBox.FormattingEnabled = true;
            employeeBox.Location = new Point(318, 226);
            employeeBox.Name = "employeeBox";
            employeeBox.Size = new Size(207, 23);
            employeeBox.TabIndex = 15;
            // 
            // employeeLbl
            // 
            employeeLbl.AutoSize = true;
            employeeLbl.Location = new Point(244, 226);
            employeeLbl.Name = "employeeLbl";
            employeeLbl.Size = new Size(65, 15);
            employeeLbl.TabIndex = 16;
            employeeLbl.Text = "Employee :";
            // 
            // addAssetBtn
            // 
            addAssetBtn.Location = new Point(81, 116);
            addAssetBtn.Name = "addAssetBtn";
            addAssetBtn.Size = new Size(123, 23);
            addAssetBtn.TabIndex = 17;
            addAssetBtn.Text = "Add Asset";
            addAssetBtn.UseVisualStyleBackColor = true;
            addAssetBtn.Click += addAssetBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(81, 239);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(123, 23);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // viewAssetBtn
            // 
            viewAssetBtn.Location = new Point(81, 177);
            viewAssetBtn.Name = "viewAssetBtn";
            viewAssetBtn.Size = new Size(123, 23);
            viewAssetBtn.TabIndex = 19;
            viewAssetBtn.Text = "View Assets";
            viewAssetBtn.UseVisualStyleBackColor = true;
            // 
            // AssetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewAssetBtn);
            Controls.Add(cancelBtn);
            Controls.Add(addAssetBtn);
            Controls.Add(employeeLbl);
            Controls.Add(employeeBox);
            Controls.Add(notesTxt);
            Controls.Add(notesLbl);
            Controls.Add(label1);
            Controls.Add(purchaseDateDTP);
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
        private DateTimePicker purchaseDateDTP;
        private Label label1;
        private Label notesLbl;
        private TextBox notesTxt;
        private ComboBox employeeBox;
        private Label employeeLbl;
        private Button addAssetBtn;
        private Button cancelBtn;
        private Button viewAssetBtn;
    }
}