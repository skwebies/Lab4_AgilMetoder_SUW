using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopDemoLibrary;

namespace ShopDemoUI
{
    public partial class frmShopUI : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();


        public frmShopUI()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items;
            lbItems.DataSource = itemsBinding;

            lbItems.DisplayMember = "Display";
            lbItems.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            lbCartItems.DataSource = cartBinding;

            lbCartItems.DisplayMember = "Display";
            lbCartItems.ValueMember = "Display";
            
        }

        private void SetupData()
        {

            //store.Vendors.Add(demoVendor);
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Romeo Juliet",
                Description = "A book about true love",
                Price = 2.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Austin",
                Description = "A book about a girl",
                Price = 6.50M,
                Owner = store.Vendors[1]
            });

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Figure out what is selected from the items list
            // copy that item to the shopping cart
            // Do we remove the item from the items list? - no
            Item selectedItem = (Item)lbItems.SelectedItem;

            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Mark each item in the cart as sold
            // clear the cart
           
            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
            }

            shoppingCartData.Clear();

            cartBinding.ResetBindings(false);
        }
    }
}
