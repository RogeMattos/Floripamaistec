fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking')
  .then(response => response.json()) 
  .then(data => {
    // Inverte a lista
    const listaInvertida = data.reverse();

    // resposta da lista no console
    console.log(listaInvertida);
  })
  .catch(error => {
    console.log(error);
  });