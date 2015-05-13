using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "";
                btnCopyText.Enabled = true;
            }
        }

        protected void btnCopyText_Click(object sender, EventArgs e)
        {
            //copy the text boxto the label
            lblMessage.Text = txtMessage.Text;
            btnCopyText.Enabled = false;
        }

        protected void buttonShowSelections_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "";
            //loop through the list of checkboxes
            foreach (ListItem topping in cblToppings.Items)
            {
                if (topping.Selected)
                {
                    lblToppings.Text += topping.Text + " ";
                }
            }
            //display the selected size
            lblSize.Text = ddlSize.SelectedItem.Text;
        }

    }
}