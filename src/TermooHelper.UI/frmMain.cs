//Copyright (c) Charles Alves - Ceu System - Todos os direitos reservados.

using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;

namespace TermooHelper.UI
{
    public partial class frmMain : Form
    {
        //private readonly SqliteConnection _conn = new("Data Source=palavras.db");

        //private SqlConnection sqlConnection = new SqlConnection(
        //    @"Data Source=localhost\SQLEXPRESS;Integrated Security=True;Database=termoo");

        //private SqlConnection sqlLocalConnection = new SqlConnection(
        //    @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Palavras.mdf;Integrated Security=True");


        SqlConnection localSqlconn;

        public frmMain()
        {
            InitializeComponent();

            var dbpath = Path.Combine(Environment.CurrentDirectory, "Palavras.mdf");
            var connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbpath + ";Integrated Security=True";
            localSqlconn = new SqlConnection(connection);
            localSqlconn.Open();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //sqlConnection.Open();

            //_conn.Open();

        }

        private string BuildQuery()
        {
            /*
                    SELECT * FROM palavras2 
                    WHERE len(palavra) = 5
                    AND palavra LIKE '_____' COLLATE Latin1_General_CI_Ai
                    AND palavra LIKE '[^_]____' COLLATE Latin1_General_CI_Ai
                    AND palavra LIKE '%[]%' COLLATE Latin1_General_CI_Ai
                    AND palavra NOT LIKE '%[]%' COLLATE Latin1_General_CI_Ai
                    ORDER BY palavra
             */

            var templateQuery = @"                    SELECT * FROM palavras2 
                    WHERE len(palavra) = 5
                    AND palavra LIKE '_____' COLLATE Latin1_General_CI_Ai
                    AND palavra LIKE '[^_]____' COLLATE Latin1_General_CI_Ai
                    AND palavra LIKE '%[]%' COLLATE Latin1_General_CI_Ai
                    AND palavra NOT LIKE '%[]%' COLLATE Latin1_General_CI_Ai
                    ORDER BY palavra;
";


            var sb = new StringBuilder();
            sb.AppendLine(" select palavra from palavras where");
            sb.AppendLine(BuildLike());
            sb.AppendLine(BuildContains());
            sb.AppendLine(BuildWrongPosition());
            sb.AppendLine(BuildNotContains());
            sb.AppendLine(" order by palavra");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private string BuildWrongPosition()
        {
            var sb = new StringBuilder();
            sb.Append($" and palavra like '");
            foreach (TextBox txtLetter in pnlWrong.Controls)
            {
                var l = string.IsNullOrWhiteSpace(txtLetter.Text) ? "_" : $"[^{ txtLetter.Text}]";
                sb.Append($"{ l }");
            }
            sb.AppendLine($"' COLLATE Latin1_General_CI_Ai ");
            sb.AppendLine();
            return sb.ToString();
        }


        private string BuildLike()
        {
            var sb = new StringBuilder();
            sb.Append($" palavra like '");
            foreach (TextBox txtLetter in pnlLetters.Controls)
            {
                var l = string.IsNullOrWhiteSpace(txtLetter.Text) ? "_" : txtLetter.Text;
                sb.Append($"{ l }");
            }
            sb.AppendLine($"' COLLATE Latin1_General_CI_Ai ");
            sb.AppendLine();
            return sb.ToString();
        }

        private string BuildContains()
        {
            var sb = new StringBuilder();
            sb.Append($" and palavra like '%[");
            foreach (var c in txtContains.Text)
            {
                sb.Append($"{ c }");
            }
            sb.AppendLine("]%' COLLATE Latin1_General_CI_Ai ");
            sb.AppendLine();
            return sb.ToString();
        }

        private string BuildNotContains()
        {
            var sb = new StringBuilder();
            sb.Append($" and palavra not like '%[");
            foreach (var c in txtNotContain.Text)
            {
                sb.Append($"{ c }");
            }
            sb.AppendLine("]%' COLLATE Latin1_General_CI_Ai ");
            sb.AppendLine();
            return sb.ToString();
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F5) return;

            var comm = localSqlconn.CreateCommand();
            comm.CommandText = BuildQuery();
            
            using var reader = comm.ExecuteReader();

            dgWords.Rows.Clear();

            while (reader.Read())
            {
                dgWords.Rows.Add(reader.GetValue(0));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtLetter in pnlLetters.Controls)
            {
                txtLetter.Text = "";
            }

            txtContains.Text = "";
            txtNotContain.Text = "";
            dgWords.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMain_KeyUp(null!, new KeyEventArgs(Keys.F5));
        }


    }
}