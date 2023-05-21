
function CalculoIMC (peso, altura){
    var resultado = peso / (altura * altura)
    return resultado.toFixed(0)
}

console.log("O seu IMC é: " + CalculoIMC(90, 1.87))