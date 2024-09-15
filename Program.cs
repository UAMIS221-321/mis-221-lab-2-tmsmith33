string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
if (stadium != "" && game != "") {
    DisplayStadiumDetails(stadium, game);
} else {
    System.Console.WriteLine("Invalid input. Please try again.");
}


static string GetEnjoymentLevel(){
    Console.WriteLine("What enjoyment level of do you want to experience: Boring, Average, Fun, Epic");
    string enjoymentValue = Console.ReadLine();
    return enjoymentValue;
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "Boring"){
        return "Newland Stadium";
    } else if(enjoymentLevel == "Average"){
        return "Jordan-Hare Stadium";
    } else if(enjoymentLevel == "Fun"){
        return "Tiger Stadium";
    } else if(enjoymentLevel == "Epic"){
        return "Saban Field at Bryant-Denny Stadium";
    } else{
        return "";
    }
}   

static string GetGameRecommendation(string stadium){
    if (stadium == "Newland Stadium"){
        return "vs Kent State";
    } else if(stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    } else if(stadium == "Tiger Stadium"){
        return "vs Alabama";
    } else if(stadium == "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    } else {
        return "";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine("Congratulations you will go to " + stadium + " to watch the game " + game);
}