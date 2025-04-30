using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace VbCommentCleanerWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            string code = txtInput.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please paste VB.NET code to clean.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tree = VisualBasicSyntaxTree.ParseText(code);
            var root = tree.GetRoot();
            var cleanedRoot = root.ReplaceTrivia(
                root.DescendantTrivia(),
                (trivia, _) =>
                    trivia.IsKind(SyntaxKind.CommentTrivia) ||
                    trivia.IsKind(SyntaxKind.DocumentationCommentTrivia)
                    ? default
                    : trivia
            );
            string result = cleanedRoot.ToFullString();
            var lines = result.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var nonEmpty = lines.Where(l => !string.IsNullOrWhiteSpace(l));
            txtOutput.Text = string.Join(Environment.NewLine, nonEmpty);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
                Clipboard.SetText(txtOutput.Text);
        }
    }
}