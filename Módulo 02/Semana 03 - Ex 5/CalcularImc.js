function calcularImc(){
    var peso = document.getElementById("Peso").value
    var altura = document.getElementById("Altura").value
    var IMC = peso / (altura * altura);

    document.getElementById("Resultado").innerHTML = "O seu IMC é " + IMC.toFixed(2)

    
    var classificacao = 0

if(IMC <= 18.5){
    classificacao = "Abaixo do peso"
}else if(IMC >= 18.5 && IMC <= 24.99){
     classificacao = "Peso Normal"
}else if(IMC>= 25.0 && IMC <= 29.99 ){
    classificacao = "Sobrepeso"
}else if(IMC >= 30.0 && IMC <= 34.99 ){
    classificacao = "Obesidade grau 1"
}else if(IMC >= 35.00 && IMC <= 39.99){
    classificacao = "Obesidade grau 2"
}else if(IMC >= 40.0){
    classificacao = "Obesidade grau 3 (mórbida)"
}

var imcTabela = document.getElementById('imcTabela')
imcTabela.innerHTML = IMC.toFixed(2)

var classTabela = document.getElementById('classTabela')
classTabela.innerHTML = classificacao




var tabelaResultado = document.getElementById("tabelaResultado")
tabelaResultado.removeAttribute("hidden")




}





