// Change Text Task
document.getElementById('changeTextButton').addEventListener('click', function () {
    document.getElementById('text').innerText = 'New Text';
});

// Change Color Task
document.getElementById('changeColorButton').addEventListener('click', function () {
    document.getElementById('colorText').setAttribute('class', 'newColor');
});

// Input Validation Task
document.getElementById('validateButton').addEventListener('click', function () {
    var input = document.getElementById('numberInput').value;
    var number = +input; // Convert to number
    var resultText = number > 100 ? "תקין" : "לא תקין";
    document.getElementById('result').innerText = resultText;
});