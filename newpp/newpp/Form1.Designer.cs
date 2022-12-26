namespace newpp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtmajor = new System.Windows.Forms.TextBox();
            this.chess1dbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chessclubDataSet = new newpp.chessclubDataSet();
            this.txtactivity = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnassign = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.chess1dbTableAdapter = new newpp.chessclubDataSetTableAdapters.chess1dbTableAdapter();
            this.btndisplay = new System.Windows.Forms.Button();
            this.txtgndr = new System.Windows.Forms.TextBox();
            this.chessclubDataSet1 = new newpp.chessclubDataSet1();
            this.chess1dbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chess1dbTableAdapter1 = new newpp.chessclubDataSet1TableAdapters.chess1dbTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btndetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chess1dbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessclubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessclubDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chess1dbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "USIU CHESS CLUB MEMBER MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(51, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create new member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "School ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Major";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(18, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(522, 488);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "A Product of Sharad Software Solutions ltd.";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(112, 67);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(116, 23);
            this.txtname.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(112, 97);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(116, 23);
            this.txtid.TabIndex = 8;
            // 
            // txtmajor
            // 
            this.txtmajor.Location = new System.Drawing.Point(112, 126);
            this.txtmajor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmajor.Name = "txtmajor";
            this.txtmajor.Size = new System.Drawing.Size(116, 23);
            this.txtmajor.TabIndex = 9;
            // 
            // chess1dbBindingSource
            // 
            this.chess1dbBindingSource.DataMember = "chess1db";
            this.chess1dbBindingSource.DataSource = this.chessclubDataSet;
            // 
            // chessclubDataSet
            // 
            this.chessclubDataSet.DataSetName = "chessclubDataSet";
            this.chessclubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtactivity
            // 
            this.txtactivity.Location = new System.Drawing.Point(705, 116);
            this.txtactivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtactivity.Name = "txtactivity";
            this.txtactivity.Size = new System.Drawing.Size(116, 23);
            this.txtactivity.TabIndex = 20;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(705, 88);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(116, 23);
            this.idtxt.TabIndex = 19;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(705, 58);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(116, 23);
            this.nametxt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(610, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Activity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(610, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "School ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(610, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(643, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Assign activities";
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.LimeGreen;
            this.btncreate.Location = new System.Drawing.Point(236, 67);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(88, 53);
            this.btncreate.TabIndex = 21;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnnext.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnnext.Location = new System.Drawing.Point(610, 178);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(105, 27);
            this.btnnext.TabIndex = 22;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnprev.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnprev.Location = new System.Drawing.Point(716, 178);
            this.btnprev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(116, 27);
            this.btnprev.TabIndex = 23;
            this.btnprev.Text = "Previous";
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnassign
            // 
            this.btnassign.BackColor = System.Drawing.Color.LimeGreen;
            this.btnassign.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnassign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnassign.Location = new System.Drawing.Point(716, 212);
            this.btnassign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnassign.Name = "btnassign";
            this.btnassign.Size = new System.Drawing.Size(116, 43);
            this.btnassign.TabIndex = 24;
            this.btnassign.Text = "Assign";
            this.btnassign.UseVisualStyleBackColor = false;
            this.btnassign.Click += new System.EventHandler(this.btnassign_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnclose.FlatAppearance.BorderSize = 3;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnclose.Location = new System.Drawing.Point(648, 391);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(159, 76);
            this.btnclose.TabIndex = 25;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnview.Location = new System.Drawing.Point(236, 129);
            this.btnview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(88, 57);
            this.btnview.TabIndex = 26;
            this.btnview.Text = "View/ Refresh";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.Black;
            this.btnhide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnhide.FlatAppearance.BorderSize = 2;
            this.btnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhide.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnhide.Location = new System.Drawing.Point(648, 280);
            this.btnhide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(156, 76);
            this.btnhide.TabIndex = 27;
            this.btnhide.Text = "Hide";
            this.btnhide.UseVisualStyleBackColor = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // chess1dbTableAdapter
            // 
            this.chess1dbTableAdapter.ClearBeforeFill = true;
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.SystemColors.ControlText;
            this.btndisplay.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btndisplay.Location = new System.Drawing.Point(610, 145);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(222, 27);
            this.btndisplay.TabIndex = 28;
            this.btndisplay.Text = "Display Members";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // txtgndr
            // 
            this.txtgndr.Location = new System.Drawing.Point(112, 155);
            this.txtgndr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgndr.Name = "txtgndr";
            this.txtgndr.Size = new System.Drawing.Size(116, 23);
            this.txtgndr.TabIndex = 29;
            // 
            // chessclubDataSet1
            // 
            this.chessclubDataSet1.DataSetName = "chessclubDataSet1";
            this.chessclubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chess1dbBindingSource1
            // 
            this.chess1dbBindingSource1.DataMember = "chess1db";
            this.chess1dbBindingSource1.DataSource = this.chessclubDataSet1;
            // 
            // chess1dbTableAdapter1
            // 
            this.chess1dbTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namesDataGridViewTextBoxColumn,
            this.schoolidDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.chess1dbBindingSource, "memberID", true));
            this.dataGridView1.DataSource = this.chess1dbBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(21, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(572, 289);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.Visible = false;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "names";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.namesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.namesDataGridViewTextBoxColumn.HeaderText = "names";
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolidDataGridViewTextBoxColumn
            // 
            this.schoolidDataGridViewTextBoxColumn.DataPropertyName = "schoolid";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.schoolidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.schoolidDataGridViewTextBoxColumn.FillWeight = 80F;
            this.schoolidDataGridViewTextBoxColumn.HeaderText = "schoolid";
            this.schoolidDataGridViewTextBoxColumn.Name = "schoolidDataGridViewTextBoxColumn";
            this.schoolidDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolidDataGridViewTextBoxColumn.Width = 80;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.genderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.genderDataGridViewTextBoxColumn.FillWeight = 80F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 80;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "major";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.majorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.majorDataGridViewTextBoxColumn.HeaderText = "major";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "activity";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.activityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.activityDataGridViewTextBoxColumn.FillWeight = 170F;
            this.activityDataGridViewTextBoxColumn.HeaderText = "activity";
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            this.activityDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn.Width = 170;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(613, 212);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 43);
            this.btndelete.TabIndex = 31;
            this.btndelete.Text = "REMOVE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(196, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Note: Press details to view";
            // 
            // btndetails
            // 
            this.btndetails.BackColor = System.Drawing.SystemColors.ControlText;
            this.btndetails.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btndetails.Location = new System.Drawing.Point(236, 41);
            this.btndetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(88, 27);
            this.btndetails.TabIndex = 33;
            this.btndetails.Text = "Details";
            this.btndetails.UseVisualStyleBackColor = false;
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(331, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 142);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::newpp.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndetails);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtgndr);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnassign);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtactivity);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmajor);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Chess Club Member\'s App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chess1dbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessclubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessclubDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chess1dbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtmajor;
        private System.Windows.Forms.TextBox txtactivity;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnassign;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnhide;
        private chessclubDataSet chessclubDataSet;
        private System.Windows.Forms.BindingSource chess1dbBindingSource;
        private chessclubDataSetTableAdapters.chess1dbTableAdapter chess1dbTableAdapter;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.TextBox txtgndr;
        private chessclubDataSet1 chessclubDataSet1;
        private System.Windows.Forms.BindingSource chess1dbBindingSource1;
        private chessclubDataSet1TableAdapters.chess1dbTableAdapter chess1dbTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btndetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
    }
}

