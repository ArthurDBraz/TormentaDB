using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TormentaDB
{
    public partial class ResultsForm : Form
    {
        private SqlDataReader queryResults;

        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(String htmlOfResults)
        {
            InitializeComponent();
            ResultsHTMLBox.DocumentText = htmlOfResults;
        }

        public ResultsForm(SqlDataReader results)
        {
            InitializeComponent();
            queryResults = results;
            ResultsHTMLBox.DocumentText = dataTableToHTML(queryResults);
        }

        private String dataTableToHTML(SqlDataReader reader)
        {
            String resultsHtml = "<html><body>";

            if (reader.HasRows) while (reader.Read())
                {
                    resultsHtml +=
                        // TODO Implement Show/Hide Button
                        "<p><font size=5>" + reader[0] + "</font></p>" + // Nome
                        "<p>" + ((!String.IsNullOrEmpty(reader[1].ToString())) ? "arcana " + reader[1] + " " : "") +
                        ((!String.IsNullOrEmpty(reader[2].ToString())) ? "divina " + reader[2] : "") + "<br>" +
                        reader[3] + "</p>" +
                        ((!String.IsNullOrEmpty(reader[4].ToString())) ? "<b>" + "Tempo de Execução:</b> " + reader[4] + "<br>" : "") +
                        ((!String.IsNullOrEmpty(reader[5].ToString())) ? "<b>" + "Alcance:</b> " + reader[5] + "<br>" : "") +
                        ((!String.IsNullOrEmpty(reader[6].ToString())) ? "<b>" + "Alvo:</b> " + reader[6] + "<br>" : "") +
                        ((!String.IsNullOrEmpty(reader[7].ToString())) ? "<b>" + "Área:</b> " + reader[7] + "<br>" : "") +
                        ((!String.IsNullOrEmpty(reader[8].ToString())) ? "<b>" + "Efeito:</b> " + reader[8] + "<br>" : "") +
                        ((!String.IsNullOrEmpty(reader[9].ToString())) ? "<b>" + "Duração:</b> " + reader[9] + "<br>" : "") +
                        ((!String.IsNullOrEmpty(reader[10].ToString())) ? "<b>" + "Teste de resistência:</b> " + reader[10] + "<br>" : "") +
                        reader[11];
                    resultsHtml += "<hr>";
                }

            resultsHtml += "</body></html>";

            return resultsHtml;
        }
    }
}
