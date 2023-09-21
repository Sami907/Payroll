namespace PayrollMS
{
    partial class frmCompanySetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanySetup));
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompShort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebsiteUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPtcl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.companySetupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.companySetupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.compLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.compLogoLandscapePictureBox = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.companySetupBindingNavigatorUpdateItem = new System.Windows.Forms.ToolStripButton();
            this.companySetupBindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.gbImgFiltr = new System.Windows.Forms.GroupBox();
            this.rbUploadLogo = new System.Windows.Forms.RadioButton();
            this.rbUL = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtCompLogoPath = new System.Windows.Forms.TextBox();
            this.txtCompLandscapePath = new System.Windows.Forms.TextBox();
            this.companySetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCompanySetup = new PayrollMS.DataSets.DSCompanySetup();
            this.companySetupTableAdapter = new PayrollMS.DataSets.DSCompanySetupTableAdapters.CompanySetupTableAdapter();
            this.tableAdapterManager = new PayrollMS.DataSets.DSCompanySetupTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.companySetupBindingNavigator)).BeginInit();
            this.companySetupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compLogoLandscapePictureBox)).BeginInit();
            this.gbImgFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companySetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCompanySetup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(129, 76);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(270, 20);
            this.txtCompName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Company Name :";
            // 
            // txtCompShort
            // 
            this.txtCompShort.Location = new System.Drawing.Point(129, 50);
            this.txtCompShort.Name = "txtCompShort";
            this.txtCompShort.Size = new System.Drawing.Size(93, 20);
            this.txtCompShort.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Company Short :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(129, 102);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(482, 54);
            this.txtAddress.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address :";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(129, 162);
            this.txtAddress2.Multiline = true;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(482, 54);
            this.txtAddress2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address 2 :";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(129, 222);
            this.txtAddress3.Multiline = true;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(482, 54);
            this.txtAddress3.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address 3 :";
            // 
            // txtWebsiteUrl
            // 
            this.txtWebsiteUrl.Location = new System.Drawing.Point(129, 282);
            this.txtWebsiteUrl.Name = "txtWebsiteUrl";
            this.txtWebsiteUrl.Size = new System.Drawing.Size(482, 20);
            this.txtWebsiteUrl.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Website Url :";
            // 
            // txtPtcl
            // 
            this.txtPtcl.Location = new System.Drawing.Point(129, 308);
            this.txtPtcl.Name = "txtPtcl";
            this.txtPtcl.Size = new System.Drawing.Size(160, 20);
            this.txtPtcl.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "PTCL :";
            // 
            // companySetupBindingNavigator
            // 
            this.companySetupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companySetupBindingNavigator.BindingSource = this.companySetupBindingSource;
            this.companySetupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companySetupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companySetupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.companySetupBindingNavigatorSaveItem,
            this.companySetupBindingNavigatorUpdateItem,
            this.bindingNavigatorDeleteItem,
            this.companySetupBindingNavigatorRefreshItem});
            this.companySetupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companySetupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companySetupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companySetupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companySetupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companySetupBindingNavigator.Name = "companySetupBindingNavigator";
            this.companySetupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companySetupBindingNavigator.Size = new System.Drawing.Size(806, 25);
            this.companySetupBindingNavigator.TabIndex = 31;
            this.companySetupBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // companySetupBindingNavigatorSaveItem
            // 
            this.companySetupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companySetupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companySetupBindingNavigatorSaveItem.Image")));
            this.companySetupBindingNavigatorSaveItem.Name = "companySetupBindingNavigatorSaveItem";
            this.companySetupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.companySetupBindingNavigatorSaveItem.Text = "Save Data";
            this.companySetupBindingNavigatorSaveItem.Click += new System.EventHandler(this.companySetupBindingNavigatorSaveItem_Click);
            // 
            // compLogoPictureBox
            // 
            this.compLogoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.companySetupBindingSource, "CompLogo", true));
            this.compLogoPictureBox.Location = new System.Drawing.Point(621, 159);
            this.compLogoPictureBox.Name = "compLogoPictureBox";
            this.compLogoPictureBox.Size = new System.Drawing.Size(173, 166);
            this.compLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compLogoPictureBox.TabIndex = 32;
            this.compLogoPictureBox.TabStop = false;
            // 
            // compLogoLandscapePictureBox
            // 
            this.compLogoLandscapePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.companySetupBindingSource, "CompLogoLandscape", true));
            this.compLogoLandscapePictureBox.Location = new System.Drawing.Point(129, 334);
            this.compLogoLandscapePictureBox.Name = "compLogoLandscapePictureBox";
            this.compLogoLandscapePictureBox.Size = new System.Drawing.Size(482, 121);
            this.compLogoLandscapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compLogoLandscapePictureBox.TabIndex = 33;
            this.compLogoLandscapePictureBox.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companySetupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(891, 418);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(51, 20);
            this.idTextBox.TabIndex = 34;
            // 
            // companySetupBindingNavigatorUpdateItem
            // 
            this.companySetupBindingNavigatorUpdateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companySetupBindingNavigatorUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("companySetupBindingNavigatorUpdateItem.Image")));
            this.companySetupBindingNavigatorUpdateItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.companySetupBindingNavigatorUpdateItem.Name = "companySetupBindingNavigatorUpdateItem";
            this.companySetupBindingNavigatorUpdateItem.Size = new System.Drawing.Size(23, 22);
            this.companySetupBindingNavigatorUpdateItem.Text = "toolStripButton1";
            this.companySetupBindingNavigatorUpdateItem.Click += new System.EventHandler(this.companySetupBindingNavigatorUpdateItem_Click);
            // 
            // companySetupBindingNavigatorRefreshItem
            // 
            this.companySetupBindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companySetupBindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("companySetupBindingNavigatorRefreshItem.Image")));
            this.companySetupBindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.companySetupBindingNavigatorRefreshItem.Name = "companySetupBindingNavigatorRefreshItem";
            this.companySetupBindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 22);
            this.companySetupBindingNavigatorRefreshItem.Text = "toolStripButton2";
            this.companySetupBindingNavigatorRefreshItem.Click += new System.EventHandler(this.companySetupBindingNavigatorRefreshItem_Click);
            // 
            // gbImgFiltr
            // 
            this.gbImgFiltr.Controls.Add(this.btnBrowse);
            this.gbImgFiltr.Controls.Add(this.rbUL);
            this.gbImgFiltr.Controls.Add(this.rbUploadLogo);
            this.gbImgFiltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImgFiltr.Location = new System.Drawing.Point(621, 334);
            this.gbImgFiltr.Name = "gbImgFiltr";
            this.gbImgFiltr.Size = new System.Drawing.Size(173, 121);
            this.gbImgFiltr.TabIndex = 36;
            this.gbImgFiltr.TabStop = false;
            this.gbImgFiltr.Text = "Image Filter";
            // 
            // rbUploadLogo
            // 
            this.rbUploadLogo.AutoSize = true;
            this.rbUploadLogo.Location = new System.Drawing.Point(6, 29);
            this.rbUploadLogo.Name = "rbUploadLogo";
            this.rbUploadLogo.Size = new System.Drawing.Size(96, 19);
            this.rbUploadLogo.TabIndex = 0;
            this.rbUploadLogo.Text = "Upload Logo";
            this.rbUploadLogo.UseVisualStyleBackColor = true;
            // 
            // rbUL
            // 
            this.rbUL.AutoSize = true;
            this.rbUL.Location = new System.Drawing.Point(6, 54);
            this.rbUL.Name = "rbUL";
            this.rbUL.Size = new System.Drawing.Size(129, 19);
            this.rbUL.TabIndex = 1;
            this.rbUL.TabStop = true;
            this.rbUL.Text = "Upload Landscape";
            this.rbUL.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(6, 80);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(161, 35);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "            Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtCompLogoPath
            // 
            this.txtCompLogoPath.Location = new System.Drawing.Point(453, 47);
            this.txtCompLogoPath.Name = "txtCompLogoPath";
            this.txtCompLogoPath.Size = new System.Drawing.Size(95, 20);
            this.txtCompLogoPath.TabIndex = 38;
            this.txtCompLogoPath.Visible = false;
            // 
            // txtCompLandscapePath
            // 
            this.txtCompLandscapePath.Location = new System.Drawing.Point(453, 73);
            this.txtCompLandscapePath.Name = "txtCompLandscapePath";
            this.txtCompLandscapePath.Size = new System.Drawing.Size(95, 20);
            this.txtCompLandscapePath.TabIndex = 37;
            this.txtCompLandscapePath.Visible = false;
            // 
            // companySetupBindingSource
            // 
            this.companySetupBindingSource.DataMember = "CompanySetup";
            this.companySetupBindingSource.DataSource = this.dSCompanySetup;
            // 
            // dSCompanySetup
            // 
            this.dSCompanySetup.DataSetName = "DSCompanySetup";
            this.dSCompanySetup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companySetupTableAdapter
            // 
            this.companySetupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanySetupTableAdapter = this.companySetupTableAdapter;
            this.tableAdapterManager.UpdateOrder = PayrollMS.DataSets.DSCompanySetupTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 467);
            this.Controls.Add(this.txtCompLogoPath);
            this.Controls.Add(this.txtCompLandscapePath);
            this.Controls.Add(this.gbImgFiltr);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.compLogoLandscapePictureBox);
            this.Controls.Add(this.compLogoPictureBox);
            this.Controls.Add(this.companySetupBindingNavigator);
            this.Controls.Add(this.txtPtcl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWebsiteUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompShort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCompanySetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Setup";
            this.Load += new System.EventHandler(this.frmCompanySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companySetupBindingNavigator)).EndInit();
            this.companySetupBindingNavigator.ResumeLayout(false);
            this.companySetupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compLogoLandscapePictureBox)).EndInit();
            this.gbImgFiltr.ResumeLayout(false);
            this.gbImgFiltr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companySetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCompanySetup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompShort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebsiteUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPtcl;
        private System.Windows.Forms.Label label7;
        private DataSets.DSCompanySetup dSCompanySetup;
        private System.Windows.Forms.BindingSource companySetupBindingSource;
        private DataSets.DSCompanySetupTableAdapters.CompanySetupTableAdapter companySetupTableAdapter;
        private DataSets.DSCompanySetupTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator companySetupBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton companySetupBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox compLogoPictureBox;
        private System.Windows.Forms.PictureBox compLogoLandscapePictureBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ToolStripButton companySetupBindingNavigatorUpdateItem;
        private System.Windows.Forms.ToolStripButton companySetupBindingNavigatorRefreshItem;
        private System.Windows.Forms.GroupBox gbImgFiltr;
        private System.Windows.Forms.RadioButton rbUL;
        private System.Windows.Forms.RadioButton rbUploadLogo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtCompLogoPath;
        private System.Windows.Forms.TextBox txtCompLandscapePath;
    }
}