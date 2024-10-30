using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba_7_2_zadanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunawayButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            double newLeft = _random.NextDouble() * (this.Width - RunawayButton.Width);
            double newTop = _random.NextDouble() * (this.Height - RunawayButton.Height);

            DoubleAnimation leftAnimation = new DoubleAnimation(newLeft, TimeSpan.FromMilliseconds(300));
            DoubleAnimation topAnimation = new DoubleAnimation(newTop, TimeSpan.FromMilliseconds(300));

            RunawayButton.BeginAnimation(Canvas.LeftProperty, leftAnimation);
            RunawayButton.BeginAnimation(Canvas.TopProperty, topAnimation);
        }
    }
}

   