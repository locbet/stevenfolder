<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="ErrorPage.aspx.cs" Inherits="ShopWeb.ErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>出错啦！</title>
    <link href="css/common.css" rel="stylesheet" type="text/css" />
    <link href="css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
<DIV class=Header>
<DIV id=Logo><A href="http://www.360buy.com/"><IMG alt=京东商城 
src="images/logo.gif" width=167 height=46></A></DIV><!--[if !ie]>logo end<![endif]-->
<DIV class=head_box1>
<DIV id=Tip><SPAN id=vtip1>您好，欢迎来到京东商城！<SPAN>想继续购物之旅？<A 
href="javascript:login();">[请登录]</A>，新用户？<A 
href="javascript:login();">[免费注册]</A></SPAN></SPAN></DIV><!--[if !ie]>tip end<![endif]-->
<DIV id=MiniToolBar>
<UL>
  <LI id=My360buy><A onclick="setWebBILinkCount('index_top_jd2008')" 
  href="http://jd2008.360buy.com/user_home.aspx">我的京东</A> </LI>
  <LI class=line>| </LI>
  <LI class=hsub>
  <DL id=ServiceCenter>
    <DT><A onclick="setWebBILinkCount('index_channel_callcenter')" 
    href="http://www.360buy.com/help/callcenter.aspx" target=_blank>客服中心</A>
    <DD><A onclick="setWebBILinkCount('index_top_order')" 
    href="http://jd2008.360buy.com/user_order.aspx">订单中心</A>
    <DD><A onclick="setWebBILinkCount('index_top_fanxiu')" 
    href="http://jd2008.360buy.com/user_cpfx.aspx" target=_blank>返修中心</A>
    <DD><A onclick="setWebBILinkCount('index_top_tousu')" 
    href="http://jd2008.360buy.com/complaint.aspx">投诉中心</A></DD></DL></LI>
  <LI class=line>| </LI>
  <LI><A onclick="setWebBILinkCount('index_top_zhuangji')" 
  href="http://diy.360buy.com/" target=_blank>装机大师</A> </LI>
  <LI class=line>| </LI>
  <LI class=lpk><A href="http://market.360buy.com/giftcard/" 
  target=_blank>礼品卡</A> </LI></UL></DIV><!--[if !ie]>MiniToolBar end<![endif]-->
<DIV class=clear></DIV>
<UL id=Nav>
  <LI><SPAN class=Nav_first><A onfocus=this.blur() 
  onclick="setWebBILinkCount('index_channel_index')" 
  href="http://www.360buy.com/">首 页</A></SPAN> </LI>
  <LI><SPAN><A onfocus=this.blur() 
  onclick="setWebBILinkCount('index_channel_ele')" 
  href="http://www.360buy.com/electronic.html">家用电器</A></SPAN> </LI>
  <LI><SPAN><A onfocus=this.blur() 
  onclick="setWebBILinkCount('index_channel_mobile')" 
  href="http://www.360buy.com/digital.html">手机数码</A></SPAN> </LI>
  <LI><SPAN><A onfocus=this.blur() 
  onclick="setWebBILinkCount('index_channel_pc')" 
  href="http://www.360buy.com/computer.html">电脑产品</A></SPAN> </LI>
  <LI><SPAN><A onfocus=this.blur() 
  onclick="setWebBILinkCount('index_channel_jdlife')" 
  href="http://www.360buy.com/jdlife.html">日用百货</A></SPAN> </LI></UL><!--[if !ie]>Nav end<![endif]--></DIV>
<DIV class=clear></DIV>
<DIV class=head_box2>
<DIV class=head_box2_left></DIV>
<DIV class=head_box2_right></DIV>
<DIV id=HotKeyword></DIV>
<UL id=Search>
  <LI><STRONG>商品搜索：</STRONG> </LI>
  <LI class=S_input><INPUT 
  onkeydown="javascript:if(event.keyCode==13) search('keyword');" id=keyword 
  class=S_input1 onclick="this.value='';this.style.color='#444444'" 
  value="ThinkPad X200" autocomplete="off"> 
  <DIV id=Se_tip></DIV></LI>
  <LI class=S_go><IMG class=S_input2 onfocus=this.blur() 
  onclick="search('keyword');return false;" src="images/search_submit.jpg"> 
  </LI></UL><!--[if !ie]>Search end<![endif]-->
