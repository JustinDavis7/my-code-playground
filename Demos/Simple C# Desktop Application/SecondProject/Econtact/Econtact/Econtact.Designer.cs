namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxContactID = new System.Windows.Forms.TextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1931, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 84);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSearch.Location = new System.Drawing.Point(1102, 146);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(856, 45);
            this.txtBoxSearch.TabIndex = 40;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(946, 146);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 38);
            this.lblSearch.TabIndex = 39;
            this.lblSearch.Text = "Search";
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(949, 249);
            this.dgvContactList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersWidth = 72;
            this.dgvContactList.RowTemplate.Height = 37;
            this.dgvContactList.Size = new System.Drawing.Size(1011, 673);
            this.dgvContactList.TabIndex = 38;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1284, 1007);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(215, 87);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1008, 1007);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 87);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(741, 1007);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 87);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(475, 1007);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 87);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(105, 863);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(108, 38);
            this.lblGender.TabIndex = 33;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(324, 863);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(513, 46);
            this.cmbGender.TabIndex = 32;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxAddress.Location = new System.Drawing.Point(324, 575);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(513, 227);
            this.txtboxAddress.TabIndex = 31;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(105, 575);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(116, 38);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address";
            // 
            // txtboxContactNumber
            // 
            this.txtboxContactNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxContactNumber.Location = new System.Drawing.Point(324, 460);
            this.txtboxContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxContactNumber.Name = "txtboxContactNumber";
            this.txtboxContactNumber.Size = new System.Drawing.Size(513, 45);
            this.txtboxContactNumber.TabIndex = 29;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactNumber.Location = new System.Drawing.Point(105, 460);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(162, 38);
            this.lblContactNumber.TabIndex = 28;
            this.lblContactNumber.Text = "Contact No.";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxLastName.Location = new System.Drawing.Point(324, 355);
            this.txtboxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(513, 45);
            this.txtboxLastName.TabIndex = 27;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(105, 355);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(147, 38);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Last Name";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxFirstName.Location = new System.Drawing.Point(324, 249);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(513, 45);
            this.txtboxFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(105, 249);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(151, 38);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "First Name";
            // 
            // txtboxContactID
            // 
            this.txtboxContactID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxContactID.Location = new System.Drawing.Point(324, 146);
            this.txtboxContactID.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxContactID.Name = "txtboxContactID";
            this.txtboxContactID.ReadOnly = true;
            this.txtboxContactID.Size = new System.Drawing.Size(513, 45);
            this.txtboxContactID.TabIndex = 23;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.Transparent;
            this.lblContactID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactID.Location = new System.Drawing.Point(105, 146);
            this.lblContactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(146, 38);
            this.lblContactID.TabIndex = 22;
            this.lblContactID.Text = "Contact ID";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 20.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2027, 84);
            this.label1.TabIndex = 21;
            this.label1.Text = "E-Contact";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Econtact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2027, 1155);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtboxContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtboxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Econtact";
            this.Text = "Econtact";
            this.Load += new System.EventHandler(this.Econtact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtBoxSearch;
        private Label lblSearch;
        private DataGridView dgvContactList;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblGender;
        private ComboBox cmbGender;
        private TextBox txtboxAddress;
        private Label lblAddress;
        private TextBox txtboxContactNumber;
        private Label lblContactNumber;
        private TextBox txtboxLastName;
        private Label lblLastName;
        private TextBox txtboxFirstName;
        private Label lblFirstName;
        private TextBox txtboxContactID;
        private Label lblContactID;
        private Label label1;
    }
}