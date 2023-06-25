const listaDados = [
  {
    titulo: "Floresta Brasileira",
    imagem:
      "https://i2.wp.com/files.agro20.com.br/uploads/2019/07/floresta-amazonica-2.jpg?resize=600%2C338&ssl=1",
    subtitulo:
      "Florestas sendo devastadas",
  },
  {
    titulo: "Fauna Brasileira",
    imagem:
      "https://www.infoescola.com/wp-content/uploads/2008/05/onca-pintada-591459416.jpg",
    subtitulo:
      "Animais em extinção",
  },
  {
    titulo: "Crise Econômica",
    imagem:
      "https://s2.glbimg.com/IXrw7WfWnbXI5NqqQlXeyoFAEk0=/403x136:2106x1108/924x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_f035dd6fd91c438fa04ab718d608bbaa/internal_photos/bs/2020/z/c/8zFznaQIiXvkZ5XAH6Hw/lupa.jpg",
    subtitulo: "Déficiti de investimentos",
  },
  {
    titulo: "Educação",
    imagem:
      "https://img.freepik.com/fotos-premium/ilustracao-2d-da-sala-de-aula-a-noite_141465-61.jpg",
    subtitulo:
      "Crise na Educação do Brsail",
  },
  {
    titulo: "Polítca",
    imagem:
      "https://www.tse.jus.br/imagens/fotos/voto-eletronico-diminui-votos-invalidos-em-09-08.2022-871827/@@images/6eb11c3a-ca78-4b58-9c5c-1642f37c3ad3.jpeg",
    subtitulo:
      "Será que houve fraude nas últimas eleições?",
  },
  {
    titulo: "Agricultura",
    imagem:
      "https://terramagna.com.br/wp-content/uploads/2022/07/Colheitadeira-trigo-lavoura.jpg",
    subtitulo: "Reforma agrária",
  },
  {
    titulo: "Música Brasileira",
    imagem:
      "https://1.bp.blogspot.com/-CaF5tpMzwsQ/Xai2lVNDiEI/AAAAAAAAfy0/QgOU_yx-bQ0vLujllX-l1TTnw2mYvPh6ACLcBGAsYHQ/s1600/MPB.jpg",
    subtitulo: "Música brasileira no top mundial?",
  },
  {
    titulo: "carros Importados",
    imagem:
      "https://1.bp.blogspot.com/-ix_6eVVPZqs/XUGK_rNFsII/AAAAAAAAB7g/Yupooow4EH8-6avY3yx0felFsKLyO0f7wCLcBGAs/s1600/Volvo-XC60-2020-China%2B%25282%2529.jpg",
    subtitulo:
      "carros importados vão substituir os nacionais??",
  },
  {
    titulo: "Literatura",
    imagem:
      "https://www.intersaberes.com/wp-content/uploads/2022/05/AdobeStock_215842088-1-1024x576.jpeg",
    subtitulo:
      "Porque os Brasileiros não tem o hpábitoda leitura?",
  },
];


if (sessionStorage.getItem("listaDados") == null) {
  alert("Sim, eu não botei nada no header e no menu... desculpa");
  sessionStorage.setItem("listaDados", JSON.stringify(listaDados));
}

let listaDeDados = JSON.parse(sessionStorage.getItem("listaDados"));

function gerarCards(dados) {
  let listagemCards = document.getElementById("listagem-cards");
  listagemCards.innerHTML = "";
  dados.forEach((dado, index) => {
    listagemCards.innerHTML += `
    <div id=card_${index} class="card" >
      <div class="card-titulo">${dado.titulo}</div>
      <img src="${dado.imagem}" alt="...">
      <div class="card-subtitulo">${dado.subtitulo}</div>
    </div>
    `;
  });
}

document.querySelector(".busca > input").addEventListener("keyup", (e) => {
  let dadosFiltrados = []
    listaDeDados.forEach((dado) => {
      if (dado.titulo.toLowerCase().includes(e.target.value.toLowerCase()) || dado.subtitulo.toLowerCase().includes(e.target.value.toLowerCase())) {
        dadosFiltrados.push(dado) 
      }    
    })
    if (e.target.value == "") {
      dadosFiltrados = listaDeDados
    }
    gerarCards(dadosFiltrados)
  }
)

document.querySelector(".busca > button").addEventListener("click", (e) => {
  let dadosFiltrados = []
  let input = prompt("Digite o que deseja buscar")
    listaDeDados.forEach((dado) => {
      if (dado.titulo.toLowerCase().includes(input.toLowerCase()) || dado.subtitulo.toLowerCase().includes(input.toLowerCase())) {
        dadosFiltrados.push(dado)
      }
    })
    if (input == "") {
      dadosFiltrados = listaDeDados
    }
    document.querySelector(".busca > input").value = input
    gerarCards(dadosFiltrados)
  }
)

gerarCards(listaDeDados);



