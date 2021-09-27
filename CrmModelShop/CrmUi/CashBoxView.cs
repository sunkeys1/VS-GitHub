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
        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLength { get; set;}
        public Label LeaveCustomersCount { get; set; }
        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
            CashDeskName = new Label();
            Price = new NumericUpDown();
            QueueLength = new ProgressBar();
            LeaveCustomersCount = new Label();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = "label" + number;
            CashDeskName.Size = new System.Drawing.Size(35, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();

            // 
            // numericUpDown1 // это просто кусок кода из InitializeComponent(); 
            //                   там где создаются штуки на самой форме
            // 
            Price.Location = new System.Drawing.Point(x + 70, y);
            Price.Name = "numericUpDown" + number;
            Price.Size = new System.Drawing.Size(120, 20);
            Price.TabIndex = number;
            Price.Maximum = 10000000000;

            // 
            // progressBar1
            // 
            QueueLength.Location = new System.Drawing.Point(x + 250, y);
            QueueLength.Maximum = cashDesk.MaxQueueLength;
            QueueLength.Name = "progressBar" + number;
            QueueLength.Size = new System.Drawing.Size(100, 23); 
            QueueLength.TabIndex = number;
            QueueLength.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new System.Drawing.Point(x + 400, y);
            LeaveCustomersCount.Name = "label2" + number;
            LeaveCustomersCount.Size = new System.Drawing.Size(35, 13);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            //NumericUpDown.Value += e.Price; если сделать так, вылетает эксепшен:
            // попытка доступа к элементу управления '' не из того потока.
            // NumericUpDown.Invoke((Action)delegate { NumericUpDown.Value += e.Price; }); // вот такую конструкцию используешь и будет четко
            // по сути она перекидывает выполнение действия из асинхронного потока в основной и оно обновляется
            // чтобы не вылетал еще один эксепшен при закрытии окна, в свойстве(FormClosing) добавить model.Stop();
            Price.Invoke((Action)delegate
            {
                Price.Value += e.Price;
                QueueLength.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
