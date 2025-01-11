allFish = null;

async function getFish() {
    // ========================= GET ALL FISH FROM API =========================
    response = await fetch("api/Fish/GetAllFish");
    allFish = await response.json();
    //console.log(allFish);

    numFish = allFish.length;
    //console.log(numFish);

    // ================== COUNT NUM OF FISH IN EACH CATEGORY ===================
    // =============== (and display in top section of fish.html) ===============
    numFresh = 0;
    numSalt  = 0;
    numRain  = 0;
    numJunk  = 0;
    numMisc = 0;
    category = "";
    allFish.forEach((fish) => {
        //console.log(fish);
        category = fish.category;
        //console.log(category);
        if (category === "Freshwater")
            numFresh++;
        else if (category === "Saltwater")
            numSalt++;
        else if (category === "Rain")
            numRain++;
        else if (category === "Junk")
            numJunk++;
        else
            numMisc++;
    });
    
    // ================= ADD COUNTS TO TOP SECTION AND DISPLAY =================
    document.getElementById("fishintro").innerHTML = "There are " + numFish
        + " types of fish that can be caught in webfishing. This includes "
        + numFresh + "&nbsp;<a href=\"#freshwater\">freshwater&nbsp;fish</a>, "
        + numSalt + "&nbsp;<a href=\"#saltwater\">saltwater&nbsp;fish</a>, "
        + numRain + "&nbsp;<a href=\"#rain\">rain&nbsp;fish</a>, "
        + numMisc + "&nbsp;<a href=\"#misc\">miscellaneous&nbsp;fish</a>, and "
        + numJunk + "&nbsp;<a href=\"#junk\">junk&nbsp;items</a>.";
        // ^ NOTE: I'm using &nbsp as opposed to spaces to avoid line breaking 
        // in undesirable locations (such as breaking in the middle of a link 
        // or breaking in between the number and the category it corresponds to).

    // ========== CREATE AND DISPLAY "BUTTONS" (LINKS) FOR EACH FISH ===========
    freshHTML = "";
    saltHTML = "";
    rainHTML = "";
    junkHTML = "";
    miscHTML = "";
    allFish.forEach((fish) => {
        imgSrc = "Images/" + fish.category + "/" + fish.species.replaceAll(" ", "_");
        if (fish.species === "CREATURE")
            imgSrc += ".gif";
        else
            imgSrc += ".png";
        htmlToAdd = "<a href=\"fishdetails.html?species=" + fish.species 
            + "\" target=\"_blank\"> <img src=\"" + imgSrc +  "\" alt=\"" 
            + fish.species + "\" /> <h6>" + fish.species + "</h6> </a> ";
        //console.log(htmlToAdd);
        
        if (fish.category === "Freshwater")
            freshHTML += htmlToAdd;
        else if (fish.category === "Saltwater")
            saltHTML += htmlToAdd;
        else if (fish.category === "Rain")
            rainHTML += htmlToAdd;
        else if (fish.category === "Junk")
            junkHTML += htmlToAdd;
        else
            miscHTML += htmlToAdd;
    });

    document.getElementById("freshwaterfish").innerHTML = freshHTML;
    document.getElementById("saltwaterfish").innerHTML = saltHTML;
    document.getElementById("rainfish").innerHTML = rainHTML;
    document.getElementById("miscfish").innerHTML = miscHTML;
    document.getElementById("junkitems").innerHTML = junkHTML;
}