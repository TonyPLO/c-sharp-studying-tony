console.log("outer file - izhar script");

smallLetterFunction();//invoke fucntion (קריאה לפונקציה)

let result = addAction(5, 6);
console.log("result = " + result);

document.getElementById("changeMe1").innerHTML = "Hellow JavaScript";
document.getElementById("changeMe1").addEventListener("click", addOtherElement);

function addOtherElement() {
    console.log("addOtherElement")
    const node = document.createElement("h2");
    node.innerHTML = "New element";
    document.body.appendChild(node);
}

/**
 * 
 * console.log("result = " + result);
    private int seatsCount = 0;//5,000 - 70,000
        private string city = "";
        private bool isOpen = false;
 * 
 */
//object
let stadium = {
    seatCount: 0,
    city: "NA",
    isOpen: false
}
stadium.seatCount = 20;

console.log("object - ", stadium);
console.table(stadium);



function smallLetterFunction() {
    console.log("hi function");
}

function addAction(x, y) {
    return x + y;
}

console.log("continue  ");
