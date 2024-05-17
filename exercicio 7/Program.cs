using System;

class Program {
    static void Main(string[] args) {
        Playlist playlist = new Playlist("João");

        Musica musica1 = new Musica("Shape of You", "Ed Sheeran", "Atlantic Records");
        Musica musica2 = new Musica("Believer", "Imagine Dragons", "Interscope Records");
        Musica musica3 = new Musica("Bohemian Rhapsody", "Queen", "EMI Records");

        playlist.AdicionarMusica(musica1);
        playlist.AdicionarMusica(musica2);
        playlist.AdicionarMusica(musica3);

        playlist.TocarMusicaAleatoria();
    }
}