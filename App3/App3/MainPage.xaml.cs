using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bit.View.Controls;
using NodaTime;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var cal = new BitDateTimePicker()
            {
                Culture = new CultureInfo("fa"),
                Text = "لطفا تاریخ مورد تایید را انتخاب نمایید",
                DateTimeDisplayFormat = "dd MMM yyyy",
                CalendarSystem = CalendarSystem.PersianArithmetic,
                FlowDirection = FlowDirection.RightToLeft,
            };
            cal.SetBinding(BitDateTimePicker.SelectedDateTimeProperty, "MyDate");
            this.BindingContext = new MainViewModel() { MyDate = DateTime.Now };
            testStack.Children.Add(cal);

        }

    }

    public class MainViewModel
    {
        public DateTime MyDate { get; set; }
    }
}
