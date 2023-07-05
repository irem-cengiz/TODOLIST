using EFPROJESİ4._07._2023.Context;
using EFPROJESİ4._07._2023.Entities;

namespace EFPROJESİ4._07._2023
{
    public partial class Form1 : Form
    {
        YapilacakIslerDbContext db = new YapilacakIslerDbContext();
        public Form1()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            clbToDos.Items.Clear();
            clbToDos.ItemCheck -= clbToDos_ItemCheck;
            foreach (var item in db.todoItems.Where(x => !x.Deleted).OrderBy(x => x.Done))
            {
                clbToDos.Items.Add(item, item.Done);  //database deki yapılı olanı getir.
            }
            clbToDos.DisplayMember = "Title";

            clbToDos.ItemCheck += clbToDos_ItemCheck;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string title = txtYapilacakis.Text.Trim();

            if (title == "")
                return;

            TodoItem newItem = new TodoItem() { Title = title, Done = false };
            db.todoItems.Add(newItem);
            db.SaveChanges();
            Listele();
        }
        private void clbToDos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Indeterminate) return;
            TodoItem selectedtodoitem = (TodoItem)clbToDos.Items[e.Index];
            bool yeniDurum = e.NewValue == CheckState.Checked;
            selectedtodoitem.Done = yeniDurum;
            db.SaveChanges();
            //CHECK LİST BOX ÇALIŞTIKTAN SONRA LİSTELE DİYORUZ. ÇAKIŞMA GİTMESİ İÇİN.
            BeginInvoke(Listele);
        }
        private void BTNdELETE_Click(object sender, EventArgs e)
        {
            if (clbToDos.SelectedIndex == -1) return;

            TodoItem selectedItem = (TodoItem)clbToDos.SelectedItem;
            db.Remove(selectedItem);
            db.SaveChanges();
            Listele();
        }
    }
}