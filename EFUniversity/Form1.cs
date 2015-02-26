using DAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFUniversity
{
    public partial class Form1 : Form
    {
        UniversityContext context;

        public Form1()
        {
            InitializeComponent();
            context = new UniversityContext();

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            var query = from c in context.Students select c;
            var students = query.ToList();
            dataGridView1.DataSource = context.Students.ToList();
            //dataGridView1.DataMember = "Students";

            //Width = 990;
            grBoxStudent.Location = new Point(){ X = 570, Y = 70};
            grBoxStudent.Visible = true;
            grBoxGroup.Visible = false;
            grBoxSubject.Visible = false;
            grBoxGTS.Visible = false;

            int row = dataGridView1.CurrentRow.Index;
            txtUpdName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtUpdSurname.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtUpdAge.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            int grId = Int32.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());
            
            var groups = context.Groups.ToList();
            comboUpdGroupId.DataSource = groups;
            var current = (from s in context.Groups where s.Id == grId select s).FirstOrDefault();
            if(current != null)
            {
                comboUpdGroupId.SelectedItem = comboUpdGroupId.Items[comboUpdGroupId.Items.IndexOf(current)];
            }
            comboUpdGroupId.DisplayMember = "Name";
            comboUpdGroupId.ValueMember = "Id";

            comboGroupId.DataSource = groups;
            comboGroupId.DisplayMember = "Name";
            comboGroupId.ValueMember = "Id";
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            var query = from c in context.Groups select c;
            var groups = query.ToList();
            dataGridView1.DataSource = groups;

            grBoxGroup.Location = new Point() { X = 570, Y = 70 };
            grBoxStudent.Visible = false;
            grBoxGroup.Visible = true;
            grBoxSubject.Visible = false;
            grBoxGTS.Visible = false;

            int row = dataGridView1.CurrentRow.Index;
            txtUpdGroupName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            var query = from c in context.Subjects select c;
            var subjects = query.ToList();
            dataGridView1.DataSource = subjects;

            grBoxSubject.Location = new Point() { X = 570, Y = 70 };
            grBoxStudent.Visible = false;
            grBoxGroup.Visible = false;
            grBoxSubject.Visible = true;
            grBoxGTS.Visible = false;

            if (dataGridView1.CurrentRow != null)
            {
                int row = dataGridView1.CurrentRow.Index;
                txtUpdSubjName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void btnGroupToSubject_Click(object sender, EventArgs e)
        {
            var query = from c in context.GroupsToSubjects select c;
            var groupsToSubjects = query.ToList();
            dataGridView1.DataSource = groupsToSubjects;

            grBoxGTS.Location = new Point() { X = 570, Y = 70 };
            grBoxStudent.Visible = false;
            grBoxGroup.Visible = false;
            grBoxSubject.Visible = false;
            grBoxGTS.Visible = true;

            var groups = context.Groups.ToList();
            var subjects = context.Subjects.ToList();
            var updGroups = context.Groups.ToList();
            var updSubjects = context.Subjects.ToList();

            comboGTSGroup.DataSource = groups;
            comboGTSGroup.DisplayMember = "Name";
            comboGTSGroup.ValueMember = "Id";
            
            comboGTSSubj.DataSource = subjects;
            comboGTSSubj.DisplayMember = "Name";
            comboGTSSubj.ValueMember = "Id";
            
            comboGTSUpdGroup.DataSource = updGroups;
            comboGTSUpdGroup.DisplayMember = "Name";
            comboGTSUpdGroup.ValueMember = "Id";
            
            comboGTSUpdSubj.DataSource = updSubjects;
            comboGTSUpdSubj.DisplayMember = "Name";
            comboGTSUpdSubj.ValueMember = "Id";
            

            if (dataGridView1.CurrentRow != null)
            {
                int row = dataGridView1.CurrentRow.Index;
                int grId = Int32.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                int subId = Int32.Parse(dataGridView1.Rows[row].Cells[1].Value.ToString());

                var curGroup = (from s in context.Groups where s.Id == grId select s).FirstOrDefault();
                if (curGroup != null)
                {
                    comboGTSUpdGroup.SelectedItem = comboGTSUpdGroup.Items[comboGTSUpdGroup.Items.IndexOf(curGroup)];
                }
                var curSubj = (from s in context.Subjects where s.Id == grId select s).FirstOrDefault();
                if (curSubj != null)
                {
                    comboGTSUpdSubj.SelectedItem = comboGTSUpdSubj.Items[comboGTSUpdSubj.Items.IndexOf(curSubj)];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 870;
        }

        private void btnStudCreate_Click(object sender, EventArgs e)
        {
            int age;
            if(Int32.TryParse(txtAge.Text, out age))
            {
                int groupId = Int32.Parse(comboGroupId.SelectedValue.ToString());
                Student stud = new Student(txtName.Text, txtSurname.Text, age, groupId);
                StudentRepository stdRep = new StudentRepository(context);
                stdRep.InsertStudent(stud);
                stdRep.Save();
                btnStudents.PerformClick();
            }
        }

        private void btnStudUpdate_Click(object sender, EventArgs e)
        {
            int age;
            int row = dataGridView1.CurrentRow.Index;
            int id = Int32.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
            if (Int32.TryParse(txtUpdAge.Text, out age))
            {
                int groupId = Int32.Parse(comboUpdGroupId.SelectedValue.ToString());
                Student current = context.Students.FirstOrDefault(st => st.Id == id);
                current.FirstName = txtUpdName.Text;
                current.LastName = txtUpdSurname.Text;
                current.Age = age;
                current.GroupId = groupId;
                context.Entry(current).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                btnStudents.PerformClick();
            }
        }

        private void btnStudDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                StudentRepository stdRep = new StudentRepository(context);
                int id = Int32.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                stdRep.DeleteStudent(id);
                stdRep.Save();
                btnStudents.PerformClick();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            if (grBoxStudent.Visible)
            {
            txtUpdName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtUpdSurname.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtUpdAge.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            int grId = Int32.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());
            var groups = context.Groups.ToList();
            comboUpdGroupId.DataSource = groups;
            var current = (from s in context.Groups where s.Id == grId select s).FirstOrDefault();
            if (current != null)
            {
                comboUpdGroupId.SelectedItem = comboUpdGroupId.Items[comboUpdGroupId.Items.IndexOf(current)];
            }
            comboUpdGroupId.DisplayMember = "Name";
            comboUpdGroupId.ValueMember = "Id";
             }
            else if (grBoxGroup.Visible) 
            {
                txtUpdGroupName.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            }
            else if (grBoxSubject.Visible) 
            {
                txtUpdSubjName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            }/*
            else if (grBoxGTS.Visible) 
            {
                int grId = Int32.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                var groups = context.Groups.ToList();
                comboGTSUpdGroup.DataSource = groups;
                var curGr = (from s in context.Groups where s.Id == grId select s).FirstOrDefault();
                if (curGr != null)
                {
                    comboGTSUpdGroup.SelectedItem = comboGTSUpdGroup.Items[comboGTSUpdGroup.Items.IndexOf(curGr)];
                }
                comboGTSUpdGroup.DisplayMember = "Name";
                comboGTSUpdGroup.ValueMember = "Id";
                int subjId = Int32.Parse(dataGridView1.Rows[row].Cells[1].Value.ToString());
                var subjects = context.Groups.ToList();
                comboUpdGroupId.DataSource = groups;
                var curSubj = (from s in context.Subjects where s.Id == grId select s).FirstOrDefault();
                if (curSubj != null)
                {
                    comboGTSUpdSubj.SelectedItem = comboGTSUpdSubj.Items[comboGTSUpdSubj.Items.IndexOf(curSubj)];
                }
                comboGTSUpdSubj.DisplayMember = "Name";
                comboGTSUpdSubj.ValueMember = "Id";
            }*/
            
        }

        private void btnGroupCreate_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Name = txtGroupName.Text;
            context.Groups.Add(group);
            context.SaveChanges();
            btnGroups.PerformClick();
        }

        private void btnGroupDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                Group current = context.Groups.Find(id);
                context.Groups.Remove(current);
                context.SaveChanges();
                btnGroups.PerformClick();
            }
        }

        private void btnGroupUpdate_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            int id = Int32.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());

            Group current = context.Groups.FirstOrDefault(gr => gr.Id == id);
            current.Name = txtUpdGroupName.Text;
            context.Entry(current).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            btnGroups.PerformClick();
        }

        private void btnSubjCreate_Click(object sender, EventArgs e)
        {
            Subject group = new Subject();
            group.Name = txtSubj.Text;
            context.Subjects.Add(group);
            context.SaveChanges();
            btnSubjects.PerformClick();
        }

        private void btnSubjUpdate_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            int id = Int32.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());

            Subject current = context.Subjects.FirstOrDefault(sub => sub.Id == id);
            current.Name = txtUpdSubjName.Text;
            context.Entry(current).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            btnSubjects.PerformClick();
        }

        private void btnSubjDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                Subject current = context.Subjects.Find(id);
                context.Subjects.Remove(current);
                context.SaveChanges();
                btnSubjects.PerformClick();
            }
        }

        private void btnGTSCreate_Click(object sender, EventArgs e)
        {
            int groupId = Int32.Parse(comboGTSGroup.SelectedValue.ToString());
            int subjId = Int32.Parse(comboGTSSubj.SelectedValue.ToString());
            GroupToSubject gts = new GroupToSubject();
            gts.GroupId = groupId;
            gts.SubjectId = subjId;
            try
            {
                context.GroupsToSubjects.Add(gts);
                context.SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Row already exsists!");
            }
            btnGroupToSubject.PerformClick();

        }

        private void btnGTSUpdate_Click(object sender, EventArgs e)
        {/*
            int row = dataGridView1.CurrentRow.Index;
            int grId = Int32.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
            int subId = Int32.Parse(dataGridView1.Rows[row].Cells[1].Value.ToString());

            GroupToSubject current = context.GroupsToSubjects.FirstOrDefault(gts => gts.GroupId == grId && gts.SubjectId == subId);
            if (current != null)
            {
                context.GroupsToSubjects.Remove(current);                
            }
            current.GroupId = Int32.Parse(comboGTSUpdGroup.SelectedValue.ToString());
            current.SubjectId = Int32.Parse(comboGTSUpdSubj.SelectedValue.ToString());
            try
            {
                context.GroupsToSubjects.Add(current);
                //context.Entry(current).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception)
            {
                //MessageBox.Show("Row already exsists!");
            }
            btnGroupToSubject.PerformClick();
            */
        }

        private void btnGTSDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int grId = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                int subjId = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
                GroupToSubject current = context.GroupsToSubjects.Find(grId, subjId);
                context.GroupsToSubjects.Remove(current);
                context.SaveChanges();
                btnGroupToSubject.PerformClick();
            }

        }
    }
}
