using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strFilePath = @"C:\Users\yhsong\Documents\pgm\VRS_ImageSave\ai_setting.json";
            using (StreamReader file = File.OpenText(strFilePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);
                JObject jo = json.GetValue("ready_flag")["B16_Classify"] as JObject;
                //Dictionary<String, bool> dict = jo;
                foreach (KeyValuePair<String, JToken> keyValuePair in jo)
                {
                    Console.WriteLine(keyValuePair.Key);
                    Console.WriteLine(keyValuePair.Value);
                }

            }
        }
    }
}
