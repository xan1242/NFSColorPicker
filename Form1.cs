using System.Drawing;
using System.Globalization;

namespace NFSColorPicker
{
    public partial class Form1 : Form
    {
        uint gColor = 0;

        public Form1()
        {
            InitializeComponent();

            tbRGBHex.TextAcceptor = UInt32HexTextAcceptor;
            tbRGBHexSwap.TextAcceptor = UInt32HexTextAcceptor;
            tbRGBDecimal.TextAcceptor = UInt32TextAcceptor;
            tbRGBDecimalSwap.TextAcceptor = UInt32TextAcceptor;

            tbInputR.TextAcceptor = UInt8TextAcceptor;
            tbInputG.TextAcceptor = UInt8TextAcceptor;
            tbInputB.TextAcceptor = UInt8TextAcceptor;
            tbInputA.TextAcceptor = UInt8TextAcceptor;

            tbRGBHex.Text = gColor.ToString();
            tbRGBHexSwap.Text = gColor.ToString();
            tbRGBDecimal.Text = gColor.ToString();
            tbRGBDecimalSwap.Text = gColor.ToString();

            tbResultValue.Text = gColor.ToString();

            tbInputR.Text = gColor.ToString();
            tbInputG.Text = gColor.ToString();
            tbInputB.Text = gColor.ToString();
            tbInputA.Text = gColor.ToString();


            pbPreview.BackColor = Color.FromArgb((int)gColor);
        }

        void UpdateColors(uint color)
        {
            gColor = color;

            uint colorBS = (color & 0xFFFFFF) << 8;
            colorBS |= ((color & 0xFF000000) >> 24);

            tbRGBHex.Text = color.ToString("X8");
            tbRGBDecimal.Text = color.ToString();
            tbRGBHexSwap.Text = colorBS.ToString("X8");
            tbRGBDecimalSwap.Text = colorBS.ToString();
            tbResultValue.Text = tbRGBDecimalSwap.Text;

            tbInputR.Text = ((color & 0x00FF0000) >> 16).ToString();
            tbInputG.Text = ((color & 0x0000FF00) >> 8).ToString();
            tbInputB.Text = ((color & 0x000000FF)).ToString();
            tbInputA.Text = ((color & 0xFF000000) >> 24).ToString();

            pbPreview.BackColor = Color.FromArgb((int)gColor);
        }




        private bool UInt32HexTextAcceptor(string oldText, string newText, string input, int offset, int length)
        {
            uint value = 0;
            return UInt32.TryParse(newText, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value);
        }

        private bool UInt32TextAcceptor(string oldText, string newText, string input, int offset, int length)
        {
            uint value = 0;
            return UInt32.TryParse(newText, out value);
        }

        private bool UInt8TextAcceptor(string oldText, string newText, string input, int offset, int length)
        {
            byte value = 0;
            return byte.TryParse(newText, out value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.FromArgb((int)gColor);

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                uint color = (uint)(colorDialog1.Color.ToArgb());
                UpdateColors(color);
            }
        }

        private void tbInputR_Validated(object sender, EventArgs e)
        {
            uint color = gColor;
            uint inColorInt2 = uint.Parse(tbInputR.Text) & 0xFF;
            byte inColor = (byte)inColorInt2;

            uint inColorInt = (uint)inColor;
            inColorInt <<= 16;

            uint newColor = (color & 0xFF00FFFF) | inColorInt;
            UpdateColors(newColor);
        }

        private void tbInputG_Validated(object sender, EventArgs e)
        {
            uint color = gColor;
            uint inColorInt2 = uint.Parse(tbInputG.Text) & 0xFF;
            byte inColor = (byte)inColorInt2;

            uint inColorInt = (uint)inColor;
            inColorInt <<= 8;

            uint newColor = (color & 0xFFFF00FF) | inColorInt;
            UpdateColors(newColor);
        }

        private void tbInputB_Validated(object sender, EventArgs e)
        {
            uint color = gColor;
            uint inColorInt2 = uint.Parse(tbInputB.Text) & 0xFF;
            byte inColor = (byte)inColorInt2;

            uint inColorInt = (uint)inColor;

            uint newColor = (color & 0xFFFFFF00) | inColorInt;
            UpdateColors(newColor);
        }

        private void tbInputA_Validated(object sender, EventArgs e)
        {
            uint color = gColor;
            uint inColorInt2 = uint.Parse(tbInputA.Text) & 0xFF;
            byte inColor = (byte)inColorInt2;

            uint inColorInt = (uint)inColor;
            inColorInt <<= 24;

            uint newColor = (color & 0xFFFFFF) | inColorInt;
            UpdateColors(newColor);
        }

        private void tbRGBHex_Validated(object sender, EventArgs e)
        {
            uint inColor = uint.Parse(tbRGBHex.Text, NumberStyles.HexNumber);
            UpdateColors(inColor);
        }

        private void tbRGBDecimal_Validated(object sender, EventArgs e)
        {
            uint inColor = uint.Parse(tbRGBDecimal.Text);
            UpdateColors(inColor);
        }

        private void tbRGBHexSwap_Validated(object sender, EventArgs e)
        {
            uint inColor = uint.Parse(tbRGBHexSwap.Text, NumberStyles.HexNumber);
            uint colorBS = (inColor & 0xFFFFFF00) >> 8;
            colorBS |= ((inColor & 0xFF) << 24);

            UpdateColors(colorBS);
        }

        private void tbRGBDecimalSwap_Validated(object sender, EventArgs e)
        {
            uint inColor = uint.Parse(tbRGBDecimalSwap.Text);
            uint colorBS = (inColor & 0xFFFFFF00) >> 8;
            colorBS |= ((inColor & 0xFF) << 24);

            UpdateColors(colorBS);
        }
    }
}