<UL id=Cart>
  <LI class=C_num>
  <DIV id=CartSwitch_wrap><IMG id=CartSwitch src="images/head3_18.gif" 
  width=14 height=15><A onclick="setWebBILinkCount('index_head_cart')" 
  href="http://jd2008.360buy.com/purchase/shoppingcart.aspx">购物车有&nbsp;<STRONG 
  id=ProductNum></STRONG>&nbsp;件商品</A></DIV></LI>
  <LI class=C_bal><A onclick="setWebBILinkCount('index_head_check')" 
  href="http://jd2008.360buy.com/purchase/ShoppingCart.aspx">去结算</A> </LI>
  <LI class=C_ord><A onclick="setWebBILinkCount('index_head_orders')" 
  href="http://jd2008.360buy.com/user_order.aspx">我的订单</A> </LI></UL><!--[if !ie]>Cart end<![endif]--></DIV></DIV><!--[if !ie]>顶部内容结束<![endif]-->
<DIV id=MyCart></DIV>
<DIV id=My_Cart_Tip class=Tip360></DIV>
<DIV id=Collect_Tip class="Tip360 w260"></DIV>
<DIV id=Fqfk_Tip class=Tip360></DIV>
<DIV class=Main>
<DIV class=e_box>
<DIV class=error>
<H2>商品或页面没有找到，但不要着急哦！<A href="http://www.360buy.com/"><IMG 
src="images/return.gif"></A></H2>现在您可以： 
<DIV class=tip>
<DL>
  <DT>快速进入 
  <DD><A href="http://www.360buy.com/">京东首页</A><A 
  href="http://www.360buy.com/electronic.html">家用电器频道</A><A 
  href="http://www.360buy.com/digital.html">手机数码频道</A><A 
  href="http://www.360buy.com/computer.html">电脑产品频道</A><A 
  href="http://www.360buy.com/jdlife.html">日用百货频道</A> </DD></DL>
<DL>
  <DT>热门分类 
  <DD><A 
  href="http://www.360buy.com/products/652-653-655-0-0-0-0-0-0-0-1-1-1.html">手机</A><A 
  href="http://www.360buy.com/products/670-671-672-0-0-0-0-0-0-0-1-1-1.html">笔记本</A><A 
  href="http://www.360buy.com/products/652-654-831-0-0-0-0-0-0-0-1-1-1.html">数码相机</A><A 
  href="http://www.360buy.com/products/652-828-837-0-0-0-0-0-0-0-1-1-1.html">MP3/MP4</A><A 
  href="http://www.360buy.com/products/670-686-688-0-0-0-0-0-0-0-1-1-1.html">显示器</A><A 
  href="http://www.360buy.com/products/652-829-845-0-0-0-0-0-0-0-1-1-1.html">存储卡</A><A 
  href="http://www.360buy.com/products/737-794-798-0-0-0-0-0-0-0-1-1-1.html">平板电视</A><A 
  href="http://www.360buy.com/products/911-925-942-0-0-0-0-0-0-0-1-1-1.html">钟表</A><A 
  href="http://www.360buy.com/products/652-828-842-0-0-0-0-0-0-0-1-1-1.html">耳机</A><A 
  href="http://www.360buy.com/products/670-677-683-0-0-0-0-0-0-0-1-1-1.html">硬盘</A> 
  </DD></DL></DIV></DIV><!--[if !IE]>说不定还能碰到喜欢的商品 开始<![endif]-->
