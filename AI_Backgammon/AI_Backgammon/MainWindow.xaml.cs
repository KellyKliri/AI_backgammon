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

namespace AI_Backgammon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DelimitFieldView();
        }

        private void DelimitFieldView()
        {
            NodeView nvTmp;
            Point startPositionNode = new Point(135,780);
           
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    nvTmp = new NodeView();
                   // nvTmp.Margin = new Thickness(startPositionNode.X + i * 64, startPositionNode.Y - j * 61, 0, 0);
                    GridField.Children.Add(nvTmp);
                }
            }
        }
    }
}
