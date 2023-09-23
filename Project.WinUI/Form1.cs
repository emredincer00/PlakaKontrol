using Project.BLL.DesignPatterns.GenericReporsitoryPattern.ConcRep;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {


        
        VehicleRepository _vRep;
        
        public Form1()
        {
            InitializeComponent();

            _vRep = new VehicleRepository();
            dataGridView1.ClearSelection();
            BilgiGetir();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void BilgiGetir()
        {
            dataGridView1.DataSource = _vRep.GetAll();
            dataGridView1.Columns["ID"].ReadOnly = true;
            dataGridView1.Columns["LicensePlate"].HeaderText = "Plaka";
            dataGridView1.Columns["Information"].HeaderText = "Bilgilendirme";
            


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["LicensePlate"].Width = 100;
            dataGridView1.ReadOnly = false;


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "LicensePlate")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Vehicle newVehicle = dataGridView1.Rows[e.RowIndex].DataBoundItem as Vehicle;
                _vRep.Destroy(newVehicle);

                BilgiGetir();
                if (newVehicle != null)
                {
                    _vRep.Add(newVehicle);
                    BilgiGetir();
                    MessageBox.Show("Değiştirmiş olduğunuz bilgiler başarıyla güncellendi.");
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtArama.Text.Trim().ToUpper();
            int eslesenSatirIndex = -1;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan) 
                            {
                                cell.Style.BackColor = Color.Red; cell.Style.ForeColor = Color.White;
                                dataGridView1.ClearSelection();
                                cell.Selected = true;
                                eslesenSatirIndex = cell.RowIndex;
                                break;
                            }
                            else { cell.Style.BackColor = Color.White; cell.Style.ForeColor = Color.Black; dataGridView1.ClearSelection(); break; }
                        }
                    }
                }
                if (eslesenSatirIndex >= 0 && eslesenSatirIndex < dataGridView1.RowCount)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = eslesenSatirIndex;
                }
            }
        }

        private void txtArama_MouseMove(object sender, MouseEventArgs e)
        {
            AmblemRengi(Color.Transparent);
            lblAciklama.Text = "Buraya yazmış olduğunuz plaka bilgisiyle listede uyuşan bir plaka bulunuyor ise kırmızı renkte size gözükür ve sizi o plakanın olduğu sütuna götürür.\n\nEğer aynı plakadan birden fazla varsa yazdığınız bilgi ile uyuşan plakalar kırmızı gözükür.";
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            AmblemRengi(Color.Transparent);

            lblAciklama.Text = "Bilginizi güncellemek istiyorsanız:\n1) Liste üzerinden değiştirmek istediğiniz bilgiye çift tıklayın.\n2) Değişikliği yaptıktan sonra listede rastgele bir yere tıklayın.\n3) Liste başarıyla güncellenmiştir. Listenin en altında yeni bir şekilde size gözükecektir.";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            AmblemRengi(Color.Transparent);

            lblAciklama.Text = "";
        }

        private void AramaTexti()
        {
            txtArama.Text = "Bulmak istediğiniz plakayı girin.";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            AramaTexti();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            AramaTexti();

        }

        private void lblAciklama_Click(object sender, EventArgs e)
        {
            AramaTexti();

        }

        private void txtEkle_Click(object sender, EventArgs e)
        {
            AramaTexti();

        }

        private void txtBilgi_Click(object sender, EventArgs e)
        {
            AramaTexti();

        }



        private void AmblemRengi(Color renk)
        {
            btnAmblem.BackColor = renk;
        }

        private void btnAmblem_MouseMove(object sender, MouseEventArgs e)
        {
            AmblemRengi(Color.Indigo);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AramaTexti();

            StringBuilder sb = new StringBuilder();

            if (txtBilgi.Text == "" && txtEkle.Text == "" || txtEkle.Text == "")
            {
                MessageBox.Show("Plaka ve Bilgilendirme girişlerini sorunsuz yazdığınızdan emin olun.\n\nGiriş yapılabilmesi için PLAKA girilmesi gerekiyor.");
            }
            else
            {
                
                Vehicle v = new Vehicle();

                v.LicensePlate = txtEkle.Text;
                v.Information = txtBilgi.Text;
                _vRep.Add(v);
                BilgiGetir();

                txtBilgi.Text = "";
                txtEkle.Text = "";
                MessageBox.Show("Girdiğiniz bilgiler başarıyla eklendi.");
            }


            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                Vehicle selectedItem = dataGridView1.Rows[selectedRowIndex].DataBoundItem as Vehicle;
                if (selectedItem != null)
                {

                    DialogResult dr2 = MessageBox.Show($"Plaka =\t{selectedItem.LicensePlate}\n\nBilgilendirme =\t{selectedItem.Information}\n\n Silmek istediğinize emin misiniz?","Silme İşlemi!",MessageBoxButtons.YesNo);
                    if (dr2 == DialogResult.Yes)
                    {
                        _vRep.Destroy(selectedItem);

                        BilgiGetir();
                        AramaTexti();
                        MessageBox.Show("Seçtiğiniz veri başarıyla silindi.");
                    }
                    else
                    {
                        
                    }
                    
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Tablodaki en soldaki boşluğa bastığınızdan emin olun. Aksi taktirde veriyi silemezsiniz.", "Uyarı!", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    AramaTexti();
                }
            }

        }

        private void btnKaydet_MouseMove(object sender, MouseEventArgs e)
        {
            AmblemRengi(Color.Transparent);

            lblAciklama.Text = "Notlarınıza yeni bir bilgi eklemek istiyorsanız:\n1) Plaka ve Bilgilendirme altında bulunan beyaz dikdörtgenlere bilgileri girin.\n2) Bilgileri girdikten sonra 'Ekle' butonuna tıklayın.";

        }

        private void btnSil_MouseMove(object sender, MouseEventArgs e)
        {
            AmblemRengi(Color.Transparent);

            lblAciklama.Text = "Notlarınızdan bilgiyi TAMAMEN silmek istiyorsanız:\n1) Plakanın solundaki küçük kutucuğa tıklayın.\n2) Kutucuğa tıkladıktan sonra 'Sil' butonuna basın.";
        }

        private void txtArama_Click(object sender, EventArgs e)
        {
            txtArama.Text = "";
        }

        private void txtEkle_Click_1(object sender, EventArgs e)
        {
            AramaTexti();
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instagram= @emredincer00\nGmail= dincer.emre2002@gmail.com\nBionluk= @emredincer00\nGithub= @emredincer00");

        }

        private void btnDetayliIncele_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                Vehicle selectedItem = dataGridView1.Rows[selectedRowIndex].DataBoundItem as Vehicle;
                if (selectedItem != null)
                {

                    MessageBox.Show($"Plaka = {selectedItem.LicensePlate}\n\nPlaka Bilgileri = {selectedItem.Information}", "Detaylı İncele");

                }
                
            }
            else
            {
                MessageBox.Show("Bir plaka seçtiğinizden emin olun.");
            }
        }

        private void btnDetayliIncele_MouseMove(object sender, MouseEventArgs e)
        {
            lblAciklama.Text = "1) Detaylı incelemek istediğiniz sütuna sol fare tuşuyla tıklayın.\n2) İncelemek istediğiniz sütunu seçtikten sonra 'Detaylı İncele' butonuna tıklarsanız karşınıza bilgiler çıkacaktır.";
        }
    }
    }

    
    
