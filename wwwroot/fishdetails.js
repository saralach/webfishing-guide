async function getFishDetails() {

    // Get species from querystring
    let params = (new URL(document.location)).searchParams;
    console.log(params);
    let species = params.get("species");

    // Update page title
    if(species != null) 
        document.title = species + " | Webfishing Guide";

    //Get fish details from API
    response = await fetch("api/Fish/GetFishByName/" + species);
    fish = await response.json();
    console.log(fish);

    //Update display
    document.getElementById("species").innerHTML = fish.Species;

    imgUrl = "Images/" + fish.Category + "/" + fish.Species.replaceAll(" ", "_");
    if(fish.Species === "CREATURE")
        imgUrl += ".gif";
    else
        imgUrl += ".png";
    document.getElementById("fishpic").src = imgUrl;

    document.getElementById("desc").innerHTML = fish.Description;

    document.getElementById("baserate").innerHTML = parseFloat((fish.BaseCatchRate* 100).toFixed(3)) + "%";
    console.log(parseFloat(fish.BaseCatchRate) * 100)
    document.getElementById("sparklingrate").innerHTML = parseFloat((fish.SparklingLureRate* 100).toFixed(3)) + "%";
    document.getElementById("flyrate").innerHTML = parseFloat((fish.FlyHookRate* 100).toFixed(3)) + "%";
    document.getElementById("largerate").innerHTML = parseFloat((fish.LargeLureRate* 100).toFixed(3)) + "%";
    document.getElementById("magnetrate").innerHTML = parseFloat((fish.MagnetHookRate* 100).toFixed(3)) + "%";
    document.getElementById("goldenrate").innerHTML = parseFloat((fish.GoldenHookRate* 100).toFixed(3)) + "%";
}