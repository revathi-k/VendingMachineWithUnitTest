using System;
using System.Web.UI.WebControls;

namespace VendingMachineNew
{
    public partial class Home : System.Web.UI.Page
    {
        ValidateCoinsBL objBL =new ValidateCoinsBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            FillProductData();
        }

        private void FillProductData()
        {
            try
            {
                ListofProducts objList = new ListofProducts();
                grdProducts.DataSource = objList.GetProducts();
                grdProducts.DataBind();
            }
            catch(Exception ex)
            {

            }
        }

        protected void grdProducts_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            fillCurrencyDropDown();
            lblError.Text = "Inserted Amount : 0";
            Button btn = sender as Button;
            GridViewRow row = btn.NamingContainer as GridViewRow;
            ViewState["prdPrice"] = grdProducts.DataKeys[row.RowIndex].Values[0].ToString();
            //int rowIndex = Convert.ToInt32(((Button)sender).Attributes["ROW_INDEX"].ToString());
            //ViewState["prdPrice"] = grdProducts.DataKeys[rowIndex].Value;
            modelPopup.Show();

        }
        private void fillCurrencyDropDown()
        {
            ddlCurrencyType.DataSource = Constants.currencyType;
            ddlCurrencyType.DataValueField = "key";
            ddlCurrencyType.DataTextField = "value";
            ddlCurrencyType.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtInputCoins.Text = string.Empty;
            modelPopup.Hide();
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            txtInputCoins.Text = string.Empty;
            modelPopup.Hide();
        }

        protected void txtInputCoins_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInputCoins.Text))
            ValidatePayment();
            modelPopup.Show();
        }

        private void ValidatePayment()
        {
            string inputCurrency = ddlCurrencyType.SelectedItem.Text;
            if (ViewState["prdPrice"] != null )
                objBL.ValidateCoins(inputCurrency,txtInputCoins.Text, Convert.ToDouble(ViewState["prdPrice"]));
            else 
                lblError.Text = "Invlid Error.";
        }


        protected void ddlCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInputCoins.Text))
                ValidatePayment();
            modelPopup.Show();
        }
    }
}