using NewsApp.Models;
using NewsApp.Services;
namespace NewsApp.Pages;

public partial class NewsListPage : ContentPage
{
	ApiService apiService = new ApiService();
	string categoryName;
	public NewsListPage(string category)
	{
		InitializeComponent();

		categoryName = category;

		Title = $"{category} News";
		LoadNewsChannel();
        CvArticles.SelectionChanged += CvArticles_SelectionChanged;
	}
	async void LoadNewsChannel()
	{
		var news = await apiService.GetNews(categoryName);
        CvArticles.ItemsSource = news.Articles;
	}

	private async void CvArticles_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.FirstOrDefault() is Article article)
		{
			await Navigation.PushAsync(new NewsDetailPage(article));
		}

		CvArticles.SelectedItem = null;
	}
}