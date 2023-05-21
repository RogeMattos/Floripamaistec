
function calcularImc(){
    var peso = document.getElementById("Peso").value
    var altura = document.getElementById("Altura").value
    var IMC = peso / (altura * altura);

    document.getElementById("Resultado").innerHTML = "O seu IMC é " + IMC.toFixed(2)
}