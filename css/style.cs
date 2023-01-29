@import url("https://fonts.googleapis.com/css2?family=Josefin+Sans:wght@700&family=Kanit:wght@300;600;900&family=Noto+Sans+KR:wght@100;400;700&display=swap");
* {
  margin: 0px;
  padding: 0px;
  box-sizing: border-box;
  font-family: "Kanit";
}

ul,
ol,
li {
  list-style: none;
}

a {
  text-decoration: none;
}

#first {
  width: 100%;
  height: 100vh;
}
#first .upper {
  width: 100%;
  position: relative;
  display: flex;
  justify-content: center;
  max-width: 1280px;
  margin: 0px auto 100px;
  padding: 50px 0px;
}
#first .upper article {
  display: flex;
  justify-content: flex-end;
  overflow: hidden;
  position: relative;
  padding-left: 500px;
}
#first .upper article .pic {
  box-shadow: 10px 10px 15px rgba(0, 0, 0, 0.3);
  position: absolute;
  top: 10%;
  left: 0;
  width: 700px;
  height: 80%;
  z-index: 2;
}
#first .upper article .pic img {
  height: 100%;
  object-fit: cover;
  width: 100%;
}
#first .upper article .txtBox {
  position: relative;
  background-color: #f1f1f1;
  padding: 50px;
  height: 500px;
}
#first .upper article .txtBox .txt {
  margin-left: 200px;
}
#first .upper article .txtBox .txt h3 {
  font-size: 25px;
  margin-bottom: 20px;
  font-family: "Kanit";
  font-weight: 600;
}
#first .upper article .txtBox .txt p {
  font-family: "Kanit";
  font-size: 18px;
  word-break: break-all;
}
#first .lower {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  padding: 50px 0px;
  margin: 0px auto 100px;
}
#first .lower .lowerLeft {
  margin-right: 150px;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 50px 0px;
}
#first .lower .lowerLeft .title {
  border-right: 5px solid black;
  margin-right: 50px;
}
#first .lower .lowerLeft .title h2 {
  transform: rotate(90deg);
  font-size: 50px;
  letter-spacing: 1px;
  padding-top: 20px;
}
#first .lower .lowerLeft .profileTxt {
  padding: 50px;
}
#first .lower .lowerLeft .profileTxt p {
  font-weight: 600;
  font-size: 30px;
  letter-spacing: 1px;
  color: #333;
}
#first .lower .lowerLeft .profileTxt p span {
  font-weight: 300;
  padding: 20px;
  font-size: 30px;
  color: #111;
}
#first .lower .lowerLeft .profileTxt p:nth-of-type(3) {
  display: flex;
  flex-direction: column;
}
#first .lower .lowerLeft .profileTxt p:nth-of-type(3) span {
  font-weight: 300;
  padding: 0px;
}
#first .lower .lowerRight {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 50px 0px;
}
#first .lower .lowerRight .title {
  border-right: 5px solid black;
  margin-right: 50px;
}
#first .lower .lowerRight .title h2 {
  transform: rotate(90deg);
  font-size: 50px;
  padding-top: 20px;
}
#first .lower .lowerRight .logo {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 50px;
}
#first .lower .lowerRight .logo .html {
  width: 150px;
  height: 150px;
}
#first .lower .lowerRight .logo .html img {
  width: 100%;
  height: 100%;
  object-fit: center;
}
#first .lower .lowerRight .logo .css {
  width: 150px;
  height: 150px;
}
#first .lower .lowerRight .logo .css img {
  width: 100%;
  height: 100%;
  object-fit: center;
}
#first .lower .lowerRight .logo .sass {
  width: 130px;
  height: 130px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
#first .lower .lowerRight .logo .sass h2 {
  font-size: 30px;
  font-family: "Kanit";
  font-weight: 900;
}
#first .lower .lowerRight .logo .sass img {
  width: 100%;
  height: 100%;
  object-fit: center;
}
#first .lower .lowerRight .logo .js {
  width: 150px;
  height: 150px;
}
#first .lower .lowerRight .logo .js img {
  width: 100%;
  height: 100%;
  object-fit: center;
}
#first .lower .lowerRight .logo .react {
  width: 120px;
  height: 150px;
  padding-left: 30px;
  display: flex;
  align-items: center;
  flex-direction: column;
}
#first .lower .lowerRight .logo .react h2 {
  font-size: 30px;
  font-family: "Kanit";
  font-weight: 900;
}
#first .lower .lowerRight .logo .react img {
  width: 120px;
  height: 100px;
  object-fit: center;
}
#first .lower .lowerRight .logo .redux {
  width: 150px;
  height: 150px;
}
#first .lower .lowerRight .logo .redux img {
  width: 100%;
  height: 100%;
  object-fit: center;
}

#second {
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 50px 0px;
  margin: 0px auto 100px;
}
#second .title {
  border-right: 5px solid black;
  margin-right: 280px;
}
#second .title h2 {
  transform: rotate(90deg);
  font-size: 50px;
  padding-top: 20px;
}
#second .wrap {
  display: flex;
  justify-content: center;
  align-items: center;
}
#second .wrap .pic {
  width: 500px;
  height: 500px;
}
#second .wrap .pic img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
#second .wrap .txt {
  padding: 50px;
}
#second .wrap .txt p {
  font-weight: 600;
  font-size: 30px;
  letter-spacing: 1px;
  color: #333;
}
#second .wrap .txt p span {
  font-weight: 300;
  padding: 20px;
  font-size: 30px;
  color: #111;
}

#third {
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 50px 0px;
  margin: 0px auto 100px;
}
#third .title {
  border-right: 5px solid black;
  margin-right: 280px;
}
#third .title h2 {
  transform: rotate(90deg);
  font-size: 50px;
  padding-top: 20px;
}
#third .wrap {
  display: flex;
  justify-content: center;
  align-items: center;
}
#third .wrap .pic {
  width: 500px;
  height: 500px;
}
#third .wrap .pic img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
#third .wrap .txt {
  padding: 50px;
}
#third .wrap .txt p {
  font-weight: 600;
  font-size: 30px;
  letter-spacing: 1px;
  color: #333;
}
#third .wrap .txt p span {
  font-weight: 300;
  padding: 20px;
  font-size: 30px;
  color: #111;
}

/*# sourceMappingURL=style.cs.map */
