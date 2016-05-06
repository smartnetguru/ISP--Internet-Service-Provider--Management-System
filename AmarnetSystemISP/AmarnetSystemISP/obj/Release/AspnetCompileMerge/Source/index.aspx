<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="StartNetwork.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headCContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="loader_content" ContentPlaceHolderID="loaderContentPlaceHolder" runat="server">
    <div class="loaderGif">
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <div data-ride="carousel" class="carousel slide" id="myCarousel">

        <%-- <ol class="carousel-indicators">
            <li class="" data-slide-to="0" data-target="#myCarousel" data-original-title="" title=""></li>
            <li data-slide-to="1" data-target="#myCarousel" data-original-title="" title="" class=""></li>
            <li data-slide-to="2" data-target="#myCarousel" data-original-title="" title="" class="active"></li>
        </ol>--%>
        <div class="carousel-inner">
            <asp:Repeater ID="sliderRepeter" runat="server">
                <ItemTemplate>
                    <div class='<%#"item"+" "+Eval("sliderActiveImage") %>'>
                        <img alt='<%#Eval("SliderTitle") %>' class="img-responsive" src='<%#"/SliderImgae/"+Eval("ImageName") %>' style="height: 400px; width: 100%;" />
                        <div class="container">
                            <div class="carousel-caption">
                                <div class="carousel-text">
                                    <h1 class="animated bounceInRight"><%#Eval("SliderTitle") %></h1>
                                    <ul class="list-unstyled carousel-list">
                                        <li class="animated bounceInLeft" data-original-title="" title=""><%#Eval("SliderMsg") %></li>
                                    </ul>
                                    <%-- <a role="button" href="#" class="enigma_blog_read_btn animated bounceInUp">Read More</a>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <%--  <div class="item">
                <img alt="EVERY DAY OF THE WEEK" class="img-responsive" src="/sitecontent/img/35432.jpg" />
                <div class="container">
                    <div class="carousel-caption">
                        <div class="carousel-text">
                            <h1 class="animated bounceInRight">EVERY DAY OF THE WEEK</h1>
                            <ul class="list-unstyled carousel-list">
                                <li class="animated bounceInLeft" data-original-title="" title="">24 HOURS EMERGEMCY SERVICE</li>
                            </ul>
                            <a role="button" href="index.aspx#" class="enigma_blog_read_btn animated bounceInUp">Read More</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="item active">
                <img alt="FIBER OPTIC BACKBONE" class="img-responsive" src="/sitecontent/img/051.jpg">
                <div class="container">
                    <div class="carousel-caption">
                        <div class="carousel-text">
                            <h1 class="animated bounceInRight">FIBER OPTIC BACKBONE</h1>
                            <ul class="list-unstyled carousel-list">
                                <li class="animated bounceInLeft" data-original-title="" title="">NETWORK WITH STRUCTURED DESIGN</li>
                            </ul>
                            <a role="button" href="index.aspx#" class="enigma_blog_read_btn animated bounceInUp">Read More</a>
                        </div>
                    </div>
                </div>
            </div>--%>
        </div>
        <a data-slide="prev" href="index.aspx#myCarousel" class="left carousel-control"><span class="glyphicon glyphicon-chevron-left"></span></a>
        <a data-slide="next" href="index.aspx#myCarousel" class="right carousel-control"><span class="glyphicon glyphicon-chevron-right"></span></a>
        <div class="enigma_slider_shadow"></div>
    </div>

    <div class="enigma_service">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="enigma_heading_title">
                        <h3>FEATURES</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div id="isotope-service-container" class="row isotope">
                <div class=" col-md-4 service">
                    <div class="enigma_service_area appear-animation bounceIn appear-animation-visible">
                        <div class="enigma_service_iocn pull-left"><i class="fa-cubes"></i></div>
                        <div class="enigma_service_detail media-body">
                            <h3><a href="index.aspx#">Commited Bandwidth</a></h3>
                            <p></p>
                            <p>
                                <strong><span style="color: #64686d; font-family: Roboto, sans-serif; font-size: 14px; line-height: 26px;">Two dedicated Fiber optic link from different IIG's with backup link

    . Dedicated bandwidth with Lowest latency.

                                </span></strong>
                            </p>
                            <p></p>
                        </div>
                    </div>
                </div>
                <div class=" col-md-4 service">
                    <div class="enigma_service_area appear-animation bounceIn appear-animation-visible">
                        <div class="enigma_service_iocn pull-left"><i class="fa-line-chart"></i></div>
                        <div class="enigma_service_detail media-body">
                            <h3><a href="index.aspx#">Maximum Uptime</a></h3>
                            <p></p>
                            <p><strong><span style="color: #64686d; font-family: Roboto, sans-serif; font-size: 14px; line-height: 26px;">Get new connection within 1 hour's.</span></strong></p>
                            <p></p>
                        </div>
                    </div>
                </div>
                <div class=" col-md-4 service">
                    <div class="enigma_service_area appear-animation bounceIn appear-animation-visible">
                        <div class="enigma_service_iocn pull-left"><i class="fa-clock-o"></i></div>
                        <div class="enigma_service_detail media-body">
                            <h3><a href="index.aspx#">24/7 Customer Support</a></h3>
                            <p></p>
                            <p><strong><span style="color: #64686d; font-family: Roboto, sans-serif; font-size: 14px; line-height: 26px;">Our customer service team is ready to serve you for 24/7 for solving all of your Internet realted problem and 24 hours power backup</span></strong></p>
                            <p></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="enigma_project_section">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="enigma_heading_title">
                        <h3>OUR SERVICES</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="enima_photo_gallery" id="enigma_portfolio_section">
                    <div class="col-lg-3 col-md-3 col-sm-6 pull-left scrollimation fade-right d1 in">
                        <div class="img-wrapper">
                            <div class="enigma_home_portfolio_showcase">
                                <img src="/sitecontent/img/0005.jpg" alt="ABOUT US" class="enigma_img_responsive" />
                                <div class="enigma_home_portfolio_showcase_overlay">
                                    <div class="enigma_home_portfolio_showcase_overlay_inner ">
                                        <div class="enigma_home_portfolio_showcase_icons">
                                            <a href="#" title="Internet Service"><i class="fa fa-link"></i></a>
                                            <a href="/sitecontent/img/0005.jpg" class="photobox_a"><i class="fa fa-search-plus"></i>
                                                <img style="display: none !important; visibility: hidden" alt="Internet Service" src="/sitecontent/img/0005.jpg" /></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="enigma_home_portfolio_caption">
                                <h3><a href="#">Internet Service</a></h3>
                            </div>
                        </div>
                        <div class="enigma_portfolio_shadow"></div>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-6 pull-left scrollimation fade-right d1 in">
                        <div class="img-wrapper">
                            <div class="enigma_home_portfolio_showcase">
                                <img src="/sitecontent/img/ftpServices.jpg" alt="FTP SERVICE" class="enigma_img_responsive" />
                                <div class="enigma_home_portfolio_showcase_overlay">
                                    <div class="enigma_home_portfolio_showcase_overlay_inner ">
                                        <div class="enigma_home_portfolio_showcase_icons">
                                            <a href="#" title="FTP SERVICES"><i class="fa fa-link"></i></a>
                                            <a href="/sitecontent/img/ftpServices.jpg" class="photobox_a"><i class="fa fa-search-plus"></i>
                                                <img style="display: none !important; visibility: hidden" alt="FTP SERVICES" src="/sitecontent/img/ftpServices.jpg"  /></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="enigma_home_portfolio_caption">
                                <h3><a href="index.aspx#">FTP Service</a></h3>
                            </div>
                        </div>
                        <div class="enigma_portfolio_shadow"></div>
                    </div>
                  <%--  <div class="col-lg-3 col-md-3 col-sm-6 pull-left scrollimation fade-right d1 in">
                        <div class="img-wrapper">
                            <div class="enigma_home_portfolio_showcase">
                                <img src="/sitecontent/img/BDIX.png" alt="BDIX FACILITIES" class="enigma_img_responsive" />
                                <div class="enigma_home_portfolio_showcase_overlay">
                                    <div class="enigma_home_portfolio_showcase_overlay_inner ">
                                        <div class="enigma_home_portfolio_showcase_icons">
                                            <a href="index.aspx#" title="BDIX Facilities"><i class="fa fa-link"></i></a>
                                            <a href="/sitecontent/img/BDIX.png" class="photobox_a"><i class="fa fa-search-plus"></i>
                                                <img style="display: none !important; visibility: hidden" alt="Web Design" src="/sitecontent/img/BDIX.png" /></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="enigma_home_portfolio_caption">
                                <h3><a href="#">Web Design</a></h3>
                            </div>
                        </div>
                        <div class="enigma_portfolio_shadow"></div>
                    </div>--%>
                    <div class="col-lg-3 col-md-3 col-sm-6 pull-left scrollimation fade-right d1 in">
                        <div class="img-wrapper">
                            <div class="enigma_home_portfolio_showcase">
                                <img src="/sitecontent/img/FiberOptic.jpg" alt="ABOUT US" class="enigma_img_responsive" />
                                <div class="enigma_home_portfolio_showcase_overlay">
                                    <div class="enigma_home_portfolio_showcase_overlay_inner ">
                                        <div class="enigma_home_portfolio_showcase_icons">
                                            <a href="index.aspx#" title="Full Fiber-Optical Network"><i class="fa fa-link"></i></a>
                                            <a href="/sitecontent/img/FiberOptic.jpg" class="photobox_a"><i class="fa fa-search-plus"></i>
                                                <img style="display: none !important; visibility: hidden" alt="Full Fiber-Optical Network" src="/sitecontent/img/FiberOptic.jpg" /></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="enigma_home_portfolio_caption">
                                <h3><a href="#">Fiber-Optical Network</a></h3>
                            </div>
                        </div>
                        <div class="enigma_portfolio_shadow"></div>
                    </div>
                <div class="col-lg-3 col-md-3 col-sm-6 pull-left scrollimation fade-right d1 in">
                        <div class="img-wrapper">
                            <div class="enigma_home_portfolio_showcase">
                                <img src="/sitecontent/img/liveTv.jpg" alt="ABOUT US" class="enigma_img_responsive" />
                                <div class="enigma_home_portfolio_showcase_overlay">
                                    <div class="enigma_home_portfolio_showcase_overlay_inner ">
                                        <div class="enigma_home_portfolio_showcase_icons">
                                            <a href="index.aspx#" title="Live HD TV"><i class="fa fa-link"></i></a>
                                            <a href="/sitecontent/img/liveTv.jpg" class="photobox_a"><i class="fa fa-search-plus"></i>
                                                <img style="display: none !important; visibility: hidden" alt="Live TV" src="/sitecontent/img/liveTv.jpg" /></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="enigma_home_portfolio_caption">
                                <h3><a href="#">Live TV</a></h3>
                            </div>
                        </div>
                        <div class="enigma_portfolio_shadow"></div>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-6 pull-left scrollimation fade-right d1 in">
                        <div class="img-wrapper">
                            <div class="enigma_home_portfolio_showcase">
                                <img src="/sitecontent/img/Power.jpg" alt="ABOUT US" class="enigma_img_responsive" />
                                <div class="enigma_home_portfolio_showcase_overlay">
                                    <div class="enigma_home_portfolio_showcase_overlay_inner ">
                                        <div class="enigma_home_portfolio_showcase_icons">
                                            <a href="index.aspx#" title="Full Power Backup"><i class="fa fa-link"></i></a>
                                            <a href="/sitecontent/img/Power.jpg" class="photobox_a"><i class="fa fa-search-plus"></i>
                                                <img style="display: none !important; visibility: hidden" alt="Full power Back Up" src="/sitecontent/img/Power.jpg" /></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="enigma_home_portfolio_caption">
                                <h3><a href="#">24 Hours Power Back-up</a></h3>
                            </div>
                        </div>
                        <div class="enigma_portfolio_shadow"></div>
                    </div>
                     </div>
            </div>
        </div>
    </div>
    <div class="enigma_blog_area">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="enigma_heading_title">
                        <h3>ABOUT US</h3>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="wl_caroufredsel_wrapper" style="display: block; text-align: start; float: none; position: relative; top: auto; right: auto; bottom: auto; left: auto; z-index: auto; width: 1170px; height: 348px; margin: 0px; overflow: hidden;">
                <div id="enigma_blog_section" class="row" style="text-align: left; float: none; position: absolute; top: 0px; right: auto; bottom: auto; left: 0px; margin: 0px; width: 3510px; height: 348px;">
                    <div class="col-md-4 col-sm-12 scrollimation scale-in d2 pull-left in" style="width: 1170px;">
                        <div class="enigma_blog_thumb_wrapper">
                            <div class="enigma_blog_thumb_wrapper_showcase">
                                <div class="enigma_blog_thumb_wrapper_showcase_overlay">
                                    <div class="enigma_blog_thumb_wrapper_showcase_overlay_inner ">
                                        <div class="enigma_blog_thumb_wrapper_showcase_icons">
                                            <a href="#" title="ABOUT US"><i class="fa fa-link"></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <h2><a href="#">ABOUT US</a></h2>
                            <%--<p>Star Network has started its operation in the year 2007 with the commitment of standerd quality internet service at an 
