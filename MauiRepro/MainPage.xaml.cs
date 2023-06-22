namespace MauiRepro;

public partial class MainPage : ContentPage {
	public MainPage() {
		InitializeComponent();
	}

	private void Enable_Clicked(object sender, EventArgs e) {
		TestBtn.IsEnabled = true;
	}

	private void Disable_Clicked(object sender, EventArgs e) {
		TestBtn.IsEnabled = false;
	}

	private void Enable_TextChanged(object sender, TextChangedEventArgs e) {
		TestBtn.IsEnabled = true;
	}

	private void Disable_TextChanged(object sender, TextChangedEventArgs e) {
		TestBtn.IsEnabled = false;
	}
}

