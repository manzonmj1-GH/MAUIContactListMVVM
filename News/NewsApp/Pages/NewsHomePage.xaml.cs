using NewsApp.Models;
using NewsApp.Services;
namespace NewsApp.Pages;
public partial class NewsHomePage : ContentPage 
{ 
    public List<Article> ArticleList = new List<Article>(); 
    public List<Category> CategoryList = new List<Category>() 
    { 
        new Category() {Name="World", ImageUrl="world.png"}, 
        new Category() {Name="Nation", ImageUrl="nation.png"}, 
        new Category() {Name="Business", ImageUrl="business.png"}, 
        new Category() {Name="Technology", ImageUrl="technology.png"}, 
        new Category() {Name="Entertainment", ImageUrl="entertainment.png"}, 
        new Category() {Name="Sports", ImageUrl="sports.png"}, 
        new Category() {Name="Science", ImageUrl="science.png"}, 
        new Category() {Name="Health", ImageUrl="health.png"}, 
    };
    public NewsHomePage() 
    { 
        InitializeComponent(); 
        CvCategories.ItemsSource = CategoryList; 
        CvCategories.SelectionChanged += CvCategories_SelectionChanged; 
        CvNews.SelectionChanged += CvNews_SelectionChanged; 
        LoadBreakingNews(); 
    }
    private async void LoadBreakingNews() 
    { 
        var apiService = new ApiService(); 
        var newsResult = await apiService.GetNews("sports"); 
        foreach (var item in newsResult.Articles) 
        { 
            ArticleList.Add(item); 
        } 
        ArticleList = newsResult.Articles; 
        CvNews.ItemsSource = ArticleList; 
    } 
    private async void CvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e) 
    { 
        if (e.CurrentSelection.FirstOrDefault() is Category category) 
        { 
            await Navigation.PushAsync(new NewsListPage(category.Name)); 
        } 
        CvCategories.SelectedItem = null; 
    } 
    private async void CvNews_SelectionChanged(object sender, SelectionChangedEventArgs e) 
    { 
        if (e.CurrentSelection.FirstOrDefault() is Article article) 
        { 
            await Navigation.PushAsync(new NewsDetailPage(article)); 
        } 
        CvNews.SelectedItem = null; 
    } 
} 