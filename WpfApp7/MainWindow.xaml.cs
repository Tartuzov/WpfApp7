using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DockPanel dPanel = new DockPanel();
            var button1 = new Button {BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "1",Background = new SolidColorBrush(Colors.Black) };
            var button2 = new Button { BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White),Content = "2",Background = new SolidColorBrush(Colors.Black) };
            var button3 = new Button { BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White),Content = "3",Background = new SolidColorBrush(Colors.Black) };
            var button4 = new Button { BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black),Content = "4",Background = new SolidColorBrush(Colors.White) };
            var button5 = new Button { BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White),Content = "5",Background = new SolidColorBrush(Colors.Black) };
            var button6 = new Button { BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black),Content = "6",Background = new SolidColorBrush(Colors.White) };
            var button7 = new Button { BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black),Content = "7",Background = new SolidColorBrush(Colors.White) };
            var button8 = new Button { BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White),Content = "8",Background = new SolidColorBrush(Colors.Black) };
            var button9 = new Button { BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White),Content = "9",Background = new SolidColorBrush(Colors.Black) };
            var button10 = new Button {BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black), Content = "10",Background = new SolidColorBrush(Colors.White) };
            var button11 = new Button {BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "11",Background = new SolidColorBrush(Colors.Black) };
            var button12 = new Button {BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black), Content = "12",Background = new SolidColorBrush(Colors.White) };
            var button13 = new Button {BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "13",Background = new SolidColorBrush(Colors.Black) };
            var button14 = new Button {BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black), Content = "14",Background = new SolidColorBrush(Colors.White) };
            var button15 = new Button {BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "15",Background = new SolidColorBrush(Colors.Black) };
            var button16 = new Button {BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black), Content = "16",Background = new SolidColorBrush(Colors.White) };
            var button17 = new Button {BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "17",Background = new SolidColorBrush(Colors.Black) };
            var button18 = new Button {BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black), Content = "18",Background = new SolidColorBrush(Colors.White) };
            var button19 = new Button {BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "19",Background = new SolidColorBrush(Colors.Black) };
            var button20 = new Button {BorderBrush = new SolidColorBrush(Colors.White), Foreground = new SolidColorBrush(Colors.Black), Content = "20",Background = new SolidColorBrush(Colors.White) };
            var button21 = new Button { BorderBrush = new SolidColorBrush(Colors.Black), Foreground = new SolidColorBrush(Colors.White), Content = "21",Background = new SolidColorBrush(Colors.Black) };
            dPanel.Children.Add(button1);
            dPanel.Children.Add(button2);
            dPanel.Children.Add(button3);
            dPanel.Children.Add(button4);
            dPanel.Children.Add(button5);
            dPanel.Children.Add(button6);
            dPanel.Children.Add(button7);
            dPanel.Children.Add(button8);
            dPanel.Children.Add(button9);
            dPanel.Children.Add(button10);
            dPanel.Children.Add(button11);
            dPanel.Children.Add(button12);
            dPanel.Children.Add(button13);
            dPanel.Children.Add(button14);
            dPanel.Children.Add(button15);
            dPanel.Children.Add(button16);
            dPanel.Children.Add(button17);
            dPanel.Children.Add(button18);
            dPanel.Children.Add(button19);
            dPanel.Children.Add(button20);
            dPanel.Children.Add(button21);
            DockPanel.SetDock(button1, Dock.Left);
            DockPanel.SetDock(button2, Dock.Bottom);
            DockPanel.SetDock(button3, Dock.Right);
            DockPanel.SetDock(button4, Dock.Left);
            DockPanel.SetDock(button5, Dock.Top);
            DockPanel.SetDock(button6, Dock.Bottom);
            DockPanel.SetDock(button7, Dock.Right);
            DockPanel.SetDock(button8, Dock.Left);
            DockPanel.SetDock(button9, Dock.Bottom);
            DockPanel.SetDock(button10, Dock.Top);
            DockPanel.SetDock(button11, Dock.Right);
            DockPanel.SetDock(button12, Dock.Left);
            DockPanel.SetDock(button13, Dock.Top);
            DockPanel.SetDock(button14, Dock.Bottom);
            DockPanel.SetDock(button15, Dock.Left);
            DockPanel.SetDock(button16, Dock.Right);
            DockPanel.SetDock(button17, Dock.Bottom);
            DockPanel.SetDock(button18, Dock.Top);
            DockPanel.SetDock(button19, Dock.Right);
            DockPanel.SetDock(button20, Dock.Left);
            DockPanel.SetDock(button21, Dock.Top);
            dPanel.LastChildFill = false;
            grid1.Children.Add(dPanel);
        }
    }
}
