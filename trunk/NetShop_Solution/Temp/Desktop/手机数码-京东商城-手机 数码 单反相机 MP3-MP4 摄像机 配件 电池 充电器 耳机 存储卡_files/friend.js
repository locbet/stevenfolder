var jdFriendUrl='http://club.360buy.com/jdFriend/TuiJianService.aspx';
function FriendScript()
{   
    var param = getparam();
    if(param!="")
    {
        var js=document.createElement('script');
        js.type='text/javascript';
        js.src=jdFriendUrl+'?roid='+Math.random()+param;
        js.charset='GB2312';
        document.getElementsByTagName('head')[0].appendChild(js);
    }
}
window.onload = function()
{
    FriendScript();
}
function getparam()
{
    var sid=""; 
    var type="";
    var args=new Object();  
    var query=location.search.substring(1);//获取查询串   
    var pairs=query.split("&");//在逗号处断开   
    for(var i=0;i<pairs.length;i++)   
    {   
        var pos=pairs[i].indexOf('=');//查找name=value   
        if(pos==-1)continue;//如果没有找到就跳过   
        var argname=pairs[i].substring(0,pos);//提取name
        if(pairs[i].substring(0,pos)=="sid")
        {
            sid=unescape(pairs[i].substring(pos+1));//提取value 
        }
        if(pairs[i].substring(0,pos)=="t")
        {
            type=unescape(pairs[i].substring(pos+1));//提取value 
        }
        //var value=pairs[i].substring(pos+1);//提取value   
        //args[argname]=unescape(value);//存为属性   
    }
    if(sid!=""||type!="")
    {
        return "&sid="+escape(sid)+"&t="+escape(type);
    }
    else
    {
        return "";
    }
}
