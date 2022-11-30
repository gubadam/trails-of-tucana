using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TrailsOfTucana.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TrailsOfTucana.ViewModels {
    public class MainViewModel : BaseViewModel {

        public ICollection<TerrainCard> TerrainCards { get; set; }
        public ObservableCollection<TerrainCard> Items { get; }

        public MainViewModel() {
            Title = "Main";
            NextRoundCommand = new Command(NextRound);

            TerrainCards = new List<TerrainCard>();

            for (int id = 0; id < 27; id++) {
                TerrainCard card = new TerrainCard {
                    Id = id,
                    Terrain = (id <= 7 ? "Pustynia" : id <= 14 ? "Las" : id <= 20 ? "Góry" : id <= 24 ? "Morze" : "Dowolny"),
                    IsDrawn = false,
                };
                TerrainCards.Add(card);
            }
        }

        public ICommand NextRoundCommand { get; }
        public ICommand LoadTerrainCardsCommand { get; }
        
        public void NextRound() {

        }
    }
}