using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealEnginePackageManager
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Control parent, bool isDark)
        {
            Color backMain = isDark ? Color.FromArgb(37, 37, 38) : Color.FromArgb(245, 245, 245);
            Color panelBack = isDark ? Color.FromArgb(30, 30, 30) : Color.White;
            Color textFore = isDark ? Color.FromArgb(241, 241, 241) : Color.FromArgb(30, 30, 30);
            Color inputBack = isDark ? Color.FromArgb(45, 45, 48) : Color.White;
            Color buttonBack = isDark ? Color.FromArgb(45, 45, 48) : Color.FromArgb(240, 240, 240);
            Color accent = isDark ? Color.FromArgb(0, 122, 204) : Color.FromArgb(0, 102, 184);
            Color border = isDark ? Color.FromArgb(60, 60, 60) : Color.FromArgb(180, 180, 180);

            parent.BackColor = backMain;
            parent.ForeColor = textFore;

            if (parent is Panel || parent is TableLayoutPanel || parent is FlowLayoutPanel ||
                parent is TabPage || parent is TabControl || parent is GroupBox)
            {
                parent.BackColor = panelBack;
            }

            if (parent is TextBox || parent is RichTextBox || parent is ComboBox)
            {
                parent.BackColor = inputBack;
            }

            if (parent is ButtonBase btn)
            {
                btn.UseVisualStyleBackColor = false;  // <--- forces our colors
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = buttonBack;
                btn.ForeColor = textFore;
                btn.FlatAppearance.BorderColor = border;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.MouseOverBackColor = accent;
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, accent);
            }

            if (parent is LinkLabel ll)
            {
                ll.LinkColor = accent;
                ll.ActiveLinkColor = accent;
            }

            if (parent is MenuStrip ms)
            {
                ms.BackColor = panelBack;
                ms.ForeColor = textFore;
            }

            foreach (Control child in parent.Controls)
            {
                ApplyTheme(child, isDark);
            }

            parent.Refresh();  // <--- forces visual update
        }

        internal static void InitializeTheme(Control target)
        {
            bool isDark = Properties.Settings.Default.AppTheme == "Dark";
            ThemeManager.ApplyTheme(target, isDark);
        }
    }
}
