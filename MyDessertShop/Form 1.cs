using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDessertShop
{
    public partial class Form1 : Form
    {
        private List<BasketItem> basket = new List<BasketItem>();
        private decimal currentItemPrice;
        private const decimal DiscountRate = 0.10m;
        private bool discountApplied = false;
        private KeyboardForm keyboard;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
            WelcomePanel.Visible = false;
        }

        private void GobackMenuBtn_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            WelcomePanel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ÉclairLbl_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailBack_Click(object sender, EventArgs e)
        {
            panelItemsDetails.Visible = false;
            menuPanel.Visible = true;
        }

        private void btnTira_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Signature Tiramisu";
            lblDescription.Text = "A layered, no-bake dessert featuring coffee-soaked spongecake, creamy mascarpone cheese filling, and a dusting of cocoa powder.";
            lblDetailPrice.Text = "Price: £6.50 ";
            picDetailImage.Image = TiraPic.Image;

            currentItemPrice = 6.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void TiraLbl_Click(object sender, EventArgs e)
        {

        }

        private void VelvetPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBarTb_TextChanged(object sender, EventArgs e)
        {
            string q = SearchBarTb.Text.Trim().ToLower();

            searchView.Items.Clear();

            if (q == "")
            {
                searchView.Visible = false;
                return;
            }
            searchView.Visible = true;

            if ("signature tiramisu".Contains(q))
                searchView.Items.Add("Signature Tiramisu");

            if ("eclair".Contains(q))
                searchView.Items.Add("Éclair");

            if ("blueberry tarts".Contains(q))
                searchView.Items.Add("Blueberry Tarts");

            if ("strawberry shortcake".Contains(q))
                searchView.Items.Add("Strawberry Shortcake");

            if ("new york cheesecake".Contains(q))
                searchView.Items.Add("New York Cheesecake");

            if ("classic chocolate cake".Contains(q))
                searchView.Items.Add("Classic Chocolate Cake");

            if ("cherry cheesecake".Contains(q))
                searchView.Items.Add("Cherry Cheesecake");

            if ("red velvet cake".Contains(q))
                searchView.Items.Add("Red Velvet Cake");

            if ("iced matcha latte".Contains(q))
                searchView.Items.Add("Iced Matcha Latte");

            if ("hot chocolate".Contains(q))
                searchView.Items.Add("Hot Chocolate");

            if ("hot tiramisu latte".Contains(q))
                searchView.Items.Add("Hot Tiramisu Latte");

            if ("brown sugar bubble tea".Contains(q))
                searchView.Items.Add("Brown Sugar Bubble Tea");


            if (searchView.Items.Count == 0)
            {
                searchView.Visible = false;
            }
        }

        private void ÉclairBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Éclair";
            lblDescription.Text = "Light choux pastry filled with smooth vanilla cream and topped with a glossy dark chocolate glaze.";
            lblDetailPrice.Text = "Price: £4.50 ";
            picDetailImage.Image = ÉclairPic.Image;

            currentItemPrice = 4.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void BlueberryBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Blueberry Tarts";
            lblDescription.Text = "Buttery shortcrust pastry filled with vanilla custard and piled high with fresh blueberries and a fruity glaze.";
            lblDetailPrice.Text = "Price: £4.50 ";
            picDetailImage.Image = BlueberryPic.Image;

            currentItemPrice = 4.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void StrawberryBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Strawberry Shortcake";
            lblDescription.Text = "Soft vanilla sponge layered with whipped cream and sweet strawberries for a light, bright dessert.";
            lblDetailPrice.Text = "Price: £5.50 ";
            picDetailImage.Image = StrawberryPic.Image;

            currentItemPrice = 5.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void NycBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "New York Cheesecake";
            lblDescription.Text = "Rich and creamy baked vanilla cheesecake set on a buttery biscuit base.";
            lblDetailPrice.Text = "Price: £3.20 ";
            picDetailImage.Image = NYCPic.Image;

            currentItemPrice = 3.20m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void ChocoBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Classic Chocolate Cake";
            lblDescription.Text = "Moist chocolate sponge layered with silky chocolate buttercream frosting.";
            lblDetailPrice.Text = "Price: £3.70 ";
            picDetailImage.Image = ChocoPic.Image;

            currentItemPrice = 3.70m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void CherryBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Cherry Cheesecake";
            lblDescription.Text = "Creamy vanilla cheesecake swirled with tangy cherry compote on a crunchy biscuit base.";
            lblDetailPrice.Text = "Price: £4.70 ";
            picDetailImage.Image = CherryPic.Image;

            currentItemPrice = 4.70m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void velvetBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Red Velvet Cake";
            lblDescription.Text = "Velvety cocoa sponge with a hint of chocolate, finished with smooth cream cheese frosting.";
            lblDetailPrice.Text = "Price: £4.50 ";
            picDetailImage.Image = VelvetPic.Image;

            currentItemPrice = 4.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void matchaBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Iced Matcha Latte";
            lblDescription.Text = "Chilled milk blended with smooth, slightly sweet matcha green tea and served over ice.";
            lblDetailPrice.Text = "Price: £4.20 ";
            picDetailImage.Image = MatchaPic.Image;

            currentItemPrice = 4.20m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void HotChocoBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Hot Chocolate";
            lblDescription.Text = "Steamed milk mixed with rich cocoa and topped with a swirl of whipped cream.";
            lblDetailPrice.Text = "Price: £4.50 ";
            picDetailImage.Image = HotChocoPic.Image;

            currentItemPrice = 4.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void TiraLatteBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Hot Tiramisu Latte";
            lblDescription.Text = "Warm coffee and steamed milk topped with thick foam, cocoa and a ladyfinger biscuit for a tiramisu-style latte.";
            lblDetailPrice.Text = "Price: £5.50 ";
            picDetailImage.Image = TiraLattePic.Image;

            currentItemPrice = 5.50m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void BobaBtn_Click(object sender, EventArgs e)
        {
            lblDetailName.Text = "Brown Sugar Bubble Tea";
            lblDescription.Text = "Creamy milk tea sweetened with caramelised brown sugar syrup and chewy tapioca pearls.";
            lblDetailPrice.Text = "Price: £4.20 ";
            picDetailImage.Image = BobaPic.Image;

            currentItemPrice = 4.20m;

            menuPanel.Visible = false;
            panelItemsDetails.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomePanel.Visible = true;
            menuPanel.Visible = false;
            panelItemsDetails.Visible = false;

            this.ActiveControl = MenuLbl;

            // Debug: Show screen info in title bar
            var screen = Screen.PrimaryScreen;
            var total = screen.Bounds;
            var working = screen.WorkingArea;
            this.Text = $"DEBUG | Screen: {total.Width}x{total.Height}, Working: {working.Width}x{working.Height}, Form: {this.Width}x{this.Height}";
        }

        private void searchView_Click(object sender, EventArgs e)
        {

            if (searchView.SelectedItems.Count == 0)
                return;

            string selectedName = searchView.SelectedItems[0].Text;

            searchView.Visible = false;

            if (selectedName == "Signature Tiramisu")
                btnTira.PerformClick();
            else if (selectedName == "Éclair")
                ÉclairBtn.PerformClick();
            else if (selectedName == "Blueberry Tarts")
                BlueberryBtn.PerformClick();
            else if (selectedName == "Strawberry Shortcake")
                StrawberryBtn.PerformClick();
            else if (selectedName == "New York Cheesecake")
                NycBtn.PerformClick();
            else if (selectedName == "Classic Chocolate Cake")
                ChocoBtn.PerformClick();
            else if (selectedName == "Cherry Cheesecake")
                CherryBtn.PerformClick();
            else if (selectedName == "Red Velvet Cake")
                velvetBtn.PerformClick();
            else if (selectedName == "Iced Matcha Latte")
                matchaBtn.PerformClick();
            else if (selectedName == "Hot Chocolate")
                HotChocoBtn.PerformClick();
            else if (selectedName == "Hot Tiramisu Latte")
                TiraLatteBtn.PerformClick();
            else if (selectedName == "Brown Sugar Bubble Tea")
                BobaBtn.PerformClick();
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            string name = lblDetailName.Text;
            decimal unitPrice = currentItemPrice;

            BasketItem existingItem = null;

            foreach (BasketItem item in basket)
            {
                if (item.Name == name)
                {
                    existingItem = item;
                    break;
                }
            }
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                BasketItem newItem = new BasketItem();
                newItem.Name = name;
                newItem.UnitPrice = unitPrice;
                newItem.Quantity = 1;

                basket.Add(newItem);
            }
            
           ShowBigMessage(name + " added to basket.");
        }

        private void RefreshBasketView()
        {
            basketView.Items.Clear();

            decimal subtotal = 0m;

            foreach (BasketItem item in basket)
            {
                decimal lineTotal = item.UnitPrice * item.Quantity;
                subtotal += lineTotal;

                ListViewItem row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("£" + item.UnitPrice.ToString("0.00"));

                basketView.Items.Add(row);
            }

            lblBasketTotal.Text = "Total: £" + subtotal.ToString("0.00");


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (basketView.SelectedItems.Count == 0)
            {
              ShowBigMessage("Please select an item to remove.");
                return;
            }

            string selectedName = basketView.SelectedItems[0].Text;

            BasketItem itemToRemove = null;

            foreach (BasketItem item in basket)
            {
                if (item.Name == selectedName)
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove == null)
                return;

            itemToRemove.Quantity--;

            if (itemToRemove.Quantity <= 0)
            {
                basket.Remove(itemToRemove);
            }

            RefreshBasketView();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            panelBasket.Visible = false;
            menuPanel.Visible = true;
        }

        private void BasketBtn_Click(object sender, EventArgs e)
        {
            RefreshBasketView();

            menuPanel.Visible = false;
            panelItemsDetails.Visible = false;
            panelBasket.Visible = true;
        }

        private void FillBasketInListView(ListView listView)
        {
            listView.Items.Clear();

            foreach (BasketItem item in basket)
            {

                ListViewItem row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("£" + item.UnitPrice.ToString("0.00"));

                listView.Items.Add(row);
            }
        }
        private void RefreshCheckoutlist()
        {
            Checkoutlist.Items.Clear();

            decimal subtotal = 0m;

            foreach (BasketItem item in basket)
            {
                decimal lineTotal = item.UnitPrice * item.Quantity;
                subtotal += lineTotal;

                ListViewItem row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("£" + item.UnitPrice.ToString("0.00"));

                Checkoutlist.Items.Add(row);
            }

            lblSummary.Text = "Checkout summary: £" + subtotal.ToString("0.00");

            decimal discountAmount = 0m;

            if (discountApplied)
            {
                discountAmount = subtotal * DiscountRate;
                lblDiscount.Text = "Discount Applied: -£" + discountAmount.ToString("0.00");
            }
            else
            {
                lblDiscount.Text = "Discount not applied";
            }

            decimal fineTotal = subtotal - discountAmount;
            lblTotal.Text = "Checkout Total: £" + fineTotal.ToString("0.00");
        }




        public class BasketItem
        {
            public string Name;
            public decimal UnitPrice;
            public int Quantity;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            RefreshCheckoutlist();

            panelBasket.Visible = false;
            panelCheckout.Visible = true;
            WelcomePanel.Visible = false;
            menuPanel.Visible = false;
            panelItemsDetails.Visible = false;
            panelBasket.Visible = false;
        }

        private decimal CalculateSubtotal()
        {
            decimal subtotal = 0m;

            foreach (BasketItem item in basket)
            {
                subtotal += item.UnitPrice * item.Quantity;

            }

            return subtotal;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnChBack_Click(object sender, EventArgs e)
        {
            panelCheckout.Visible = false;
            panelBasket.Visible = true;

            RefreshBasketView();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (basket.Count == 0)
            {
                ShowBigMessage("Your basket is empty.");
                return;
            }


            ShowBigMessage("Order has been placed. Thank you very much!");

            basket.Clear();
            discountApplied = false;

            basketView.Items.Clear();
            Checkoutlist.Items.Clear();

            lblSummary.Text = string.Empty;
            lblTotal.Text = string.Empty;
            lblDiscount.Text = string.Empty;
            lblBasketTotal.Text = string.Empty;

            panelBasket.Visible = false;
            panelCheckout.Visible = false;
            menuPanel.Visible = false;
            panelItemsDetails.Visible = false;


            WelcomePanel.Visible = true;
            WelcomePanel.BringToFront();



        }

        private void btnLoyaltyCode_Click(object sender, EventArgs e)
        {
            using (var cam = new CameraForm())
            {
                if (cam.ShowDialog() == DialogResult.OK)
                {
                    discountApplied = true;
                    RefreshCheckoutlist();
                }
            }
        }

        private void StaffLoginBtn_Click(object sender, EventArgs e)
        {
            using (var cam = new CameraForm())
            {
                if (cam.ShowDialog() == DialogResult.OK)
                {
                    EnterCleaningMode();
                }
            }
        }

        private void EnterCleaningMode()
        {
            WelcomePanel.Visible = false;
            menuPanel.Visible = false;
            panelItemsDetails.Visible = false;
            panelBasket.Visible = false;
            panelCheckout.Visible = false;
            panelCleaningMode.Visible = true;

        }
        private void btnExitCleaningMode_Click(object sender, EventArgs e)
        {
            panelCleaningMode.Visible = false;
            WelcomePanel.Visible = true;
        }

        private void SearchBarTb_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (keyboard == null)
            {
                keyboard = new KeyboardForm();

                keyboard.FormClosed += delegate
                {
                    keyboard = null;
                    this.ActiveControl = MenuLbl;
                };
            }

            
            keyboard.SetTextBoxForOutput(tb);

            
            keyboard.Show();

            
            var screenPos = tb.PointToScreen(Point.Empty);
            keyboard.Left = screenPos.X + tb.Width - 900;
            keyboard.Top = screenPos.Y + tb.Height + 200;
        }


        private void ShowBigMessage(string message)
        {
            using (var popup = new NotificationForm(message))
            {
                popup.ShowDialog(this);
            }
        }
    }
}





