using CommunityToolkit.Maui.Core.Views;

namespace MauiRepro;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void Save_Clicked(object sender, EventArgs e) {

		float w = (float)Canvas.Width;
		float h = (float)Canvas.Height;

		// Draw a line across the canvas or else it gets cropped to the used part of it
		DrawingLine dl = new();
		dl.LineColor = Colors.Transparent;
		dl.LineWidth = 0;
		dl.Points.Add(new(0, 0));
		dl.Points.Add(new(w, h));
		Canvas.Lines.Add(dl);
		
		using Stream stream = await Canvas.GetImageStream(w, h);
		MemoryStream ms = new();
		stream.CopyTo(ms);
		//await File.WriteAllBytesAsync(Android.App.Application.Context.GetExternalFilesDir(null) + "/test.bmp", ms.ToArray());
		ms.Position = 0;
		imgSaved.Source = ImageSource.FromStream(() => ms);
	}
}

