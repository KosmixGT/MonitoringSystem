using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace MonitoringSystem
{
    public partial class labelAndComboBox : UserControl
    {
        DataBase dataBase = new DataBase();
        public string zapros;
        public DataTable OPF;
        
        public labelAndComboBox()
        {
            InitializeComponent();
        }
        
        public string text
        {
            get
            {
                return label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }
        public string Zapros //для каждого комбобокса будет поле с запросом из БД, чтобы можно было заполнять его элементами
        {
            get
            {
                return zapros;
            }
            set
            {
                this.zapros = value;
            }
        }
        public void SelecteIndex(int ind)
        {
            this.comboBox1.SelectedIndex = ind;
        }
        public int GetSelectedIndex()
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                return comboBox1.SelectedIndex;
            }
            else
            {
                return -1;
            }
        }
        public void GetElementsForComboBox() //получить элементы для комбобокса из справочника БД
        {
            if (zapros.Length > 5)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand(zapros, dataBase.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                OPF = table;
                foreach (DataRow item in table.Rows)
                {
                    this.comboBox1.Items.Add(item.ItemArray[0]);
                }

                this.comboBox1.SelectedItem = 0;

                SetWidthDropDownComboBox();
            }
        }
        private void SetWidthDropDownComboBox() //установка ширины для выпадающего списка комбобокса
        {
            var senderComboBox = (ComboBox)comboBox1;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }
    }
}
