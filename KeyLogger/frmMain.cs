using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace GIGHook
{
    public partial class FrmMain : Form
    {

        private UserActivityHook _hooker;
        public FrmMain()
        {
            InitializeComponent();
         
        }
       private void ButtonStartClick(object sender, EventArgs e)
        {
            if (!_hooker.IsActive)
                _hooker.Start(false,true);

        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            if (_hooker.IsActive)
                _hooker.Stop();
              
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            _hooker = new UserActivityHook(false,true);
            _hooker.KeyDown += HookerKeyDown;
            _hooker.KeyPress += HookerKeyPress;
            _hooker.KeyUp += HookerKeyUp;
            _hooker.Stop();
        }
        public void MouseMoved(object sender, MouseEventArgs e)
        {
            //labelMousePosition.Text = String.Format("X:{0},Y={1},Wheel:{2}", e.X, e.Y, e.Delta);
            //if (e.Clicks <= 0) return;
            //txt_MouseLog.AppendText("MouseButton:" + e.Button);
            //txt_MouseLog.AppendText(Environment.NewLine);
        }

        public void HookerKeyDown(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyData.ToString();
            //if (e.KeyData.ToString() == "Return")
            //    Logger("[Enter]");
            //if (e.KeyData.ToString() == "Escape")
            //    Logger("[Escape]");
            ////Logger(e.KeyData + Environment.NewLine);
            //switch (e.KeyData.ToString())
            //{
            //    case "RMenu":
            //    case "LMenu":
            //        _isAltDown = true;
            //        break;
            //    case "RControlKey":
            //    case "LControlKey":
            //        _isControlDown = true;
            //        break;
            //    case "LShiftKey":
            //    case "RShiftKey":
            //        _isShiftDown = true;
            //        break;
            //    case "F10":
            //    case "F11":
            //    case "F12":
            //        _isFsDown = true;
            //        break;
            //}

            //if (_isAltDown && _isControlDown && _isShiftDown && _isFsDown)
            //    if (_isHide)
            //    {
            //        Show();
            //        _isHide = false;
            //    }
            //    else
            //    {
            //        Hide();
            //        _isHide = true;
            //    }
        }

        public void HookerKeyPress(object sender, KeyPressEventArgs e)
        {
            //_allowtoTik = true;
            //if ((byte) e.KeyChar == 9)
            //    Logger("[TAB]");
            //else if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            //    Logger(e.KeyChar.ToString());
            //else if (e.KeyChar == 32)
            //    Logger(" ");
            //else if (e.KeyChar != 27 && e.KeyChar != 13) //Escape
            //    Logger("[Char\\" + ((byte) e.KeyChar) + "]");

            //_tik = 0;
        }

        public void HookerKeyUp(object sender, KeyEventArgs e)
        {
            ////Logger("KeyUP : " + e.KeyData.ToString() + Environment.NewLine);
            //switch (e.KeyData.ToString())
            //{
            //    case "RMenu":
            //    case "LMenu":
            //        _isAltDown = false;
            //        break;
            //    case "RControlKey":
            //    case "LControlKey":
            //        _isControlDown = false;
            //        break;
            //    case "LShiftKey":
            //    case "RShiftKey":
            //        _isShiftDown = false;
            //        break;
            //    case "F10":
            //    case "F11":
            //    case "F12":
            //        _isFsDown = false;
            //        break;
            //}
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

    
    }
}