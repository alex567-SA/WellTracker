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

            // Цветовая палитра из ТЗ
            this.BackColor = ColorTranslator.FromHtml("#F8F9FA");
            this.ForeColor = ColorTranslator.FromHtml("#F44336"); // основной текст

            // Шрифт по умолчанию
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Запрет изменения размера (опционально)
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
