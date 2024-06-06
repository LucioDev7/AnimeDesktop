using DesktopAnime.Models;
using DesktopAnime.Repositories;

namespace AnimeReposityTesteo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task TestGetAnimes()
        {
            AnimeRepository animeRepository = new AnimeRepository();
            var animes = await animeRepository.GetAnimesAsync();
            Assert.That(animes.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestGetByIDAnime()
        {
            AnimeRepository animeRepository = new AnimeRepository();
            var anime = await animeRepository.GetByIDAsync("666122b3cdf88b1400001eda");
            Assert.That(anime.nombre, Is.EqualTo("Kenka Dokugaku"));
        }

        [Test]
        public async Task TestPostAnime()
        {
            AnimeRepository animeRepository = new AnimeRepository();
            var anime = await animeRepository.PostAsync("Lucio234", "TipoTest", "GeneroTest", "Desconocido", "https://www3.animeflv.net/uploads/animes/covers/3989.jpg", "https://www.youtube.com/watch?v=Sf7RCzDvJlA&embeds_referring_euri=https%3A%2F%2Fjkanime.net%2F&source_ve_path=MjM4NTE&feature=emb_title", "https://jkanime.net/kenka-dokugaku/9/#option1", 24, "SinopsisTest");
            Assert.That(anime.nombre, Is.EqualTo("Lucio234"));
        }

        [Test]
        public async Task TestPutAnime()
        {
            AnimeRepository animeRepository = new AnimeRepository();
            var anime = await animeRepository.PutAsync("Prueba", "TipoTest", "GeneroTest", "24", "https://www3.animeflv.net/uploads/animes/covers/3989.jpg", "https://www.youtube.com/watch?v=Sf7RCzDvJlA&embeds_referring_euri=https%3A%2F%2Fjkanime.net%2F&source_ve_path=MjM4NTE&feature=emb_title", "https://jkanime.net/kenka-dokugaku/9/#option1", 24, "SinopsisTest", "66614386e97f2d3a00000014");
            Assert.That(anime.nombre, Is.EqualTo("Prueba"));
        }

        [Test]
        public async Task TestDeleteAnime()
        {
            AnimeRepository animeRepository = new AnimeRepository();
            var borrado = await animeRepository.DeleteAsync("66614386e97f2d3a00000014");
            Assert.That(borrado, Is.EqualTo(true));
        }


    }
}