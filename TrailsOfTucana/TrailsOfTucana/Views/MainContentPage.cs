using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrailsOfTucana.Models;
using Xamarin.Forms;

namespace TrailsOfTucana.Views {
    public class MainContentPage : ContentPage {

        public ICollection<TerrainCard> TerrainCards { get; set; }
        public int roundNumber { get; private set; }
        public Button nextRoundButton { get; private set; }
        public Label textLabel { get; private set; }

        public MainContentPage() {

            // Data
            TerrainCards = new List<TerrainCard>();
            for (int id = 0; id < 27; id++) {
                TerrainCard card = new TerrainCard {
                    Id = id,
                    Terrain = (id <= 7 ? "Pustynia" : id <= 14 ? "Las" : id <= 20 ? "Góry" : id <= 24 ? "Morze" : "Dowolny"),
                    IsDrawn = false,
                };
                TerrainCards.Add(card);
            }

            roundNumber = 0;

            // View
            Title = "Wyspy Tukana";

            nextRoundButton = new Button {
                Text = "Następna runda: " + (roundNumber < 13 ? roundNumber + 1 + "/13" :  "1/13" ),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            textLabel = new Label {
                Text = "Zacznij grę klikając w przycisk '" + nextRoundButton.Text + "'",
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            nextRoundButton.Clicked += async (sender, args) => {
                nextRoundButton.IsEnabled = false;
                if (roundNumber < 13) {
                    roundNumber++;
                    textLabel.Text = "Runda: " + roundNumber + "\nKarty: " + DrawTerrainCard() + " i " + DrawTerrainCard();
                } else if (roundNumber == 13) {

                }
                
                if (roundNumber == 13) {
                    textLabel.Text += "\nRysujemy i liczymy punkty!";
                    roundNumber = 0;
                    Reshuffle();
                }

                nextRoundButton.Text = "Następna runda: " + (roundNumber < 13 ? roundNumber + 1 + "/13" : "1/13");

                await textLabel.RelRotateTo(360, 1000);
                nextRoundButton.IsEnabled = true;
            };


            Content = new StackLayout {
                Children = {
                    textLabel,
                    nextRoundButton
                }
            };
        }

        private string DrawTerrainCard() {
            var random = new Random();

            var subList = TerrainCards.Where(c => c.IsDrawn == false).ToList();

            int randomIndex = random.Next(subList.Count);

            var randomCard = subList[randomIndex];
            TerrainCards.Where(c => c.Id == randomCard.Id).First().IsDrawn = true;
            return randomCard.Terrain;
        }

        private void Reshuffle() {
            foreach (TerrainCard card in TerrainCards) {
                card.IsDrawn = false;
            }
        }
    }
}