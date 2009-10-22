<%@ Page Title="京东商城-中国专业的电脑、手机、数码、家电、日用百货网上购物商城" Language="C#" MasterPageFile="~/MasterPage.Master"
    AutoEventWireup="false" CodeBehind="Default.aspx.cs" Inherits="ShopWeb.Default" %>

<%@ Register Src="Controls/CtlCategory.ascx" TagName="CtlCategory" TagPrefix="uc1" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="京东商城-专业的数码网上购物商城,产品包括数码、家电、手机、电脑配件、网络产品等数万种商品直销,便捷，诚信的服务,为您提供愉悦的网上商城购物体验!" />
    <meta name="keywords" content="网上购物,网上商城,手机,笔记本,电脑,MP3,CD,VCD,DV,相机,数码,配件,手表,存储卡,京东商城" />
    <link href="css/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <form id="form1" runat="server">
    <div class="Main">
        <div class="left">
            <uc1:CtlCategory ID="CtlCategory1" runat="server" />
        </div>
        <div class="right">
            <div class="right_box1_left">
                <div id="ScareBuying">
                    <h2>
                        <img alt="新品上架" src="images/column_xpsj.jpg" width="122" height="27" /></h2>
                    <div class="Product_List_S3">
                        <ul>
                            <%for (int i = 0; i < 12; i++)
                              { %>
                            <li>
                                <dl>
                                    <dt><a href="#" target="_blank">
                                        <div>
                                            ￥6199</div>
                                        <img alt="夏普（AQUOS）40英寸 高清液晶电视 LCD-40Z660A 六小时限时抢购中" src="images/xiapu.jpg" />
                                    </a></dt>
                                    <dd class="p_Price">
                                        京东价：<em>￥6199.00</em></dd>
                                    <dd class="p_Name">
                                        <a href="#" target="_blank">夏普（AQUOS）40英寸 高清液晶电视 LCD-40Z660A 六小时限时抢购中</a></dd>
                                </dl>
                            </li>
                            <%}%>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="right_box1_right">
                <div id="Report" class="jdtex">
                    <h2>
                        京东快报</h2>
                    <ul>
                        <%for (int i = 0; i < 10; i++)
                          { %>
                        <li>·<a href="#" target="_blank">IT畅秋精品轰炸抢购！</a></li>
                        <%} %>
                        <li class="more">
                            <img src="images/arr_more.gif"><a class="link_1" href="#">更多&gt;&gt;</a></li>
                    </ul>
                </div>
                <div id='Sale' class='jdtex'>
                    <h2>
                        热卖新品</h2>
                    <ul>
                        <li class='recommend'>
                            <dl>
                                <dt><a target="_blank" href='#'>
                                    <img src='images/hu.jpg' alt='' /></a></dt>
                                <dd class='p_Name'>
                                    <a target="_blank" href='#'>美的（Midea）空气加湿器S20U-M（米宝宝）</a></dd>
                                <dd class="p_Price">
                                    京东价：￥<em>89.00</em></dd>
                            </dl>
                        </li>
                        <%for (int i = 0; i < 12; i++)
                          { %>
                        <li>·<a target="_blank" href='#'>古龙金属黑色框抗辐射眼镜特价款</a></li>
                        <%} %>
                        <li class='more'>
                            <img src='images/arr_more.gif' /><a href='#' class="link_1">更多&gt;&gt;</a></li></ul>
                </div>
            </div>
        </div>
    </div>
    </form>
</asp:Content>
