var toggle1 = true, toggle2 = false;

//This is toggle!
function func1() {
  if(toggle1) {
    $("#imgDiv").hide();
    toggle1 = false;
  }else {
    $("#imgDiv").show();
    toggle1 = true;
  }
}

//And this is also toggle!
function func2() {
  if(toggle2) {
    $("#textDiv").removeClass("colorSwap");
    //setTimeout 0 is start in next tick (will reset animation)
    setTimeout(function() {$("#textDiv").addClass("colorSwapReverse")}, 0);
    toggle2 = false;
  }else {
    $("#textDiv").removeClass("colorSwapReverse");
    setTimeout(function() {$("#textDiv").addClass("colorSwap")}, 0);
    toggle2 = true;
  }

}
