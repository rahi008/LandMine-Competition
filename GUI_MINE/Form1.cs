using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GUI_MINE
{
    public partial class Form1 : Form
    {
        private SerialPort myport;

        public string line;
        public Form1()
        {
            InitializeComponent();
            button362.BackColor = Color.Purple;
            button363.BackColor = Color.Blue;
            
        }

        private void frwrd_btn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("F");
        }

        private void cnct_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = int.Parse(baud.Text);
                myport.PortName = comboBox1.SelectedItem.ToString();
                myport.Open();
                myport.DataReceived += OnScan;
                discnct_btn.Enabled = true;
                label3.Text = "Connected";
                label3.ForeColor = Color.Green;
                
            }

            catch
            {
                MessageBox.Show("Can't Communicate");
                label3.Text = "Disonnected";
                label3.ForeColor = Color.Red;
            }

        }

        private void bckwrd_btn_Click(object sender, EventArgs e)
        {
            
            myport.WriteLine("B");
            
        }
        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                myport.WriteLine("L");
            }
            else if (e.KeyCode.ToString() == "D")
            {
                myport.WriteLine("R");
            }
            else if (e.KeyCode.ToString() == "W")
            {
                myport.WriteLine("F");
            }
            else if (e.KeyCode.ToString() == "S")
            {
                myport.WriteLine("B");
            }
        }

        private void Form1_keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                myport.WriteLine("S");
            }
            if (e.KeyCode.ToString() == "W")
            {
                myport.WriteLine("S");
            }
            if (e.KeyCode.ToString() == "D")
            {
                myport.WriteLine("S");
            }
            if (e.KeyCode.ToString() == "S")
            {
                myport.WriteLine("S");
            }
        }

        private void discnct_btn_Click(object sender, EventArgs e)
        {
            myport.Close();
            cnct_btn.Enabled = true;
            discnct_btn.Enabled=false;
            label3.Text = "Disconnected";
            label3.ForeColor = Color.Red;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stp_btn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("S");
        }

        private void lft_btn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("L");

        }

        private void rght_btn_Click(object sender, EventArgs e)
        {

            myport.WriteLine("R");
        }
        
        void OnScan(object sender, SerialDataReceivedEventArgs args)
        {
            SerialPort port = sender as SerialPort;

            line = port.ReadExisting();

            //textBox39.Text == line.Trim(line, Strings.ChrW(Strings.Len(line) - 1))
            myport.DiscardInBuffer();
            if (line == "A1B")
                button1.BackColor = Color.Blue;
            if (line == "A1S")
                button1.BackColor = Color.Purple;
            if (line == "A2B")
                button2.BackColor = Color.Blue;
            if (line == "A2S")
                button2.BackColor = Color.Purple;
            if (line == "A3B")
                button3.BackColor = Color.Blue;
            if (line == "A3S")
                button3.BackColor = Color.Purple;
            if (line == "A4B")
                button4.BackColor = Color.Blue;
            if (line == "A4S")
                button4.BackColor = Color.Purple;
            if (line == "A5B")
                button5.BackColor = Color.Blue;
            if (line == "A5S")
                button5.BackColor = Color.Purple;
            if (line == "A6B")
                button6.BackColor = Color.Blue;
            if (line == "A6S")
                button6.BackColor = Color.Purple;
            if (line == "A7B")
                button7.BackColor = Color.Blue;
            if (line == "A7S")
                button7.BackColor = Color.Purple;
            if (line == "A8B")
                button8.BackColor = Color.Blue;
            if (line == "A8S")
                button8.BackColor = Color.Purple;
            if (line == "A9B")
                button9.BackColor = Color.Blue;
            if (line == "A9S")
                button9.BackColor = Color.Purple;
            if (line == "A10B")
                button10.BackColor = Color.Blue;
            if (line == "A10S")
                button10.BackColor = Color.Purple;
            if (line == "A11B")
                button11.BackColor = Color.Blue;
            if (line == "A11S")
                button11.BackColor = Color.Purple;
            if (line == "A12B")
                button12.BackColor = Color.Blue;
            if (line == "A12S")
                button12.BackColor = Color.Purple;
            if (line == "A13B")
                button13.BackColor = Color.Blue;
            if (line == "A13S")
                button13.BackColor = Color.Purple;
            if (line == "A14B")
                button14.BackColor = Color.Blue;
            if (line == "A14S")
                button14.BackColor = Color.Purple;
            if (line == "A15B")
                button15.BackColor = Color.Blue;
            if (line == "A15S")
                button15.BackColor = Color.Purple;
            if (line == "A16B")
                button16.BackColor = Color.Blue;
            if (line == "A16S")
                button16.BackColor = Color.Purple;
            if (line == "A17B")
                button17.BackColor = Color.Blue;
            if (line == "A17S")
                button17.BackColor = Color.Purple;
            if (line == "A18B")
                button18.BackColor = Color.Blue;
            if (line == "A18S")
                button18.BackColor = Color.Purple;
            if (line == "A19B")
                button19.BackColor = Color.Blue;
            if (line == "A19S")
                button19.BackColor = Color.Purple;
            if (line == "B19B")
                button20.BackColor = Color.Blue;
            if (line == "B19S")
                button20.BackColor = Color.Purple;
            if (line == "B18B")
                button21.BackColor = Color.Blue;
            if (line == "B18S")
                button21.BackColor = Color.Purple;
            if (line == "B17B")
                button22.BackColor = Color.Blue;
            if (line == "B17S")
                button22.BackColor = Color.Purple;
            if (line == "B16B")
                button23.BackColor = Color.Blue;
            if (line == "B16S")
                button23.BackColor = Color.Purple;
            if (line == "B15B")
                button24.BackColor = Color.Blue;
            if (line == "B15S")
                button24.BackColor = Color.Purple;
            if (line == "B14B")
                button25.BackColor = Color.Blue;
            if (line == "B14S")
                button25.BackColor = Color.Purple;
            if (line == "B13B")
                button26.BackColor = Color.Blue;
            if (line == "B13S")
                button26.BackColor = Color.Purple;
            if (line == "B12B")
                button27.BackColor = Color.Blue;
            if (line == "B12S")
                button27.BackColor = Color.Purple;
            if (line == "B11B")
                button28.BackColor = Color.Blue;
            if (line == "B11S")
                button28.BackColor = Color.Purple;
            if (line == "B10B")
                button29.BackColor = Color.Blue;
            if (line == "B10S")
                button29.BackColor = Color.Purple;
            if (line == "B9B")
                button30.BackColor = Color.Blue;
            if (line == "B9S")
                button30.BackColor = Color.Purple;
            if (line == "B8B")
                button31.BackColor = Color.Blue;
            if (line == "B8S")
                button31.BackColor = Color.Purple;
            if (line == "B7B")
                button32.BackColor = Color.Blue;
            if (line == "B7S")
                button32.BackColor = Color.Purple;
            if (line == "B6B")
                button33.BackColor = Color.Blue;
            if (line == "B6S")
                button33.BackColor = Color.Purple;
            if (line == "B5B")
                button34.BackColor = Color.Blue;
            if (line == "B5S")
                button34.BackColor = Color.Purple;
            if (line == "B4B")
                button35.BackColor = Color.Blue;
            if (line == "B4S")
                button35.BackColor = Color.Purple;
            if (line == "B3B")
                button36.BackColor = Color.Blue;
            if (line == "B3S")
                button36.BackColor = Color.Purple;
            if (line == "B2B")
                button37.BackColor = Color.Blue;
            if (line == "B2S")
                button37.BackColor = Color.Purple;
            if (line == "B1B")
                button38.BackColor = Color.Blue;
            if (line == "B1S")
                button38.BackColor = Color.Purple;
            if (line == "C1B")
                button39.BackColor = Color.Blue;
            if (line == "C1S")
                button39.BackColor = Color.Purple;
            if (line == "C2B")
                button40.BackColor = Color.Blue;
            if (line == "C2S")
                button40.BackColor = Color.Purple;
            if (line == "C3B")
                button41.BackColor = Color.Blue;
            if (line == "C3S")
                button41.BackColor = Color.Purple;
            if (line == "C4B")
                button42.BackColor = Color.Blue;
            if (line == "C4S")
                button42.BackColor = Color.Purple;
            if (line == "C5B")
                button43.BackColor = Color.Blue;
            if (line == "C5S")
                button43.BackColor = Color.Purple;
            if (line == "C6B")
                button44.BackColor = Color.Blue;
            if (line == "C6S")
                button44.BackColor = Color.Purple;
            if (line == "C7B")
                button45.BackColor = Color.Blue;
            if (line == "C7S")
                button45.BackColor = Color.Purple;
            if (line == "C8B")
                button46.BackColor = Color.Blue;
            if (line == "C8S")
                button46.BackColor = Color.Purple;
            if (line == "C9B")
                button47.BackColor = Color.Blue;
            if (line == "C9S")
                button47.BackColor = Color.Purple;
            if (line == "C10B")
                button48.BackColor = Color.Blue;
            if (line == "C10S")
                button48.BackColor = Color.Purple;
            if (line == "C11B")
                button49.BackColor = Color.Blue;
            if (line == "C11S")
                button49.BackColor = Color.Purple;
            if (line == "C12B")
                button50.BackColor = Color.Blue;
            if (line == "C12S")
                button50.BackColor = Color.Purple;
            if (line == "C13B")
                button51.BackColor = Color.Blue;
            if (line == "C13S")
                button51.BackColor = Color.Purple;
            if (line == "C14B")
                button52.BackColor = Color.Blue;
            if (line == "C14S")
                button52.BackColor = Color.Purple;
            if (line == "C15B")
                button53.BackColor = Color.Blue;
            if (line == "C15S")
                button53.BackColor = Color.Purple;
            if (line == "C16B")
                button54.BackColor = Color.Blue;
            if (line == "C16S")
                button54.BackColor = Color.Purple;
            if (line == "C17B")
                button55.BackColor = Color.Blue;
            if (line == "C17S")
                button55.BackColor = Color.Purple;
            if (line == "C18B")
                button56.BackColor = Color.Blue;
            if (line == "C18S")
                button56.BackColor = Color.Purple;
            if (line == "C19B")
                button57.BackColor = Color.Blue;
            if (line == "C19S")
                button57.BackColor = Color.Purple;
            if (line == "D19B")
                button58.BackColor = Color.Blue;
            if (line == "D19S")
                button58.BackColor = Color.Purple;
            if (line == "D18B")
                button59.BackColor = Color.Blue;
            if (line == "D18S")
                button59.BackColor = Color.Purple;
            if (line == "D17B")
                button60.BackColor = Color.Blue;
            if (line == "D17S")
                button60.BackColor = Color.Purple;
            if (line == "D16B")
                button61.BackColor = Color.Blue;
            if (line == "D16S")
                button61.BackColor = Color.Purple;
            if (line == "D15B")
                button62.BackColor = Color.Blue;
            if (line == "D15S")
                button62.BackColor = Color.Purple;
            if (line == "D14B")
                button63.BackColor = Color.Blue;
            if (line == "D14S")
                button63.BackColor = Color.Purple;
            if (line == "D13B")
                button64.BackColor = Color.Blue;
            if (line == "D13S")
                button64.BackColor = Color.Purple;
            if (line == "B12B")
                button65.BackColor = Color.Blue;
            if (line == "D12S")
                button65.BackColor = Color.Purple;
            if (line == "D11B")
                button66.BackColor = Color.Blue;
            if (line == "D11S")
                button66.BackColor = Color.Purple;
            if (line == "D10B")
                button67.BackColor = Color.Blue;
            if (line == "D10S")
                button67.BackColor = Color.Purple;
            if (line == "D9B")
                button68.BackColor = Color.Blue;
            if (line == "D9S")
                button68.BackColor = Color.Purple;
            if (line == "D8B")
                button69.BackColor = Color.Blue;
            if (line == "D8S")
                button69.BackColor = Color.Purple;
            if (line == "D7B")
                button70.BackColor = Color.Blue;
            if (line == "D7S")
                button70.BackColor = Color.Purple;
            if (line == "D6B")
                button71.BackColor = Color.Blue;
            if (line == "D6S")
                button71.BackColor = Color.Purple;
            if (line == "D5B")
                button72.BackColor = Color.Blue;
            if (line == "D5S")
                button72.BackColor = Color.Purple;
            if (line == "D4B")
                button73.BackColor = Color.Blue;
            if (line == "D4S")
                button73.BackColor = Color.Purple;
            if (line == "D3B")
                button74.BackColor = Color.Blue;
            if (line == "D3S")
                button74.BackColor = Color.Purple;
            if (line == "D2B")
                button75.BackColor = Color.Blue;
            if (line == "D2S")
                button75.BackColor = Color.Purple;
            if (line == "D1B")
                button76.BackColor = Color.Blue;
            if (line == "D1S")
                button76.BackColor = Color.Purple;
            if (line == "E1B")
                button77.BackColor = Color.Blue;
            if (line == "E1S")
                button77.BackColor = Color.Purple;
            if (line == "E2B")
                button78.BackColor = Color.Blue;
            if (line == "E2S")
                button78.BackColor = Color.Purple;
            if (line == "E3B")
                button79.BackColor = Color.Blue;
            if (line == "E3S")
                button79.BackColor = Color.Purple;
            if (line == "E4B")
                button80.BackColor = Color.Blue;
            if (line == "E4S")
                button80.BackColor = Color.Purple;
            if (line == "E5B")
                button81.BackColor = Color.Blue;
            if (line == "E5S")
                button81.BackColor = Color.Purple;
            if (line == "E6B")
                button82.BackColor = Color.Blue;
            if (line == "E6S")
                button82.BackColor = Color.Purple;
            if (line == "E7B")
                button83.BackColor = Color.Blue;
            if (line == "E7S")
                button83.BackColor = Color.Purple;
            if (line == "E8B")
                button84.BackColor = Color.Blue;
            if (line == "E8S")
                button84.BackColor = Color.Purple;
            if (line == "E9B")
                button85.BackColor = Color.Blue;
            if (line == "E9S")
                button85.BackColor = Color.Purple;
            if (line == "E10B")
                button86.BackColor = Color.Blue;
            if (line == "E10S")
                button86.BackColor = Color.Purple;
            if (line == "E11B")
                button87.BackColor = Color.Blue;
            if (line == "E11S")
                button87.BackColor = Color.Purple;
            if (line == "E12B")
                button88.BackColor = Color.Blue;
            if (line == "E12S")
                button88.BackColor = Color.Purple;
            if (line == "E13B")
                button89.BackColor = Color.Blue;
            if (line == "E13S")
                button89.BackColor = Color.Purple;
            if (line == "E14B")
                button90.BackColor = Color.Blue;
            if (line == "E14S")
                button90.BackColor = Color.Purple;
            if (line == "E15B")
                button91.BackColor = Color.Blue;
            if (line == "E15S")
                button91.BackColor = Color.Purple;
            if (line == "E16B")
                button92.BackColor = Color.Blue;
            if (line == "E16S")
                button92.BackColor = Color.Purple;
            if (line == "E17B")
                button93.BackColor = Color.Blue;
            if (line == "E17S")
                button93.BackColor = Color.Purple;
            if (line == "E18B")
                button94.BackColor = Color.Blue;
            if (line == "E18S")
                button94.BackColor = Color.Purple;
            if (line == "E19B")
                button95.BackColor = Color.Blue;
            if (line == "E19S")
                button95.BackColor = Color.Purple;
            if (line == "F19B")
                button96.BackColor = Color.Blue;
            if (line == "F19S")
                button96.BackColor = Color.Purple;
            if (line == "F18B")
                button97.BackColor = Color.Blue;
            if (line == "F18S")
                button97.BackColor = Color.Purple;
            if (line == "F17B")
                button98.BackColor = Color.Blue;
            if (line == "F17S")
                button98.BackColor = Color.Purple;
            if (line == "F16B")
                button99.BackColor = Color.Blue;
            if (line == "F16S")
                button99.BackColor = Color.Purple;
            if (line == "F15B")
                button100.BackColor = Color.Blue;
            if (line == "F15S")
                button100.BackColor = Color.Purple;
            if (line == "F14B")
                button101.BackColor = Color.Blue;
            if (line == "F14S")
                button101.BackColor = Color.Purple;
            if (line == "F13B")
                button102.BackColor = Color.Blue;
            if (line == "F13S")
                button102.BackColor = Color.Purple;
            if (line == "F12B")
                button103.BackColor = Color.Blue;
            if (line == "F12S")
                button103.BackColor = Color.Purple;
            if (line == "F11B")
                button104.BackColor = Color.Blue;
            if (line == "F11S")
                button104.BackColor = Color.Purple;
            if (line == "F10B")
                button105.BackColor = Color.Blue;
            if (line == "F10S")
                button105.BackColor = Color.Purple;
            if (line == "F9B")
                button106.BackColor = Color.Blue;
            if (line == "F9S")
                button106.BackColor = Color.Purple;
            if (line == "F8B")
                button107.BackColor = Color.Blue;
            if (line == "F8S")
                button107.BackColor = Color.Purple;
            if (line == "F7B")
                button108.BackColor = Color.Blue;
            if (line == "F7S")
                button108.BackColor = Color.Purple;
            if (line == "F6B")
                button109.BackColor = Color.Blue;
            if (line == "F6S")
                button109.BackColor = Color.Purple;
            if (line == "F5B")
                button110.BackColor = Color.Blue;
            if (line == "F5S")
                button110.BackColor = Color.Purple;
            if (line == "F4B")
                button111.BackColor = Color.Blue;
            if (line == "F4S")
                button111.BackColor = Color.Purple;
            if (line == "F3B")
                button112.BackColor = Color.Blue;
            if (line == "F3S")
                button112.BackColor = Color.Purple;
            if (line == "F2B")
                button113.BackColor = Color.Blue;
            if (line == "F2S")
                button113.BackColor = Color.Purple;
            if (line == "F1B")
                button114.BackColor = Color.Blue;
            if (line == "F1S")
                button114.BackColor = Color.Purple;
            if (line == "G1B")
                button115.BackColor = Color.Blue;
            if (line == "G1S")
                button115.BackColor = Color.Purple;
            if (line == "G2B")
                button116.BackColor = Color.Blue;
            if (line == "G2S")
                button116.BackColor = Color.Purple;
            if (line == "G3B")
                button117.BackColor = Color.Blue;
            if (line == "G3S")
                button117.BackColor = Color.Purple;
            if (line == "G4B")
                button118.BackColor = Color.Blue;
            if (line == "G4S")
                button118.BackColor = Color.Purple;
            if (line == "G5B")
                button119.BackColor = Color.Blue;
            if (line == "G5S")
                button119.BackColor = Color.Purple;
            if (line == "G6B")
                button120.BackColor = Color.Blue;
            if (line == "G6S")
                button120.BackColor = Color.Purple;
            if (line == "G7B")
                button121.BackColor = Color.Blue;
            if (line == "G7S")
                button121.BackColor = Color.Purple;
            if (line == "G8B")
                button122.BackColor = Color.Blue;
            if (line == "G8S")
                button122.BackColor = Color.Purple;
            if (line == "G9B")
                button123.BackColor = Color.Blue;
            if (line == "G9S")
                button123.BackColor = Color.Purple;
            if (line == "G10B")
                button124.BackColor = Color.Blue;
            if (line == "G10S")
                button124.BackColor = Color.Purple;
            if (line == "G11B")
                button125.BackColor = Color.Blue;
            if (line == "G11S")
                button125.BackColor = Color.Purple;
            if (line == "G12B")
                button126.BackColor = Color.Blue;
            if (line == "G12S")
                button126.BackColor = Color.Purple;
            if (line == "G13B")
                button127.BackColor = Color.Blue;
            if (line == "G13S")
                button127.BackColor = Color.Purple;
            if (line == "G14B")
                button128.BackColor = Color.Blue;
            if (line == "G14S")
                button128.BackColor = Color.Purple;
            if (line == "G15B")
                button129.BackColor = Color.Blue;
            if (line == "G15S")
                button129.BackColor = Color.Purple;
            if (line == "G16B")
                button130.BackColor = Color.Blue;
            if (line == "G16S")
                button130.BackColor = Color.Purple;
            if (line == "G17B")
                button131.BackColor = Color.Blue;
            if (line == "G17S")
                button131.BackColor = Color.Purple;
            if (line == "G18B")
                button132.BackColor = Color.Blue;
            if (line == "G18S")
                button132.BackColor = Color.Purple;
            if (line == "G19B")
                button133.BackColor = Color.Blue;
            if (line == "G19S")
                button133.BackColor = Color.Purple;
            if (line == "H19B")
                button134.BackColor = Color.Blue;
            if (line == "H19S")
                button134.BackColor = Color.Purple;
            if (line == "H18B")
                button135.BackColor = Color.Blue;
            if (line == "H18S")
                button135.BackColor = Color.Purple;
            if (line == "H17B")
                button136.BackColor = Color.Blue;
            if (line == "H17S")
                button136.BackColor = Color.Purple;
            if (line == "H16B")
                button137.BackColor = Color.Blue;
            if (line == "H16S")
                button137.BackColor = Color.Purple;
            if (line == "H15B")
                button138.BackColor = Color.Blue;
            if (line == "H15S")
                button138.BackColor = Color.Purple;
            if (line == "H14B")
                button139.BackColor = Color.Blue;
            if (line == "H14S")
                button139.BackColor = Color.Purple;
            if (line == "H13B")
                button140.BackColor = Color.Blue;
            if (line == "H13S")
                button140.BackColor = Color.Purple;
            if (line == "H12B")
                button141.BackColor = Color.Blue;
            if (line == "H12S")
                button141.BackColor = Color.Purple;
            if (line == "H11B")
                button142.BackColor = Color.Blue;
            if (line == "H11S")
                button142.BackColor = Color.Purple;
            if (line == "H10B")
                button143.BackColor = Color.Blue;
            if (line == "H10S")
                button143.BackColor = Color.Purple;
            if (line == "H9B")
                button144.BackColor = Color.Blue;
            if (line == "H9S")
                button144.BackColor = Color.Purple;
            if (line == "H8B")
                button145.BackColor = Color.Blue;
            if (line == "H8S")
                button145.BackColor = Color.Purple;
            if (line == "H7B")
                button146.BackColor = Color.Blue;
            if (line == "H7S")
                button146.BackColor = Color.Purple;
            if (line == "H6B")
                button147.BackColor = Color.Blue;
            if (line == "H6S")
                button147.BackColor = Color.Purple;
            if (line == "H5B")
                button148.BackColor = Color.Blue;
            if (line == "H5S")
                button148.BackColor = Color.Purple;
            if (line == "H4B")
                button149.BackColor = Color.Blue;
            if (line == "H4S")
                button149.BackColor = Color.Purple;
            if (line == "H3B")
                button150.BackColor = Color.Blue;
            if (line == "H3S")
                button150.BackColor = Color.Purple;
            if (line == "H2B")
                button151.BackColor = Color.Blue;
            if (line == "H2S")
                button151.BackColor = Color.Purple;
            if (line == "H1B")
                button152.BackColor = Color.Blue;
            if (line == "H1S")
                button152.BackColor = Color.Purple;
            if (line == "I1B")
                button153.BackColor = Color.Blue;
            if (line == "I1S")
                button153.BackColor = Color.Purple;
            if (line == "I2B")
                button154.BackColor = Color.Blue;
            if (line == "I2S")
                button154.BackColor = Color.Purple;
            if (line == "I3B")
                button155.BackColor = Color.Blue;
            if (line == "I3S")
                button155.BackColor = Color.Purple;
            if (line == "I4B")
                button156.BackColor = Color.Blue;
            if (line == "I4S")
                button156.BackColor = Color.Purple;
            if (line == "I5B")
                button157.BackColor = Color.Blue;
            if (line == "I5S")
                button157.BackColor = Color.Purple;
            if (line == "I6B")
                button158.BackColor = Color.Blue;
            if (line == "I6S")
                button158.BackColor = Color.Purple;
            if (line == "I7B")
                button159.BackColor = Color.Blue;
            if (line == "I7S")
                button159.BackColor = Color.Purple;
            if (line == "I8B")
                button160.BackColor = Color.Blue;
            if (line == "I8S")
                button160.BackColor = Color.Purple;
            if (line == "I9B")
                button161.BackColor = Color.Blue;
            if (line == "I9S")
                button161.BackColor = Color.Purple;
            if (line == "I10B")
                button162.BackColor = Color.Blue;
            if (line == "I10S")
                button162.BackColor = Color.Purple;
            if (line == "I11B")
                button163.BackColor = Color.Blue;
            if (line == "I11S")
                button163.BackColor = Color.Purple;
            if (line == "I12B")
                button164.BackColor = Color.Blue;
            if (line == "I12S")
                button164.BackColor = Color.Purple;
            if (line == "I13B")
                button165.BackColor = Color.Blue;
            if (line == "I13S")
                button165.BackColor = Color.Purple;
            if (line == "I14B")
                button166.BackColor = Color.Blue;
            if (line == "I14S")
                button166.BackColor = Color.Purple;
            if (line == "I15B")
                button167.BackColor = Color.Blue;
            if (line == "I15S")
                button167.BackColor = Color.Purple;
            if (line == "I16B")
                button168.BackColor = Color.Blue;
            if (line == "I16S")
                button168.BackColor = Color.Purple;
            if (line == "I17B")
                button169.BackColor = Color.Blue;
            if (line == "I17S")
                button169.BackColor = Color.Purple;
            if (line == "I18B")
                button170.BackColor = Color.Blue;
            if (line == "I18S")
                button170.BackColor = Color.Purple;
            if (line == "I19B")
                button171.BackColor = Color.Blue;
            if (line == "I19S")
                button171.BackColor = Color.Purple;
            if (line == "J19B")
                button172.BackColor = Color.Blue;
            if (line == "J19S")
                button172.BackColor = Color.Purple;
            if (line == "J18B")
                button173.BackColor = Color.Blue;
            if (line == "J18S")
                button173.BackColor = Color.Purple;
            if (line == "J17B")
                button174.BackColor = Color.Blue;
            if (line == "J17S")
                button174.BackColor = Color.Purple;
            if (line == "J16B")
                button175.BackColor = Color.Blue;
            if (line == "J16S")
                button175.BackColor = Color.Purple;
            if (line == "J15B")
                button176.BackColor = Color.Blue;
            if (line == "J15S")
                button176.BackColor = Color.Purple;
            if (line == "J14B")
                button177.BackColor = Color.Blue;
            if (line == "J14S")
                button177.BackColor = Color.Purple;
            if (line == "J13B")
                button178.BackColor = Color.Blue;
            if (line == "J13S")
                button178.BackColor = Color.Purple;
            if (line == "J12B")
                button179.BackColor = Color.Blue;
            if (line == "J12S")
                button179.BackColor = Color.Purple;
            if (line == "J11B")
                button180.BackColor = Color.Blue;
            if (line == "J11S")
                button180.BackColor = Color.Purple;
            if (line == "J10B")
                button181.BackColor = Color.Blue;
            if (line == "J10S")
                button181.BackColor = Color.Purple;
            if (line == "J9B")
                button182.BackColor = Color.Blue;
            if (line == "J9S")
                button182.BackColor = Color.Purple;
            if (line == "J8B")
                button183.BackColor = Color.Blue;
            if (line == "J8S")
                button183.BackColor = Color.Purple;
            if (line == "J7B")
                button184.BackColor = Color.Blue;
            if (line == "J7S")
                button184.BackColor = Color.Purple;
            if (line == "J6B")
                button185.BackColor = Color.Blue;
            if (line == "J6S")
                button185.BackColor = Color.Purple;
            if (line == "J5B")
                button186.BackColor = Color.Blue;
            if (line == "J5S")
                button186.BackColor = Color.Purple;
            if (line == "J4B")
                button187.BackColor = Color.Blue;
            if (line == "J4S")
                button187.BackColor = Color.Purple;
            if (line == "J3B")
                button188.BackColor = Color.Blue;
            if (line == "J3S")
                button188.BackColor = Color.Purple;
            if (line == "J2B")
                button189.BackColor = Color.Blue;
            if (line == "J2S")
                button189.BackColor = Color.Purple;
            if (line == "J1B")
                button190.BackColor = Color.Blue;
            if (line == "J1S")
                button190.BackColor = Color.Purple;
            if (line == "K1B")
                button191.BackColor = Color.Blue;
            if (line == "K1S")
                button191.BackColor = Color.Purple;
            if (line == "K2B")
                button192.BackColor = Color.Blue;
            if (line == "K2S")
                button192.BackColor = Color.Purple;
            if (line == "K3B")
                button193.BackColor = Color.Blue;
            if (line == "K3S")
                button193.BackColor = Color.Purple;
            if (line == "K4B")
                button194.BackColor = Color.Blue;
            if (line == "K4S")
                button194.BackColor = Color.Purple;
            if (line == "K5B")
                button195.BackColor = Color.Blue;
            if (line == "K5S")
                button195.BackColor = Color.Purple;
            if (line == "K6B")
                button196.BackColor = Color.Blue;
            if (line == "K6S")
                button196.BackColor = Color.Purple;
            if (line == "K7B")
                button197.BackColor = Color.Blue;
            if (line == "K7S")
                button197.BackColor = Color.Purple;
            if (line == "K8B")
                button198.BackColor = Color.Blue;
            if (line == "K8S")
                button198.BackColor = Color.Purple;
            if (line == "K9B")
                button199.BackColor = Color.Blue;
            if (line == "k9S")
                button199.BackColor = Color.Purple;
            if (line == "K10B")
                button200.BackColor = Color.Blue;
            if (line == "K10S")
                button200.BackColor = Color.Purple;
            if (line == "K11B")
                button201.BackColor = Color.Blue;
            if (line == "K11S")
                button201.BackColor = Color.Purple;
            if (line == "K12B")
                button202.BackColor = Color.Blue;
            if (line == "K12S")
                button202.BackColor = Color.Purple;
            if (line == "K13B")
                button203.BackColor = Color.Blue;
            if (line == "K13S")
                button203.BackColor = Color.Purple;
            if (line == "K14B")
                button204.BackColor = Color.Blue;
            if (line == "K14S")
                button204.BackColor = Color.Purple;
            if (line == "K15B")
                button205.BackColor = Color.Blue;
            if (line == "K15S")
                button205.BackColor = Color.Purple;
            if (line == "K16B")
                button206.BackColor = Color.Blue;
            if (line == "K16S")
                button206.BackColor = Color.Purple;
            if (line == "K17B")
                button207.BackColor = Color.Blue;
            if (line == "K17S")
                button207.BackColor = Color.Purple;
            if (line == "K18B")
                button208.BackColor = Color.Blue;
            if (line == "K18S")
                button208.BackColor = Color.Purple;
            if (line == "K19B")
                button209.BackColor = Color.Blue;
            if (line == "K19S")
                button209.BackColor = Color.Purple;
            if (line == "L19B")
                button210.BackColor = Color.Blue;
            if (line == "L19S")
                button210.BackColor = Color.Purple;
            if (line == "L18B")
                button211.BackColor = Color.Blue;
            if (line == "L18S")
                button211.BackColor = Color.Purple;
            if (line == "L17B")
                button212.BackColor = Color.Blue;
            if (line == "L17S")
                button212.BackColor = Color.Purple;
            if (line == "L16B")
                button213.BackColor = Color.Blue;
            if (line == "L16S")
                button213.BackColor = Color.Purple;
            if (line == "L15B")
                button214.BackColor = Color.Blue;
            if (line == "L15S")
                button214.BackColor = Color.Purple;
            if (line == "L14B")
                button215.BackColor = Color.Blue;
            if (line == "L14S")
                button215.BackColor = Color.Purple;
            if (line == "L13B")
                button216.BackColor = Color.Blue;
            if (line == "L13S")
                button216.BackColor = Color.Purple;
            if (line == "L12B")
                button217.BackColor = Color.Blue;
            if (line == "L12S")
                button217.BackColor = Color.Purple;
            if (line == "L11B")
                button218.BackColor = Color.Blue;
            if (line == "L11S")
                button218.BackColor = Color.Purple;
            if (line == "L10B")
                button219.BackColor = Color.Blue;
            if (line == "L10S")
                button219.BackColor = Color.Purple;
            if (line == "L9B")
                button220.BackColor = Color.Blue;
            if (line == "L9S")
                button220.BackColor = Color.Purple;
            if (line == "L8B")
                button221.BackColor = Color.Blue;
            if (line == "L8S")
                button221.BackColor = Color.Purple;
            if (line == "L7B")
                button222.BackColor = Color.Blue;
            if (line == "L7S")
                button222.BackColor = Color.Purple;
            if (line == "L6B")
                button223.BackColor = Color.Blue;
            if (line == "L6S")
                button223.BackColor = Color.Purple;
            if (line == "L5B")
                button224.BackColor = Color.Blue;
            if (line == "L5S")
                button224.BackColor = Color.Purple;
            if (line == "L4B")
                button225.BackColor = Color.Blue;
            if (line == "L4S")
                button225.BackColor = Color.Purple;
            if (line == "L3B")
                button226.BackColor = Color.Blue;
            if (line == "L3S")
                button226.BackColor = Color.Purple;
            if (line == "L2B")
                button227.BackColor = Color.Blue;
            if (line == "L2S")
                button227.BackColor = Color.Purple;
            if (line == "L1B")
                button228.BackColor = Color.Blue;
            if (line == "L1S")
                button228.BackColor = Color.Purple;
            if (line == "M1B")
                button229.BackColor = Color.Blue;
            if (line == "M1S")
                button229.BackColor = Color.Purple;
            if (line == "M2B")
                button230.BackColor = Color.Blue;
            if (line == "M2S")
                button230.BackColor = Color.Purple;
            if (line == "M3B")
                button231.BackColor = Color.Blue;
            if (line == "M3S")
                button231.BackColor = Color.Purple;
            if (line == "M4B")
                button232.BackColor = Color.Blue;
            if (line == "M4S")
                button232.BackColor = Color.Purple;
            if (line == "M5B")
                button233.BackColor = Color.Blue;
            if (line == "M5S")
                button233.BackColor = Color.Purple;
            if (line == "M6B")
                button234.BackColor = Color.Blue;
            if (line == "M6S")
                button234.BackColor = Color.Purple;
            if (line == "M7B")
                button235.BackColor = Color.Blue;
            if (line == "M7S")
                button235.BackColor = Color.Purple;
            if (line == "M8B")
                button236.BackColor = Color.Blue;
            if (line == "M8S")
                button236.BackColor = Color.Purple;
            if (line == "M9B")
                button237.BackColor = Color.Blue;
            if (line == "M9S")
                button237.BackColor = Color.Purple;
            if (line == "M10B")
                button238.BackColor = Color.Blue;
            if (line == "M10S")
                button238.BackColor = Color.Purple;
            if (line == "M11B")
                button239.BackColor = Color.Blue;
            if (line == "M11S")
                button239.BackColor = Color.Purple;
            if (line == "M12B")
                button240.BackColor = Color.Blue;
            if (line == "M12S")
                button240.BackColor = Color.Purple;
            if (line == "M13B")
                button241.BackColor = Color.Blue;
            if (line == "M13S")
                button241.BackColor = Color.Purple;
            if (line == "M14B")
                button242.BackColor = Color.Blue;
            if (line == "M14S")
                button242.BackColor = Color.Purple;
            if (line == "M15B")
                button243.BackColor = Color.Blue;
            if (line == "M15S")
                button243.BackColor = Color.Purple;
            if (line == "M16B")
                button244.BackColor = Color.Blue;
            if (line == "M16S")
                button244.BackColor = Color.Purple;
            if (line == "M17B")
                button245.BackColor = Color.Blue;
            if (line == "M17S")
                button245.BackColor = Color.Purple;
            if (line == "M18B")
                button246.BackColor = Color.Blue;
            if (line == "M18S")
                button246.BackColor = Color.Purple;
            if (line == "M19B")
                button247.BackColor = Color.Blue;
            if (line == "M19S")
                button247.BackColor = Color.Purple;
            if (line == "N19B")
                button248.BackColor = Color.Blue;
            if (line == "N19S")
                button248.BackColor = Color.Purple;
            if (line == "N18B")
                button249.BackColor = Color.Blue;
            if (line == "N18S")
                button249.BackColor = Color.Purple;
            if (line == "N17B")
                button250.BackColor = Color.Blue;
            if (line == "N17S")
                button250.BackColor = Color.Purple;
            if (line == "N16B")
                button251.BackColor = Color.Blue;
            if (line == "N16S")
                button251.BackColor = Color.Purple;
            if (line == "N15B")
                button252.BackColor = Color.Blue;
            if (line == "N15S")
                button252.BackColor = Color.Purple;
            if (line == "N14B")
                button253.BackColor = Color.Blue;
            if (line == "N14S")
                button253.BackColor = Color.Purple;
            if (line == "N13B")
                button254.BackColor = Color.Blue;
            if (line == "N13S")
                button254.BackColor = Color.Purple;
            if (line == "N12B")
                button255.BackColor = Color.Blue;
            if (line == "N12S")
                button255.BackColor = Color.Purple;
            if (line == "N11B")
                button256.BackColor = Color.Blue;
            if (line == "N11S")
                button256.BackColor = Color.Purple;
            if (line == "N10B")
                button257.BackColor = Color.Blue;
            if (line == "N10S")
                button257.BackColor = Color.Purple;
            if (line == "N9B")
                button258.BackColor = Color.Blue;
            if (line == "N9S")
                button258.BackColor = Color.Purple;
            if (line == "N8B")
                button259.BackColor = Color.Blue;
            if (line == "N8S")
                button259.BackColor = Color.Purple;
            if (line == "N7B")
                button260.BackColor = Color.Blue;
            if (line == "N7S")
                button260.BackColor = Color.Purple;
            if (line == "N6B")
                button261.BackColor = Color.Blue;
            if (line == "N6S")
                button261.BackColor = Color.Purple;
            if (line == "N5B")
                button262.BackColor = Color.Blue;
            if (line == "N5S")
                button262.BackColor = Color.Purple;
            if (line == "N4B")
                button263.BackColor = Color.Blue;
            if (line == "N4S")
                button263.BackColor = Color.Purple;
            if (line == "N3B")
                button264.BackColor = Color.Blue;
            if (line == "N3S")
                button264.BackColor = Color.Purple;
            if (line == "N2B")
                button265.BackColor = Color.Blue;
            if (line == "N2S")
                button265.BackColor = Color.Purple;
            if (line == "N1B")
                button266.BackColor = Color.Blue;
            if (line == "N1S")
                button266.BackColor = Color.Purple;
            if (line == "O1B")
                button267.BackColor = Color.Blue;
            if (line == "O1S")
                button267.BackColor = Color.Purple;
            if (line == "O2B")
                button268.BackColor = Color.Blue;
            if (line == "O2S")
                button268.BackColor = Color.Purple;
            if (line == "O3B")
                button269.BackColor = Color.Blue;
            if (line == "O3S")
                button269.BackColor = Color.Purple;
            if (line == "O4B")
                button270.BackColor = Color.Blue;
            if (line == "O4S")
                button270.BackColor = Color.Purple;
            if (line == "O5B")
                button271.BackColor = Color.Blue;
            if (line == "O5S")
                button271.BackColor = Color.Purple;
            if (line == "O6B")
                button272.BackColor = Color.Blue;
            if (line == "O6S")
                button272.BackColor = Color.Purple;
            if (line == "O7B")
                button273.BackColor = Color.Blue;
            if (line == "O7S")
                button273.BackColor = Color.Purple;
            if (line == "O8B")
                button274.BackColor = Color.Blue;
            if (line == "O8S")
                button274.BackColor = Color.Purple;
            if (line == "O9B")
                button275.BackColor = Color.Blue;
            if (line == "O9S")
                button275.BackColor = Color.Purple;
            if (line == "O10B")
                button276.BackColor = Color.Blue;
            if (line == "O10S")
                button276.BackColor = Color.Purple;
            if (line == "O11B")
                button277.BackColor = Color.Blue;
            if (line == "O11S")
                button277.BackColor = Color.Purple;
            if (line == "O12B")
                button278.BackColor = Color.Blue;
            if (line == "O12S")
                button278.BackColor = Color.Purple;
            if (line == "O13B")
                button279.BackColor = Color.Blue;
            if (line == "O13S")
                button279.BackColor = Color.Purple;
            if (line == "O14B")
                button280.BackColor = Color.Blue;
            if (line == "O14S")
                button280.BackColor = Color.Purple;
            if (line == "O15B")
                button281.BackColor = Color.Blue;
            if (line == "O15S")
                button281.BackColor = Color.Purple;
            if (line == "O16B")
                button282.BackColor = Color.Blue;
            if (line == "O16S")
                button282.BackColor = Color.Purple;
            if (line == "O17B")
                button283.BackColor = Color.Blue;
            if (line == "O17S")
                button283.BackColor = Color.Purple;
            if (line == "O18B")
                button284.BackColor = Color.Blue;
            if (line == "O18S")
                button284.BackColor = Color.Purple;
            if (line == "O19B")
                button285.BackColor = Color.Blue;
            if (line == "O19S")
                button285.BackColor = Color.Purple;
            if (line == "P19B")
                button286.BackColor = Color.Blue;
            if (line == "P19S")
                button286.BackColor = Color.Purple;
            if (line == "P18B")
                button287.BackColor = Color.Blue;
            if (line == "P18S")
                button287.BackColor = Color.Purple;
            if (line == "P17B")
                button288.BackColor = Color.Blue;
            if (line == "P17S")
                button288.BackColor = Color.Purple;
            if (line == "P16B")
                button289.BackColor = Color.Blue;
            if (line == "P16S")
                button289.BackColor = Color.Purple;
            if (line == "P15B")
                button290.BackColor = Color.Blue;
            if (line == "P15S")
                button290.BackColor = Color.Purple;
            if (line == "P14B")
                button291.BackColor = Color.Blue;
            if (line == "P14S")
                button291.BackColor = Color.Purple;
            if (line == "P13B")
                button292.BackColor = Color.Blue;
            if (line == "P13S")
                button292.BackColor = Color.Purple;
            if (line == "P12B")
                button293.BackColor = Color.Blue;
            if (line == "P12S")
                button293.BackColor = Color.Purple;
            if (line == "P11B")
                button294.BackColor = Color.Blue;
            if (line == "P11S")
                button294.BackColor = Color.Purple;
            if (line == "P10B")
                button295.BackColor = Color.Blue;
            if (line == "P10S")
                button295.BackColor = Color.Purple;
            if (line == "P9B")
                button296.BackColor = Color.Blue;
            if (line == "P9S")
                button296.BackColor = Color.Purple;
            if (line == "P8B")
                button297.BackColor = Color.Blue;
            if (line == "P8S")
                button297.BackColor = Color.Purple;
            if (line == "P7B")
                button298.BackColor = Color.Blue;
            if (line == "P7S")
                button298.BackColor = Color.Purple;
            if (line == "P6B")
                button299.BackColor = Color.Blue;
            if (line == "P6S")
                button299.BackColor = Color.Purple;
            if (line == "P5B")
                button300.BackColor = Color.Blue;
            if (line == "P5S")
                button300.BackColor = Color.Purple;
            if (line == "P4B")
                button301.BackColor = Color.Blue;
            if (line == "P4S")
                button301.BackColor = Color.Purple;
            if (line == "P3B")
                button302.BackColor = Color.Blue;
            if (line == "P3S")
                button302.BackColor = Color.Purple;
            if (line == "P2B")
                button303.BackColor = Color.Blue;
            if (line == "P2S")
                button303.BackColor = Color.Purple;
            if (line == "P1B")
                button304.BackColor = Color.Blue;
            if (line == "P1S")
                button304.BackColor = Color.Purple;
            if (line == "Q1B")
                button305.BackColor = Color.Blue;
            if (line == "Q1S")
                button305.BackColor = Color.Purple;
            if (line == "Q2B")
                button306.BackColor = Color.Blue;
            if (line == "Q2S")
                button306.BackColor = Color.Purple;
            if (line == "Q3B")
                button307.BackColor = Color.Blue;
            if (line == "Q3S")
                button307.BackColor = Color.Purple;
            if (line == "Q4B")
                button308.BackColor = Color.Blue;
            if (line == "Q4S")
                button308.BackColor = Color.Purple;
            if (line == "Q5B")
                button309.BackColor = Color.Blue;
            if (line == "Q5S")
                button309.BackColor = Color.Purple;
            if (line == "Q6B")
                button310.BackColor = Color.Blue;
            if (line == "Q6S")
                button310.BackColor = Color.Purple;
            if (line == "Q7B")
                button311.BackColor = Color.Blue;
            if (line == "Q7S")
                button311.BackColor = Color.Purple;
            if (line == "Q8B")
                button312.BackColor = Color.Blue;
            if (line == "Q8S")
                button312.BackColor = Color.Purple;
            if (line == "Q9B")
                button313.BackColor = Color.Blue;
            if (line == "Q9S")
                button313.BackColor = Color.Purple;
            if (line == "Q10B")
                button314.BackColor = Color.Blue;
            if (line == "Q10S")
                button314.BackColor = Color.Purple;
            if (line == "Q11B")
                button315.BackColor = Color.Blue;
            if (line == "Q11S")
                button315.BackColor = Color.Purple;
            if (line == "Q12B")
                button316.BackColor = Color.Blue;
            if (line == "Q12S")
                button316.BackColor = Color.Purple;
            if (line == "Q13B")
                button317.BackColor = Color.Blue;
            if (line == "Q13S")
                button317.BackColor = Color.Purple;
            if (line == "Q14B")
                button318.BackColor = Color.Blue;
            if (line == "Q14S")
                button318.BackColor = Color.Purple;
            if (line == "Q15B")
                button319.BackColor = Color.Blue;
            if (line == "Q15S")
                button319.BackColor = Color.Purple;
            if (line == "Q16B")
                button320.BackColor = Color.Blue;
            if (line == "Q16S")
                button320.BackColor = Color.Purple;
            if (line == "Q17B")
                button321.BackColor = Color.Blue;
            if (line == "Q17S")
                button321.BackColor = Color.Purple;
            if (line == "Q18B")
                button322.BackColor = Color.Blue;
            if (line == "Q18S")
                button322.BackColor = Color.Purple;
            if (line == "Q19B")
                button323.BackColor = Color.Blue;
            if (line == "Q19S")
                button323.BackColor = Color.Purple;
            if (line == "R19B")
                button324.BackColor = Color.Blue;
            if (line == "R19S")
                button324.BackColor = Color.Purple;
            if (line == "R18B")
                button325.BackColor = Color.Blue;
            if (line == "R18S")
                button325.BackColor = Color.Purple;
            if (line == "R17B")
                button326.BackColor = Color.Blue;
            if (line == "R17S")
                button326.BackColor = Color.Purple;
            if (line == "R16B")
                button327.BackColor = Color.Blue;
            if (line == "R16S")
                button327.BackColor = Color.Purple;
            if (line == "R15B")
                button328.BackColor = Color.Blue;
            if (line == "R15S")
                button328.BackColor = Color.Purple;
            if (line == "R14B")
                button329.BackColor = Color.Blue;
            if (line == "R14S")
                button329.BackColor = Color.Purple;
            if (line == "R13B")
                button330.BackColor = Color.Blue;
            if (line == "R13S")
                button330.BackColor = Color.Purple;
            if (line == "R12B")
                button331.BackColor = Color.Blue;
            if (line == "R12S")
                button331.BackColor = Color.Purple;
            if (line == "R11B")
                button332.BackColor = Color.Blue;
            if (line == "R11S")
                button332.BackColor = Color.Purple;
            if (line == "R10B")
                button333.BackColor = Color.Blue;
            if (line == "R10S")
                button333.BackColor = Color.Purple;
            if (line == "R9B")
                button334.BackColor = Color.Blue;
            if (line == "R9S")
                button334.BackColor = Color.Purple;
            if (line == "R8B")
                button335.BackColor = Color.Blue;
            if (line == "R8S")
                button335.BackColor = Color.Purple;
            if (line == "R7B")
                button336.BackColor = Color.Blue;
            if (line == "R7S")
                button336.BackColor = Color.Purple;
            if (line == "R6B")
                button337.BackColor = Color.Blue;
            if (line == "R6S")
                button337.BackColor = Color.Purple;
            if (line == "R5B")
                button338.BackColor = Color.Blue;
            if (line == "R5S")
                button338.BackColor = Color.Purple;
            if (line == "R4B")
                button339.BackColor = Color.Blue;
            if (line == "R4S")
                button339.BackColor = Color.Purple;
            if (line == "R3B")
                button340.BackColor = Color.Blue;
            if (line == "R3S")
                button340.BackColor = Color.Purple;
            if (line == "R2B")
                button341.BackColor = Color.Blue;
            if (line == "R2S")
                button341.BackColor = Color.Purple;
            if (line == "R1B")
                button342.BackColor = Color.Blue;
            if (line == "R1S")
                button342.BackColor = Color.Purple;
            if (line == "S1B")
                button343.BackColor = Color.Blue;
            if (line == "S1S")
                button343.BackColor = Color.Purple;
            if (line == "S2B")
                button344.BackColor = Color.Blue;
            if (line == "S2S")
                button344.BackColor = Color.Purple;
            if (line == "S3B")
                button345.BackColor = Color.Blue;
            if (line == "S3S")
                button345.BackColor = Color.Purple;
            if (line == "S4B")
                button346.BackColor = Color.Blue;
            if (line == "S4S")
                button346.BackColor = Color.Purple;
            if (line == "S5B")
                button347.BackColor = Color.Blue;
            if (line == "S5S")
                button347.BackColor = Color.Purple;
            if (line == "S6B")
                button348.BackColor = Color.Blue;
            if (line == "S6S")
                button348.BackColor = Color.Purple;
            if (line == "S7B")
                button349.BackColor = Color.Blue;
            if (line == "S7S")
                button349.BackColor = Color.Purple;
            if (line == "S8B")
                button350.BackColor = Color.Blue;
            if (line == "S8S")
                button350.BackColor = Color.Purple;
            if (line == "S9B")
                button351.BackColor = Color.Blue;
            if (line == "S9S")
                button351.BackColor = Color.Purple;
            if (line == "S10B")
                button352.BackColor = Color.Blue;
            if (line == "S10S")
                button352.BackColor = Color.Purple;
            if (line == "S11B")
                button353.BackColor = Color.Blue;
            if (line == "S11S")
                button353.BackColor = Color.Purple;
            if (line == "S12B")
                button354.BackColor = Color.Blue;
            if (line == "S12S")
                button354.BackColor = Color.Purple;
            if (line == "S13B")
                button355.BackColor = Color.Blue;
            if (line == "S13S")
                button355.BackColor = Color.Purple;
            if (line == "S14B")
                button356.BackColor = Color.Blue;
            if (line == "S14S")
                button356.BackColor = Color.Purple;
            if (line == "S15B")
                button357.BackColor = Color.Blue;
            if (line == "S15S")
                button357.BackColor = Color.Purple;
            if (line == "S16B")
                button358.BackColor = Color.Blue;
            if (line == "S16S")
                button358.BackColor = Color.Purple;
            if (line == "S17B")
                button359.BackColor = Color.Blue;
            if (line == "S17S")
                button359.BackColor = Color.Purple;
            if (line == "S18B")
                button360.BackColor = Color.Blue;
            if (line == "S18S")
                button360.BackColor = Color.Purple;
            if (line == "S19B")
                button361.BackColor = Color.Blue;
            if (line == "S19S")
                button361.BackColor = Color.Purple;
        }

    }
}
