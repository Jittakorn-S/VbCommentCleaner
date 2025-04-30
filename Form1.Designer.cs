namespace VbCommentCleanerWinApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCopy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.tableLayout.ColumnCount = 2;
            this.tableLayout.RowCount = 3;
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));

            this.tableLayout.Controls.Add(this.lblInput, 0, 0);
            this.tableLayout.Controls.Add(this.lblOutput, 1, 0);
            this.tableLayout.Controls.Add(this.txtInput, 0, 1);
            this.tableLayout.Controls.Add(this.txtOutput, 1, 1);
            this.tableLayout.Controls.Add(this.btnClean, 0, 2);
            this.tableLayout.Controls.Add(this.btnCopy, 1, 2);

            this.lblInput.Text = "Input VB.NET Code:";
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblOutput.Text = "Cleaned Code:";
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtInput.Multiline = true;
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Consolas", 10F);

            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtOutput.ReadOnly = true;

            this.btnClean.Text = "Clean Comments";
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);

            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);

            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayout);
            this.Text = "VB.NET Comment Cleaner";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}