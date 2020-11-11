using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maakonnad_DM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maakonnad_P : ContentPage
    {
        Picker picker_list;
        Editor editor;
        public Maakonnad_P()
        {
            InitializeComponent();
            {
                Grid gr = new Grid
                {
                    RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                },
                    ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
                };
                picker_list = new Picker { Title = "Picker list", TitleColor = Color.DarkCyan };
                picker_list.Items.Add("C#");
                picker_list.Items.Add("Python");
                picker_list.Items.Add("C++");
                picker_list.Items.Add("VisualBasic");
                picker_list.Items.Add("Java");
                gr.Children.Add(picker_list, 1, 0);
                picker_list.SelectedIndexChanged += Picker_SelectedIndexChanged;

                editor = new Editor { Placeholder = "Vali keel \nnimekirjast" };
                gr.Children.Add(editor, 1, 0);
            }
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor.Text = "Oli valitud: " + picker_list.Items[picker_list.SelectedIndex];
        }
    }
}