<DIV class=Product_List_S7>
<H2><IMG alt=促销商品 src="images/jjsp.gif" width=159 height=24></H2>
<UL>
  <LI>
  <DL>
    <DT><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183226.html" target=_blank><IMG 
    alt="联想（Lenovo）R510 1U机架式服务器（至强新四核E5410，4*2G内存，4*500G硬盘，CD光驱，RAID卡）" 
    src="images/e28dd80d-8f62-4b20-bef1-863c7241a798.jpg"></A></DT>
    <DD class=p_Name><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183226.html" 
    target=_blank>联想（Lenovo）R510 
    1U机架式服务器（至强新四核E5410，4*2G内存，4*500G硬盘，CD光驱，RAID卡）<FONT 
    color=#ff0000></FONT></A></DD>
    <DD class=p_Price>京东价：<EM>￥13100.00</EM></DD></DL></LI>
  <LI>
  <DL>
    <DT><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183019.html" target=_blank><IMG 
    alt="索尼（SONY）VPCCW18FC/W 14.0英寸宽屏笔记本电脑（白色）P8700 4G 500G GT 230M 512M独立显卡" 
    src="images/1b30a75d-9625-4cd9-a1f9-35bad7043f3f.jpg"></A></DT>
    <DD class=p_Name><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183019.html" 
    target=_blank>索尼（SONY）VPCCW18FC/W 14.0英寸宽屏笔记本电脑（白色）P8700 4G 500G GT 230M 
    512M独立显卡<FONT color=#ff0000>正版Windows 7 索尼强势产品线火爆预定中！</FONT></A></DD>
    <DD class=p_Price>京东价：<EM>￥7599.00</EM></DD></DL></LI>
  <LI>
  <DL>
    <DT><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183018.html" target=_blank><IMG 
    alt="索尼（SONY）VPCCW18FC/R 14.0英寸宽屏笔记本电脑（红色）P8700 4G 500G GT 230M 512M独立显卡" 
    src="images/726f0b63-b4dd-485c-bb41-ea04afd6c660.jpg"></A></DT>
    <DD class=p_Name><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183018.html" 
    target=_blank>索尼（SONY）VPCCW18FC/R 14.0英寸宽屏笔记本电脑（红色）P8700 4G 500G GT 230M 
    512M独立显卡<FONT color=#ff0000>正版Windows 7 索尼强势产品线火爆预定中！</FONT></A></DD>
    <DD class=p_Price>京东价：<EM>￥7599.00</EM></DD></DL></LI>
  <LI>
  <DL>
    <DT><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183017.html" target=_blank><IMG 
    alt="索尼（SONY）VPCCW18FC/P 14.0英寸宽屏笔记本电脑（粉色） P8700 4G 500G GT 230M 512M独立显卡" 
    src="images/a48a4bd4-4761-4997-9411-055e72cb8db2.jpg"></A></DT>
    <DD class=p_Name><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183017.html" 
    target=_blank>索尼（SONY）VPCCW18FC/P 14.0英寸宽屏笔记本电脑（粉色） P8700 4G 500G GT 230M 
    512M独立显卡<FONT color=#ff0000>正版Windows 7 索尼强势产品线火爆预定中！</FONT></A></DD>
    <DD class=p_Price>京东价：<EM>￥7599.00</EM></DD></DL></LI>
  <LI>
  <DL>
    <DT><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183016.html" target=_blank><IMG 
    alt="索尼（SONY）VPCCW18FC/B 14.0英寸宽屏笔记本电脑（黑色） P8700 4G 500G GT 230M 512M独立显卡" 
    src="images/d8ce1549-7d61-4e1f-ba0a-f49d7466c46a.jpg"></A></DT>
    <DD class=p_Name><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183016.html" 
    target=_blank>索尼（SONY）VPCCW18FC/B 14.0英寸宽屏笔记本电脑（黑色） P8700 4G 500G GT 230M 
    512M独立显卡<FONT color=#ff0000>正版Windows 7 索尼强势产品线火爆预定中！</FONT></A></DD>
    <DD class=p_Price>京东价：<EM>￥7599.00</EM></DD></DL></LI>
  <LI>
  <DL>
    <DT><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183015.html" target=_blank><IMG 
    alt="索尼（SONY）VPCCW15EC/WU 14.0英寸宽屏笔记本电脑（哑光白）T4300 2G 250G G210M 256M独立显卡" 
    src="images/e3d78c30-bc43-4a2b-bdad-4781b4dfb4b0.jpg"></A></DT>
    <DD class=p_Name><A onclick="setWebBILinkCount('')" 
    href="http://www.360buy.com/product/183015.html" 
    target=_blank>索尼（SONY）VPCCW15EC/WU 14.0英寸宽屏笔记本电脑（哑光白）T4300 2G 250G G210M 
    256M独立显卡<FONT color=#ff0000>正版Windows 7 新模具，新概念，新普及！</FONT></A></DD>
    <DD class=p_Price>京东价：<EM>￥5099.00</EM></DD></DL></LI></UL></DIV><!--[if !IE]>说不定还能碰到喜欢的商品 结束<![endif]--></DIV></DIV>
<DIV class=Help>
<DL>
  <DT><IMG alt=购物指南 src="images/help_gwzn.gif"> 
  <DD><A href="http://www.360buy.com/help/flow.aspx" target=_blank>购物流程</A>
  <DD><A href="http://www.360buy.com/help/member.aspx" target=_blank>会员介绍</A> 
  <DD><A href="http://www.360buy.com/help/order.aspx" target=_blank>订单状态</A>
  <DD><A href="http://www.360buy.com/help/faq.aspx" target=_blank>常见问题</A> 
  <DD><A href="http://www.360buy.com/help/helectronic.aspx" target=_blank>大 家 
  电</A>
  <DD><A href="http://www.360buy.com/help/callcenter.aspx" 
  target=_blank>联系客服</A> </DD></DL>
