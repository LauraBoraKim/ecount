using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //함수 : object sender, EventArgs e
        //button1_Click 함수는 eventHandler 델리게이트를 통해서  자동등록
        //click 사건이 발생하면 button1_Click 자동 호출
        //Delegate  EventHandler (object sender, EventArgs e)

        // object sender, EventArgs e
        private void button1_Click(object sender, EventArgs e)
        {
            //개발 .... 함수만 구현
            MessageBox.Show("이벤트 동작");
        }
    }
}
