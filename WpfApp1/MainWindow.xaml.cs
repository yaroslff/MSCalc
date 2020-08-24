using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Инициализирю поля на всякий случай :) я ещё чайник
            Price.detail = 0;
            Price.markup = 0;
            Price.total = 0;
            Price.work = 0;


        }

        //Обработчик ошибок
        public async void Error(string message)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
               
            });

            MessageBox.Show(message);
            PriceGSPN.Text = "0";
        }



        private async void PriceGSPN_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            

            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 

            if (PriceGSPN.Text != "")
            {

                try
                {

                    Price.detail = float.Parse(PriceGSPN.Text);
                    Price.markup = float.Parse(Marcup.Text);
                    Price.work = float.Parse(Work.Text);

                    PriceNDS.Text = (Price.detail + (Price.detail * Price.nds)).ToString();

                }
                catch
                {
                    Error("Давай без букав");
                }
                finally
                {
                    Total.Text = Calc.Sum().ToString();
                }
                
            }
        }

        private async void Marcup_TextChanged(object sender, TextChangedEventArgs e)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 

            if (Marcup.Text != "")
            {

                try
                {
                    Price.markup = float.Parse(Marcup.Text);

                }
                catch
                {
                    //логика нарушена
                }
                finally
                {
                    Total.Text = Calc.Sum().ToString();
                }
            }
        }

        private async void Work_TextChanged(object sender, TextChangedEventArgs e)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 

            if (Work.Text != "")
            {

                try
                {
                    Price.work = float.Parse(Work.Text);

                }
                catch
                {
                    //логика нарушена
                }
                finally
                {
                    Total.Text = Calc.Sum().ToString();
                }
            }
        }

        private async void Total_TextChanged(object sender, TextChangedEventArgs e)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 

            if (Total.Text != "")
            {

                try
                {
                    //логика

                }
                catch
                {
                    //логика нарушена
                }
                finally
                {
                    Total.Text = Calc.Sum().ToString();
                }
            }
        }

        private async void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 
            Work.Text = "1000";
            
        }

        private async void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 

           

            Work.Text = "1500";
           
        }

        private async void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                //await Task.Delay(1000);
            });
            // этот код будет продолжен в UI потоке, 

            Work.Text = "2000";
        }

       
    }
}
