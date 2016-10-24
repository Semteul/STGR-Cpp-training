"use strict";

let pics = [
  ["Pig", "http://kids.nationalgeographic.com/content/dam/kids/photos/animals/Mammals/H-P/pig-young-closeup.jpg.adapt.945.1.jpg"],
  ["Dog", "https://i.ytimg.com/vi/opKg3fyqWt4/hqdefault.jpg"],
  ["Chicken", "http://www.pets4homes.co.uk/images/articles/1847/large/10-faqs-answers-about-chicken-keeping-53c2ece3f2d5c.jpg"]

  //Do you want to see more?
  //Download this html in
  //[http://notborder.org/lyk/hw/CIGE-First-Jquery/pkg.zip]
  //and Comment in below lines!

  //,["Rabbit", "https://a2ua.com/animal/animal-028.jpg"],
  //["Tiger", "http://s2.acorneplc.info/content/img/product/main/adopt-an-animal-05151432.jpg"]
];


$(document).ready(()=>{
  //Reset
  $("#content").empty();
  $("#buttons").empty();

  for(let i = 0; i < pics.length; i++) {
    $("#content").append("<img id='"+pics[i][0]+"' alt='"+pics[i][0]+"' src='"+pics[i][1]+"' />");
    $("#buttons").append("<button id='"+pics[i][0]+"Btn'>"+pics[i][0]+"</button>");

    $("#"+pics[i][0]+"Btn").click(()=>{
      //Show selected Picture
      $("#"+pics[i][0]).show();
      for(let o = 1; o < pics.length; o++) {
        //Hide another
        $("#"+pics[(i+o)%pics.length][0]).hide();
      }
    })
  }
});
