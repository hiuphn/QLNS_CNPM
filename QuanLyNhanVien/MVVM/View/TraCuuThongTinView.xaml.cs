using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using BUS;
using DTO;
using QuanLyNhanVien.MessageBox;
using QuanLyNhanVien.WindowView;

namespace QuanLyNhanVien.MVVM.View
{
    /// <summary>
    /// Interaction logic for TraCuuThongTinView.xaml
    /// </summary>
    public partial class TraCuuThongTinView : UserControl
    {
        BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public TraCuuThongTinView()
        {
            InitializeComponent();
            DataGridLoad();
        }
        public void DataGridLoad()
        {
            dsTimKiemThongTinDtg.DataContext = busNhanVien.getNhanVien();
        }

        private void timkiemBtn_Click(object sender, RoutedEventArgs e)
        {
            Loc();
        }

        private void timkiemTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (manvRdBtn.IsChecked == true)
            {
                e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
            }
            if (hotenRdBtn.IsChecked == true)
            {
                e.Handled = new Regex("[0-9]+").IsMatch(e.Text);
            }
            if (sdtRdBtn.IsChecked == true)
            {
                e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
            }
        }

        private void lamMoiBtn_Click(object sender, RoutedEventArgs e)
        {
            timkiemTbx.Text = "";
            DataGridLoad();
        }

        private void timkiemTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Loc();
            }    
        }

        public void Loc()
        {
            if (timkiemTbx.Text == String.Empty)
            {
                bool? result = new MessageBoxCustom("Vui lòng điền đầy đủ thông tin!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                DataGridLoad();
                return;
            }
            if (manvRdBtn.IsChecked == true)
            {
                dsTimKiemThongTinDtg.DataContext = busNhanVien.TimKiemNhanVienTheoMa(timkiemTbx.Text);
            }
            if (hotenRdBtn.IsChecked == true)
            {
                dsTimKiemThongTinDtg.DataContext = busNhanVien.TimKiemNhanVienTheoTen(timkiemTbx.Text);
            }
            if (sdtRdBtn.IsChecked == true)
            {
                dsTimKiemThongTinDtg.DataContext = busNhanVien.TimKiemNhanVienTheoSDT(timkiemTbx.Text);
            }
        }

        public void XemChiTiet()
        {
            DTO_NHANVIEN ctNhanVien = new DTO_NHANVIEN();
            DataRowView row = dsTimKiemThongTinDtg.SelectedItem as DataRowView;
            ChiTietNhanVienForm chiTietNhanVienForm = new ChiTietNhanVienForm();

            ctNhanVien.Manv = int.Parse(row[0].ToString());
            ctNhanVien.Maphong = row[1].ToString();
            ctNhanVien.Maluong = row[2].ToString();
            ctNhanVien.Hoten = row[3].ToString();
            ctNhanVien.Ngaysinh = DateTime.Parse(row[4].ToString());
            ctNhanVien.Gioitinh = row[5].ToString();
            ctNhanVien.Dantoc = row[6].ToString();
            ctNhanVien.Cmnd_cccd = row[7].ToString();
            ctNhanVien.Noicap = row[8].ToString();
            ctNhanVien.Chucvu = row[9].ToString();
            ctNhanVien.Maloainv = row[10].ToString();
            ctNhanVien.Loaihd = row[11].ToString();
            ctNhanVien.Thoigian = int.Parse(row[12].ToString());
            ctNhanVien.Ngaydangki = DateTime.Parse(row[13].ToString());
            ctNhanVien.Ngayhethan = DateTime.Parse(row[14].ToString());
            ctNhanVien.Sdt = row[15].ToString();
            ctNhanVien.Hocvan = row[16].ToString();
            ctNhanVien.Ghichu = row[17].ToString();

            chiTietNhanVienForm.ctNhanVien = ctNhanVien;
            chiTietNhanVienForm.ShowDialog();
            DataGridLoad();
        }

        private void dsTimKiemThongTinDtg_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dsTimKiemThongTinDtg.SelectedItems.Count == 0)
            {
                return;
            }
            XemChiTiet();
        }
    }
}
