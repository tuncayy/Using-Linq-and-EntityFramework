using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           using (eShopperDBEntities products = new eShopperDBEntities())
           {
               var query = from p in products.tProducts
                           
                           select p;


               tProduct product = (query.FirstOrDefault<tProduct>());
               GridView1.DataSource = query.ToList();
               GridView1.DataBind();
           }
        using (eShopperDBEntities categpry = new eShopperDBEntities())
        {
            var query =( from c in categpry.tCategories

                        select c );


           //   tCategory categpryies = (query.FirstOrDefault<tCategory>());
            //    GridView1.DataSource = query.ToList();
            //    GridView1.DataBind();
           
           
            DropDownList2.DataSource = query.ToList();
            DropDownList2.DataTextField = "CategoryName";
            DropDownList2.DataValueField = "CategoryID";
            DropDownList2.DataBind();
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int min = Convert.ToInt32(TextBox1.Text);
        int max = Convert.ToInt32(TextBox2.Text);
        if(DropDownList1.SelectedIndex < 9)
        { using (eShopperDBEntities products = new eShopperDBEntities())
        {
            var query = from p in products.tProducts
                        where p.CategoryID == DropDownList1.SelectedIndex + 1
                        where p.Price >= min
                        where p.Price <= max
                        
                        select p;


            tProduct product = (query.FirstOrDefault<tProduct>());
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }}
        else
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts
                          
                            where p.Price >= min
                            where p.Price <= max
                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
        
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int min = Convert.ToInt32(TextBox1.Text);
        int max = Convert.ToInt32(TextBox2.Text);
        if (DropDownList1.SelectedIndex < 9)
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts
                            where p.CategoryID == DropDownList1.SelectedIndex + 1
                            where p.Price >= min
                            where p.Price <= max

                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
        else
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts

                            where p.Price >= min
                            where p.Price <= max
                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int min = Convert.ToInt32(TextBox1.Text);
        int max = Convert.ToInt32(TextBox2.Text);
        if (DropDownList1.SelectedIndex < 9)
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts
                            where p.CategoryID == DropDownList1.SelectedIndex + 1
                            where p.Price >= min
                            where p.Price <= max

                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
        else
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts

                            where p.Price >= min
                            where p.Price <= max
                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        int min = Convert.ToInt32(TextBox1.Text);
        int max = Convert.ToInt32(TextBox2.Text);
        if (DropDownList1.SelectedIndex < 9)
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts
                            where p.CategoryID == DropDownList1.SelectedIndex + 1
                            where p.Price >= min
                            where p.Price <= max

                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
        else
        {
            using (eShopperDBEntities products = new eShopperDBEntities())
            {
                var query = from p in products.tProducts

                            where p.Price >= min
                            where p.Price <= max
                            select p;


                tProduct product = (query.FirstOrDefault<tProduct>());
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
    }
}