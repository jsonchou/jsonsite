<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="footer.ascx.cs" Inherits="JC.Web.ascx.footer" %>
<div class="moreInfo">
            <div class="moreInfo-box fix">
                <div class="fl">
                    <dl>
                        <dt>产品介绍</dt>
                        <%for (int i = 0; i < productMenulist.Count; i++)
                            {%>
                        <dd class="<%=JC.Common.Common.ShowClassAbs("/product/"+productMenulist[i].linktag,"on") %>"><a href="/product/<%=productMenulist[i].linktag %>"><%=productMenulist[i].title %></a></dd>
                        <% } %>
                    </dl>
                    <dl>
                        <dt>解决方案</dt>
                        <dd><a href="/solution/">新房装修</a></dd>
                        <dd><a href="/solution/">工程使用</a></dd>
                        <dd class="<%=JC.Common.Common.ShowClassAbs("/qa/","on") %>"><a href="/qa/">常见问题</a></dd>
                    </dl>
                    <dl>
                        <dt>用户见证</dt>
                        <dd><a href="/huifang/">用户回访</a></dd>
                        <dd><a href="/cases/">用户案例</a></dd>
                    </dl>
                    <dl>
                        <dt>产品花色</dt>

                         <%for (int i = 0; i < colorMenulist.Count; i++)
                            {%>
                        <dd class="<%=JC.Common.Common.ShowClassAbs("/color/"+colorMenulist[i].linktag,"on") %>"><a href="/color/<%=colorMenulist[i].linktag %>"><%=colorMenulist[i].title %></a></dd>
                        <% } %>
                    </dl>
                    <dl>
                        <dt>关于惠申</dt>
                        <dd><a href="/about/">关于我们</a></dd>
                        <dd><a href="/news/">新闻中心</a></dd>
                    </dl>
                    <dl>
                        <dt>联系我们</dt>
                        <dd><%=msite.freetele %></dd>
                        <dd>周一至周日 6:00-21:00</dd>
                        <dd>仅收市话费</dd>
                    </dl>
                </div>
                <div class="message fr">
                    <form id="j_form">
                        <div><input type="text" name="name" placeholder="联系人" /></div>
                        <div><input type="text" name="mobile" placeholder="手机号码" /></div>
                        <div><textarea name="info" placeholder="有任何问题，你可留言给我们，我们会在12小时内给你答复"></textarea></div>
                        <span class="email btn" ></span>
                    </form>
                    <div class="mascot"></div>
                </div>
            </div>
        </div>
<div class="footer">
    <div class="footer-box tc">
        <div class="copyright fl">&copy; Copyright：<%=msite.company %></div>
        <div class="recordNumber fr"><%=msite.beiancode %></div>
        <div class="logo"><img src="/content/dist/img/logo2.png" /></div>
    </div>
</div>

<%=msite.sitetrack %>