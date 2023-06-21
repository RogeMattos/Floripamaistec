fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking')
  .then(response => response.json()) 
  .then(data => {
    // Inverte a lista
    const listaInvertida = data.reverse();
    

    // Seleciona o elemento HTML onde serão adicionados os dados
    const lista = document.getElementById('dados');

    // Itera sobre a lista invertida e adiciona os itens ao elemento HTML
    listaInvertida.forEach(item => {
      const div = document.createElement('div');
      div.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;
      lista.appendChild(div);
    });

    // Resposta da lista no console
    console.log(listaInvertida);
  })
  .catch(error => {
    console.log(error);
  });