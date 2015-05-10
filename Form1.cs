using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        private Employee 員工;
        private Salary 陳秉瑤;
        private int TotalSalary;

        public Form1()
        {
            InitializeComponent();
            陳秉瑤 = new Salary();
            員工 = new Employee();
        }

        private void setSalaryButton1_Click(object sender, EventArgs e)
        {
            int _basesalary = int.Parse(SalaryTextBox1.Text);
            int _benefit = int.Parse(BenefitTextBox1.Text);
            陳秉瑤.基本薪資 = _basesalary;
            陳秉瑤.獎金 = _benefit;
            this.TotalSalary = 陳秉瑤.基本薪資 + 陳秉瑤.獎金;
            MessageBox.Show(NameTextBox.Text + "\r" + IDTextBox.Text + "\r" + "TotalSalary:" +TotalSalary.ToString());
        }

        private void setSalaryButton2_Click(object sender, EventArgs e)
        {
            int _basesalary = int.Parse(SalaryTextBox1.Text);
            int _benefit = int.Parse(BenefitTextBox1.Text);
            陳秉瑤.基本薪資 = _basesalary;
            陳秉瑤.獎金 = _benefit;
            TotalSalary = 陳秉瑤.基本薪資 + 陳秉瑤.獎金;
            員工.姓名 = NameTextBox.Text;
            員工.工號 = IDTextBox.Text;
            MessageBox.Show(員工.姓名 + "\r" + 員工.工號 + "\r" + "TotalSalary:" + TotalSalary.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
