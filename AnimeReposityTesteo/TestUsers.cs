using DesktopAnime;
using DesktopAnime.Models;
using DesktopAnime.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeReposityTesteo
{
    public class TestUsers
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task TestGetUsarios()
        {
            UserRepository userRepository = new UserRepository();
            var usuario = await userRepository.GetUsersAsync();
            Assert.That(usuario.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestGetByIDUsuarios()
        {
            UserRepository userRepository = new UserRepository();
            var user = await userRepository.GetByIDAsync("6661fa0de97f2d3a00001974");
            Assert.That(user.usuario, Is.EqualTo("admin"));
        }

        [Test]
        public async Task TestPostUsuarios()
        {
            UserRepository userRepository = new UserRepository();
            var user = await userRepository.PostAsync("pianettilucio3@gmail.com", "Contra", "Usu", "Empleado");
            Assert.That(user.usuario, Is.EqualTo("Usu"));
        }

        [Test]
        public async Task TestPutUsuarios()
        {
            UserRepository userRepository = new UserRepository();
            var user = await userRepository.PutAsync("pianettilucio0@gmail.com", "Cambiado", "Cambiado", "Cambiado", "66628cba855eef4300000023");
            Assert.That(user.usuario, Is.EqualTo("Cambiado"));
        }

        [Test]
        public async Task TestDeleteUsuario()
        {
            UserRepository userRepository = new UserRepository();
            var borrado = await userRepository.DeleteAsync("6661fa34e97f2d3a00001978");
            Assert.That(borrado, Is.EqualTo(true));
        }

        [Test]
        public async Task TestGetUserDataAsync()
        {
            UserRepository userRepository = new UserRepository();
            var user = await userRepository.GetUserDataAsync("admin");
            Assert.That(user.usuario, Is.EqualTo("admin"));
        }

        [Test]
        public async Task TestVerifyCredentialsAsync()
        {
            UserRepository userRepository = new UserRepository();
            var usuario = await userRepository.VerifyCredentialsAsync("admin", "admin");
            Assert.That(usuario, Is.EqualTo(true));
        }
    }
}