function validateEmailForm(emailForm) {
  //--- validate first name -------------------------------------------
    validChars = "abcdefghijklmnopqrstuvwxyz ";
  fname = emailForm.firstname.value;

  if(fname.length < 2 || fname.length > 25) {
    alert("Names must be between 2 and 25 letters long." 
      + " Please try again.");
    return false;
  }
  else {
    fnamelowercase = fname.toLowerCase();
    for(i = 0; i < fname.length; i++) {
      if(validChars.indexOf(fnamelowercase.charAt(i)) == -1) {
          alert("First names may only include letters and spaces."
            + " Please try again.");
        return false;               
      } 
    }
  }

  //--- get email (input type=email does validation) ------------------
  emailAddr = emailForm.emailaddr.value;
  //console.log(emailAddr);

  //--- confirm that the user checked 1 or more types of content ------
  contentSelected = "";

  if(emailForm.fish.checked)
    contentSelected += "<li>New fish</li>";
  if(emailForm.cosmetics.checked)
    contentSelected += "<li>New cosmetic items</li>";
  if(emailForm.quests.checked)
    contentSelected += "<li>New hidden quests</li>";
  //console.log(contentSelected);

  if(contentSelected === "") {
    alert("Please select at least one type of content and try again.");
    return false;
  }
    
  //--- display validated data ----------------------------------------
  displayDiv = document.getElementById("formdata");
  displayDiv.style.display = "block";
  displayMsg = "<h5>VALIDATED FORM DATA</h5>"
      + "<span class='txtbold'>Name: </span>" + fname 
      + "</br><span class='txtbold'>Email: </span>" + emailAddr
      + "</br><span class='txtbold'>Selected Content:</span>" 
      + "<ul>" + contentSelected + "</ul>";

  displayDiv.innerHTML = displayMsg;

  return false;
}