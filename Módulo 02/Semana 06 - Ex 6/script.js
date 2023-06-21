export function buscaLista(element) {
    fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking')
        .then(response => response.json())
        .then(data => {
            // Inverte a lista
            let listaInvertida = data.reverse();
            //filtro para verificar nomes que não tem a letra 'A' e quais tem menos de 6 letras
            const listaFiltrada = listaInvertida.filter(item => item.nome.toLowerCase().includes('a') && item.nome.length < 6);
            // Itera sobre a lista invertida e adiciona os itens ao elemento HTML
            listaFiltrada.forEach(item => {
                const div = document.createElement('div');
                div.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;
                element.append(div)
            });


        })
        .catch(error => {
            console.log(error);
        });


}
