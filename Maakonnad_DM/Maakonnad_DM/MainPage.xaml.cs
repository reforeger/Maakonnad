using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maakonnad_DM
{
    public partial class MainPage : ContentPage
    {
        Editor editor, editor1;
        Picker picker_list, picker_list2;
        public MainPage()
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
                picker_list = new Picker();
                picker_list = new Picker 
                {
                    Title = "Столицы уездов", TitleColor = Color.Cyan
                    
                };
                picker_list.Items.Add("Валга");
                picker_list.Items.Add("Вильянди");
                picker_list.Items.Add("Выру");
                picker_list.Items.Add("Йыхви");
                picker_list.Items.Add("Йыгева");
                picker_list.Items.Add("Раквере");
                picker_list.Items.Add("Хаапсалу");
                picker_list.Items.Add("Пылва");
                picker_list.Items.Add("Пярну");
                picker_list.Items.Add("Рапла");
                picker_list.Items.Add("Курессааре");
                picker_list.Items.Add("Тарту");
                picker_list.Items.Add("Таллин");
                picker_list.Items.Add("Кярдла");
                picker_list.Items.Add("Пайде");
                gr.Children.Add(picker_list, 0, 0);
                picker_list.SelectedIndexChanged += Picker_SelectedIndexChanged;

                picker_list2 = new Picker();
                picker_list2 = new Picker
                {
                    Title = "Уезды",
                    TitleColor = Color.Cyan

                };
                picker_list2.Items.Add("Валгамаа");
                picker_list2.Items.Add("Вильяндимаа");
                picker_list2.Items.Add("Вырумаа");
                picker_list2.Items.Add("Ида-Вирумаа");
                picker_list2.Items.Add("Йыгевамаа");
                picker_list2.Items.Add("Ляэне-Вирумаа");
                picker_list2.Items.Add("Ляэнемаа");
                picker_list2.Items.Add("Пылвамаа");
                picker_list2.Items.Add("Пярнумаа");
                picker_list2.Items.Add("Рапламаа");
                picker_list2.Items.Add("Сааремаа");
                picker_list2.Items.Add("Тартумаа");
                picker_list2.Items.Add("Харьюмаа");
                picker_list2.Items.Add("Хийумаа");
                picker_list2.Items.Add("Ярвамаа");
                gr.Children.Add(picker_list2, 1, 0);
                picker_list2.SelectedIndexChanged += Picker_SelectedIndexChanged2;

                editor1 = new Editor { Placeholder = "Выбрана \nстолица уезда" };
                gr.Children.Add(editor1, 1, 1);
                editor = new Editor { Placeholder = "Выбран \nуезд" };
                gr.Children.Add(editor, 0, 1);
                Content = gr;
            }
        }
        private void Picker_SelectedIndexChanged2(object sender, EventArgs e)
        {
            editor1.Text = "Oli valitud: \n" + picker_list2.Items[picker_list2.SelectedIndex];
            if (picker_list == null)
            {
                editor.Text = "Oli valitud: \n Валгамаа";
            }
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor.Text = "Oli valitud: \n" + picker_list.Items[picker_list.SelectedIndex];
        }
    }
}