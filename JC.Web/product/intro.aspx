<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="intro.aspx.cs" Inherits="JC.Web.product.intro" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" ID="meta1" />
    <title><%=mmenu.title %>_<%=msite.title %></title>
    <meta name="keywords" content="<%=mmenu.keywords %>" />
    <meta name="description" content="<%=mmenu.description %>" />
    <uc1:static runat="server" ID="static1" />
</head>
<body>
    <div class="header">
        <uc1:header runat="server" ID="header1" />
        <uc1:menu runat="server" ID="menu1" />
    </div>
    <div class="instructions">
        <div class="instructions-cont">
            <h2>基材信息</h2>
            <div class="title fix">
                <div class="left fl">强化复合地板系列</div>
                <div class="right fl">实木多层地板系列</div>
            </div>
            <ul class="instructions-list float">
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>尺寸：</label>808mm（长） x 130mm（宽） x 12mm（厚）
                        </div>
                        <div class="li-right">
                            <label>尺寸：</label>910mm（长） x 127mm（宽） x 15mm（厚）
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>主要材料：</label>纯松木基材
                        </div>
                        <div class="li-right">
                            <label>主要材料：</label>桦木+榉木基材
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>基材密度：</label>0.89（国家标准：≥0.85）
                        </div>
                        <div class="li-right">
                            <label>表面耐磨：</label>0.07，且表面有漆膜（国家标准：≤0.15）
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>吸水膨胀率：</label>6（国家标准：≤18）
                        </div>
                        <div class="li-right">
                            <label>漆膜耐候：</label>表面无明显裂纹
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>耐磨指数：</label>6000转（国家标准：≥6000转，家用I级）
                        </div>
                        <div class="li-right">
                            <label>甲醛释放：</label>0.5（国家标准：≤1.5，E1级）
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>甲醛释放：</label>0.8（国家标准：≤1.5，E1级）
                        </div>
                        <div class="li-right">
                            <label>防触电保护：</label>带电部位不易触及
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>防触电保护：</label>带电部位不易触及
                        </div>
                        <div class="li-right">
                            <label>冷态泄漏电流：</label>0.02（国家标准：工作温度下冷态泄漏电流≤0.75）
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>冷态泄漏电流：</label>0.02（国家标准：工作温度下冷态泄漏电流≤0.75）
                        </div>
                        <div class="li-right">
                            <label>介电强度：</label>工作温度下未发生闪络或击穿现象
                        </div>
                    </div>
                </li>
                <li>
                    <div class="fix">
                        <div class="li-left">
                            <label>介电强度：</label>工作温度下未发生闪络或击穿现象
                        </div>
                    </div>
                </li>
            </ul>
            <h2>发热系统信息</h2>
            <div class="icon tc">
                <img src="/content/dist/img/h48.png" /></div>
            <ul class="instructions-list">
                <li>
                    <label>使用电压：</label>≤380V</li>
                <li>
                    <label>工作温度：</label>长期使用≤35℃</li>
                <li>
                    <label>耐受温度：</label>≤200℃，绝缘材料（硅胶）在150℃下可长期使用而几乎无性能变化。</li>
                <li>
                    <label>功率密度：</label>150W / m2</li>
                <li>
                    <label>耐压强度：</label>2000V</li>
                <li>
                    <label>功率偏差：</label>±5 %</li>
                <li>
                    <label>泄漏电流：</label>0.05mA / m</li>
                <li>
                    <label>绝缘电阻：</label>≥30 MΩ .km</li>
                <li>
                    <label>阻值：</label>1.0-20000欧姆/米</li>
                <li>
                    <label>使用寿命：</label>100000H以上</li>
            </ul>
            <h2>磁场发射测试</h2>
            <div class="table-box">
                <table>
                    <tr>
                        <td class="tc border-left-none" rowspan="8" width="40%">
                            <img src="/content/dist/img/h116.jpg" /></td>
                        <td class="b border-none">测试位置</td>
                        <td class="b" colspan="3">磁场感应强度</td>
                    </tr>
                    <tr>
                        <td class="border-none tc"></td>
                        <td>
                            <p class="b">运行时</p>
                            在x、y、z方向取得最大值</td>
                        <td>
                            <p class="b">关闭时</p>
                            在x、y、z方向取得最大值</td>
                        <td class="b">绝对值</td>
                    </tr>
                    <tr>
                        <td class="border-none tc">1</td>
                        <td class="b">0.89</td>
                        <td class="b">0.02</td>
                        <td class="b">0.87</td>
                    </tr>
                    <tr>
                        <td class="border-none tc">2</td>
                        <td class="b">0.47</td>
                        <td class="b">0.02</td>
                        <td class="b">0.45</td>
                    </tr>
                    <tr>
                        <td class="border-none tc">3</td>
                        <td class="b">0.53</td>
                        <td class="b">0.02</td>
                        <td class="b">0.51</td>
                    </tr>
                    <tr>
                        <td class="border-none tc">4</td>
                        <td class="b">0.63</td>
                        <td class="b">0.02</td>
                        <td class="b">0.61</td>
                    </tr>
                    <tr>
                        <td class="border-none tc">5</td>
                        <td class="b">0.53</td>
                        <td class="b">0.02</td>
                        <td class="b">0.61</td>
                    </tr>
                    <tr>
                        <td class="border-none tc">6</td>
                        <td class="b">0.37</td>
                        <td class="b">0.02</td>
                        <td class="b">0.35</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
