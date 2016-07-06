using System;
using Xamarin.Forms;

namespace ChapterThree
{
	public partial class ChapterThreePage : ContentPage
	{


		void idunno(object sender, TextChangedEventArgs e)
		{
			try 
			{
				String s= e.NewTextValue.Replace(" " , "");
				int x = s.Length;
				labe.Text = e.NewTextValue + "\n Lenght : " + x +"\n sdsa :" +s.Trim();
				 

			}
			catch (System.NotImplementedException)
			{ 
				//ang mahiwagang minsahe
			}
		}
		Label labe = new Label
		{
			Text = "",
			HorizontalOptions = LayoutOptions.Start,
			VerticalOptions = LayoutOptions.Center,

		};



		public ChapterThreePage()
		{
			InitializeComponent();

			Entry entry1 = new Entry { 
				Text ="",
				Placeholder="I dont know",
				//HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
							                
			};

			entry1.TextChanged += idunno;

			StackLayout stackOne = new StackLayout
			{
				Spacing = 5,
				BackgroundColor=Color.Aqua,
				Orientation = StackOrientation.Horizontal ,
				HorizontalOptions=LayoutOptions.CenterAndExpand,
				Children = {
				new Label
		{
			Text = "First",
			HorizontalOptions= LayoutOptions.Start,
			VerticalOptions = LayoutOptions.Center,
		},
				new Label
		{
			Text = "Middle",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.End,
		},
				new Label
		{
			Text = "Last",
			HorizontalOptions = LayoutOptions.End,

		},
					entry1
			},
				HeightRequest = 1500
			};
			StackLayout stackTwo = new StackLayout
			{
				Spacing = 5,
				BackgroundColor=Color.Blue,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = {
				new Label
		{
			Text = "Second First",
			HorizontalOptions= LayoutOptions.StartAndExpand,
		},
				new Label
		{
			Text = "Second Second",
			HorizontalOptions = LayoutOptions.Center,
		},

					new StackLayout{
				Spacing = 5,
				BackgroundColor = Color.Lime,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.EndAndExpand,
				Children = {
				new Label
		{
			Text = "Third First",
			HorizontalOptions= LayoutOptions.Start,
		},


			},
				HeightRequest = 1500
					}
				
			},
				HeightRequest = 1500,



			};


			StackLayout stackThree = new StackLayout
			{
				Spacing = 5,
				BackgroundColor = Color.Lime,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.EndAndExpand,
				Children = {
				new Label
		{
			Text = "Third First",
			HorizontalOptions= LayoutOptions.Start,
		},
					labe

			},
				HeightRequest = 1500
			};

			ScrollView scrollView = new ScrollView
			{
				//BackgroundColor = Color.White,

				VerticalOptions = LayoutOptions.Fill,
				Content = stackThree
			};

			StackLayout stackAll = new StackLayout
			{
				Spacing = 20,
				BackgroundColor = Color.Yellow,
				Orientation = StackOrientation.Vertical,

				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					stackOne,
					stackTwo,
					scrollView,
			},
				HeightRequest = 1500
			};

			this.Content = stackAll;
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

		}

}
}

