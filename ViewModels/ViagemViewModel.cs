using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viagem.Models;

namespace Viagem.ViewModels
{
    public partial class ViagemViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<ViagemItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;
        public bool ExibirBotao => !IsLastPosicao;

        public ViagemViewModel()
        {
            Itens = new List<ViagemItem>
            {
                new ViagemItem
                {
                    Titulo = "Explore",
                    Subtitulo = "Exotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide.",
                    ImageUrl = "explore.png"
                },

                new ViagemItem
                {
                    Titulo = "Discover",
                    Subtitulo = "Local Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                    ImageUrl = "discovery.png"
                },
                new ViagemItem
                {
                    Titulo = "Plan",
                    Subtitulo = "Your Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                    ImageUrl = "train.png"
                },
                new ViagemItem
                {
                    Titulo = "Capture and Share",
                    Subtitulo = "Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                    ImageUrl = "vacation.png"
                }
            };
        }

        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }
    }
}
