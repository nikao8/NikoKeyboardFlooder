using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ProjetoFlooderKeyboard
{

    public partial class FormFlooder : Form
    {
        
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        protected override void WndProc(ref Message m)
        {

            // Desabilitadas na leitura de keys
            const int MYACTION_HOTKEY_ID_INSERT = 13;
            const int MYACTION_HOTKEY_ID_DELETE = 14;
            const int MYACTION_HOTKEY_ID_RETURN = 15;
            const int MYACTION_HOTKEY_ID_END = 16;
            const int MYACTION_HOTKEY_ID_F12 = 12;

            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_INSERT, 0, (int)Keys.Insert);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_DELETE, 0, (int)Keys.Delete);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_RETURN, 0, (int)Keys.Return);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_END, 0, (int)Keys.End);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F12, 0, (int)Keys.F12);
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID_RETURN);
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID_INSERT);
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID_DELETE);
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID_END);
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F12);

            // Habilitadas na leitura
            const int MYACTION_HOTKEY_ID_F1 = 1;
            const int MYACTION_HOTKEY_ID_F2 = 2;
            const int MYACTION_HOTKEY_ID_F3 = 3;
            const int MYACTION_HOTKEY_ID_F4 = 4;
            const int MYACTION_HOTKEY_ID_F5 = 5;
            const int MYACTION_HOTKEY_ID_F6 = 6;
            const int MYACTION_HOTKEY_ID_F7 = 7;
            const int MYACTION_HOTKEY_ID_F8 = 8;
            const int MYACTION_HOTKEY_ID_F9 = 9;
            const int MYACTION_HOTKEY_ID_F10 = 10;
            const int MYACTION_HOTKEY_ID_F11 = 11;
            
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F1, 0, (int)Keys.F1);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F2, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F3, 0, (int)Keys.F3);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F4, 0, (int)Keys.F4);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F5, 0, (int)Keys.F5);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F6, 0, (int)Keys.F6);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F7, 0, (int)Keys.F7);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F8, 0, (int)Keys.F8);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F9, 0, (int)Keys.F9);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F10, 0, (int)Keys.F10);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID_F11, 0, (int)Keys.F11);
            

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F1)
            {
                if(comboboxKey.Text == "F1" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");                  
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F2)
            {
                if (comboboxKey.Text == "F2" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F3)
            {
                if (comboboxKey.Text == "F3" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F4)
            {
                if (comboboxKey.Text == "F4" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F5)
            {
                if (comboboxKey.Text == "F5" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F6)
            {
                if (comboboxKey.Text == "F6" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F7)
            {
                if (comboboxKey.Text == "F7" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F8)
            {
                if (comboboxKey.Text == "F8" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F9)
            {
                if (comboboxKey.Text == "F9" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F10)
            {
                if (comboboxKey.Text == "F10" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID_F11)
            {
                if (comboboxKey.Text == "F11" && radioOn.Checked == true)
                {
                    SendKeys.Send(richTextBox1.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            base.WndProc(ref m);
        }

        public FormFlooder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por: github.com/nikao8\n\n\nDonate?, chave pix: nicolasmarquesjf@hotmail.com", "Suporte");
            radioOff.Checked = true;
        }
    }
}