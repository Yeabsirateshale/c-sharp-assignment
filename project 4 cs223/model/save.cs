using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4_cs223.model
{
    class save
    {
        public string number { get; set; }
        public DateTime date { get; set; }
        public string inventoryNumber { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }

        internal void Save(save s)
        {
            MessageBox.Show($"Item Has been Added! \n Item number: " +
                $"{s.number}\n " +
                $"Item date: {s.date}\n " +
                $"Inventory number: {s.inventoryNumber}\n " +
                $"Item name: {s.objectname}\n " +
                $"Quantity: {s.count}\n " +
                $"Price: {s.price} ");
        }
    }
}
