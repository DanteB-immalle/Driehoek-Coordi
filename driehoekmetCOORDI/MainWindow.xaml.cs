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

namespace driehoekmetCOORDI
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MijnKnop_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Orange);

            string s1 = TX1.Text;
            string s2 = TY1.Text;

            int xPlace2 = Convert.ToInt32(s1);
            int yPlace2 = Convert.ToInt32(s2);

            DrawTriangle(canvas, brush, xPlace2, yPlace2, 100, 150);

            


        }
        private void DrawTriangle(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double width, double height)
        {
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace + height, xPlace + width, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace + width, yPlace + height);
        }
        private void DrawLine(Canvas drawingArea, SolidColorBrush brushToUse, double startX, double startY, double endX, double endY)
        {
            Line l = new Line();
            l.X1 = startX; l.X2 = endX;
            l.Y1 = startY; l.Y2 = endY;
            l.Stroke = brushToUse;
            drawingArea.Children.Add(l);
        }

      
    }
}
