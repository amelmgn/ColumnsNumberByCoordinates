using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColumnsNumberByCoordinates
{
    public partial class OptionsForm : Form
    {
        //нужно создать публичную переменную для возврата значения поля формы
        public string markPref;
        public bool XthenY;

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Прирвниваем созданную переменную к значению поля tbPref
            markPref = tbPref.Text;

            XthenY = rbXthenY.Checked;
            
            //Срабатывание кнопки как команды "ОК". Для кнопки отмены будет DialogResult.Cancel
            this.DialogResult = DialogResult.OK;
            //Закрытие формы по нажатию кнопки ОК
            this.Close();
        }

        private void rbYthenX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbPref_TextChanged(object sender, EventArgs e)
        {

        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
