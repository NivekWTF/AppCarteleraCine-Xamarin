using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Practica6_ListView.Models;

namespace Practica6_ListView
{
    public partial class MainPage : ContentPage
    {
        public List<Pelicula> listPeliculas = new List<Pelicula>();

        public MainPage()
        {
            InitializeComponent();
            this.listPeliculas = new List<Pelicula>();
            Pelicula pelicula = new Pelicula()
            {
                Poster = "https://dam.smashmexico.com.mx/wp-content/uploads/2021/12/poster-morbius-clip.jpg",
                Nombre = "Morbius",
                Director = "Daniel Espinosa",
                Horarios = "11:40    -  12;30"
            };
            Pelicula pelicula2 = new Pelicula()
            {
                Poster = "https://m.media-amazon.com/images/I/71hvoqd-X3L._AC_SL1357_.jpg",
                Nombre = "Spiderman 1",
                Director = "Sam Raimi",
                Horarios = "10:40    -  13;30    -   15:50"
            };
            Pelicula pelicula3 = new Pelicula()
            {
                Poster = "https://static.cinepolis.com/img/peliculas/39326/1/1/39326.jpg",
                Nombre = "Lightyear",
                Director = "Angus MacLane",
                Horarios = "10:40    -  13;30    -   15:50"
            };
            Pelicula pelicula4 = new Pelicula()
            {
                Poster = "https://static.cinepolis.com/img/peliculas/39033/1/1/39033.jpg",
                Nombre = "Doctor Strange en el Multiverso de la Locura",
                Director = "Sam Raimi",
                Horarios = "10:40    -  13;30    -   15:50"
            };
            Pelicula pelicula5 = new Pelicula()
            {
                Poster = "https://static.cinepolis.com/img/peliculas/39182/1/1/39182.jpg",
                Nombre = "Jurassic World: Dominio",
                Director = "Colin Trevorrow",
                Horarios = "10:40    -  13;30    -   15:50"
            };
            Pelicula pelicula6 = new Pelicula()
            {
                Poster = "https://static.cinepolis.com/img/peliculas/38740/1/1/38740.jpg",
                Nombre = "Sonic 2: La Película",
                Director = "Colin Raimi",
                Horarios = "10:40    -  13;30    -   15:50"
            };
            Pelicula pelicula7 = new Pelicula()
            {
                Poster = "https://static.cinepolis.com/img/peliculas/38972/1/1/38972.jpg",
                Nombre = "Animales Fantásticos: Los Secretos de Dumbledore",
                Director = "Sam Colin",
                Horarios = "10:40    -  13;30    -   15:50"
            };

            this.listPeliculas.Add(pelicula);
            this.listPeliculas.Add(pelicula2);
            this.listPeliculas.Add(pelicula3);
            this.listPeliculas.Add(pelicula4);
            this.listPeliculas.Add(pelicula5);
            this.listPeliculas.Add(pelicula6);
            this.peliculas.ItemsSource = this.listPeliculas;
        }
    }
}
