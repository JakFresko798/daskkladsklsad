using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ЖальЧтоЯНеПаблоЭскобар_18ИПо8284;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room = new Room();
        livingRoom livingRoom = new livingRoom();
        Office office = new Office();

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            room.RoomLength = Convert.ToDouble(TBLengthL.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            ListRooms.Content += room.info() + "\n";
            ListRooms.Content += livingRoom.info() + "\n";
            ListRooms.Content += office.info() + "\n";
        }
    }
}