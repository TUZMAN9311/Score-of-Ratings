namespace ScoreOfRatings;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	public void OnMyButtonClick(object sender, EventArgs e)
	{
		Result3.Text = "";
		string g5 = grade5.Text;
		string g4 = grade4.Text;
		string g3 = grade3.Text;
		string g2 = grade2.Text;
		double input5;
		double input4;
		double input3;
		double input2;
		double.TryParse(g5, out input5);
		double.TryParse(g4, out input4);
		double.TryParse(g3, out input3);
		double.TryParse(g2, out input2);
		double test = input2 + input3 + input4 + input5;
		if(test == 0)
		{
			Result2.Text = "Вы не ввели ни одной оценки";
		}
		else
		{
			double result = (5*input5 + 4*input4 + 3*input3 + 2*input2) / test;
			double result2 = Math.Round(result, 2);
        	string strResult = Convert.ToString(result2);
        	Result2.Text = $"Ваш средний балл: {strResult}";
			if(result2 == 0)
			{
				Result3.Text = "";
			}
			else if(result2 < 2.5)
			{
				Result3.Text = "У вас выходит оценка 2 :(";
			}
			else if(result2 == 2.5)
			{
				Result3.Text = "У вас спорная между оценками 2 и 3 :(";
			}
			else if(result2 > 2.5 && result2 < 3.5)
			{
				Result3.Text = "У вас выходит оценка 3 :(";
			}
			else if(result2 == 3.5)
			{
				Result3.Text = "У вас спорная между 3 и 4";
			}
			else if(result2 > 3.5 && result2 < 4.5)
			{
				Result3.Text = "У вас выходит оценка 4 :)";
			}
			else if(result2 == 4.5)
			{
				Result3.Text = "У вас спорная между 4 и 5 :)";
			}
			else if(result2 > 4.5)
			{
				Result3.Text = "У вас выходит оценка 5 :)";
			}
		}
	}
}