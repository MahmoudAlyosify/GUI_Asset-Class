using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp___Asset_Class
{
   
    public partial class Form1 : Form
    {
        static string name1;
        static decimal value1;
        static decimal D_rate1;
        static string n1;
        static decimal v1;
        static decimal r1;
        static decimal depr1;
        static decimal NewValue1;
        static decimal NEW_depr1;
        //\\\\\\\\\\\\\\
        static string name2;
        static decimal value2;
        static decimal D_rate2;
        static string n2;
        static decimal v2;
        static decimal r2;
        static decimal depr2;
        static decimal NewValue2;
        static decimal NEW_depr2;
        //\\\\\\\\\\\\\\\
        class Asset
        {
            string asset_name;
            decimal asset_value;
            decimal depreciation_rate;
            public Asset()
            {
                asset_name = "";
                asset_value = 0;
                depreciation_rate = 0;
            }
            public Asset(string name, decimal value, decimal rate)
            {
                asset_name = name;
                asset_value = value;
                depreciation_rate = rate;
            }
            public string Asset_name
            {
                get { return this.asset_name; }
                set
                {
                    this.asset_name = value;
                }
            }
            public decimal Asset_value
            {
                get { return this.asset_value; }
                set
                {
                    if (value >= 0)
                        this.asset_value = value;
                }
            }
            public decimal Depreciation_rate
            {
                get { return this.depreciation_rate; }
                set
                {
                    if (value >= 0)
                        this.depreciation_rate = value / 100;
                }
            }
        }
        class AssetTest
        {
            Asset Obj1 = null;
            Asset Obj2 = null;
            public AssetTest()
            {
                Obj1 = new Asset();
                Obj2 = new Asset();
                {
                    Obj1.Asset_name = name1;
                    Obj1.Asset_value = value1;
                    Obj1.Depreciation_rate = D_rate1;
                }
                {
                  
                    Obj2.Asset_name = name2;
                    Obj2.Asset_value =value2;
                    Obj2.Depreciation_rate = D_rate2;
                }
                set_old();
                set_new();
            }
     
           
            void set_old()
            {
                n1 = Obj1.Asset_name;
                n2 = Obj2.Asset_name;
                v1 = Obj1.Asset_value;
                v2 = Obj2.Asset_value;
                r1=(Obj1.Depreciation_rate );
                r2 = (Obj2.Depreciation_rate );
                depr1 = Obj1.Depreciation_rate * Obj1.Asset_value;
                depr2=Obj2.Depreciation_rate* Obj2.Asset_value;
               
            }
            void set_new()
            {
                
               v1 = Obj1.Asset_value;
                NewValue1 = Obj1.Asset_value + (v1 * 5 / 100);
               v2 = Obj2.Asset_value;
                NewValue2 = Obj2.Asset_value + (v2 * 5 / 100);
                NEW_depr1 = Obj1.Depreciation_rate * NewValue1;
                NEW_depr2 = Obj2.Depreciation_rate * NewValue2;
            }
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          name1=textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            value1 = decimal.Parse(textBox2.Text);
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            D_rate1 = decimal.Parse(textBox3.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            name2 = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            value2= decimal.Parse(textBox5.Text);
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            D_rate2= decimal.Parse(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            AssetTest Asset1 = new AssetTest();
            label8.Text = "The Asset's data before increasing:-";
            label12.Text= " Object1's Asset name : " + "'"+n1.ToString()+"'" + " and Object2's Asset name is " + "'" + n2.ToString()+"'";
            label14.Text = " Object1's Asset value : " + v1.ToString() + " and Object2's Asset value is " + v2.ToString();
            label13.Text= " Object1's Depreciation rate : " + (r1 * 100).ToString() + "% ," + " and Object 2's Depreciation rate is " + (r2 * 100).ToString() + "%.";
            label16.Text = "The Amount of depreciation for Object1 is : " + depr1.ToString() + ", and the Amount of depreciation for Object2 is : " + depr2.ToString()+".";
            label15.Text =
                "The Asset's data After increasing:-";
            label18.Text =
                " Object1's Asset name : " + "'" + n1.ToString()+"'" + " and Object2's Asset name is " + "'" + n2.ToString()+"'"; 
            label17.Text = " Object1's Asset_value : " + NewValue1.ToString() + " and Object2's Asset_value is " + NewValue2.ToString(); ;
            label19.Text = " Object1's Depreciation rate : " + (r1 * 100).ToString() + "% ," + " and Object2's Depreciation rate is " + (r2 * 100).ToString() + "%."; 
            label20.Text = "The Amount of depreciation for Object1 is : " + NEW_depr1.ToString() + ", and the Amount of depreciation for Object2 is : " + NEW_depr2.ToString()+"."; 
        }
    }

    
}
