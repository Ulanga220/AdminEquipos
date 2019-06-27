using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEquipos
{
    public partial class AdminEq : Form
    {
        public AdminEq()
        {
            InitializeComponent();
        }

        List<Sensor> listaSen = new List<Sensor>();
        string[] equipos = { "NoiseMaster 4000", "Dnya 310", "Nse 21" };
        string[] locaciones = { "Plaza San Martin", "Subte D est. Callao", "Av. San Luis 2100", "Av. Pueyrredón 2520", "Av. Cabildo 2310" };



        private bool ValidarIngreso(string t1, string t2, string t3)
        {
            if (t1 == "" || t2 == "" || t3 == "")
            {
                return false;
            }
        return true;
        }

        public void CargarListView()
        {
            lstvS.Items.Clear();
            for (int i = 0; i < listaSen.Count; i++)
            {
                ListViewItem Item = new ListViewItem(listaSen[i].locacion);
                Item.SubItems.Add(listaSen[i].equipo);
                lstvS.Items.Add(Item);
                }




        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarIngreso(txtequipo.Text, txtlocacion.Text, txtsensor.Text) == false)
            {
                MessageBox.Show("No puede ingresar campos vacíos");
                return;
            }
            Sensor sensor = new Sensor();

            if(sensor.ValidarId(txtsensor.Text) == false)
            {
                MessageBox.Show("El id del sensor no es válido");
                return;
            }
            sensor.id = txtsensor.Text.ToUpper();
            txtsensor.Text = sensor.id;

            int IdE;

            if (Int32.TryParse(txtequipo.Text, out IdE))
            {
                IdE -= 1;
                if(IdE>=0 && IdE <= 2)
                {
                    sensor.equipo = equipos[IdE];
                }
                else
                {
                    MessageBox.Show("El equipo no existe");
                    return;
                }
               
            }
            int idL;
            if (Int32.TryParse(txtlocacion.Text, out idL))
            {
                idL -= 1;
                if (idL >= 0 && idL <= 4)
                {
                    sensor.locacion = locaciones[idL];
                }
                else
                {
                    MessageBox.Show("El ID de locacion está fuera de los parametros");
                    return;
                }
            }

            for (int i = 0; i < listaSen.Count; i++)
            {
                if (listaSen[i].equipo == equipos[IdE] && listaSen[i].locacion == locaciones[idL])
                {
                    MessageBox.Show("Ya existe ese sensor");
                    return;
                }
                if (listaSen[i].id == sensor.id)
                {
                    MessageBox.Show("Ya existe ese codigo de sensor");
                    return;
                }
            }
            ListViewItem ITEM = new ListViewItem(locaciones[idL]);
            ITEM.SubItems.Add(equipos[IdE]);

            lstvS.Items.Add(ITEM);
            //Agregar a la lista
            listaSen.Add(sensor);

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (lstvS.SelectedItems.Count == 0)
            {
                return;
            }
            string Locacion = lstvS.SelectedItems[0].Text;
            string Equipo = lstvS.SelectedItems[0].SubItems[1].Text;

            for (int i = 0; i < listaSen.Count; i++)
            {
                if (listaSen[i].locacion == Locacion && listaSen[i].equipo == Equipo)
                {
                    listaSen.Remove(listaSen[i]);
                    CargarListView();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstvS.MultiSelect = false;
        }


    }
}

