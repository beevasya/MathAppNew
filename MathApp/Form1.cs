using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {
        List<OperationsEnum> _operations;
        public Form1()
        {
            InitializeComponent();
            _operations = OperationFactory.GetOperations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtError.Text = "";
                double param1 = string.IsNullOrEmpty(txtParam1.Text) ? 0 : Convert.ToDouble(txtParam1.Text);
                double param2 = string.IsNullOrEmpty(txtParam2.Text) ? 0 : Convert.ToDouble(txtParam2.Text);
                if (lstOperations.SelectedValue == null)
                    throw new Exception("Не выбрана операция");
                var oper = _operations.FirstOrDefault(p => p.Id == (int)lstOperations.SelectedValue);
                txtResult.Text = oper.Operation.Calc(param1, param2).ToString();
            }
            catch (Exception err)
            {
                txtError.Text = "Ошибка: " + err.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstOperations.DisplayMember = "Name";
            lstOperations.ValueMember = "Id";
            lstOperations.DataSource = _operations;

            lstOperations.SelectedItem = _operations.Count > 0 ? _operations[0] : null;
        }

        private void lstOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOperations.SelectedValue == null)
                return;
            var oper = _operations.FirstOrDefault(p => p.Id == (int)lstOperations.SelectedValue);
            txtDescription.Text = oper.Description;
        }
    }
}
