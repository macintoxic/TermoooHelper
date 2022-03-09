//Copyright (c) Charles Alves - Ceu System - Todos os direitos reservados.
using System.Text;
using Microsoft.Data.Sqlite;

namespace TermooHelper.UI
{
    public partial class frmMain : Form
    {
        private readonly SqliteConnection _conn = new("Data Source=palavras.db");

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _conn.Open();
        }

        private string BuildQuery()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" select * from palavras where");

            sb.Append(BuildLike());
            sb.Append(BuildContains());
            sb.Append(BuildNotContains());
            sb.AppendLine(" order by palavra");
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
            sb.AppendLine($"'");
            sb.AppendLine();
            return sb.ToString();
        }

        private string BuildContains()
        {
            var sb = new StringBuilder();

            foreach (var c in txtContains.Text)
            {
                sb.AppendLine($" and instr(palavra, '{c}' ) > 0");
            }

            return sb.ToString();
        }

        private string BuildNotContains()
        {
            var sb = new StringBuilder();
            foreach (var c in txtNotContain.Text)
            {
                sb.AppendLine($" and instr(palavra, '{c}' ) = 0");
            }

            return sb.ToString();
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F5) return;

            var comm = _conn.CreateCommand();
            comm.CommandText = BuildQuery();
            var reader = comm.ExecuteReader();

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
            frmMain_KeyUp(null, new KeyEventArgs(Keys.F5));
        }
    }
}