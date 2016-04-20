'use strict';

var div = document.getElementById("calendar");
if(div == null) {
  alert("Null calendar");
}else {
  var date = new Date();
  var cal = "<table>";
  cal += "<caption>" + (date.getMonth()+1) + " 월</caption>"
  cal += "<tr><th>일</th><th>월</th><th>화</th><th>수</th><th>목</th><th>금</th><th>토</th></tr>";
  var index = 0;
  while(index < getMaxDate(date.getMonth()+1)) {
    var tmp = createTableLine(date, index);
    index = tmp[0];
    cal += tmp[1];
  }
  cal += "</table>";
  div.innerHTML = cal;
  $.getJSON("json/calendar.json").done(function(data) {
    alert(data);
  });
}

function createTableLine(date, index) {
  var line = "<tr>";
  var max = getMaxDate(date.getMonth()+1);
  return [99/*index*/, line + "</tr>"];
}

function getMaxDate(month) {
  switch(month) {
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
      return 31;
    case 2:
      return 28;
    default:
      return 30;
  }
}
