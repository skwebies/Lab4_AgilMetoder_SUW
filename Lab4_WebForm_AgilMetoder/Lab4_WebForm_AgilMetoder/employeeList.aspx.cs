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
        //creating a list to add employees
        private List<AddEmployee> addEmployees;
        
        //Creating a list that holds the deleted employees!
        private List<AddEmployee> deletedEmployees;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // checking the page is rendered for first time or loaded for the response of postback
            {
                Session["Employees"] = new List<AddEmployee>(); // creating a session variable for add employees
                Session["DeleteEmployees"] = new List<AddEmployee>(); // creating the session variable for delete employees
            }
        }

        //When add button gets clicked this event will take effect!
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            InsertEmployees(); // Inserting the employees
            BindEmployees();   // Bind the inserted employees from the list to repeater at the front end.
            txtClear();        // Clearing the text box properties after add event fired!

        }

        //Inserting the Employee details to the list!
        private void InsertEmployees()
        {
            if (Session["Employees"] != null) //Session Check for current input
                addEmployees = (List<AddEmployee>)Session["Employees"];
            else
                addEmployees = new List<AddEmployee>();

            int isAvailable = 0;
            for (int i = 0; i < addEmployees.Count; i++)
            {
                if (addEmployees[i].AddEmail == txtEmail.Text) //Comparing the email with all the embloyees to find the match.
                {
                    isAvailable = 1;
                }
            }

            if (isAvailable == 1) //if there is a email matching record exist!
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", //alert message for the exist records.
                  "alert('Recorded is Already exist!');", true);
            }
            else
            {
                addEmployees.Add(new AddEmployee(txtName.Text, txtEmail.Text, txtPhone.Text)); // adding the records to the list.
            }



            Session["Employees"] = addEmployees; // setting the session back to addEmployees

        }

        //Binding the list items to the html elements to display.
        private void BindEmployees()
        {
            rptEmployees.DataSource = addEmployees;
            rptEmployees.DataBind();


        }
        // After adding the List items text felds are made clear and set focused to first text field!
        private void txtClear()
        {
            this.txtName.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            //this.txtName.Focus();
        }

        //removing the selected items
        private void srcRemove()
        {
            deletedEmployees = new List<AddEmployee>();

            if (Session["Employees"] != null)
            {
                addEmployees = (List<AddEmployee>)Session["Employees"];
            }

            // for (int i = 0; i < addEmployees.Count; i++) // counting the added records
            // {
            int ischecked = 0;
            foreach (RepeaterItem item in rptEmployees.Items) // assigning the repeater item as repeated items
            {
                CheckBox chkMark = (CheckBox)item.FindControl("chkMark");
                Label lblName = (Label)item.FindControl("lblName");
                Label lblEmail = (Label)item.FindControl("lblEmail");
                Label lblPhone = (Label)item.FindControl("lblPhone");


                if (chkMark.Checked) // using the email as ID to find the checked item as a match
                {
                    for (int i = 0; i < addEmployees.Count; i++) // counting the added records
                    {
                        if (addEmployees[i].AddEmail == chkMark.Text)
                        {

                            addEmployees.Remove(addEmployees[i]);
                        }

                    }
                    ischecked = 1;
                }

                if (chkMark.Checked) // using the email as ID to find the checked item as a match
                {
                    deletedEmployees.Add(new AddEmployee(lblName.Text, lblEmail.Text, lblPhone.Text));
                }

            }
            if (ischecked == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage",
                                          "alert('Please check an item to delete');", true);
            }

            // }




            //addEmployees.Clear();
            BindEmployees();

            Session["DeleteEmployees"] = deletedEmployees;


        }


        //Strings are get setted on a class called AddEmployee
        public class AddEmployee
        {


            public string AddName
            {
                get;
                private set;
            }
            public string AddEmail
            {
                get;
                private set;
            }
            public string AddPhone
            {
                get;
                private set;
            }

            public AddEmployee(string addName, string addEmail, string addPhone)
            {
                AddName = addName;
                AddEmail = addEmail;
                AddPhone = addPhone;
            }




        }

        //deleting the selected records from the list.
        protected void btnDelete_Click(object sender, EventArgs e)
        {

            srcRemove();

        }

        //selecting all records
        protected void btnView_Click(object sender, EventArgs e)
        {
            if (rptEmployees.Items.Count != 0)
            {
                foreach (RepeaterItem item in rptEmployees.Items) // creating item variable 
                {
                    CheckBox chkMark = (CheckBox)item.FindControl("chkMark");

                    chkMark.Checked = true;

                }

            }else
            { // Poping a message when fails to have some records to delete on the list(front end)
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage",
                                                          "alert('Make sure that you have items on the list to select!');", true);
            }


        }

        // show deleted items in the list.
        protected void btnShow_Click(object sender, EventArgs e)
        {
            if (Session["DeleteEmployees"] != null)
            {
                deletedEmployees = (List<AddEmployee>)Session["DeleteEmployees"];
            }

            if (Session["Employees"] != null)
            {
                addEmployees = (List<AddEmployee>)Session["Employees"];
            }

          

            for (int i = 0; i < deletedEmployees.Count; i++)
            {
                addEmployees.Add(new AddEmployee(deletedEmployees[i].AddName, deletedEmployees[i].AddEmail, deletedEmployees[i].AddPhone));

            }



            BindEmployees();

        }
        //when clicked on first name Column heading list will be sorted as a-z (asc)
        protected void lbtnFullName_Click(object sender, EventArgs e)
        {
            if (Session["Employees"] != null) // session check
            {
                addEmployees = (List<AddEmployee>)Session["Employees"]; 
            }

            addEmployees.Sort(delegate (AddEmployee e1, AddEmployee e2)
            {
                return e1.AddName.CompareTo(e2.AddName);
              
            });




            BindEmployees();
        }


        //editting the list of items
        protected void lbtnEdit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            if (btn.ID.Equals("lbtnEdit"))
            {
                txtName.Text = btn.ID;
                txtName.DataBind();
            }
        }
    }
}