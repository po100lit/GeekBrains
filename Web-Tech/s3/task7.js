user_age = prompt('Сколько вам лет?');
switch (parseInt(user_age)){ // вместо parseInt можно использовать "+user_age"
    case 10:
        alert('Детсво');
        break;
    case 18:
        alert('Юность');
        break;
    case 30:
        alert('Взрослая жизнь');
        break;
    default:
        alert('Нет вариантов');
        break;
}