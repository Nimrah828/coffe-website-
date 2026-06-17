/* ================= GLOBAL ================= */

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
}

body{
    font-family: 'Playfair Display', serif;
}

h1,h2,h3,h4,h5{
    font-weight:700;
}

.main-btn{
    background:#F9C06A;
    border:none;
    padding:12px 28px;
    border-radius:30px;
    font-weight:600;
    transition:0.3s;
}

.main-btn:hover{
    background:#e0a84f;
}

/* ================= HERO SECTION ================= */

.hero-section{
    width:100%;
    min-height:100vh;
    background:
    linear-gradient(to right, rgba(0,0,0,0.8), rgba(0,0,0,0.3)),
    url('./nathan-dumlao-c2Y16tC3yO8-unsplash.jpg');

    background-size:cover;
    background-position:center;
    color:white;
}

/* Navbar */

.navbar{
    padding:25px 0;
}

.logo{
    font-size:32px;
    font-weight:700;
}

.navbar-nav .nav-link{
    color:white !important;
    margin:0 15px;
}

.nav-buttons{
    display:flex;
    align-items:center;
    gap:20px;
}

.signin-btn{
    color:white;
    text-decoration:none;
}

.signup-btn{
    background:#F9C06A;
    padding:10px 24px;
    border-radius:30px;
    color:black;
    text-decoration:none;
}

/* Hero Content */

.hero-content{
    padding-top:120px;
}

.small-heading{
    font-size:22px;
}

.hero-content h1{
    font-size:180px;
    font-weight:900;
}

.hero-text{
    width:500px;
    line-height:1.8;
    margin-bottom:30px;
}

/* ================= DISCOVER SECTION ================= */

.discover-section{
    padding:100px 0;
}

.discover-section h2{
    font-size:55px;
    color:#603809;
    margin-bottom:25px;
}

.discover-section p{
    color:#707070;
    line-height:2;
    margin-bottom:30px;
}

.discover-img{
    width:90%;
}

/* ================= PRODUCTS ================= */

.products-section{
    padding:80px 0;
}

.products-section h2{
    color:#603809;
    font-size:50px;
}

.products-section p{
    color:#707070;
}

.coffee-card{
    border:1px solid #f1d6b1;
    text-align:center;
    background:#FFF9F1;
}

.card-content{
    padding:20px;
}

.card-content h4{
    color:#603809;
}

.card-content h5{
    color:#603809;
    margin:15px 0;
}

/* ================= RESPONSIVE ================= */

@media(max-width:768px){

    .hero-content h1{
        font-size:90px;
    }

    .hero-text{
        width:100%;
    }

    .discover-section h2,
    .products-section h2{
        font-size:35px;
    }

}

.morning-section {
    position: relative;
    background: url("images/coffee-beans.jpg") center/cover no-repeat;
    min-height: 320px;
    border-radius: 20px;
    overflow: hidden;
    margin: 80px auto;
}

.overlay {
    position: absolute;
    inset: 0;
    background: rgba(74, 40, 12, 0.75);
}

.content {
    position: relative;
    z-index: 2;
    color: white;
}

.different-section{
    background:#fff;
    padding:100px 0;
}

.section-title{
    font-size:54px;
    font-weight:700;
    color:#603809;
    font-family:Georgia, serif;
}

.section-subtitle{
    color:#707070;
    margin-top:10px;
}

.feature-card{
    background:#fff9f1;
    border:1px solid #f1e0c8;
    padding:35px 20px;
    transition:.3s;
    height:100%;
}

.active-card{
    background:#ffeed8;
}

.feature-card img{
    width:70px;
    margin-bottom:20px;
}

.feature-card h5{
    color:#603809;
    font-weight:700;
}

.feature-card p{
    color:#707070;
    margin:0;
}

.idea-text{
    color:#707070;
}

.today-text{
    color:#603809;
    font-weight:700;
    margin-bottom:20px;
}

.coffee-btn{
    background:#F9C06A;
    color:#000;
    border:none;
    border-radius:30px;
    padding:12px 35px;
    font-weight:600;
}

.coffee-btn:hover{
    background:#e8ae53;
}
.mydiv{
    /* margin-top: 100px; */
}

/*  */
.coffee-banner{
    position: relative;
    width: 100%;
}

.coffee-banner img{
    width: 100%;
    display: block;
}

.banner-content{
    position: absolute;
    top: 50%;
    left: 80px;
    transform: translateY(-50%);
    color: white;
    width: 400px;
}

.banner-content h2{
    font-size: 48px;
    margin-bottom: 20px;
}

.banner-content p{
    font-size: 16px;
    margin-bottom: 20px;
}

.banner-content button{
    padding: 10px 25px;
    border: none;
    border-radius: 20px;
    background: #F9C06A;
    cursor: pointer;
}


