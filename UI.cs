using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TormentaDB
{
    public partial class UI : Form
    {
        private DBHelper dbHelper;

        public UI()
        {
            dbHelper = new DBHelper();
            InitializeComponent();
        }

        private delegate int test(int x, int y);

        private void UI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spellsDBDataSet.Table' table. You can move, or remove it, as needed.
            schoolCheckBoxList = new List<CheckBox>();
            schoolCheckBoxList.Add(this.abjurationCheckBox);
            schoolCheckBoxList.Add(this.divinationCheckBox);
            schoolCheckBoxList.Add(this.enchantmentCheckBox);
            schoolCheckBoxList.Add(this.illusionCheckBox);
            schoolCheckBoxList.Add(this.transmutationCheckBox);
            schoolCheckBoxList.Add(this.healCheckBox);
            schoolCheckBoxList.Add(this.necromancyCheckBox);
            schoolCheckBoxList.Add(this.conjurationCheckBox);
            schoolCheckBoxList.Add(this.fireCheckBox);
            schoolCheckBoxList.Add(this.waterCheckBox);
            schoolCheckBoxList.Add(this.airCheckBox);
            schoolCheckBoxList.Add(this.earthcheckBox);
            schoolCheckBoxList.Add(this.electricityCheckBox);
            schoolCheckBoxList.Add(this.coldCheckBox);
            schoolCheckBoxList.Add(this.acidCheckBox);
            //this.tableTableAdapter.Fill(this.spellsDBDataSet.Table);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.levelRangeMinNumUpDown.Value > this.levelRangeMaxNumUpDown.Value)
            {
                MessageBox.Show("O nível mínimo deve ser menor que o nível máximo");
                return;
            }

            if (!(this.arcaneCheckBox.Checked || this.divineCheckBox.Checked))
            {
                MessageBox.Show("Selecione pelo menos um tipo de magia");
                return;
            }

            List<String> SelectedSchools = new List<String>();
            foreach (CheckBox schoolCheckBox in schoolCheckBoxList)
                if (schoolCheckBox.Checked)
                    SelectedSchools.Add(schoolCheckBox.Text);

            dbHelper.QueryAndShow(nameTextBox.Text,
                (short)levelRangeMinNumUpDown.Value, (short)levelRangeMaxNumUpDown.Value,
                divineCheckBox.Checked, arcaneCheckBox.Checked,
                SelectedSchools);
        }
    }
}
