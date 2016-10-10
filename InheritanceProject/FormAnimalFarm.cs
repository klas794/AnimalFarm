using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceProject
{
    public partial class FormAnimalFarm : Form
    {
        List<Animal> animals;
        int[] warehouse;
        int numberOfProds;
        int ForageStock = 0;
        List<Buildings> buildings { get; set; } = new List<Buildings>();
        Dictionary<Buildings, string> buildingNames { get; set; } = new Dictionary<Buildings, string>();
        int warehouseCapacity = 1000;

        public FormAnimalFarm()
        {
            InitializeComponent();
            animals = new List<Animal>();

            numberOfProds = Enum.GetNames(typeof(Products)).Length; // Spara längden på din enum i en int för senare användning
            warehouse = new int[numberOfProds];

            warehouse[(int)Products.Milk] += 5;

            UpdateLabels();

            buildingNames[Buildings.CowShed] = "kostall";
            buildingNames[Buildings.HenShed] = "hönshus";
            buildingNames[Buildings.BigBarn] = "stor lada";

            btnBuyChicken.Enabled = false;
            btnBuyCow.Enabled = false;
        }

        private void AddProductionToWarehouse(int[] production)
        {
            for (int i = 0; i < numberOfProds; i++)
            {
                warehouse[i] += production[i];
            }
        }

        private void CreateNewChicken(string name, int age)
        {
            Chicken chick = new Chicken(name, age);
            animals.Add(chick);
        }

        private void CreateNewCow(string name, int age)
        {
            Cow chick = new Cow(name, age);
            animals.Add(chick);
        }

        private void btnBuyCow_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text == "" ? "Ko" : txtName.Text;

                CreateNewCow(name, int.Parse(txtAge.Text));
                label2.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                label2.ForeColor = Color.Red;
            }

            UpdateLabels();
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {   
            try
            {
                var name = txtName.Text == "" ? "Kyckling" : txtName.Text;

                CreateNewChicken(name, int.Parse(txtAge.Text));
                label2.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                label2.ForeColor = Color.Red;
            }

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            labelCount.Text = animals.Count().ToString();

            PrintToLabel(animals.Where(x => x.Alive).ToList(), labelInfo);
            PrintToLabel(animals.Where(x => !x.Alive).ToList(), labelInfoDead);

            lblEggs.Text = warehouse[(int)Products.Egg].ToString();
            lblMilk.Text = warehouse[(int)Products.Milk].ToString();
            lblMeat.Text = warehouse[(int)Products.Meat].ToString();

            lblForage.Text = ForageStock.ToString() + " st";

            lblBuildings.Text = string.Join(", ", buildingNames.Where(x => buildings.Contains(x.Key)).Select(x => x.Value));
        }

        private void PrintToLabel(List<Animal> list, Label label)
        {
            var strings = list.Select(x => x.Name + ", " + x.Age + " år");

            label.Text = string.Join("\n", strings);
        }

        private void btnNextYear_Click(object sender, EventArgs e)
        {
            int[] production = new int[numberOfProds];

            foreach (var animal in animals)
            {
                
                animal.TreatedWell = checkBoxFeelGood.Checked;

                animal.Feed(ref ForageStock);

                animal.HaveBirthday();

                if(animal.CalculateAgeOfNaturalDeath() == animal.Age || animal.SlaughterAge())
                {
                    animal.Alive = false;
                }

                if (warehouse.Sum() >= warehouseCapacity)
                {
                    UpdateLabels();
                    continue;
                }

                var oneProduction = animal.ProduceYearsWorth();

                production[(int)Products.Milk] += oneProduction[(int)Products.Milk];
                production[(int)Products.Egg] += oneProduction[(int)Products.Egg];
                production[(int)Products.Meat] += oneProduction[(int)Products.Meat];
                production[(int)Products.Grain] += oneProduction[(int)Products.Grain];

                /*
                if (typeof(Chicken) == animal.GetType())
                {
                    lblEggs.Text = (eggs + animal.ProductionRate).ToString();
                }
                */
            }

            AddProductionToWarehouse(production);            
            UpdateLabels();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            var eggPrice = 2;
            var milkPrice = 8;
            var meatPrice = 100;

            var eggs = warehouse[(int)Products.Egg];
            var milk = warehouse[(int)Products.Milk];
            var meat = warehouse[(int)Products.Meat];

            lblCash.Text = (eggs * eggPrice + milk * milkPrice + meat * meatPrice).ToString() + " kr";

            for (int i = 0; i < warehouse.Length; i++)
            {
                warehouse[i] = 0;
            }

            lblMilk.Text = "0";
            lblEggs.Text = "0";
            lblMeat.Text = "0";
        }

        private void btnForage_Click(object sender, EventArgs e)
        {
            ForageStock += 50;

            UpdateLabels();
        }

        private void btnButchYear_Click(object sender, EventArgs e)
        {
            try
            {
                var age = int.Parse(txtButchYear.Text);

                foreach (var animal in animals)
                {
                    animal.AgeForSlaughter = age;
                }

                txtButchYear.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                txtButchYear.ForeColor = Color.Red;
            }

        }

        private void btnBuyCowShed_Click(object sender, EventArgs e)
        {
            buildings.Add(Buildings.CowShed);
            btnBuyCow.Enabled = true;
            UpdateLabels();
        }

        private void btnBuyHenShed_Click(object sender, EventArgs e)
        {
            buildings.Add(Buildings.HenShed);
            btnBuyChicken.Enabled = true;
            UpdateLabels();
        }

        private void btnBuyBigBarn_Click(object sender, EventArgs e)
        {
            buildings.Add(Buildings.BigBarn);
            warehouseCapacity = 5000;

            if(buildings.Contains(Buildings.CowShed))
            {
                btnBuyCow.Enabled = true;
            }

            if (buildings.Contains(Buildings.HenShed))
            {
                btnBuyChicken.Enabled = true;
            }

            UpdateLabels();
        }
    }
}
