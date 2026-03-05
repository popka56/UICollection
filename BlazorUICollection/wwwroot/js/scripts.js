// Game list functions
function setPointer(id) {
    element = document.getElementById(id);
    element.classList.add("pointer");
}

function removePointer(id) {
    element = document.getElementById(id);
    element.classList.remove("pointer");
}