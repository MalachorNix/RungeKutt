using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabProject.RungeKutt;
using System.Data.SqlClient;

namespace RungeKutt
{
    public partial class RungeKutt_Methods : Form
    {
        private RungeKuttMethod rungeKutt;
        private double x0;
        private double y0;

        public RungeKutt_Methods()
        {
            InitializeComponent();
            rungeKutt = RungeKuttMethodInstance.Instance;
        }

        private void rungeKuttDatabaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rungeKuttDatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRungeKutt);

            databaseRungeKutt.RungeKuttDatabase.AcceptChanges();

        }

        private void RungeKutt_Metods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseRungeKutt.RungeKuttDatabase". При необходимости она может быть перемещена или удалена.
            this.rungeKuttDatabaseTableAdapter.Fill(this.databaseRungeKutt.RungeKuttDatabase);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x0 = Convert.ToDouble(xOTextBox.Text);
            y0 = Convert.ToDouble(yOtextBox.Text);
            rungeKutt.xO = x0;
            rungeKutt.yO = y0;

            rungeKutt.RungeKuttThird();

            double[] solution = rungeKutt.Solution;


            
            this.rungeKuttDatabaseTableAdapter.Insert(3, x0, y0, solution[0], solution[1], solution[2], solution[3]);
            rungeKuttDatabaseTableAdapter.Fill(databaseRungeKutt.RungeKuttDatabase);
            databaseRungeKutt.RungeKuttDatabase.AcceptChanges();
            //this.tableAdapterManager.UpdateAll(this.databaseRungeKutt);
            //this.rungeKuttDatabaseTableAdapter.Update(this.databaseRungeKutt.RungeKuttDatabase);
            
            //this.Validate();
            //this.rungeKuttDatabaseBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.databaseRungeKutt);


        }

        private void yOLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rungeKuttDatabaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
