using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFood
{
    public partial class Form_order : Form
    {
        public Form_order()
        {
            InitializeComponent();
        }

        void Tboxcheck()
        {
            if (tbox_blktea.Text != "" && int.Parse(tbox_blktea.Text) > 0) cb_blktea.Checked = true; else cb_blktea.Checked = false;
            if (tbox_milktea.Text != "" && int.Parse(tbox_milktea.Text) > 0) cb_milktea.Checked = true; else cb_milktea.Checked = false;
            if (tbox_burger.Text != "" && int.Parse(tbox_burger.Text) > 0) cb_burger.Checked = true; else cb_burger.Checked = false;
            if (tbox_chicken.Text != "" && int.Parse(tbox_chicken.Text) > 0) cb_chicken.Checked = true; else cb_chicken.Checked = false;
            if (tbox_orange_jui.Text != "" && int.Parse(tbox_orange_jui.Text) > 0) cb_orange_jui.Checked = true; else cb_orange_jui.Checked = false;
            if (tbox_treemilk.Text != "" && int.Parse(tbox_treemilk.Text) > 0) cb_treemilk.Checked = true; else cb_treemilk.Checked = false;
        }
//        int Menu()
//        {
//            int total = 0;

//            if (CheckOrder())
//            {
//                listMeal[0].Total = listMeal[0].Price * int.Parse(tbox_blktea.Text);
 
//                listMeal[1].Total = listMeal[1].Price * int.Parse(tbox_milktea.Text);

//                listMeal[2].Total = listMeal[2].Price * int.Parse(tbox_treemilk.Text);
   
//                listMeal[3].Total = listMeal[3].Price * int.Parse(tbox_orange_jui.Text);
//;
//                listMeal[4].Total = listMeal[4].Price * int.Parse(tbox_burger.Text);
               
//                listMeal[5].Total = listMeal[5].Price * int.Parse(tbox_chicken.Text);
               
//                for (int i = 0; i < listMeal.Count; i++)
//                {
//                    total += listMeal[i].Total;
//                }
//            }
//            return total;
//        }

        public int CheckOrder()
        {
            List<Meal> listMeal = new List<Meal>()
            {
                 new Meal(0,"泡沫紅茶",30),
                 new Meal(1,"珍珠奶茶",35),
                 new Meal(2,"木瓜牛奶",40),
                 new Meal(3,"柳橙汁",40),
                 new Meal(4,"漢堡A餐",100),
                 new Meal(5,"麥脆雞塊",120)
            };
            int total=0;
            if (cb_blktea.Checked == true && tbox_blktea.Text != "") 
            {
                total += listMeal[0].Price * int.Parse(tbox_blktea.Text);
                tbox_total.Text += $"{listMeal[0].Name} * {tbox_blktea.Text} = {listMeal[0].Price * int.Parse(tbox_blktea.Text)}\t\n" + Environment.NewLine;
            }
            if(cb_burger.Checked == true && tbox_burger.Text != "") 
            {
                total += listMeal[4].Price * int.Parse(tbox_burger.Text);
                tbox_total.Text += $"{listMeal[4].Name} * {tbox_burger.Text} = {listMeal[4].Price * int.Parse(tbox_burger.Text)}\t\n" + Environment.NewLine;
            }
            if (cb_chicken.Checked == true && tbox_chicken.Text != "")
            {
                total += listMeal[5].Price * int.Parse(tbox_chicken.Text);
                tbox_total.Text += $"{listMeal[5].Name} * {tbox_chicken.Text} = {listMeal[5].Price * int.Parse(tbox_chicken.Text)}\t\n" + Environment.NewLine;
            }
            if (cb_milktea.Checked == true && tbox_milktea.Text != "")
            {
                total += listMeal[1].Price * int.Parse(tbox_milktea.Text);
                tbox_total.Text += $"{listMeal[1].Name} * {tbox_milktea.Text} = {listMeal[1].Price * int.Parse(tbox_milktea.Text)}\t\n" + Environment.NewLine;
            }
            if (cb_orange_jui.Checked == true && tbox_orange_jui.Text != "")
            {
                total += listMeal[3].Price * int.Parse(tbox_orange_jui.Text);
                tbox_total.Text += $"{listMeal[3].Name} * {tbox_orange_jui.Text} = {listMeal[3].Price * int.Parse(tbox_orange_jui.Text)}\t\n" + Environment.NewLine;
            }
            if (cb_treemilk.Checked == true && tbox_treemilk.Text != "")
            {
                total += listMeal[2].Price * int.Parse(tbox_treemilk.Text);
                tbox_total.Text += $"{listMeal[2].Name} * {tbox_treemilk.Text} = {listMeal[2].Price * int.Parse(tbox_treemilk.Text)}\t\n" + Environment.NewLine;
            }
            return total;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            tbox_total.Text = "";
            int total = CheckOrder();
            string line = new string('-', 20);
            if (rbtn_in.Checked == true)
            {
                total += 10;
                label_welcome.Text = "總金額 : NT " + total + "元 !";
                tbox_total.Text += line + Environment.NewLine + "總金額 : NT " + total + "元 !";
            }
            else if (rbtn_out.Checked == true)
            {
                label_welcome.Text = "總金額 : NT " + total + "元 !";
                tbox_total.Text += line + Environment.NewLine + "總金額 : NT " + total + "元 !";
            }
            //label_welcome.Text = CheckOrder().ToString();
        }


        private void tbox_blktea_TextChanged(object sender, EventArgs e)
        {
            Tboxcheck();
        }

        private void tbox_milktea_TextChanged(object sender, EventArgs e)
        {
            Tboxcheck();
        }

        private void tbox_treemilk_TextChanged(object sender, EventArgs e)
        {
            Tboxcheck();
        }

        private void tbox_orange_jui_TextChanged(object sender, EventArgs e)
        {
            Tboxcheck();
        }

        private void tbox_burger_TextChanged(object sender, EventArgs e)
        {
            Tboxcheck();
        }

        private void tbox_chicken_TextChanged(object sender, EventArgs e)
        {
            Tboxcheck();
        }
    }
}
