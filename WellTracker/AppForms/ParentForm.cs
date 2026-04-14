using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WellTracker.AppForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();

            this.Size = new Size(900, 600);
            this.MinimumSize = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Цветовая палитра 
            this.BackColor = ColorTranslator.FromHtml("#F8F9FA");
            this.ForeColor = ColorTranslator.FromHtml("#F44336"); // основной текст

            // Шрифт по умолчанию
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Запрет изменения размера (опционально)
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyTheme(this);
        }

        private void ApplyTheme(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#2E86AB");
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                }
                else if (c is Label lbl && !lbl.Name.StartsWith("lblHeader"))
                {
                    lbl.ForeColor = ColorTranslator.FromHtml("#F44336");
                }
            }
        }
    }
}
