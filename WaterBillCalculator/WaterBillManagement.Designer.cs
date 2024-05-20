namespace WaterBillCalculator
{
    partial class WaterBillManagement
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
            this.tabControlWaterBill = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNumberPeople = new System.Windows.Forms.TextBox();
            this.lbNumberPeople = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtWaterThisMonth = new System.Windows.Forms.TextBox();
            this.txtWaterLastMonth = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageManageBill = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSortDESC = new System.Windows.Forms.Button();
            this.btnSortASC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.txtNumberPeople1 = new System.Windows.Forms.TextBox();
            this.lbNumberPeople1 = new System.Windows.Forms.Label();
            this.cbCustomerType1 = new System.Windows.Forms.ComboBox();
            this.txtWaterThisMonth1 = new System.Windows.Forms.TextBox();
            this.txtWaterLastMonth1 = new System.Windows.Forms.TextBox();
            this.txtCustomerName1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageLogout = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControlWaterBill.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageManageBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWaterBill
            // 
            this.tabControlWaterBill.Controls.Add(this.tabPageAdd);
            this.tabControlWaterBill.Controls.Add(this.tabPageManageBill);
            this.tabControlWaterBill.Controls.Add(this.tabPageLogout);
            this.tabControlWaterBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWaterBill.Location = new System.Drawing.Point(0, 0);
            this.tabControlWaterBill.Name = "tabControlWaterBill";
            this.tabControlWaterBill.SelectedIndex = 0;
            this.tabControlWaterBill.Size = new System.Drawing.Size(1132, 596);
            this.tabControlWaterBill.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btnLuu);
            this.tabPageAdd.Controls.Add(this.txtNumberPeople);
            this.tabPageAdd.Controls.Add(this.lbNumberPeople);
            this.tabPageAdd.Controls.Add(this.btnXuatHoaDon);
            this.tabPageAdd.Controls.Add(this.cbCustomerType);
            this.tabPageAdd.Controls.Add(this.label5);
            this.tabPageAdd.Controls.Add(this.pictureBox1);
            this.tabPageAdd.Controls.Add(this.panel1);
            this.tabPageAdd.Controls.Add(this.txtWaterThisMonth);
            this.tabPageAdd.Controls.Add(this.txtWaterLastMonth);
            this.tabPageAdd.Controls.Add(this.txtCustomerName);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1124, 567);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add New";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            this.tabPageAdd.Click += new System.EventHandler(this.tabPageAdd_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Crimson;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLuu.Location = new System.Drawing.Point(303, 512);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(200, 46);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu thông tin KH";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNumberPeople
            // 
            this.txtNumberPeople.Location = new System.Drawing.Point(97, 478);
            this.txtNumberPeople.Name = "txtNumberPeople";
            this.txtNumberPeople.Size = new System.Drawing.Size(381, 22);
            this.txtNumberPeople.TabIndex = 29;
            // 
            // lbNumberPeople
            // 
            this.lbNumberPeople.AutoSize = true;
            this.lbNumberPeople.Location = new System.Drawing.Point(94, 458);
            this.lbNumberPeople.Name = "lbNumberPeople";
            this.lbNumberPeople.Size = new System.Drawing.Size(137, 16);
            this.lbNumberPeople.TabIndex = 28;
            this.lbNumberPeople.Text = "Số thành viên gia đình";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.Blue;
            this.btnXuatHoaDon.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(97, 512);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(200, 46);
            this.btnXuatHoaDon.TabIndex = 27;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Items.AddRange(new object[] {
            "Household ",
            "Administrative agency",
            "Production units",
            "Business services"});
            this.cbCustomerType.Location = new System.Drawing.Point(97, 402);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(381, 24);
            this.cbCustomerType.TabIndex = 26;
            this.cbCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbCustomerType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hóa đơn khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WaterBillCalculator.Properties.Resources.company_logo;
            this.pictureBox1.Location = new System.Drawing.Point(88, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblUsage);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(569, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 369);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thành tiền: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Loại khách hàng: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Số nước dùng: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tên khách hàng: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(473, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Công ty nước sạch Hà Nội - Địa chỉ số 10 Bà Triệu , Hà Nội. Liên hệ 0965741031";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(227, 185);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(0, 16);
            this.lblBill.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(227, 143);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 16);
            this.lblType.TabIndex = 2;
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(227, 103);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(0, 16);
            this.lblUsage.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(227, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 0;
            // 
            // txtWaterThisMonth
            // 
            this.txtWaterThisMonth.Location = new System.Drawing.Point(97, 331);
            this.txtWaterThisMonth.Name = "txtWaterThisMonth";
            this.txtWaterThisMonth.Size = new System.Drawing.Size(381, 22);
            this.txtWaterThisMonth.TabIndex = 23;
            // 
            // txtWaterLastMonth
            // 
            this.txtWaterLastMonth.Location = new System.Drawing.Point(97, 253);
            this.txtWaterLastMonth.Name = "txtWaterLastMonth";
            this.txtWaterLastMonth.Size = new System.Drawing.Size(381, 22);
            this.txtWaterLastMonth.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(94, 189);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(384, 22);
            this.txtCustomerName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Chọn loại khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chỉ số công tơ tháng này";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chỉ số công tơ tháng trước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên khách hàng";
            // 
            // tabPageManageBill
            // 
            this.tabPageManageBill.Controls.Add(this.btnCancel);
            this.tabPageManageBill.Controls.Add(this.txtSearch);
            this.tabPageManageBill.Controls.Add(this.btnSearch);
            this.tabPageManageBill.Controls.Add(this.btnSortDESC);
            this.tabPageManageBill.Controls.Add(this.btnSortASC);
            this.tabPageManageBill.Controls.Add(this.btnDelete);
            this.tabPageManageBill.Controls.Add(this.btnEdit);
            this.tabPageManageBill.Controls.Add(this.dgvBills);
            this.tabPageManageBill.Controls.Add(this.txtNumberPeople1);
            this.tabPageManageBill.Controls.Add(this.lbNumberPeople1);
            this.tabPageManageBill.Controls.Add(this.cbCustomerType1);
            this.tabPageManageBill.Controls.Add(this.txtWaterThisMonth1);
            this.tabPageManageBill.Controls.Add(this.txtWaterLastMonth1);
            this.tabPageManageBill.Controls.Add(this.txtCustomerName1);
            this.tabPageManageBill.Controls.Add(this.label7);
            this.tabPageManageBill.Controls.Add(this.label8);
            this.tabPageManageBill.Controls.Add(this.label9);
            this.tabPageManageBill.Controls.Add(this.label10);
            this.tabPageManageBill.Controls.Add(this.pictureBox2);
            this.tabPageManageBill.Location = new System.Drawing.Point(4, 25);
            this.tabPageManageBill.Name = "tabPageManageBill";
            this.tabPageManageBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageBill.Size = new System.Drawing.Size(1124, 567);
            this.tabPageManageBill.TabIndex = 1;
            this.tabPageManageBill.Text = "Manage Bill";
            this.tabPageManageBill.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1015, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 53);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(499, 128);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 34);
            this.txtSearch.TabIndex = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(897, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 34);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSortDESC
            // 
            this.btnSortDESC.Location = new System.Drawing.Point(867, 26);
            this.btnSortDESC.Name = "btnSortDESC";
            this.btnSortDESC.Size = new System.Drawing.Size(88, 53);
            this.btnSortDESC.TabIndex = 48;
            this.btnSortDESC.Text = "DESC";
            this.btnSortDESC.UseVisualStyleBackColor = true;
            this.btnSortDESC.Click += new System.EventHandler(this.btnSortDESC_Click);
            // 
            // btnSortASC
            // 
            this.btnSortASC.Location = new System.Drawing.Point(704, 26);
            this.btnSortASC.Name = "btnSortASC";
            this.btnSortASC.Size = new System.Drawing.Size(88, 53);
            this.btnSortASC.TabIndex = 47;
            this.btnSortASC.Text = "ASC";
            this.btnSortASC.UseVisualStyleBackColor = true;
            this.btnSortASC.Click += new System.EventHandler(this.btnSortASC_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 53);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(383, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 53);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvBills
            // 
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(383, 187);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.Size = new System.Drawing.Size(733, 311);
            this.dgvBills.TabIndex = 44;
            this.dgvBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellClick);
            // 
            // txtNumberPeople1
            // 
            this.txtNumberPeople1.Location = new System.Drawing.Point(31, 476);
            this.txtNumberPeople1.Name = "txtNumberPeople1";
            this.txtNumberPeople1.Size = new System.Drawing.Size(290, 22);
            this.txtNumberPeople1.TabIndex = 42;
            // 
            // lbNumberPeople1
            // 
            this.lbNumberPeople1.AutoSize = true;
            this.lbNumberPeople1.Location = new System.Drawing.Point(28, 456);
            this.lbNumberPeople1.Name = "lbNumberPeople1";
            this.lbNumberPeople1.Size = new System.Drawing.Size(137, 16);
            this.lbNumberPeople1.TabIndex = 41;
            this.lbNumberPeople1.Text = "Số thành viên gia đình";
            // 
            // cbCustomerType1
            // 
            this.cbCustomerType1.FormattingEnabled = true;
            this.cbCustomerType1.Items.AddRange(new object[] {
            "Household ",
            "Administrative agency",
            "Production units",
            "Business services"});
            this.cbCustomerType1.Location = new System.Drawing.Point(31, 400);
            this.cbCustomerType1.Name = "cbCustomerType1";
            this.cbCustomerType1.Size = new System.Drawing.Size(290, 24);
            this.cbCustomerType1.TabIndex = 39;
            // 
            // txtWaterThisMonth1
            // 
            this.txtWaterThisMonth1.Location = new System.Drawing.Point(31, 329);
            this.txtWaterThisMonth1.Name = "txtWaterThisMonth1";
            this.txtWaterThisMonth1.Size = new System.Drawing.Size(290, 22);
            this.txtWaterThisMonth1.TabIndex = 38;
            // 
            // txtWaterLastMonth1
            // 
            this.txtWaterLastMonth1.Location = new System.Drawing.Point(31, 251);
            this.txtWaterLastMonth1.Name = "txtWaterLastMonth1";
            this.txtWaterLastMonth1.Size = new System.Drawing.Size(290, 22);
            this.txtWaterLastMonth1.TabIndex = 37;
            // 
            // txtCustomerName1
            // 
            this.txtCustomerName1.Location = new System.Drawing.Point(28, 187);
            this.txtCustomerName1.Name = "txtCustomerName1";
            this.txtCustomerName1.Size = new System.Drawing.Size(293, 22);
            this.txtCustomerName1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Chọn loại khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Chỉ số công tơ tháng này";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Chỉ số công tơ tháng trước";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tên khách hàng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WaterBillCalculator.Properties.Resources.company_logo;
            this.pictureBox2.Location = new System.Drawing.Point(28, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // tabPageLogout
            // 
            this.tabPageLogout.Controls.Add(this.btnLogout);
            this.tabPageLogout.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogout.Name = "tabPageLogout";
            this.tabPageLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogout.Size = new System.Drawing.Size(1124, 567);
            this.tabPageLogout.TabIndex = 2;
            this.tabPageLogout.Text = "Logout";
            this.tabPageLogout.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(445, 245);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 45);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // WaterBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 596);
            this.Controls.Add(this.tabControlWaterBill);
            this.Name = "WaterBillManagement";
            this.Text = "WaterBillManagement";
            this.tabControlWaterBill.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageManageBill.ResumeLayout(false);
            this.tabPageManageBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWaterBill;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageManageBill;
        private System.Windows.Forms.TabPage tabPageLogout;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtNumberPeople;
        private System.Windows.Forms.Label lbNumberPeople;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtWaterThisMonth;
        private System.Windows.Forms.TextBox txtWaterLastMonth;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.TextBox txtNumberPeople1;
        private System.Windows.Forms.Label lbNumberPeople1;
        private System.Windows.Forms.ComboBox cbCustomerType1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtWaterThisMonth1;
        private System.Windows.Forms.TextBox txtWaterLastMonth1;
        private System.Windows.Forms.TextBox txtCustomerName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSortDESC;
        private System.Windows.Forms.Button btnSortASC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}