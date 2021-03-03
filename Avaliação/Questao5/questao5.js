const musicas = []
const nomeMusicas = []
function inserirMusicaArray () {

    var aux = 0
    this.setInfo = (nome, artista, duracao) => {
        this.nome = nome
        this.artista = artista
        this.duracao = duracao
        
        musicas[aux] = {nome, artista, duracao}
        aux++

        return musicas
    }
    
    this.getResultadoNomes = () => {
        for (cadaMusica in musicas) {
           if (cadaMusica !== null) nomeMusicas.push(musicas[cadaMusica].nome)
        }

        for (let y = 0; y < aux; y++) console.log(nomeMusicas[y])
    }

    this.getDuracaoTotal = () => {
        let minutos = parseInt(0)
        let segundos = parseInt(0)

        for (let i = 0; i < aux; i++) {
          minutos += parseInt(musicas[i].duracao.substring(0, 2))
          segundos += parseInt(musicas[i].duracao.substring(3, 5))
        }
        let horas = parseInt(minutos/60)

        minutos %= parseInt(60)
        minutos += parseInt(segundos/60)
        segundos %= parseInt(60)

        return `A duração total das músicas da playlist é de ${horas} horas, ${minutos} minutos e ${segundos} segundos`;
      
    }
}

const getMusica = new inserirMusicaArray()

let m1 = getMusica.setInfo('Next to Me', 'Imagine Dragons', '03:50') //add musica
let m2 = getMusica.setInfo('XO', 'John Mayer', '03:33')
let m3 = getMusica.setInfo('Small Bump', 'Ed Sheeran', '04:19')
let m4 = getMusica.setInfo('State Lines', 'Novo Amor', '03:28')
let m5 = getMusica.setInfo('Tenerife Sea', 'Ed Sheeran', '04:01')
let m6 = getMusica.setInfo('Selva Branca', 'Chiclete com Banana', '05:02')

getMusica.getResultadoNomes()
console.log(getMusica.getDuracaoTotal())
