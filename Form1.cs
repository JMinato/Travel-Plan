namespace Travel_Plan
{
    public partial class Form1 : Form
    {
        private double precio;
        private double hotelNoche;
        private double desayuno;
        private double tour;
        private double seguroDia;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Travel Plan";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "";
            comboBox3.SelectedIndex = -1;
            comboBox3.Text = "";

            if (comboBox1.Text.Equals("Perú"))
            {

                comboBox2.Items.Add("Cajamarca");


                comboBox2.Items.Add("Cusco");


                comboBox2.Items.Add("Arequipa");


            }
            else if (comboBox1.Text.Equals("Colombia"))
            {
                rBtnBus.AutoCheck = false;
                rBtnBus.ForeColor = Color.Gray; 


                rBtnTren.AutoCheck = false;
                rBtnTren.ForeColor = Color.Gray;

 
                rBtnAutomovil.AutoCheck = false;
                rBtnAutomovil.ForeColor = Color.Gray;

                comboBox2.Items.Add("Antioquia");


                comboBox2.Items.Add("Valle del Cauca");


                comboBox2.Items.Add("Atlántico");

            }
            else if (comboBox1.Text.Equals("Chile"))
            {
                rBtnBus.AutoCheck = false;
                rBtnBus.ForeColor = Color.Gray; 

   
                rBtnTren.AutoCheck = false;
                rBtnTren.ForeColor = Color.Gray;


                rBtnAutomovil.AutoCheck = false;
                rBtnAutomovil.ForeColor = Color.Gray;

                comboBox2.Items.Add("Región Metropolitana");


                comboBox2.Items.Add("Valparaíso");


                comboBox2.Items.Add("Biobío");


            }
            else if (comboBox1.Text.Equals("Argentina"))
            {
                rBtnBus.AutoCheck = false;
                rBtnBus.ForeColor = Color.Gray; 

             
                rBtnTren.AutoCheck = false;
                rBtnTren.ForeColor = Color.Gray;

             
                rBtnAutomovil.AutoCheck = false;
                rBtnAutomovil.ForeColor = Color.Gray;


                comboBox2.Items.Add("Buenos Aires");

                comboBox2.Items.Add("Córdoba");

                comboBox2.Items.Add("Mendoza");

            }
            else if (comboBox1.Text.Equals("Mexico"))
            {
                rBtnBus.AutoCheck = false;
                rBtnBus.ForeColor = Color.Gray; 

           
                rBtnTren.AutoCheck = false;
                rBtnTren.ForeColor = Color.Gray;

              
                rBtnAutomovil.AutoCheck = false;
                rBtnAutomovil.ForeColor = Color.Gray;

                comboBox2.Items.Add("Jalisco");

                comboBox2.Items.Add("Nuevo León");

                comboBox2.Items.Add("Yucatán");

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            if (comboBox2.Text.Equals("Cajamarca"))
            {
                comboBox3.Items.Add("Cajamarca");
                comboBox3.Items.Add("Jaén");
                comboBox3.Items.Add("Chota");
                return;
            }

            if (comboBox2.Text.Equals("Cusco"))
            {
                comboBox3.Items.Add("Cusco");
                comboBox3.Items.Add("Sicuani");
                comboBox3.Items.Add("Urubamba");
                return;
            }

            if (comboBox2.Text.Equals("Arequipa"))
            {
                comboBox3.Items.Add("Arequipa");
                comboBox3.Items.Add("Mollendo");
                comboBox3.Items.Add("Camaná");
                return;
            }

            if (comboBox2.Text.Equals("Antioquia"))
            {
                comboBox3.Items.Add("Medellín");
                comboBox3.Items.Add("Envigado");
                comboBox3.Items.Add("Rionegro");
                return;
            }

            if (comboBox2.Text.Equals("Valle del Cauca"))
            {
                comboBox3.Items.Add("Cali");
                comboBox3.Items.Add("Palmira");
                comboBox3.Items.Add("Buenaventura");
                return;
            }

            if (comboBox2.Text.Equals("Atlántico"))
            {
                comboBox3.Items.Add("Barranquilla");
                comboBox3.Items.Add("Soledad");
                comboBox3.Items.Add("Puerto Colombia");
                return;
            }

            if (comboBox2.Text.Equals("Región Metropolitana"))
            {
                comboBox3.Items.Add("Santiago");
                comboBox3.Items.Add("Maipú");
                comboBox3.Items.Add("Puente Alto");
                return;
            }

            if (comboBox2.Text.Equals("Valparaíso"))
            {
                comboBox3.Items.Add("Valparaiso");
                comboBox3.Items.Add("Viña del Mar");
                comboBox3.Items.Add("Quilpué");
                return;
            }

            if (comboBox2.Text.Equals("Biobío"))
            {
                comboBox3.Items.Add("Concepción");
                comboBox3.Items.Add("Talcahuano");
                comboBox3.Items.Add("Los Ángeles");
                return;
            }

            if (comboBox2.Text.Equals("Buenos Aires"))
            {
                comboBox3.Items.Add("La Plata");
                comboBox3.Items.Add("Mar de Plata");
                comboBox3.Items.Add("Bahía Blanca");
                return;
            }

            if (comboBox2.Text.Equals("Córdoba"))
            {
                comboBox3.Items.Add("Córdoba");
                comboBox3.Items.Add("Villa Carlos Paz");
                comboBox3.Items.Add("Río Cuarto");
                return;
            }

            if (comboBox2.Text.Equals("Mendoza"))
            {
                comboBox3.Items.Add("Mendoza");
                comboBox3.Items.Add("San Rafael");
                comboBox3.Items.Add("Godoy Cruz");
                return;
            }

            if (comboBox2.Text.Equals("Jalisco"))
            {
                comboBox3.Items.Add("Guadalajara");
                comboBox3.Items.Add("Puerto vallarta");
                comboBox3.Items.Add("Zapopan");
                return;
            }

            if (comboBox2.Text.Equals("Nuevo León"))
            {
                comboBox3.Items.Add("Monterrey");
                comboBox3.Items.Add("San Nicolás de los Garza");
                comboBox3.Items.Add("Guadalupe");
                return;
            }

            if (comboBox2.Text.Equals("Yucatán"))
            {
                comboBox3.Items.Add("Merida");
                comboBox3.Items.Add("Valladolid");
                comboBox3.Items.Add("Progreso");
                return;
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rBtnBus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            precioTotal();

            listBox1.Items.Add("Cotización de Viaje");
            listBox1.Items.Add("Duración: " + textBox2.Text + " Dias / " + (int.Parse(textBox2.Text) - 1) + "noches");
            listBox1.Items.Add("Destino: " + comboBox3.Text + ", " + comboBox2.Text + ", " + comboBox1.Text);
            String transporte = "";
            if (rBtnBus.Checked)
            {
                transporte = "Bus";
            }
            else if (rBtnAutomovil.Checked)
            {
                transporte = "Automóvil";
            }
            else if (rBtnTren.Checked)
            {
                transporte = "Tren";
            }
            else if (rBtnAvion.Checked)
            {
                transporte = "Avión";
            }

            listBox1.Items.Add("Transporte: " + transporte);

            listBox1.Items.Add("");

            listBox1.Items.Add("Servicios Seleccinados: ");

            listBox1.Items.Add("Transporte (ida y vuelta)");

            listBox1.Items.Add("S/." + precio.ToString("F2"));

            listBox1.Items.Add("Hotel (" + (int.Parse(textBox2.Text) - 1) + " noches x " + hotelNoche.ToString("F2") + ")");

            listBox1.Items.Add("S/." + (hotelNoche * (int.Parse(textBox2.Text) - 1)).ToString("F2"));

            listBox1.Items.Add("Desayuno (" + (int.Parse(textBox2.Text)) + " dias x " + desayuno.ToString("F2") + ")");

            listBox1.Items.Add("S/." + (desayuno * (int.Parse(textBox2.Text))).ToString("F2"));

            listBox1.Items.Add("Tour Guiado");

            listBox1.Items.Add("S/." + tour.ToString("F2"));

            listBox1.Items.Add("Seguro (" + textBox2.Text + " Dias x " + seguroDia.ToString("F2") + ")");

            listBox1.Items.Add("S/." + (seguroDia * (int.Parse(textBox2.Text))).ToString("F2"));

            listBox1.Items.Add("Total: ");

            listBox1.Items.Add("S/." + (precio + (hotelNoche * (int.Parse(textBox2.Text) - 1)) + (desayuno * (int.Parse(textBox2.Text))) + tour + (seguroDia * (int.Parse(textBox2.Text)))).ToString("F2"));

        }

        private void precioTotal()
        {
            precio = 0;
            hotelNoche = 0;
            desayuno = 0;
            tour = 0;
            seguroDia = 0;


            if (comboBox3.Text.Equals("Cajamarca"))
            {
                hotelNoche = 90;
                desayuno = 20;
                tour = 50;
                seguroDia = 8;
            }
            else if (comboBox3.Text.Equals("Jaén"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 80;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 140;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 120;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 220;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 90;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 20;
                }

                if (checkBox3.Checked)
                {
                    tour = 50;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 8;
                }
            }
            else if (comboBox3.Text.Equals("Chota"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 60;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 120;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 120;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 200;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 80;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 18;
                }

                if (checkBox3.Checked)
                {
                    tour = 45;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 8;
                }
            }
            else if (comboBox3.Text.Equals("Cusco"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 160;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 260;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 140;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 3500;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 10;
                }

            }
            else if (comboBox3.Text.Equals("Sicuani"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 190;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 300;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 130;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 390;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 110;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 22;
                }

                if (checkBox3.Checked)
                {
                    tour = 75;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 9;
                }
            }
            else if (comboBox3.Text.Equals("Urubamba"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 170;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 280;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 150;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 360;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 170;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 10;
                }

            }
            else if (comboBox3.Text.Equals("Arequipa"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 140;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 230;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 150;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 320;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 140;
                }

                if (checkBox2.Checked)
                    desayuno = 28;
                {
                }

                if (checkBox3.Checked)
                {
                    tour = 90;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 9;
                }
            }
            else if (comboBox3.Text.Equals("Mollendo"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 160;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 250;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 140;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 350;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 120;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 24;
                }

                if (checkBox3.Checked)
                {
                    tour = 75;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 9;
                }
            }
            else if (comboBox3.Text.Equals("Camaná"))
            {
                if (rBtnBus.Checked)
                {
                    precio = 150;
                }
                else if (rBtnAutomovil.Checked)
                {
                    precio = 240;
                }
                else if (rBtnTren.Checked)
                {
                    precio = 160;
                }
                else if (rBtnAvion.Checked)
                {
                    precio = 340;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 110;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 22;
                }

                if (checkBox3.Checked)
                {
                    tour = 70;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 9;
                }
            }
            else if (comboBox3.Text.Equals("Medellín"))
            {

                if (rBtnAvion.Checked)
                {
                    precio = 1100;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 180;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 35;
                }

                if (checkBox3.Checked)
                {
                    tour = 130;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Envigado"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1150;
                }
                if (checkBox1.Checked)
                {
                    hotelNoche = 190;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 35;
                }

                if (checkBox3.Checked)
                {
                    tour = 130;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Rionegro"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1080;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Cali"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1050;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 160;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Palmira"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1080;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 140;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Buenaventura"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1160;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 130;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 25;
                }

                if (checkBox3.Checked)
                {
                    tour = 90;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Barranquilla"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1200;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 170;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Soledad"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1220;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 140;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Puerto Colombia"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1240;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 160;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Santiago"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 950;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 170;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Maipú"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 980;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Puente Alto"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 990;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Valparaiso"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1050;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 160;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Viña del Mar"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1080;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 190;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 35;
                }

                if (checkBox3.Checked)
                {
                    tour = 140;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Quilpué"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1060;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Concepción"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1100;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Talcahuano"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1120;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 140;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 26;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("Los Ángeles"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1150;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 135;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 25;
                }

                if (checkBox3.Checked)
                {
                    tour = 95;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 14;
                }
            }
            else if (comboBox3.Text.Equals("La Plata"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1050;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 190;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 35;
                }

                if (checkBox3.Checked)
                {
                    tour = 130;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Mar de Plata"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1120;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 180;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 140;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Bahía Blanca"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1150;
                }


                if (checkBox1.Checked)
                {
                    hotelNoche = 160;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Córdoba"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1000;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 160;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Villa Carlos Paz"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1050;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 170;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 130;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Río Cuarto"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1080;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 100;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Mendoza"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1050;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 170;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("San Rafael"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1120;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 110;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Godoy Cruz"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1060;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 165;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 115;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 15;
                }
            }
            else if (comboBox3.Text.Equals("Guadalajara"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1500;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 190;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 35;
                }

                if (checkBox3.Checked)
                {
                    tour = 150;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Puerto Vallarta"))
            {

                if (rBtnAvion.Checked)
                {
                    precio = 1650;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 220;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 40;
                }

                if (checkBox3.Checked)
                {
                    tour = 180;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Zapopan"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1530;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 180;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 33;
                }

                if (checkBox3.Checked)
                {
                    tour = 140;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Monterrey"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1450;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 200;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 35;
                }

                if (checkBox3.Checked)
                {
                    tour = 140;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("San Nicolás de los Garza"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1480;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 170;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Guadalupe"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1470;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 175;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 120;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Merida"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1600;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 180;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 32;
                }

                if (checkBox3.Checked)
                {
                    tour = 140;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Valladolid"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1680;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 150;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 28;
                }

                if (checkBox3.Checked)
                {
                    tour = 130;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }
            }
            else if (comboBox3.Text.Equals("Progreso"))
            {
                if (rBtnAvion.Checked)
                {
                    precio = 1650;
                }

                if (checkBox1.Checked)
                {
                    hotelNoche = 160;
                }

                if (checkBox2.Checked)
                {
                    desayuno = 30;
                }

                if (checkBox3.Checked)
                {
                    tour = 135;
                }

                if (checkBox4.Checked)
                {
                    seguroDia = 18;
                }

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            rBtnBus.Checked = false;
            rBtnAutomovil.Checked = false;
            rBtnTren.Checked = false;
            rBtnAvion.Checked = false;

            listBox1.Items.Clear();
        }
    }



}
