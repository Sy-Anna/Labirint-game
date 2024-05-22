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
	/// Interaction logic for Settings.xaml
	/// </summary>
	public partial class Settings : Window
	{
		string theme;
		string background;
		string gamemode;
		public Settings()
		{
			InitializeComponent();
		}


		private void inSettingsStartBtn_Click(object sender, RoutedEventArgs e)
		{
			Game game = new Game(theme, background, gamemode);
			this.Hide();
			game.Show();
		}



		private void ThemeSettings()
		{

		}

		private void lightThemeRdb_Checked(object sender, RoutedEventArgs e)
		{
			theme = "light";
		}

		private void darkThemeRdb_Checked(object sender, RoutedEventArgs e)
		{
			theme = "dark";
		}

		private void SpongeBobRdb_Checked(object sender, RoutedEventArgs e)
		{
			background = "SpongeBob";
		}

		private void brickWallRdb_Checked(object sender, RoutedEventArgs e)
		{
			background = "brickWall";
		}

		private void starsRdb_Checked(object sender, RoutedEventArgs e)
		{
			background = "stars";
		}

		private void survivalRdb_Checked(object sender, RoutedEventArgs e)
		{
			gamemode = "survival";
		}

		private void godModeRdb_Checked(object sender, RoutedEventArgs e)
		{
			gamemode = "godMode";
		}
	}
}
