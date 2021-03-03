const musicas = []

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
    
    this.getResultado = () => {
        for (cadaMusica in musicas){
           if (cadaMusica !== null) console.log(musicas[cadaMusica].nome)
        }
    }

    let horas, minutos, segundos
    
    this.duracaoTotal = () => {
        horas = parseInt(0)
        minutos = parseInt(this.duracao.substring(0, 2))
        segundos = parseInt(this.duracao.substring(3, 5))

        for (aux in musicas) {
            if (aux == 0) {
                continue
            }
            segundos = segundos + segundos
            minutos = minutos + minutos
            horas = horas + horas
        }

        if (minutos > 60) {
            minutos = minutos % 60
            horas += 1 
        }
        
        if (segundos > 60) {
            segundos = segundos % 60
            minutos += 1 
        }  

        return `A duração total das músicas da playlist é de ${horas} horas, ${minutos} minutos e ${segundos} segundos`
    }
}

const getMusica = new inserirMusicaArray()
let m1 = getMusica.setInfo('Next to Me', 'Imagine Dragons', '03:50') //add musica
let m2 = getMusica.setInfo('XO', 'John Mayer', '03:33')
//let m3 = getMusica.setInfo('Small Bump', 'Ed Sheeran', '04:19')
//let m4 = getMusica.setInfo('State Lines', 'Novo Amor', '03:28')

getMusica.getResultado()
console.log(getMusica.duracaoTotal())

