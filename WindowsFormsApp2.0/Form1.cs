using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxC.Enabled = false;
            textBoxB.Enabled = false;
            textBoxZ.Enabled = false;
            textBoxL.Enabled = false;
            textBoxP.Enabled = false;
            textBoxA.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                XMLConvertPlant plantXML = new XMLConvertPlant();
                if (plantXML.Convert(Form1.OpenFile(), comboBox1))
                {
                    XMLConvertPlant.GetPlant(XMLConvertPlant.plantXMLs[XMLConvertPlant.plantXMLs.Count - 1], textBoxC, textBoxB, textBoxZ, textBoxL, textBoxP, textBoxA);
                }
            }
            catch (Exception)
            {
                Clear();
                MessageBox.Show("Выбран некорректный файл", "Ошибка");
            }
            
                
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = (string)comboBox1.SelectedItem;
            int num = -1;
            bool check = false;
            foreach (var item in Plant.namesForCombo)
            {
                ++num;
                if (name == item)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Данный элемент не найден" ,"Ошибка");
                return;
            }
            XMLConvertPlant.GetPlant(XMLConvertPlant.plantXMLs[num], textBoxC, textBoxB, textBoxZ, textBoxL, textBoxP, textBoxA);

        }

        private void Clear()
        {
            textBoxC.Text = "";
            textBoxB.Text = "";
            textBoxZ.Text = "";
            textBoxL.Text = "";
            textBoxP.Text = "";
            textBoxA.Text = "";
            //comboBox1.Items.Clear();
        }

        private static string OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Users\\stars\\OneDrive\\Desktop";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return null;
            }
        }
    }

    interface IXML
    {
        bool Convert(string fileName, ComboBox comboBox);
    }
    public class Plant
    {
        public static List<string> namesForCombo = new List<string>();
        public string common;
        public string botanical;
        public string zone;
        public string light;
        public string price;
        public string availability;
    }

    public class XMLConvertPlant :  IXML
    {
        public static List<Plant> plantXMLs = new List<Plant>();

        public bool Convert(string fileName, ComboBox comboBox)
        {
            if (fileName == null)
            {
                return false;
            }

            Plant.namesForCombo.Clear();
            comboBox.Items.Clear();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);

            XmlElement xRoot = xDoc.DocumentElement; //catalog
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot) //plant
                {
                    Plant plantXML = new Plant();

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {

                        if (childnode.Name == "COMMON")
                        {
                            plantXML.common = childnode.InnerText;
                            Plant.namesForCombo.Add(childnode.InnerText);
                            comboBox.Items.Add(plantXML.common);
                        }
                        if (childnode.Name == "BOTANICAL")
                        {
                            plantXML.botanical = childnode.InnerText;
                        }
                        if (childnode.Name == "ZONE")
                        {
                            plantXML.zone = childnode.InnerText;
                        }
                        if (childnode.Name == "LIGHT")
                        {
                            plantXML.light = childnode.InnerText;
                        }
                        if (childnode.Name == "PRICE")
                        {
                            plantXML.price = childnode.InnerText;
                        }
                        if (childnode.Name == "AVAILABILITY")
                        {
                            plantXML.availability = childnode.InnerText;
                        }
                    }

                    plantXMLs.Add(plantXML);

                }

                comboBox.SelectedIndex = Plant.namesForCombo.Count - 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void GetPlant(Plant plant, params TextBox[] textBoxes)
        {
            foreach (TextBox item in textBoxes)
            {
                switch (item.Name)
                {
                    case "textBoxC":
                        item.Text = plant.common;
                        continue;
                    case "textBoxB":
                        item.Text = plant.botanical;
                        continue;
                    case "textBoxZ":
                        item.Text = plant.zone;
                        continue;
                    case "textBoxL":
                        item.Text = plant.light;
                        continue;
                    case "textBoxP":
                        item.Text = plant.price;
                        continue;
                    case "textBoxA":
                        item.Text = plant.availability;
                        continue;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
        }
    }
}
