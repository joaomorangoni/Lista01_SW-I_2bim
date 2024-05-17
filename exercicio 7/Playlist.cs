using System;

class Playlist {
    private List<Musica> musicas;
    private string donoPlaylist;
    private Random random;

    public Playlist(string donoPlaylist) {
        musicas = new List<Musica>();
        this.donoPlaylist = donoPlaylist;
        random = new Random();
    }

    public void AdicionarMusica(Musica musica) {
        musicas.Add(musica);
    }

    public void TocarMusicaAleatoria() {
        if (musicas.Count == 0) {
            Console.WriteLine("Playlist vazia. Adicione músicas primeiro.");
            return;
        }
        int indiceAleatorio = random.Next(musicas.Count);
        Musica musicaAleatoria = musicas[indiceAleatorio];
        Console.WriteLine($"Tocando música: {musicaAleatoria.Nome}");
    }
}