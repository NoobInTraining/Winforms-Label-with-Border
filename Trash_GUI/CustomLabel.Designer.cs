using System.Windows.Forms;
using System.Drawing;

namespace TrashGUI
{
    partial class CustomLabel
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //System.Console.WriteLine(Left);
            //System.Console.WriteLine(Top);
            //System.Console.WriteLine(Width);
            //System.Console.WriteLine(Height);
            //draw upper 
            //e.Graphics.DrawLine(Pens.Black, Left, Top, Left + Width, Top);
            //draw lower
            //e.Graphics.DrawLine(Pens.Black, Left, Top, Left + Width, Top);
            /*
              A  ___________  B
                |           |
                |           |
              C |___________| D
             */

            Point A = new Point(Left, Top);
            Point B = new Point(Left + Width, Top);
            Point C = new Point(Left, Top + Width);
            Point D = new Point(Left + Width, Top + Height);


            Color borderColour = Color.Black;
            int borderThickness = 1;

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                    borderColour, borderThickness, ButtonBorderStyle.Solid,
                                    borderColour, borderThickness, ButtonBorderStyle.Solid,
                                    borderColour, borderThickness, ButtonBorderStyle.Solid,
                                    borderColour, borderThickness, ButtonBorderStyle.Solid);


        }

        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion
    }
}
