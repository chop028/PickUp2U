﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickUp2U
{
    public partial class MainOwnerform : Form
    {

        public static int userId;
        public MainOwnerform(int userId)
        {
            InitializeComponent();
            MainOwnerform.userId = userId;
            txt_userid.Text = userId.ToString();
        }

        private void 매장등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Shopform.userId = userId;
            shop = new Shopform();
            shop.MdiParent = this;
            shop.Show();
        }

        Shopform shop;
        Productform product;

        private void 상품등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            product = new Productform();
            product.MdiParent = this;
            product .Show();  
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginform loginForm = new Loginform();
            loginForm.Show();
        }

        OwnerShopform OwnerShop;
        private void 보유매장조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerShop = new OwnerShopform(userId);
            OwnerShop.MdiParent = this;
            OwnerShop.Show();
        }
        ShopOrderHistoryform shopOrderHistory;
        private void 픽업관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shopOrderHistory = new ShopOrderHistoryform();
            shopOrderHistory.MdiParent = this;
            shopOrderHistory.Show();
        }

        OrderListForm orderList;
        private void 주문조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderList = new OrderListForm();
            orderList.userId = userId;
            orderList.MdiParent = this;
            orderList.Show();  
        }
    }

}