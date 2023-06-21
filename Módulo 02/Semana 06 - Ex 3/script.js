
export function buscaLista(element) {

    fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking')
        .then(response => response.json())
            .then(data => {
              // Inverte a lista
              const listaInvertida = data.reverse();
              // Itera sobre a lista invertida e adiciona os itens ao elemento HTML
                listaInvertida.forEach(item => {
                const div = document.createElement('div');
                div.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;
                element.append(div)
            });

           
        })
        .catch(error => {
            console.log(error);
        });
}









