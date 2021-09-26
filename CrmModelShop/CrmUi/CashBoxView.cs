using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    class CashBoxView
    {
        CashDesk cashDesk;
        public Label Label { get; set; }
        public NumericUpDown NumericUpDown { get; set; }
        public ProgressBar ProgressBar { get; set;}
        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
            Label = new Label();
            NumericUpDown = new NumericUpDown();
            ProgressBar = new ProgressBar();

            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, y);
            Label.Name = "label" + number;
            Label.Size = new System.Drawing.Size(35, 13);
            Label.TabIndex = number;
            Label.Text = cashDesk.ToString();

            // 
            // numericUpDown1 // это просто кусок кода из InitializeComponent(); 
            //                   там где создаются штуки на самой форме
            // 
            NumericUpDown.Location = new System.Drawing.Point(x + 70, y);
            NumericUpDown.Name = "numericUpDown" + number;
            NumericUpDown.Size = new System.Drawing.Size(120, 20);
            NumericUpDown.TabIndex = number;
            NumericUpDown.Maximum = 10000000000;

            // 
            // progressBar1
            // 
            ProgressBar.Location = new System.Drawing.Point(59, 59);
            ProgressBar.Maximum = 10;
            ProgressBar.Name = "progressBar1";
            ProgressBar.Size = new System.Drawing.Size(100, 23); // тута стоп
            ProgressBar.TabIndex = 1;
            ProgressBar.Value = 1;

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            //NumericUpDown.Value += e.Price; если сделать так, вылетает эксепшен:
            // попытка доступа к элементу управления '' не из того потока
            NumericUpDown.Invoke((Action)delegate { NumericUpDown.Value += e.Price; }); // вот такую конструкцию используешь и будет четко
            // по сути она перекидывает выполнение действия из асинхронного потока в основной и оно обновляется
            // чтобы не вылетал еще один эксепшен при закрытии окна, в свойстве(FormClosing) добавить model.Stop();

        }
    }
}
