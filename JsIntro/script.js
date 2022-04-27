function GetCurrentDate(){
    console.log("executed GetCurrentDate function");
    return Date();
}
function displayDate(id){
    document.getElementById(id).value = GetCurrentDate();
}

