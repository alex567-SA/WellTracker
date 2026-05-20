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
        // Цветовая палитра
        protected readonly Color PrimaryColor = ColorTranslator.FromHtml("#E53935");
        protected readonly Color SecondaryColor = ColorTranslator.FromHtml("#1E88E5");
        protected readonly Color BackgroundColor = ColorTranslator.FromHtml("#FAFAFA");
        protected readonly Color TextSecondary = ColorTranslator.FromHtml("#78909C");

        public ParentForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1200, 800);

            this.BackColor = BackgroundColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplySimpleTheme(this);
        }

        // ✅ ПРОСТАЯ стилизация - только цвета и шрифты, БЕЗ изменения размеров
        private void ApplySimpleTheme(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // Label
                if (c is Label lbl)
                {
                    if (lbl.Name.Contains("Header") || lbl.Name.Contains("Title"))
                    {
                        lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
                        lbl.ForeColor = PrimaryColor;
                    }
                    else if (lbl.Name.Contains("Greeting"))
                    {
                        lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                        lbl.ForeColor = SecondaryColor;
                    }
                    else
                    {
                        lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                        lbl.ForeColor = TextSecondary;
                    }
                }

                // Button - только цвета, БЕЗ изменения размеров и padding
                else if (c is Button btn)
                {
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;

                    // Красные кнопки (Сохранить, Выбрать)
                    if (btn.Text.Contains("Сохранить") || btn.Text.Contains("Выбрать") ||
                        btn.Text.Contains("Добавить") || btn.Text.Contains("Зарегистрироваться"))
                    {
                        btn.BackColor = PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;

                        btn.MouseEnter += (s, e) => btn.BackColor = ColorTranslator.FromHtml("#C62828");
                        btn.MouseLeave += (s, e) => btn.BackColor = PrimaryColor;
                    }
                    // Синие кнопки (Отмена, Закрыть)
                    else if (btn.Text.Contains("Отмена") || btn.Text.Contains("Закрыть") ||
                             btn.Text.Contains("Отменить"))
                    {
                        btn.BackColor = SecondaryColor;
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;

                        btn.MouseEnter += (s, e) => btn.BackColor = ColorTranslator.FromHtml("#1565C0");
                        btn.MouseLeave += (s, e) => btn.BackColor = SecondaryColor;
                    }
                    // Кнопки-плитки на Dashboard
                    else if (btn.Dock == DockStyle.Fill)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = PrimaryColor;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#E0E0E0");
                        btn.FlatAppearance.BorderSize = 2;

                        btn.MouseEnter += (s, e) => {
                            btn.BackColor = ColorTranslator.FromHtml("#FFF3E0");
                            btn.FlatAppearance.BorderColor = PrimaryColor;
                        };
                        btn.MouseLeave += (s, e) => {
                            btn.BackColor = Color.White;
                            btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#E0E0E0");
                        };
                    }
                }

                // TextBox
                else if (c is TextBox txt)
                {
                    txt.Font = new Font("Segoe UI", 10F);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }

                // ComboBox - БЕЗ кастомной отрисовки, чтобы не ломать DataSource
                else if (c is ComboBox cmb)
                {
                    cmb.Font = new Font("Segoe UI", 10F);
                    cmb.FlatStyle = FlatStyle.Standard;
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                // NumericUpDown
                else if (c is NumericUpDown num)
                {
                    num.Font = new Font("Segoe UI", 10F);
                    num.TextAlign = HorizontalAlignment.Center;
                }

                // DataGridView - БЕЗ изменения AutoSizeColumnsMode
                else if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = SecondaryColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 35;
                    dgv.GridColor = ColorTranslator.FromHtml("#E0E0E0");
                    dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FFCCBC");
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dgv.RowHeadersVisible = false;
                    dgv.AllowUserToAddRows = false;
                    dgv.AllowUserToDeleteRows = false;
                }

                // Panel/TableLayoutPanel - БЕЗ изменения Padding!
                else if (c is Panel panel)
                {
                    panel.BackColor = Color.White;
                }
                else if (c is TableLayoutPanel tlp)
                {
                    tlp.BackColor = Color.White;
                    // НЕ МЕНЯЕМ Padding - это ломает вёрстку!
                }

                // ListBox
                else if (c is ListBox lb)
                {
                    lb.Font = new Font("Segoe UI", 10F);
                    lb.BorderStyle = BorderStyle.FixedSingle;
                }

                // Рекурсивно применяем к вложенным контролам
                if (c.Controls.Count > 0)
                {
                    ApplySimpleTheme(c);
                }
            }
        }
    }
}