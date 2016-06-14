using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TormentaDB
{
    class DBHelper
    {
        //private SpellsDBDataSetTableAdapters.ManualBasTableAdapter tableTableAdapter;
        //private SpellsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private const string CONNECTION_STRING = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\SpellsDB.mdf;Integrated Security=True";

        public DBHelper()
        {
            //// tableTableAdapter
            //this.tableTableAdapter = new TormentaDB.SpellsDBDataSetTableAdapters.ManualBasTableAdapter();
            //this.tableTableAdapter.ClearBeforeFill = true;
            //// tableAdapterManager
            //this.tableAdapterManager = new TormentaDB.SpellsDBDataSetTableAdapters.TableAdapterManager();
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.ManualBasTableAdapter = this.tableTableAdapter;
            //this.tableAdapterManager.UpdateOrder = TormentaDB.SpellsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
        }

        public void QueryAndShow(String name, short levelMin, short levelMax, bool isDivine, bool isArcane, List<String> SelectedSchools)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand command = new SqlCommand(createQuery(name,
                levelMin, levelMax,
                isDivine, isArcane,
                SelectedSchools),
                con);
            command.CommandType = global::System.Data.CommandType.Text;
            command.Connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                    (new ResultsForm(reader)).Show();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro de SQL",e.ErrorCode.ToString());
            }
            command.Connection.Close();
        }

        public String createQuery(String name, short levelMin, short levelMax, bool isDivine, bool isArcane, List<String> SelectedSchools)
        {
            String whereClause = "WHERE ";

            if (name != "")
                whereClause += "Name LIKE " + "'%" + name + "%' AND ";

            //****** Level range check *********
            whereClause += '(';

            if (isArcane)
                whereClause += "[Arcane Level] >= " + levelMin + " AND [Arcane Level] <= " + levelMax;

            if (isArcane && isDivine)
                whereClause += " OR ";

            if (isDivine)
                whereClause += "[Divine Level] >= " + levelMin + " AND [Divine Level] <= " + levelMax;

            whereClause += ')';

            //******* Selected schools check ********
            if (SelectedSchools.Count > 0)
                if (SelectedSchools.Count == 1)
                    whereClause += " AND School LIKE '%" + SelectedSchools[0] + "%'";
                else
                {
                    whereClause += " AND (School LIKE '%" + SelectedSchools[0] + "%'";
                    for (int i = 1; i < SelectedSchools.Count; i++)
                        whereClause += " OR School LIKE '%" + SelectedSchools[i] + "%'";
                    whereClause += ')';
                }
            //******* Sources select *******
            String query = '(' + "SELECT * FROM [ManualBas] " + whereClause + ')' +
                " UNION ALL (SELECT * FROM [ManualDev] " + whereClause + ')' +
                " UNION ALL (SELECT * FROM [ManualAr] " + whereClause + ')';

            //******* Order *******
            if (isArcane && !isDivine)
                query += " ORDER BY [Arcane Level]";
            else if (!isArcane && isDivine)
                query += " ORDER BY [Divine Level]";

            return query;
        }
    }
}
