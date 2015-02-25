namespace EFUniversity
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnGroupToSubject = new System.Windows.Forms.Button();
            this.grBoxStudent = new System.Windows.Forms.GroupBox();
            this.btnStudUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboUpdGroupId = new System.Windows.Forms.ComboBox();
            this.txtUpdAge = new System.Windows.Forms.TextBox();
            this.txtUpdSurname = new System.Windows.Forms.TextBox();
            this.lblUpdStudGroup = new System.Windows.Forms.Label();
            this.lblUpdStudAge = new System.Windows.Forms.Label();
            this.lblUpdStudSurname = new System.Windows.Forms.Label();
            this.lblUpdStudName = new System.Windows.Forms.Label();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.btnStudDelete = new System.Windows.Forms.Button();
            this.btnStudCreate = new System.Windows.Forms.Button();
            this.lblInsert = new System.Windows.Forms.Label();
            this.comboGroupId = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grBoxGroup = new System.Windows.Forms.GroupBox();
            this.btnGroupUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUpdGroupName = new System.Windows.Forms.Label();
            this.txtUpdGroupName = new System.Windows.Forms.TextBox();
            this.btnGroupDelete = new System.Windows.Forms.Button();
            this.btnGroupCreate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.grBoxSubject = new System.Windows.Forms.GroupBox();
            this.btnSubjUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdSubjName = new System.Windows.Forms.Label();
            this.txtUpdSubjName = new System.Windows.Forms.TextBox();
            this.btnSubjDelete = new System.Windows.Forms.Button();
            this.btnSubjCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubjName = new System.Windows.Forms.Label();
            this.txtSubj = new System.Windows.Forms.TextBox();
            this.grBoxGTS = new System.Windows.Forms.GroupBox();
            this.btnGTSUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGTSUpdGroup = new System.Windows.Forms.ComboBox();
            this.lblGTSUpdGroup = new System.Windows.Forms.Label();
            this.btnGTSDelete = new System.Windows.Forms.Button();
            this.btnGTSCreate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboGTSGroup = new System.Windows.Forms.ComboBox();
            this.lblGTSGroup = new System.Windows.Forms.Label();
            this.comboGTSSubj = new System.Windows.Forms.ComboBox();
            this.lblGTSSubj = new System.Windows.Forms.Label();
            this.comboGTSUpdSubj = new System.Windows.Forms.ComboBox();
            this.lblGTSUpdSubj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grBoxStudent.SuspendLayout();
            this.grBoxGroup.SuspendLayout();
            this.grBoxSubject.SuspendLayout();
            this.grBoxGTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(567, 12);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(112, 23);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(567, 41);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(112, 23);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(726, 12);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(112, 23);
            this.btnSubjects.TabIndex = 3;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnGroupToSubject
            // 
            this.btnGroupToSubject.Location = new System.Drawing.Point(726, 41);
            this.btnGroupToSubject.Name = "btnGroupToSubject";
            this.btnGroupToSubject.Size = new System.Drawing.Size(112, 23);
            this.btnGroupToSubject.TabIndex = 4;
            this.btnGroupToSubject.Text = "GroupToSubject";
            this.btnGroupToSubject.UseVisualStyleBackColor = true;
            this.btnGroupToSubject.Click += new System.EventHandler(this.btnGroupToSubject_Click);
            // 
            // grBoxStudent
            // 
            this.grBoxStudent.Controls.Add(this.btnStudUpdate);
            this.grBoxStudent.Controls.Add(this.label1);
            this.grBoxStudent.Controls.Add(this.comboUpdGroupId);
            this.grBoxStudent.Controls.Add(this.txtUpdAge);
            this.grBoxStudent.Controls.Add(this.txtUpdSurname);
            this.grBoxStudent.Controls.Add(this.lblUpdStudGroup);
            this.grBoxStudent.Controls.Add(this.lblUpdStudAge);
            this.grBoxStudent.Controls.Add(this.lblUpdStudSurname);
            this.grBoxStudent.Controls.Add(this.lblUpdStudName);
            this.grBoxStudent.Controls.Add(this.txtUpdName);
            this.grBoxStudent.Controls.Add(this.btnStudDelete);
            this.grBoxStudent.Controls.Add(this.btnStudCreate);
            this.grBoxStudent.Controls.Add(this.lblInsert);
            this.grBoxStudent.Controls.Add(this.comboGroupId);
            this.grBoxStudent.Controls.Add(this.txtAge);
            this.grBoxStudent.Controls.Add(this.txtSurname);
            this.grBoxStudent.Controls.Add(this.lblGroupId);
            this.grBoxStudent.Controls.Add(this.lblAge);
            this.grBoxStudent.Controls.Add(this.lblSurname);
            this.grBoxStudent.Controls.Add(this.lblName);
            this.grBoxStudent.Controls.Add(this.txtName);
            this.grBoxStudent.Location = new System.Drawing.Point(844, 12);
            this.grBoxStudent.Name = "grBoxStudent";
            this.grBoxStudent.Size = new System.Drawing.Size(271, 388);
            this.grBoxStudent.TabIndex = 9;
            this.grBoxStudent.TabStop = false;
            this.grBoxStudent.Text = "Student";
            this.grBoxStudent.Visible = false;
            // 
            // btnStudUpdate
            // 
            this.btnStudUpdate.Location = new System.Drawing.Point(6, 330);
            this.btnStudUpdate.Name = "btnStudUpdate";
            this.btnStudUpdate.Size = new System.Drawing.Size(259, 23);
            this.btnStudUpdate.TabIndex = 26;
            this.btnStudUpdate.Text = "Update Selected Row";
            this.btnStudUpdate.UseVisualStyleBackColor = true;
            this.btnStudUpdate.Click += new System.EventHandler(this.btnStudUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Update Selected Row";
            // 
            // comboUpdGroupId
            // 
            this.comboUpdGroupId.FormattingEnabled = true;
            this.comboUpdGroupId.Location = new System.Drawing.Point(81, 303);
            this.comboUpdGroupId.Name = "comboUpdGroupId";
            this.comboUpdGroupId.Size = new System.Drawing.Size(184, 21);
            this.comboUpdGroupId.TabIndex = 24;
            // 
            // txtUpdAge
            // 
            this.txtUpdAge.Location = new System.Drawing.Point(81, 277);
            this.txtUpdAge.Name = "txtUpdAge";
            this.txtUpdAge.Size = new System.Drawing.Size(184, 20);
            this.txtUpdAge.TabIndex = 23;
            // 
            // txtUpdSurname
            // 
            this.txtUpdSurname.Location = new System.Drawing.Point(81, 251);
            this.txtUpdSurname.Name = "txtUpdSurname";
            this.txtUpdSurname.Size = new System.Drawing.Size(184, 20);
            this.txtUpdSurname.TabIndex = 22;
            // 
            // lblUpdStudGroup
            // 
            this.lblUpdStudGroup.AutoSize = true;
            this.lblUpdStudGroup.Location = new System.Drawing.Point(36, 306);
            this.lblUpdStudGroup.Name = "lblUpdStudGroup";
            this.lblUpdStudGroup.Size = new System.Drawing.Size(39, 13);
            this.lblUpdStudGroup.TabIndex = 21;
            this.lblUpdStudGroup.Text = "Group:";
            // 
            // lblUpdStudAge
            // 
            this.lblUpdStudAge.AutoSize = true;
            this.lblUpdStudAge.Location = new System.Drawing.Point(46, 280);
            this.lblUpdStudAge.Name = "lblUpdStudAge";
            this.lblUpdStudAge.Size = new System.Drawing.Size(29, 13);
            this.lblUpdStudAge.TabIndex = 20;
            this.lblUpdStudAge.Text = "Age:";
            // 
            // lblUpdStudSurname
            // 
            this.lblUpdStudSurname.AutoSize = true;
            this.lblUpdStudSurname.Location = new System.Drawing.Point(17, 254);
            this.lblUpdStudSurname.Name = "lblUpdStudSurname";
            this.lblUpdStudSurname.Size = new System.Drawing.Size(58, 13);
            this.lblUpdStudSurname.TabIndex = 19;
            this.lblUpdStudSurname.Text = "LastName:";
            // 
            // lblUpdStudName
            // 
            this.lblUpdStudName.AutoSize = true;
            this.lblUpdStudName.Location = new System.Drawing.Point(18, 228);
            this.lblUpdStudName.Name = "lblUpdStudName";
            this.lblUpdStudName.Size = new System.Drawing.Size(57, 13);
            this.lblUpdStudName.TabIndex = 18;
            this.lblUpdStudName.Text = "FirstName:";
            // 
            // txtUpdName
            // 
            this.txtUpdName.Location = new System.Drawing.Point(81, 225);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(184, 20);
            this.txtUpdName.TabIndex = 17;
            // 
            // btnStudDelete
            // 
            this.btnStudDelete.Location = new System.Drawing.Point(6, 359);
            this.btnStudDelete.Name = "btnStudDelete";
            this.btnStudDelete.Size = new System.Drawing.Size(259, 23);
            this.btnStudDelete.TabIndex = 15;
            this.btnStudDelete.Text = "Delete Selected Row";
            this.btnStudDelete.UseVisualStyleBackColor = true;
            this.btnStudDelete.Click += new System.EventHandler(this.btnStudDelete_Click);
            // 
            // btnStudCreate
            // 
            this.btnStudCreate.Location = new System.Drawing.Point(6, 147);
            this.btnStudCreate.Name = "btnStudCreate";
            this.btnStudCreate.Size = new System.Drawing.Size(259, 23);
            this.btnStudCreate.TabIndex = 9;
            this.btnStudCreate.Text = "Insert New Record";
            this.btnStudCreate.UseVisualStyleBackColor = true;
            this.btnStudCreate.Click += new System.EventHandler(this.btnStudCreate_Click);
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(116, 16);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(33, 13);
            this.lblInsert.TabIndex = 8;
            this.lblInsert.Text = "Insert";
            // 
            // comboGroupId
            // 
            this.comboGroupId.FormattingEnabled = true;
            this.comboGroupId.Location = new System.Drawing.Point(81, 120);
            this.comboGroupId.Name = "comboGroupId";
            this.comboGroupId.Size = new System.Drawing.Size(184, 21);
            this.comboGroupId.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(81, 94);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(184, 20);
            this.txtAge.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(81, 68);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(184, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Location = new System.Drawing.Point(36, 123);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(39, 13);
            this.lblGroupId.TabIndex = 4;
            this.lblGroupId.Text = "Group:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(46, 97);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 71);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "LastName:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "FirstName:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 0;
            // 
            // grBoxGroup
            // 
            this.grBoxGroup.Controls.Add(this.btnGroupUpdate);
            this.grBoxGroup.Controls.Add(this.label6);
            this.grBoxGroup.Controls.Add(this.lblUpdGroupName);
            this.grBoxGroup.Controls.Add(this.txtUpdGroupName);
            this.grBoxGroup.Controls.Add(this.btnGroupDelete);
            this.grBoxGroup.Controls.Add(this.btnGroupCreate);
            this.grBoxGroup.Controls.Add(this.label11);
            this.grBoxGroup.Controls.Add(this.lblGroupName);
            this.grBoxGroup.Controls.Add(this.txtGroupName);
            this.grBoxGroup.Location = new System.Drawing.Point(1121, 216);
            this.grBoxGroup.Name = "grBoxGroup";
            this.grBoxGroup.Size = new System.Drawing.Size(230, 198);
            this.grBoxGroup.TabIndex = 27;
            this.grBoxGroup.TabStop = false;
            this.grBoxGroup.Text = "Group";
            this.grBoxGroup.Visible = false;
            // 
            // btnGroupUpdate
            // 
            this.btnGroupUpdate.Location = new System.Drawing.Point(6, 133);
            this.btnGroupUpdate.Name = "btnGroupUpdate";
            this.btnGroupUpdate.Size = new System.Drawing.Size(212, 23);
            this.btnGroupUpdate.TabIndex = 26;
            this.btnGroupUpdate.Text = "Update Selected Row";
            this.btnGroupUpdate.UseVisualStyleBackColor = true;
            this.btnGroupUpdate.Click += new System.EventHandler(this.btnGroupUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Update Selected Row";
            // 
            // lblUpdGroupName
            // 
            this.lblUpdGroupName.AutoSize = true;
            this.lblUpdGroupName.Location = new System.Drawing.Point(18, 110);
            this.lblUpdGroupName.Name = "lblUpdGroupName";
            this.lblUpdGroupName.Size = new System.Drawing.Size(38, 13);
            this.lblUpdGroupName.TabIndex = 18;
            this.lblUpdGroupName.Text = "Name:";
            // 
            // txtUpdGroupName
            // 
            this.txtUpdGroupName.Location = new System.Drawing.Point(81, 107);
            this.txtUpdGroupName.Name = "txtUpdGroupName";
            this.txtUpdGroupName.Size = new System.Drawing.Size(137, 20);
            this.txtUpdGroupName.TabIndex = 17;
            // 
            // btnGroupDelete
            // 
            this.btnGroupDelete.Location = new System.Drawing.Point(6, 162);
            this.btnGroupDelete.Name = "btnGroupDelete";
            this.btnGroupDelete.Size = new System.Drawing.Size(212, 23);
            this.btnGroupDelete.TabIndex = 15;
            this.btnGroupDelete.Text = "Delete Selected Row";
            this.btnGroupDelete.UseVisualStyleBackColor = true;
            this.btnGroupDelete.Click += new System.EventHandler(this.btnGroupDelete_Click);
            // 
            // btnGroupCreate
            // 
            this.btnGroupCreate.Location = new System.Drawing.Point(6, 55);
            this.btnGroupCreate.Name = "btnGroupCreate";
            this.btnGroupCreate.Size = new System.Drawing.Size(212, 23);
            this.btnGroupCreate.TabIndex = 9;
            this.btnGroupCreate.Text = "Insert New Record";
            this.btnGroupCreate.UseVisualStyleBackColor = true;
            this.btnGroupCreate.Click += new System.EventHandler(this.btnGroupCreate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Insert";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(18, 32);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(38, 13);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Name:";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(81, 29);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(137, 20);
            this.txtGroupName.TabIndex = 0;
            // 
            // grBoxSubject
            // 
            this.grBoxSubject.Controls.Add(this.btnSubjUpdate);
            this.grBoxSubject.Controls.Add(this.label2);
            this.grBoxSubject.Controls.Add(this.lblUpdSubjName);
            this.grBoxSubject.Controls.Add(this.txtUpdSubjName);
            this.grBoxSubject.Controls.Add(this.btnSubjDelete);
            this.grBoxSubject.Controls.Add(this.btnSubjCreate);
            this.grBoxSubject.Controls.Add(this.label4);
            this.grBoxSubject.Controls.Add(this.lblSubjName);
            this.grBoxSubject.Controls.Add(this.txtSubj);
            this.grBoxSubject.Location = new System.Drawing.Point(1121, 12);
            this.grBoxSubject.Name = "grBoxSubject";
            this.grBoxSubject.Size = new System.Drawing.Size(230, 198);
            this.grBoxSubject.TabIndex = 28;
            this.grBoxSubject.TabStop = false;
            this.grBoxSubject.Text = "Subject";
            this.grBoxSubject.Visible = false;
            // 
            // btnSubjUpdate
            // 
            this.btnSubjUpdate.Location = new System.Drawing.Point(6, 133);
            this.btnSubjUpdate.Name = "btnSubjUpdate";
            this.btnSubjUpdate.Size = new System.Drawing.Size(212, 23);
            this.btnSubjUpdate.TabIndex = 26;
            this.btnSubjUpdate.Text = "Update Selected Row";
            this.btnSubjUpdate.UseVisualStyleBackColor = true;
            this.btnSubjUpdate.Click += new System.EventHandler(this.btnSubjUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Update Selected Row";
            // 
            // lblUpdSubjName
            // 
            this.lblUpdSubjName.AutoSize = true;
            this.lblUpdSubjName.Location = new System.Drawing.Point(18, 110);
            this.lblUpdSubjName.Name = "lblUpdSubjName";
            this.lblUpdSubjName.Size = new System.Drawing.Size(38, 13);
            this.lblUpdSubjName.TabIndex = 18;
            this.lblUpdSubjName.Text = "Name:";
            // 
            // txtUpdSubjName
            // 
            this.txtUpdSubjName.Location = new System.Drawing.Point(81, 107);
            this.txtUpdSubjName.Name = "txtUpdSubjName";
            this.txtUpdSubjName.Size = new System.Drawing.Size(137, 20);
            this.txtUpdSubjName.TabIndex = 17;
            // 
            // btnSubjDelete
            // 
            this.btnSubjDelete.Location = new System.Drawing.Point(6, 162);
            this.btnSubjDelete.Name = "btnSubjDelete";
            this.btnSubjDelete.Size = new System.Drawing.Size(212, 23);
            this.btnSubjDelete.TabIndex = 15;
            this.btnSubjDelete.Text = "Delete Selected Row";
            this.btnSubjDelete.UseVisualStyleBackColor = true;
            this.btnSubjDelete.Click += new System.EventHandler(this.btnSubjDelete_Click);
            // 
            // btnSubjCreate
            // 
            this.btnSubjCreate.Location = new System.Drawing.Point(6, 55);
            this.btnSubjCreate.Name = "btnSubjCreate";
            this.btnSubjCreate.Size = new System.Drawing.Size(212, 23);
            this.btnSubjCreate.TabIndex = 9;
            this.btnSubjCreate.Text = "Insert New Record";
            this.btnSubjCreate.UseVisualStyleBackColor = true;
            this.btnSubjCreate.Click += new System.EventHandler(this.btnSubjCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insert";
            // 
            // lblSubjName
            // 
            this.lblSubjName.AutoSize = true;
            this.lblSubjName.Location = new System.Drawing.Point(18, 32);
            this.lblSubjName.Name = "lblSubjName";
            this.lblSubjName.Size = new System.Drawing.Size(38, 13);
            this.lblSubjName.TabIndex = 1;
            this.lblSubjName.Text = "Name:";
            // 
            // txtSubj
            // 
            this.txtSubj.Location = new System.Drawing.Point(81, 29);
            this.txtSubj.Name = "txtSubj";
            this.txtSubj.Size = new System.Drawing.Size(137, 20);
            this.txtSubj.TabIndex = 0;
            // 
            // grBoxGTS
            // 
            this.grBoxGTS.Controls.Add(this.comboGTSUpdSubj);
            this.grBoxGTS.Controls.Add(this.lblGTSUpdSubj);
            this.grBoxGTS.Controls.Add(this.comboGTSSubj);
            this.grBoxGTS.Controls.Add(this.lblGTSSubj);
            this.grBoxGTS.Controls.Add(this.btnGTSUpdate);
            this.grBoxGTS.Controls.Add(this.label3);
            this.grBoxGTS.Controls.Add(this.comboGTSUpdGroup);
            this.grBoxGTS.Controls.Add(this.lblGTSUpdGroup);
            this.grBoxGTS.Controls.Add(this.btnGTSDelete);
            this.grBoxGTS.Controls.Add(this.btnGTSCreate);
            this.grBoxGTS.Controls.Add(this.label10);
            this.grBoxGTS.Controls.Add(this.comboGTSGroup);
            this.grBoxGTS.Controls.Add(this.lblGTSGroup);
            this.grBoxGTS.Location = new System.Drawing.Point(567, 70);
            this.grBoxGTS.Name = "grBoxGTS";
            this.grBoxGTS.Size = new System.Drawing.Size(271, 257);
            this.grBoxGTS.TabIndex = 27;
            this.grBoxGTS.TabStop = false;
            this.grBoxGTS.Text = "GroupToSubject";
            this.grBoxGTS.Visible = false;
            // 
            // btnGTSUpdate
            // 
            this.btnGTSUpdate.Location = new System.Drawing.Point(6, 196);
            this.btnGTSUpdate.Name = "btnGTSUpdate";
            this.btnGTSUpdate.Size = new System.Drawing.Size(259, 23);
            this.btnGTSUpdate.TabIndex = 26;
            this.btnGTSUpdate.Text = "Update Selected Row";
            this.btnGTSUpdate.UseVisualStyleBackColor = true;
            this.btnGTSUpdate.Click += new System.EventHandler(this.btnGTSUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Update Selected Row";
            // 
            // comboGTSUpdGroup
            // 
            this.comboGTSUpdGroup.FormattingEnabled = true;
            this.comboGTSUpdGroup.Location = new System.Drawing.Point(81, 142);
            this.comboGTSUpdGroup.Name = "comboGTSUpdGroup";
            this.comboGTSUpdGroup.Size = new System.Drawing.Size(184, 21);
            this.comboGTSUpdGroup.TabIndex = 24;
            // 
            // lblGTSUpdGroup
            // 
            this.lblGTSUpdGroup.AutoSize = true;
            this.lblGTSUpdGroup.Location = new System.Drawing.Point(36, 145);
            this.lblGTSUpdGroup.Name = "lblGTSUpdGroup";
            this.lblGTSUpdGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGTSUpdGroup.TabIndex = 21;
            this.lblGTSUpdGroup.Text = "Group:";
            // 
            // btnGTSDelete
            // 
            this.btnGTSDelete.Location = new System.Drawing.Point(6, 225);
            this.btnGTSDelete.Name = "btnGTSDelete";
            this.btnGTSDelete.Size = new System.Drawing.Size(259, 23);
            this.btnGTSDelete.TabIndex = 15;
            this.btnGTSDelete.Text = "Delete Selected Row";
            this.btnGTSDelete.UseVisualStyleBackColor = true;
            this.btnGTSDelete.Click += new System.EventHandler(this.btnGTSDelete_Click);
            // 
            // btnGTSCreate
            // 
            this.btnGTSCreate.Location = new System.Drawing.Point(6, 91);
            this.btnGTSCreate.Name = "btnGTSCreate";
            this.btnGTSCreate.Size = new System.Drawing.Size(259, 23);
            this.btnGTSCreate.TabIndex = 9;
            this.btnGTSCreate.Text = "Insert New Record";
            this.btnGTSCreate.UseVisualStyleBackColor = true;
            this.btnGTSCreate.Click += new System.EventHandler(this.btnGTSCreate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Insert";
            // 
            // comboGTSGroup
            // 
            this.comboGTSGroup.FormattingEnabled = true;
            this.comboGTSGroup.Location = new System.Drawing.Point(81, 37);
            this.comboGTSGroup.Name = "comboGTSGroup";
            this.comboGTSGroup.Size = new System.Drawing.Size(184, 21);
            this.comboGTSGroup.TabIndex = 7;
            // 
            // lblGTSGroup
            // 
            this.lblGTSGroup.AutoSize = true;
            this.lblGTSGroup.Location = new System.Drawing.Point(36, 40);
            this.lblGTSGroup.Name = "lblGTSGroup";
            this.lblGTSGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGTSGroup.TabIndex = 4;
            this.lblGTSGroup.Text = "Group:";
            // 
            // comboGTSSubj
            // 
            this.comboGTSSubj.FormattingEnabled = true;
            this.comboGTSSubj.Location = new System.Drawing.Point(81, 64);
            this.comboGTSSubj.Name = "comboGTSSubj";
            this.comboGTSSubj.Size = new System.Drawing.Size(184, 21);
            this.comboGTSSubj.TabIndex = 28;
            // 
            // lblGTSSubj
            // 
            this.lblGTSSubj.AutoSize = true;
            this.lblGTSSubj.Location = new System.Drawing.Point(36, 67);
            this.lblGTSSubj.Name = "lblGTSSubj";
            this.lblGTSSubj.Size = new System.Drawing.Size(46, 13);
            this.lblGTSSubj.TabIndex = 27;
            this.lblGTSSubj.Text = "Subject:";
            // 
            // comboGTSUpdSubj
            // 
            this.comboGTSUpdSubj.FormattingEnabled = true;
            this.comboGTSUpdSubj.Location = new System.Drawing.Point(81, 169);
            this.comboGTSUpdSubj.Name = "comboGTSUpdSubj";
            this.comboGTSUpdSubj.Size = new System.Drawing.Size(184, 21);
            this.comboGTSUpdSubj.TabIndex = 30;
            // 
            // lblGTSUpdSubj
            // 
            this.lblGTSUpdSubj.AutoSize = true;
            this.lblGTSUpdSubj.Location = new System.Drawing.Point(36, 172);
            this.lblGTSUpdSubj.Name = "lblGTSUpdSubj";
            this.lblGTSUpdSubj.Size = new System.Drawing.Size(46, 13);
            this.lblGTSUpdSubj.TabIndex = 29;
            this.lblGTSUpdSubj.Text = "Subject:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 475);
            this.Controls.Add(this.grBoxGTS);
            this.Controls.Add(this.grBoxSubject);
            this.Controls.Add(this.grBoxGroup);
            this.Controls.Add(this.grBoxStudent);
            this.Controls.Add(this.btnGroupToSubject);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnGroups);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "University";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grBoxStudent.ResumeLayout(false);
            this.grBoxStudent.PerformLayout();
            this.grBoxGroup.ResumeLayout(false);
            this.grBoxGroup.PerformLayout();
            this.grBoxSubject.ResumeLayout(false);
            this.grBoxSubject.PerformLayout();
            this.grBoxGTS.ResumeLayout(false);
            this.grBoxGTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnGroupToSubject;
        private System.Windows.Forms.GroupBox grBoxStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboGroupId;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Button btnStudCreate;
        private System.Windows.Forms.Button btnStudDelete;
        private System.Windows.Forms.Button btnStudUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUpdGroupId;
        private System.Windows.Forms.TextBox txtUpdAge;
        private System.Windows.Forms.TextBox txtUpdSurname;
        private System.Windows.Forms.Label lblUpdStudGroup;
        private System.Windows.Forms.Label lblUpdStudAge;
        private System.Windows.Forms.Label lblUpdStudSurname;
        private System.Windows.Forms.Label lblUpdStudName;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.GroupBox grBoxGroup;
        private System.Windows.Forms.Button btnGroupUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUpdGroupName;
        private System.Windows.Forms.TextBox txtUpdGroupName;
        private System.Windows.Forms.Button btnGroupDelete;
        private System.Windows.Forms.Button btnGroupCreate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.GroupBox grBoxSubject;
        private System.Windows.Forms.Button btnSubjUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdSubjName;
        private System.Windows.Forms.TextBox txtUpdSubjName;
        private System.Windows.Forms.Button btnSubjDelete;
        private System.Windows.Forms.Button btnSubjCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubjName;
        private System.Windows.Forms.TextBox txtSubj;
        private System.Windows.Forms.GroupBox grBoxGTS;
        private System.Windows.Forms.ComboBox comboGTSUpdSubj;
        private System.Windows.Forms.Label lblGTSUpdSubj;
        private System.Windows.Forms.ComboBox comboGTSSubj;
        private System.Windows.Forms.Label lblGTSSubj;
        private System.Windows.Forms.Button btnGTSUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGTSUpdGroup;
        private System.Windows.Forms.Label lblGTSUpdGroup;
        private System.Windows.Forms.Button btnGTSDelete;
        private System.Windows.Forms.Button btnGTSCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboGTSGroup;
        private System.Windows.Forms.Label lblGTSGroup;
    }
}

