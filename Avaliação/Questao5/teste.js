const musicas = []
function inserirMusicaArray () {
    
    var aux = 0
    this.setInfo = (nome, artista, duracao) => {
        this.nome = nome
        this.artista = artista
        this.duracao = duracao
        
        musicas[aux] = {nome, artista, duracao}

        return musicas
    }

    this.getResultadoNomes = () => {
        for (cadaMusica in musicas){
           if (cadaMusica !== null) console.log(musicas[cadaMusica].artista)
        }
    }
}

const getMusica = new inserirMusicaArray()
getMusica.setInfo('Next to Me', 'Imagine Dragons', '03:50')
console.log(musicas)
console.log(getMusica.getResultadoNomes())