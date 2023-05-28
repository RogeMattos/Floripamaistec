
function compararNumero(){

    let numero = document.getElementById("numero").Value
    let resultado = numero

    if(resultado < 10){
     document.getElementById('resultado').innerHTML = "O numero digitado é menor que 10."
    }
    else if(resultado == 10){
     document.getElementById('resultado').innerHTML = "O numero digitado é igual a 10."
    }
    else{
     document.getElementById('resultado').innerHTML = "O numero digitado é maior que 10."
    }
  }