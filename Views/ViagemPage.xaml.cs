using Viagem.ViewModels;

namespace Viagem.Views;

public partial class ViagemPage : ContentPage
{
	public  ViagemPage(ViagemViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}