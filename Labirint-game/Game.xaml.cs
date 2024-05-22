using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Labirint_game
{
	/// <summary>
	/// Interaction logic for Game.xaml
	/// </summary>
	public partial class Game : Window
	{
		string theme;
		string background;
		string gamemode;
		public Game(string tm, string bg, string gm)
		{
			InitializeComponent();
			theme = tm;
			background = bg;
			gamemode = gm;
		}

		private void inGameSettingsBtn_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			this.Hide();
			mainWindow.Show();
			showProperities();
		}

		private void showProperities()
		{
			switch (theme)
			{
				case "light":
					themeLbl.Content = "Téma: Világos";
					break;
				case "dark":
					themeLbl.Content = "Téma: Sötét";
					break;
			}
			switch (background)
			{
				case "SpongeBob":
					backgroundLbl.Content = "Háttér: Spongyabob";
					break;
				case "brickWall":
					backgroundLbl.Content = "Háttér: Téglafal";
					break;
				case "star":
					backgroundLbl.Content = "Háttér: Csillagok";
					break;
			}
			switch (gamemode)
			{
				case "survival":
					gamemodeLbl.Content = "Játékmód: Túlélő";
					break;
				case "godMode":
					gamemodeLbl.Content = "Játékmód: God mode";
					break;
			}
		}
	}
}