affordable price. At the time of commencement star Network started with broadband service with the state of art technology.
 In the course of time it’s R & D team has developed and introduced many new technologies to
 meet the requirement of new millennium. In the last 5 years star Network has introduced many new ideas 
and technologies to the internet industry. We beieve we will be successful if our clients are successful. 
Solving the hardest problems requires the best people. We think that the best people will be drawn to the 
opportunity to work on the hardest problems.
 We have built our company around that belief.</p>--%>
                            <%--<a class="enigma_blog_read_btn" href="#"><i class="fa fa-plus-circle"></i>Read More</a>
                            <div class="enigma_blog_thumb_footer">
                                <ul class="enigma_blog_thumb_date">
                                    <li data-original-title="" title=""><i class="fa fa-user"></i><a href="#">admin</a></li>
                                    <li data-original-title="" title=""><i class="fa fa-clock-o"></i>
                                        May 27, 2015 </li>
                                    <li data-original-title="" title=""><i class="fa fa-comments-o"></i><span>-</span></li>
                                </ul>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
            <div class="enigma_carousel-navi">
                <div class="enigma_carousel-prev hidden" id="port-next" style="display: none;"><i class="fa fa-arrow-left"></i></div>
                <div class="enigma_carousel-next hidden" id="port-prev" style="display: none;"><i class="fa fa-arrow-right"></i></div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptContentPLaceHolder" runat="server">
    <script>
        $(document).ready(function () {
            $('.enigma_blog_area').fadeIn(2500);


        });
        $(window).load(function () {
            $('.loaderGif').fadeOut(3000);
        });
    </script>
</asp:Content>
