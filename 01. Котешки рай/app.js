const footers = document.querySelectorAll("footer")
const body = document.querySelector("body")
const li = document.querySelectorAll("li")

footers.forEach((footer) => footer.addEventListener("click", () => { 
    body.style.background = "#b36a5e"
    
}))