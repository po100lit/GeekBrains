
function showName() {
    user_name = prompt("Введите имя");
    document.getElementById("result").innerHTML = ""
    document.getElementById("result").append(`Ваше имя: ${user_name}`);
}
