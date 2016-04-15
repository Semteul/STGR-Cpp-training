//alert("Hello, World!");
console.log("Hello, HTML!");
console.log("My first HTML Page");

const SPACE = "&nbsp;";

function newContent() {
  //Test1
  var output = document.getElementById("result1");
  output.innerHTML = "구구단의 단을 입력해주세요";

  //Test2
  var output = document.getElementById("result2");
  output.innerHTML = "상하좌우의 크기를 입력해주세요";

  //Test3
  var output = document.getElementById("result3");
  output.innerHTML = "검사할 코드블럭을 입력해주세요";

  //Test3
  var output = document.getElementById("result4");
  output.innerHTML = "아무 숫자나 집어넣으세요";
}

function run1() {
  var output = document.getElementById("result1");
  var et = document.getElementById("et11");
  var result = "";

  if(parseInt(et.value) != et.value) {
    result = "숫자를 입력해 주세요";
  }else if(et.value < 1 || et.value > 9) {
    result = "입력 범위는 1~9입니다";
  }else {
    for(var e = 1; e <= 9; e++) {
      for(var p = e*parseInt(et.value); p > 0; p--) {
        result += "*";
      }
      result += "<br>";
    }
  }
  output.innerHTML = result;
}

function run2() {
  var output = document.getElementById("result2");
  var x = document.getElementById("et21").value;
  var y = document.getElementById("et22").value;
  var result = "";

  if(parseInt(x) != x || parseInt(y) != y) {
    result = "숫자를 입력해 주세요";
  }else {
    x = parseInt(x);
    y = parseInt(y);
    for(var cy = 0; cy < y; cy++) {
      for(var cx = 0; cx < x; cx++) {
        if(cy%2 === 0) {
          result += fixNum(cy*x + cx + 1);
        }else {
          result += fixNum((cy+1)*x - cx);
        }
        result += " ";
      }
      result += "<br>";
    }
  }
  output.innerHTML = result;
}

function run3() {
  var output = document.getElementById("result3");
  var value = document.getElementById("et31").value;
  var result = "";

  var tmpAry = value.split("");
  var codeLayer = 0;
  for(var e = 0; e < tmpAry.length; e++) {
    if(tmpAry[e] === "(") {
      codeLayer++;
    }else if(tmpAry[e] === ")") {
      codeLayer--;
    }
    if(codeLayer < 0) {
      break;
    }
  }

  if(codeLayer === 0) {
    result = "PASS";
  }else {
    result = "FAIL";
  }

  output.innerHTML = result;
}

var test4ary = [];

function run4() {
  var output = document.getElementById("result4");
  var input = document.getElementById("et41").value;
  var result = "";

  document.getElementById("et41").value = "";

  if(parseInt(input) != input) {
    alert("제대로 된 숫자를 입력해 주세요");
    return;
  }

  input = parseInt(input);
  test4ary.push(input);
  result += test4ary + "<br><br>";

  result += "최대값: " + Math.max.apply(null, test4ary) + " ";
  result += "최소값: " + Math.min.apply(null, test4ary);

  output.innerHTML = result;
}

function run4clear() {
  test4ary = [];
  var output = document.getElementById("result4");
  output.innerHTML = "아무 숫자나 집어넣으세요";
}

var t5 = {
  run: false,
  total: 0,
  player0: 0,
  player1: 0, //CPU
}
var t5color = {
  player0: "#0f0",
  player1: "#f00"
}
const ROCK = 0;
const SISSOR = 1;
const PAPER = 2;

function run5() {
  var stair = document.getElementById("et51").value;
  var result5 = document.getElementById("result5");

  if(parseInt(stair) != stair) {
    alert("정확한 수를 입력하세요!");
    return;
  }else if(stair < 10 || stair > 30) {
    alert("수의 범위는 무조건 10~30이여야 합니다");
    return;
  }else if(t5.run) {
    if(!confirm("이미 진행중인 게임이 있습니다.\n계속하시겠습니까?")) return;
  }

  t5.run = true;
  t5.total = parseInt(stair);
  t5.player0 = 0;
  t5.player1 = 0;

  var output = "<b>Game Start!</b><br>" +
  fixColor(t5color.player0, "★Player") + SPACE + SPACE +
  fixColor(t5color.player1, "★CPU");

  output += "<br><br>" + run5fildCreator(t5.total, 0, 0);

  result5.innerHTML = output;
}

function run5s() {
  run5play(SISSOR);
}

function run5r() {
  run5play(ROCK);
}

function run5p() {
  run5play(PAPER);
}

function run5play(player0) {
  if(!t5.run) {
    alert("게임이 진행중이지 않습니다!");
    return;
  }

  var result5 = document.getElementById("result5");
  var player1 = run5CPU();
  var result = run5RSP(player0, player1);
  var output;

  if(result === -1) {
    output = fixColor("#ff0", "DRAW");
  }else if(result === 0) {
    t5.player0 += run5RSPScore(player0);
    if(t5.player0-1 >= t5.total) {

    }else {
      output = fixColor(t5color.player0, "Player Win");
    }
  }else if(result === 1) {
    output = fixColor(t5color.player1, "CPU Win");
  }
  output += "<br>" +
  fixColor(t5color.player0, "★Player: " + run5RSPtoString(player0)) + SPACE + SPACE +
  fixColor(t5color.player1, "★CPU: " + run5RSPtoString(player1));

  output += "<br><br>" + run5fildCreator(t5.total, t5.player0, t5.player1);

  result5.innerHTML = output;
}

function run5fildCreator(size, player0, player1) {
  var result = "";
  var dup;
  if(player0 === player1) {
    dup = "#ff0";
  }

  for(var e = size; e >= 0; e--) {
    for(var f = 0; f < size; f++) {
      if(e === f) {
        if(player0 === e) {
          if(dup) {
            result += fixColor("#ff0", "★");
          }else {
            result += fixColor(t5color.player0, "★");
          }
        }else if(player1 === e) {
          result += fixColor(t5color.player1, "★");
        }else {
          result += "□";
        }
      }else if(e < f) {
        result += "■";
      }else {
        result += "□";
      }
    }
    result += " [" + fixNum(e) + "]<br>";
  }
  return result;
}

function run5CPU() {
  return parseInt(Math.floor(Math.random()*3));
}

function run5RSP(player0, player1) {
  //-1: draw
  //0: player0 win
  //1: player1 win
  if(player0 == player1) {
    return -1;
  }else if((player0 === ROCK && player1 === SISSOR)
  || (player0 === SISSOR && player1 === PAPER)
  || (player0 === PAPER && player1 === ROCK)) {
    return 0;
  }else {
    return 1;
  }
}

function run5RSPScore(rsp) {
  if(rsp === ROCK) {
    return 2;
  }else if(rsp === SISSOR) {
    return 1;
  }else if(rsp === PAPER) {
    return 3;
  }else {
    return 0;
  }
}

function run5RSPtoString(rsp) {
  if(rsp == ROCK) {
    return "주먹";
  }else if(rsp == SISSOR) {
    return "가위";
  }else if(rsp == PAPER) {
    return "보";
  }else {
    return "알 수 없음";
  }
}

function fixColor(color, str) {
  return "<font color=" + color + ">" + str + "</font>";
}

function fixNum(num) {
  if(num < 10) {
    num = SPACE + SPACE + num;
  }else if(num < 100) {
    num = SPACE + num;
  }
  return num;
}
