using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_WebForm_AgilMetoder
{
    public partial class employeeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Delete button
        protected void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                if (listbox.Items[i].Selected)
                    listbox.Items.Remove(listbox.Items[i]);
            }

        }

        // Clears textfields
        private void clear()
        {
            this.txtName.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtPhone.Text))

            {
                ScriptManager.RegisterStartupScript(this, GetType(), "AlertMealertnesse", "alert('Please enter some items');", true);
            }
            else
            {
                

        }




    }

        protected void listbox_SelectedIndexChanged(object sender, EventArgs e)
        { //

            
        }
    }
}