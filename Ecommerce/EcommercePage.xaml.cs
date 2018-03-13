using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ecommerce;


namespace Ecommerce
{
    public partial class EcommercePage : ContentPage
    {
        DateTime starts;
        DateTime final;

        public EcommercePage()
        {
            
            InitializeComponent();
           // ShowingTimer();
            this.BindingContext = new
            {
                dt = DateTime.Now.ToLocalTime().ToString(),
                ts=TimeSpan.FromHours(24).ToString()
                             
            };
            start();
            counter_Tick();
            ShowingTimer();

        }

        private void start()
        {
            starts = DateTime.Now;
            final = starts + TimeSpan.FromHours(24);
            get1.Text = final.ToString();
        }

        private void counter_Tick()
        {
            starts = DateTime.Now;
            get2.Text = starts.ToString();
            get.Text = (final - starts).Hours.ToString() + "h:" + (final - starts).Minutes.ToString() + "m:" + (final - starts).Seconds.ToString()+"s";
            if (final == starts)
            {
                
            }
        }

        private async void ShowingTimer()
        {
            //var date = new DateTime(2018, 03, 09, 00, 12, 59);
           
            //var now = DateTime.Now.ToLocalTime();

            //var distance =  date - now ;

            // get.Text=distance.ToString();




            //var starttime = DateTime.Now;
            //var endtime = starttime.AddMinutes(15);


            int _end = 0;
            for (var _hour = 23; _hour >= 0; _hour--)
            {

                for (int _minute = 59; _minute >= 0; _minute--)
                {
                    for (int _second = 59; _second >= 0; _second--)
                    {
                        if (_second < 10)
                        {
                            _secondView.Text = Convert.ToString("" + _second);
                        }
                        else
                        {
                            _secondView.Text = Convert.ToString(_second);
                        }
                        _minuteView.Text = Convert.ToString("" + _minute);
                        _hourView.Text = Convert.ToString("" + _hour);
                        await Task.Delay(1000);
                    }
                }
                _end++;
                if (_end == 59) { break; }
            }

        }
    }
}