.bcoffe{
    width: 100%;
}


 .coffee-section{
    position: relative;
    width: 100%;
}

.bg-image{
    width: 100%;
    display: block;
}

.content{
    position: absolute;
    top: 50%;
    left: 80px;
    transform: translateY(-50%);
    color: white;
}

.cup-image{
    position: absolute;
    right: 100px;
    top: 50%;
    transform: translateY(-50%);
    width: 300px;   /* yahan size control karo */
    height: auto;
}

.feedback{
    padding: 100px 0;
    background: #fff;
    text-align: center;
}

.feedback h2{
    font-size: 45px;
    color: #603809;
    margin-bottom: 10px;
}

.sub-title{
    color: #707070;
    margin-bottom: 50px;
}

.feedback-card{
    width: 80%;
    max-width: 900px;
    margin: auto;
    background: #FFF9F1;
    border: 1px solid #F9C06A;
    padding: 60px;
    position: relative;
}

.quote{
    font-size: 90px;
    color: #603809;
    display: block;
    text-align: left;
    line-height: 1;
}

.feedback-text{
    color: #707070;
    line-height: 2;
    margin: 20px 0;
}

.feedback-card h3{
    color: #603809;
    font-size: 28px;
    margin-top: 20px;
}

.designation{
    color: #707070;
}

.profile{
    width: 90px;
    height: 90px;
    margin-top: 30px;
    border-radius: 10px;
}

.left-btn,
.right-btn{
    position: absolute;
    top: 50%;
    transform: translateY(-50%);
    width: 50px;
    height: 50px;
    border: none;
    background: #F9C06A;
    border-radius: 12px;
    cursor: pointer;
    font-size: 20px;
}

.left-btn{
    left: -25px;
}

.right-btn{
    right: -25px;
}

/*  */

/* Subscribe Section */

.subscribe{
    background: url("images/coffee-beans.jpg") center/cover;
    min-height: 350px;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
    position: relative;
}

.subscribe::before{
    content: "";
    position: absolute;
    inset: 0;
    background: rgba(96,56,9,0.75);
}

.subscribe-content{
    position: relative;
    z-index: 1;
}

.subscribe h2{
    color: #fff;
    font-size: 48px;
    margin-bottom: 15px;
}

.subscribe p{
    color: #fff;
    margin-bottom: 25px;
}

.subscribe-box{
    display: flex;
    justify-content: center;
}

.subscribe-box input{
    width: 400px;
    padding: 15px;
    border: none;
    outline: none;
}

.subscribe-box button{
    padding: 15px 25px;
    border: none;
    background: #F9C06A;
    font-weight: bold;
    cursor: pointer;
}


/* footer */
.footer{
    background: linear-gradient(rgba(92,40,0,.9),
    rgba(92,40,0,.95)),
    url("");
    background-size: cover;
    background-position: center;
    color: white;
    position: relative;
    overflow: hidden;
}

/* Newsletter */

.newsletter{
    position: relative;
    text-align: center;
    padding: 80px 20px;
    background: rgba(0,0,0,0.25);
}

.newsletter h2{
    font-size: 42px;
    margin-bottom: 10px;
}

.newsletter p{
    margin-bottom: 25px;
}

.subscribe-box{
    display: flex;
    justify-content: center;
    max-width: 500px;
    margin: auto;
}

.subscribe-box input{
    width: 75%;
    padding: 15px;
    border: none;
    outline: none;
}

.subscribe-box button{
    background: #F9C06A;
    border: none;
    padding: 15px 25px;
    cursor: pointer;
    font-weight: bold;
}

/* Coffee Cups */

.cup-left,
.cup-right{
    position: absolute;
    width: 180px;
    bottom: -20px;
}

.cup-left{
    left: 0;
}

.cup-right{
    right: 0;
}

/* Footer Content */

.footer-content{
    display: grid;
    grid-template-columns: 2fr 1fr 1fr 1fr;
    gap: 40px;
    padding: 80px 100px;
    background: #5b2f0c;
    position: relative;
}

.footer-content::after{
    content: "";
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    height: 120px;
    /* background: url("./mike-kenneally-TD4DBagg2wE-unsplash\ \(2\).jpg"); */
    background-repeat: repeat-x;
    background-size: contain;
}

.logo{
    font-size: 35px;
    margin-bottom: 20px;
}

.footer-col h3{
    margin-bottom: 20px;
}

.footer-col ul{
    list-style: none;
}

.footer-col ul li{
    margin-bottom: 12px;
}

.social-icons{
    margin-top: 20px;
}

.social-icons i{
    margin-right: 15px;
    font-size: 18px;
    cursor: pointer;
}

/* Responsive */

@media(max-width:768px){

.footer-content{
    grid-template-columns:1fr;
    padding:50px 30px;
}

.newsletter h2{
    font-size:28px;
}

.cup-left,
.cup-right{
    width:120px;
}
}
