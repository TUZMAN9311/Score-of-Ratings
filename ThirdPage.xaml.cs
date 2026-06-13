namespace ScoreOfRatings;

public partial class ThirdPage : ContentPage
{
    public ThirdPage()
    {
        InitializeComponent();
    }
    
    public void OnMyButtonClick(object sender, EventArgs e)
	{
		Result3.Text = "";
		string g12 = grade12.Text;
        string g11 = grade11.Text;
        string g10 = grade10.Text;
        string g9 = grade9.Text;
        string g8 = grade8.Text;
        string g7 = grade7.Text;
        string g6 = grade6.Text;
        string g5 = grade5.Text;
		string g4 = grade4.Text;
		string g3 = grade3.Text;
		string g2 = grade2.Text;
		string g1 = grade1.Text;
        double input12;
        double input11;
        double input10;
        double input9;
        double input8;
        double input7;
        double input6;
		double input5;
		double input4;
		double input3;
		double input2;
		double input1;
        double.TryParse(g12, out input12);
        double.TryParse(g11, out input11);
		double.TryParse(g10, out input10);
		double.TryParse(g9, out input9);
		double.TryParse(g8, out input8);
		double.TryParse(g7, out input7);
        double.TryParse(g6, out input6);
        double.TryParse(g5, out input5);
		double.TryParse(g4, out input4);
		double.TryParse(g3, out input3);
		double.TryParse(g2, out input2);
		double.TryParse(g1, out input1);
		double test = input1 + input2 + input3 + input4 + input5 + input6 + input7 + input8 + input9 + input10 + input11 + input12;
		if(test == 0)
		{
			Result2.Text = "Вы не ввели ни одной оценки";
		}
		else
		{
			double result = (12*input12 + 11*input11 + 10*input10 + 9*input9 + 8*input8 + 7*input7 + 6*input6 + 5*input5 + 4*input4 + 3*input3 + 2*input2 + 1*input1) / test;
			double result2 = Math.Round(result, 2);
        	string strResult = Convert.ToString(result2);
        	Result2.Text = $"Ваш средний балл: {strResult}";
			if(result2 == 0)
			{
				Result3.Text = "";
			}
			else if(result2 < 1.5)
			{
				Result3.Text = "У вас выходит оценка 1 :(";
			}
			else if(result2 == 1.5)
			{
				Result3.Text = "У вас спорная между оценками 1 и 2 :(";
			}
			else if(result2 > 1.5 && result2 < 2.5)
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
				Result3.Text = "У вас спорная между 3 и 4 :(";
			}
			else if(result2 > 3.5 && result2 < 4.5)
			{
				Result3.Text = "У вас выходит оценка 4 :(";
			}
			else if(result2 == 4.5)
			{
				Result3.Text = "У вас спорная между 4 и 5 :(";
			}
			else if(result2 > 4.5 && result2 < 5.5)
			{
				Result3.Text = "У вас выходит оценка 5 :(";
			}
			else if(result2 == 5.5)
			{
				Result3.Text = "У вас спорная между 5 и 6 :(";
			}
			else if(result2 > 5.5 && result2 < 6.5)
			{
				Result3.Text = "У вас выходит оценка 6 :(";
			}
			else if(result2 == 6.5)
			{
				Result3.Text = "У вас спорная между 6 и 7";
			}
			else if(result2 > 6.5 && result2 < 7.5)
			{
				Result3.Text = "У вас выходит оценка 7 :)";
			}
			else if(result2 == 7.5)
			{
				Result3.Text = "У вас спорная между 7 и 8 :)";
			}
			else if(result2 > 7.5 && result2 < 8.5)
			{
				Result3.Text = "У вас выходит оценка 8 :)";
			}
			else if(result2 == 8.5)
			{
				Result3.Text = "У вас спорная между 8 и 9 :)";
			}
			else if(result2 > 8.5 && result2 < 9.5)
			{
				Result3.Text = "У вас выходит оценка 9 :)";
			}
			else if(result2 == 9.5)
			{
				Result3.Text = "У вас спорная между 9 и 10 :)";
			}
			else if(result2 > 9.5 && result2 < 10.5)
			{
				Result3.Text = "У вас выходит оценка 10 :)";
			}
            else if(result2 == 10.5)
			{
				Result3.Text = "У вас спорная между 10 и 11 :)";
			}
			else if(result2 > 10.5 && result2 < 11.5)
			{
				Result3.Text = "У вас выходит оценка 11 :)";
			}
            else if(result2 == 11.5)
			{
				Result3.Text = "У вас спорная между 11 и 12 :)";
			}
			else if(result2 > 11.5)
			{
				Result3.Text = "У вас выходит оценка 12 :)";
			}
		}
    }
}