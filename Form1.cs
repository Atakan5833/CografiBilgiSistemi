using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CografiBilgiSistemi
{
    public partial class Form1 : Form
    {
        //heryerde gözükmesi için burda tanımladım
        GMapOverlay katman1;
        List<Araclar> list;

        //veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=F58\SQLEXPRESS;Initial Catalog=Projeler;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
            initializeMap();
            aracListesiniOlustur();

        }

        private void aracListesiniOlustur()
        { 
            list = new List<Araclar>();
            // Veritabanından DB ADO.NET ile çekilmesi
            try
            {
                baglanti.Open();
                string tabloCumlesi = "SELECT Plaka,Tip,[From],[To] ,Enlem,Boylam FROM Araclar";
                // veritabanıyla etkileşimde bulunmak için bir araçtır ve veritabanı işlemlerini kolaylaştırır.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tabloCumlesi , baglanti);
                DataTable dataTable = new DataTable();
                //tabloya dataadapterden gelenleri doldurma
                sqlDataAdapter.Fill(dataTable);
                //veritabanından birşeyler geldiyse eğer datagridview in içine doldurmasını söylüyorum
                if(dataTable.Rows.Count > 0 )
                {
                    dataGridView1.DataSource = dataTable;
                }
                for( int i = 0; i < dataTable.Rows.Count; i++ ) {
                    list.Add(new Araclar(dataTable.Rows[i][0].ToString(),
                        dataTable.Rows[i][1].ToString(),
                        dataTable.Rows[i][2].ToString(),
                        dataTable.Rows[i][3].ToString(),
                        new PointLatLng(Convert.ToDouble(dataTable.Rows[i][4].ToString()),
                        Convert.ToDouble(dataTable.Rows[i][4].ToString())

                        )));
                      
                    //Console.WriteLine(dataTable.Rows[i][0].ToString());
                 /*   list.Add(new Araclar(dataTable.Rows[i][0].ToString(),
                                         dataTable.Rows[i][1].ToString(),
                                         dataTable.Rows[i][2].ToString(),
                                         dataTable.Rows[i][3].ToString(),
                                         new PointLatLng(Convert.ToDouble(dataTable.Rows[i][4].ToString()),
                                                         Convert.ToDouble(dataTable.Rows[i][5].ToString())));*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DB bağlantı sırasında bir hata oluştu \n" + ex.Message); 
            }
            finally { 
                if (baglanti != null)
                    baglanti.Close(); }
        }

        private void initializeMap()
        {
            //sol tuşla gezinti için
            map.DragButton = MouseButtons.Left;
            //kullanıcağım harita
            map.MapProvider = GMapProviders.GoogleMap;
            //merkez alıcağı enlem boylay
            map.Zoom = 4;
            map.MinZoom = 3;
            map.MaxZoom = 10000;
            //burda oluşturdum
            katman1 = new GMapOverlay();

            //bir Overlay (katman) oluşturmamız lazım
            //harita üzerinde görüntülenecek tüm componentleri bu katman(overlay) eklemek gerek

            //ilk olarak da yeni oluşturduğumuz katmanı harita nesnemize eklemeliyiz
            map.Overlays.Add(katman1);
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //enlem ve boylamı alırken double sayı yapıtım
            PointLatLng lokasyon1 = new PointLatLng(Convert.ToDouble(textBoxEnlem.Text),Convert.ToDouble(textBoxBoylam.Text));
            //haritaya tıkladığımda ekranda beliricek markerı oluşturdum
            GMarkerGoogle marker = new GMarkerGoogle(lokasyon1, GMarkerGoogleType.purple_dot);
            //koordinatları girdiğimizde markerın üstüne gelince vericeği bilgi texti
            marker.ToolTipText = "\nLokasyon\nFrom: ankara \nTo:İstanbul ";
            //bilginin yazı rengi ayarlama 
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.Yellow;
            marker.ToolTip.Stroke = Pens.Black;
            //marker bilgisinin paddingi
            marker.ToolTip.TextPadding = new Size(2,2);
            //seçtiğimiz lokasyondaki markerın tooltipi her zaman gözükür //default : OneMouseOver
            marker.ToolTipMode = MarkerTooltipMode.Always;
            //markere id 
            marker.Tag = 1;


            

            //daha sonra markerları eklemelisiniz.
            //!!!markeri önce eklersek yanlış yere koyabilir.
            katman1.Markers.Add(marker);    
        }
        */
        /*
        private void btnHarita2_Click(object sender, EventArgs e)
        {
            //alıcağımız lokasyon bilgiler MARKER 2
            PointLatLng lokasyon2 = new PointLatLng(Convert.ToDouble(textBoxEnlem2.Text), Convert.ToDouble(textBoxBoylam2.Text));

            GMarkerGoogle marker2 = new GMarkerGoogle(lokasyon2, GMarkerGoogleType.red_dot);


            //markerdaki özet bilgiler
            marker2.ToolTipText = "\nLokasyon\nFrom: ankara \nTo:İstanbul ";
            //bilginin yazı rengi ayarlama 
            marker2.ToolTip.Fill = Brushes.Black;
            marker2.ToolTip.Foreground = Brushes.Red;
            marker2.ToolTip.Stroke = Pens.Black;
            //marker bilgisinin paddingi
            marker2.ToolTip.TextPadding = new Size(2, 2);
            //seçtiğimiz lokasyondaki markerın tooltipi her zaman gözükür //default : OneMouseOver
            marker2.ToolTipMode = MarkerTooltipMode.Always;

            //yeni marker
            marker2.Tag = 2;

            katman1.Markers.Add(marker2);

        }
        */
        //markera tıklandığında ekranda çıktısı alma
        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string secilenArac = (string)item.Tag;

            foreach(Araclar araclar in list)
            {
                if (secilenArac == araclar.Plaka)
                {
                    textBoxPlaka.Text = araclar.Plaka;
                    textBoxTip.Text = araclar.Tip;
                    textBoxKalkıs.Text = araclar.From;
                    textBoxVarıs.Text = araclar.To;
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form takılı kalmaması için uylamadan çıkma eylemi
            map.Dispose();
            Application.Exit();
        }

        //Araclar Sınıfındaki Araç bilgilerini bir döngüye alıp butona tıklandığında haritada gösterme kısmı
        private void btnList_Click(object sender, EventArgs e)
        {
            foreach (Araclar araclar in list)
            {
                //araçların konumunu işaretliceği markerın özellikleri
                GMarkerGoogle markerTmp = new GMarkerGoogle(araclar.Konum, GMarkerGoogleType.purple_dot);
                //katmandaki bilgileri
                markerTmp.ToolTipText = araclar.ToString();
                //uniq olması gerekir tagların (araçların plakaları uniq olduğu için onu seçtim)
                markerTmp.Tag = araclar.Plaka;
                //katman işlemleri, katmana ekliyorum
                katman1.Markers.Add(markerTmp);
                //consola yazdırma
                Console.WriteLine(araclar.ToString());
            }
        }
    }
}
