using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkhaLime.Utilities.Winforms
{
    class LogRichTextBox : RichTextBox
    {
        private Color _informationColor;
        private Color _successColor;
        private Color _warningColor;
        private Color _errorColor;

        public Color InformationColor
        {
            get => _informationColor;
            set
            {
                CheckColor(value, nameof(InformationColor));
                _informationColor = value;
            }
        }

        public Color SuccessColor
        {
            get => _successColor;
            set
            {
                CheckColor(value, nameof(SuccessColor));
                _successColor = value;
            }
        }

        public Color WarningColor
        {
            get => _warningColor;
            set
            {
                CheckColor(value, nameof(WarningColor));
                _warningColor = value;
            }
        }

        public Color ErrorColor
        {
            get => _errorColor;
            set
            {
                CheckColor(value, nameof(ErrorColor));
                _errorColor = value;
            }
        }


        public LogRichTextBox() : base()
        {
            InformationColor = Color.Black;
            SuccessColor = Color.Green;
            WarningColor = Color.Orange;
            ErrorColor = Color.Red;
        }

        public void AppendText(string text, Color color, bool addNewLine = false)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }

            SuspendLayout();
            SelectionStart = TextLength;
            SelectionLength = 0;

            SelectionColor = color;
            AppendText(text);
            SelectionColor = ForeColor;
            ResumeLayout();
        }

        public void AppendInformationText(string text, bool addNewLine = false)
        {
            AppendText(text, InformationColor, addNewLine);
        }

        public void AppendSuccessText(string text, bool addNewLine = false)
        {
            AppendText(text, SuccessColor, addNewLine);
        }

        public void AppendWarningText(string text, bool addNewLine = false)
        {
            AppendText(text, WarningColor, addNewLine);
        }

        public void AppendErrorText(string text, bool addNewLine = false)
        {
            AppendText(text, ErrorColor, addNewLine);
        }

        private void CheckColor(Color color, string paramName)
        {
            if (color == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

    }
}
