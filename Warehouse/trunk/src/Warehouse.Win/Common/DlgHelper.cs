using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse.Win
{
    public class DlgHelper
    {
        public static void ShowAlertMsgBox(string msg, bool isAlarmSound = false)
        {
            if (isAlarmSound)
            {
				//AlarmSound();
            }
            //MessageBox.Show(msg, "提示");
            new MessageBoxCustomForm(msg).ShowDialog();
        }

        public static DialogResult ShowConfirmMsgBox(string msg, bool isAlarmSound = false)
        {
            if (isAlarmSound)
            {
                AlarmSound();
            }
            return MessageBox.Show(msg, "提示", MessageBoxButtons.YesNo);
        }

        public static void ShowSuccessBox(bool isAlarmSound = false)
        {
            if (isAlarmSound)
            {
                AlarmSound();
            }
            MessageBox.Show("操作成功", "提示");
        }

        public static void AlarmSound()
        {
            Console.Beep(5000, 1000);
        }

    }
}