<DL>
  <DT><IMG alt=配送方式 src="images/help_psfs.gif"> 
  <DD><A href="http://www.360buy.com/help/ziti.aspx" target=_blank>上门自提</A>
  <DD><A href="http://www.360buy.com/help/kdexpress.aspx" target=_blank>快递运输</A> 

  <DD><A href="http://www.360buy.com/help/ems.aspx" target=_blank>特快专递(EMS)</A> 
  </DD></DL>
<DL>
  <DT><IMG alt=支付方式 src="images/help_zffs.gif"> 
  <DD><A href="http://www.360buy.com/help/cod.aspx" target=_blank>货到付款</A>
  <DD><A href="http://www.360buy.com/help/onlinepay.aspx" target=_blank>在线支付</A> 

  <DD><A href="http://www.360buy.com/help/banktrans.aspx" target=_blank>银行转账</A>
  <DD><A href="http://www.360buy.com/help/dividedpay.aspx" 
  target=_blank>分期付款</A> 
  <DD><A href="http://www.360buy.com/help/postage.aspx" target=_blank>邮局汇款</A> 
  <DD><A href="http://www.360buy.com/help/transfer.aspx" target=_blank>公司转账</A> 
  </DD></DL>
<DL>
  <DT><IMG alt=售后服务 src="images/help_shfw.gif"> 
  <DD><A href="http://www.360buy.com/help/return_policy.aspx" 
  target=_blank>退换货政策</A>
  <DD><A href="http://www.360buy.com/help/return_flow.aspx" 
  target=_blank>退换货流程</A> 
  <DD><A href="http://www.360buy.com/help/price.aspx" target=_blank>价格保护</A>
  <DD><A href="http://www.360buy.com/help/refundment.aspx" 
  target=_blank>退款说明</A> </DD></DL>
<DL class=Help_b5>
  <DT><IMG alt=特色服务 src="images/help_tsfw.gif"> 
  <DD><A href="http://www.360buy.com/help/bid.aspx" target=_blank>商品拍卖</A>
  <DD><A href="http://www.360buy.com/help/diy.aspx" target=_blank>DIY装机</A> 
  <DD><A href="http://market.360buy.com/hd/yanbao090702/ind.html" 
  target=_blank><FONT color=red>延保服务</FONT></A>
  <DD><A href="http://www.360buy.com/help/visitservice.aspx" 
  target=_blank>上门服务</A> 
  <DD><A href="http://search.360buy.com/Search?keyword=diy上门" 
  target=_blank>上门装机</A>
  <DD><A href="http://market.360buy.com/giftcard/index.html" 
  target=_blank>京东礼品卡</A> </DD></DL></DIV><!--[if !ie]>Help end<![endif]-->
<SCRIPT type=text/javascript defer src="images/minicart.js"></SCRIPT>

<DIV class=Footer_Nav><A href="http://www.360buy.com/intro/about.aspx" 
target=_blank>关于我们</A>|<A href="http://www.360buy.com/contact/" 
target=_blank>联系我们</A>|<A href="http://www.360buy.com/intro/service.aspx" 
target=_blank>广告服务</A>|<A href="http://www.360buy.com/intro/job.aspx" 
target=_blank>人才招聘</A>|<A href="http://club.360buy.com/" 
target=_blank>京东社区</A>|<A href="http://club.360buy.com/allreview/1-1.html" 
target=_blank>商品评价</A>|<A href="http://club.360buy.com/links.aspx" 
target=_blank>友情链接</A></DIV><!--[if !ie]>Footer_Nav end<![endif]-->
<DIV class=Copyright>北京市公安局海淀分局备案编号：1101081681&nbsp;&nbsp;<A class=icp 
href="http://www.hd315.gov.cn/beian/view.asp?bianhao=010202007080200026">京ICP证070359号</A><BR>Copyright&copy;2004-2009&nbsp;&nbsp;360buy京东商城&nbsp;&nbsp;版权所有<BR></DIV><!--[if !ie]>Copyright end<![endif]-->
<DIV class=Footer_Link><A 
href="http://www.hd315.gov.cn/beian/view.asp?bianhao=010202007080200026" 
target=_blank><IMG alt=经营性网站备案中心 src="images/f_icp.gif"></A><A 
href="https://tns-ssverify.cnnic.cn/verifyseal.dll?dn=www.360buy.com" 
target=_blank><IMG alt=站点卫视 src="images/f_cnnic.gif"></A></DIV>
</body>
</html>
