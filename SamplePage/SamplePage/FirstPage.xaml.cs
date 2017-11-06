using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SamplePage
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            //Save user name to App Current properties
            App.Current.Properties["LoginUserName"] = "Ravi";
            App.Current.SavePropertiesAsync();
            //End

            //Get username from Save properties
            if (App.Current.Properties.ContainsKey("LoginUserName")){
                string userName = App.Current.Properties["LoginUserName"].ToString();
            }
			//end


			//Convert string to base 64 encoding
			byte[] bytes = Encoding.UTF8.GetBytes("Ravi");
			string base64 = Convert.ToBase64String(bytes);
			Console.WriteLine(base64);
            //end

            //Decode base64 string to normal string
            byte[] bytesData = Convert.FromBase64String(base64);
			string str = Encoding.UTF8.GetString(bytesData);
			Console.WriteLine(str);
            //end

        }
    }
}
