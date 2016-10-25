function initClick() {
  $("#initBtn").hide();
  $("#before").fadeOut(1000);
  $("#after").fadeIn(1000);
  $("header").show();
  $("header").addClass("slideDown");
}

function whyClick() {
  $(".content").hide();
  $("#ken").show();
}

function helpClick() {
  $(".content").hide();
  $("#reg").show();
}

function submitClick() {
  alert(":>");
}
