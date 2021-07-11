using System;
using System.Text;
using System.Windows.Controls;

namespace TeleBarWdg
{
    public class MaskedTextBox : TextBox
    {
        public TextBoxMask Mask { get; set; }

        public MaskedTextBox()
        {
            TextChanged += new TextChangedEventHandler(MaskedTextBox_TextChanged);
        }

        void MaskedTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CaretIndex = Text.Length;

            var tbEntry = sender as MaskedTextBox;

            if (tbEntry != null && tbEntry.Text.Length > 0)
            {
                tbEntry.Text = formatNumber(tbEntry.Text, tbEntry.Mask);
            }
        }

        public static string formatNumber(string MaskedNum, TextBoxMask phoneFormat)
        {
            int x;
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            if (MaskedNum != null)
            {
                for (int i = 0; i < MaskedNum.Length; i++)
                {
                    if (int.TryParse(MaskedNum.Substring(i, 1), out x))
                    {
                        sb.Append(x.ToString());
                    }
                }
                switch (phoneFormat)
                {
                    //case TextBoxMask.Phone7Digit:
                    //    return FormatFor7DigitPhone(sb.ToString());

                    //case TextBoxMask.Phone7DigitWithExt:
                    //    return FormatFor7DigitPhoneWithExt(sb.ToString());

                    case TextBoxMask.Phone10Digit:
                        return FormatFor10DigitPhone(sb.ToString()).ToString();

                    //case TextBoxMask.Phone10DigitWithExt:
                    //    return FormatFor10DigitPhoneWithExt(sb.ToString());

                    case TextBoxMask.Phone11Digit:
                        return FormatFor11DigitPhone(sb.ToString()).ToString();

                    //case TextBoxMask.Phone11DigitWithExt:
                    //    return FormatFor11DigitPhoneWithExt(sb.ToString());

                    case TextBoxMask.SSN:
                        return FormatForSSN(sb.ToString()).ToString();

                    default:
                        break;
                }

            }
            return sb.ToString();
        }

        public static StringBuilder FormatFor10DigitPhone(string sb)
        {
            StringBuilder sb2 = new StringBuilder();

            if (sb.Length > 0) sb2.Append("(");

            if (sb.Length > 0) sb2.Append(sb.Substring(0, 1));
            if (sb.Length > 1) sb2.Append(sb.Substring(1, 1));
            if (sb.Length > 2) sb2.Append(sb.Substring(2, 1));

            if (sb.Length > 3) sb2.Append(") ");

            if (sb.Length > 3) sb2.Append(sb.Substring(3, 1));
            if (sb.Length > 4) sb2.Append(sb.Substring(4, 1));
            if (sb.Length > 5) sb2.Append(sb.Substring(5, 1));

            if (sb.Length > 6) sb2.Append("-");

            if (sb.Length > 6) sb2.Append(sb.Substring(6, 1));
            if (sb.Length > 7) sb2.Append(sb.Substring(7, 1));
            if (sb.Length > 8) sb2.Append(sb.Substring(8, 1));
            if (sb.Length > 9) sb2.Append(sb.Substring(9, 1));

            return sb2;
        }

        public static StringBuilder FormatFor11DigitPhone(string sb)
        {
            StringBuilder sb2 = new StringBuilder();

            if (sb.Length > 0) sb2.Append("(+");

            if (sb.Length > 0) sb2.Append(sb.Substring(0, 1));
            if (sb.Length > 1) sb2.Append(sb.Substring(1, 1));
            if (sb.Length > 2) sb2.Append(sb.Substring(2, 1));

            if (sb.Length > 2) sb2.Append(") ");

            if (sb.Length > 3) sb2.Append(sb.Substring(3, 1));
            if (sb.Length > 4) sb2.Append(sb.Substring(4, 1));

            if (sb.Length > 5) sb2.Append(" ");

            if (sb.Length > 5) sb2.Append(sb.Substring(5, 1));
            if (sb.Length > 6) sb2.Append(sb.Substring(6, 1));

            if (sb.Length > 7) sb2.Append("-");

            if (sb.Length > 7) sb2.Append(sb.Substring(7, 1));
            if (sb.Length > 8) sb2.Append(sb.Substring(8, 1));

            if (sb.Length > 9) sb2.Append("-");

            if (sb.Length > 9) sb2.Append(sb.Substring(9, 1));
            if (sb.Length > 10) sb2.Append(sb.Substring(10, 1));

            return sb2;
        }

        public static StringBuilder FormatForSSN(String sb)
        {
            StringBuilder sb2 = new StringBuilder();

            if (sb.Length > 0) sb2.Append(sb.Substring(0, 1));
            if (sb.Length > 1) sb2.Append(sb.Substring(1, 1));
            if (sb.Length > 2) sb2.Append(sb.Substring(2, 1));

            if (sb.Length > 3) sb2.Append("-");

            if (sb.Length > 3) sb2.Append(sb.Substring(3, 1));
            if (sb.Length > 4) sb2.Append(sb.Substring(4, 1));

            if (sb.Length > 5) sb2.Append("-");

            if (sb.Length > 5) sb2.Append(sb.Substring(5, 1));
            if (sb.Length > 6) sb2.Append(sb.Substring(6, 1));
            if (sb.Length > 7) sb2.Append(sb.Substring(7, 1));
            if (sb.Length > 8) sb2.Append(sb.Substring(8, 1));

            return sb2;
        }
    }

    public enum TextBoxMask
    {
        Phone7Digit,
        Phone7DigitWithExt,
        Phone10Digit,
        Phone10DigitWithExt,
        Phone11Digit,
        Phone11DigitWithExt,
        SSN
    }
}