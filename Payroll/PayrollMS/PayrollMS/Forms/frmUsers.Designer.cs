namespace PayrollMS
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSUserLogin = new PayrollMS.DataSets.DSUserLogin();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingNavigatorUpdateItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.cbUserStatus = new System.Windows.Forms.ComboBox();
            this.usersTableAdapter = new PayrollMS.DataSets.DSUserLoginTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new PayrollMS.DataSets.DSUserLoginTableAdapters.TableAdapterManager();
            this.btnMRights = new System.Windows.Forms.Button();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvForms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllowSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowRefresh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowShowForm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowFirst = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowNext = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowPrevious = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAllowLast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Role :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Status :";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvFormId,
            this.dgvForms,
            this.dgvAllowSave,
            this.dgvAllowUpdate,
            this.dgvAllowDelete,
            this.dgvAllowRefresh,
            this.dgvAllowShowForm,
            this.dgvAllowFirst,
            this.dgvAllowNext,
            this.dgvAllowPrevious,
            this.dgvAllowLast});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Location = new System.Drawing.Point(12, 140);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(810, 409);
            this.dgvList.TabIndex = 8;
            // 
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usersBindingNavigatorSaveItem,
            this.usersBindingNavigatorUpdateItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorRefreshItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersBindingNavigator.Size = new System.Drawing.Size(837, 25);
            this.usersBindingNavigator.TabIndex = 14;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            this.usersBindingNavigator.RefreshItems += new System.EventHandler(this.usersBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dSUserLogin;
            // 
            // dSUserLogin
            // 
            this.dSUserLogin.DataSetName = "DSUserLogin";
            this.dSUserLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.MergeIndex = -2;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usersBindingNavigatorSaveItem.Text = "Save Data";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // usersBindingNavigatorUpdateItem
            // 
            this.usersBindingNavigatorUpdateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorUpdateItem.Image")));
            this.usersBindingNavigatorUpdateItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersBindingNavigatorUpdateItem.Name = "usersBindingNavigatorUpdateItem";
            this.usersBindingNavigatorUpdateItem.Size = new System.Drawing.Size(23, 22);
            this.usersBindingNavigatorUpdateItem.Text = "toolStripButton2";
            this.usersBindingNavigatorUpdateItem.Click += new System.EventHandler(this.usersBindingNavigatorUpdateItem_Click);
            // 
            // usersBindingNavigatorRefreshItem
            // 
            this.usersBindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorRefreshItem.Image")));
            this.usersBindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersBindingNavigatorRefreshItem.Name = "usersBindingNavigatorRefreshItem";
            this.usersBindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 22);
            this.usersBindingNavigatorRefreshItem.Text = "toolStripButton1";
            this.usersBindingNavigatorRefreshItem.Click += new System.EventHandler(this.usersBindingNavigatorRefreshItem_Click);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(0, 591);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(18, 20);
            this.txtId.TabIndex = 15;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(99, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 20);
            this.txtUserName.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // cbUserRole
            // 
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Location = new System.Drawing.Point(99, 85);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(115, 21);
            this.cbUserRole.TabIndex = 18;
            // 
            // cbUserStatus
            // 
            this.cbUserStatus.FormattingEnabled = true;
            this.cbUserStatus.Location = new System.Drawing.Point(99, 112);
            this.cbUserStatus.Name = "cbUserStatus";
            this.cbUserStatus.Size = new System.Drawing.Size(115, 21);
            this.cbUserStatus.TabIndex = 19;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PayrollMS.DataSets.DSUserLoginTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // btnMRights
            // 
            this.btnMRights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMRights.Location = new System.Drawing.Point(717, 26);
            this.btnMRights.Name = "btnMRights";
            this.btnMRights.Size = new System.Drawing.Size(105, 23);
            this.btnMRights.TabIndex = 20;
            this.btnMRights.Text = "Modules Rights";
            this.btnMRights.UseVisualStyleBackColor = true;
            // 
            // dgvSno
            // 
            this.dgvSno.HeaderText = "S#";
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 50;
            // 
            // dgvFormId
            // 
            this.dgvFormId.HeaderText = "FormId";
            this.dgvFormId.Name = "dgvFormId";
            this.dgvFormId.Visible = false;
            // 
            // dgvForms
            // 
            this.dgvForms.HeaderText = "Forms";
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.ReadOnly = true;
            this.dgvForms.Width = 300;
            // 
            // dgvAllowSave
            // 
            this.dgvAllowSave.HeaderText = "Allow Save";
            this.dgvAllowSave.Name = "dgvAllowSave";
            this.dgvAllowSave.Width = 70;
            // 
            // dgvAllowUpdate
            // 
            this.dgvAllowUpdate.HeaderText = "Allow Update";
            this.dgvAllowUpdate.Name = "dgvAllowUpdate";
            this.dgvAllowUpdate.Width = 80;
            // 
            // dgvAllowDelete
            // 
            this.dgvAllowDelete.HeaderText = "Allow Delete";
            this.dgvAllowDelete.Name = "dgvAllowDelete";
            this.dgvAllowDelete.Width = 80;
            // 
            // dgvAllowRefresh
            // 
            this.dgvAllowRefresh.HeaderText = "Allow Refresh";
            this.dgvAllowRefresh.Name = "dgvAllowRefresh";
            this.dgvAllowRefresh.Width = 80;
            // 
            // dgvAllowShowForm
            // 
            this.dgvAllowShowForm.HeaderText = "Allow Show Form";
            this.dgvAllowShowForm.Name = "dgvAllowShowForm";
            this.dgvAllowShowForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllowShowForm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvAllowShowForm.Width = 120;
            // 
            // dgvAllowFirst
            // 
            this.dgvAllowFirst.HeaderText = "Allow First";
            this.dgvAllowFirst.Name = "dgvAllowFirst";
            this.dgvAllowFirst.Width = 70;
            // 
            // dgvAllowNext
            // 
            this.dgvAllowNext.HeaderText = "Allow Next";
            this.dgvAllowNext.Name = "dgvAllowNext";
            this.dgvAllowNext.Width = 70;
            // 
            // dgvAllowPrevious
            // 
            this.dgvAllowPrevious.HeaderText = "Allow Previous";
            this.dgvAllowPrevious.Name = "dgvAllowPrevious";
            this.dgvAllowPrevious.Width = 90;
            // 
            // dgvAllowLast
            // 
            this.dgvAllowLast.HeaderText = "Allow Last";
            this.dgvAllowLast.Name = "dgvAllowLast";
            this.dgvAllowLast.Width = 70;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 551);
            this.Controls.Add(this.btnMRights);
            this.Controls.Add(this.cbUserStatus);
            this.Controls.Add(this.cbUserRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.usersBindingNavigator);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSUserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvList;
        private DataSets.DSUserLogin dSUserLogin;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSets.DSUserLoginTableAdapters.UsersTableAdapter usersTableAdapter;
        private DataSets.DSUserLoginTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorUpdateItem;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.ComboBox cbUserStatus;
        private System.Windows.Forms.Button btnMRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvForms;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowShowForm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowFirst;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowNext;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowPrevious;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvAllowLast;
    }
}

