using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemoWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = textBox1.Text;

            Type T = Type.GetType(TypeName);

            listMethods.Items.Clear();
            listProperties.Items.Clear();
            listConstructors.Items.Clear();

            // Methods
            MethodInfo[] methods = T.GetMethods();
            
            foreach (MethodInfo method in methods)
            {
                listMethods.Items.Add(method.ReturnType.Name+" "+method.Name);
            }

            // Properties
            PropertyInfo[] properties = T.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                listProperties.Items.Add(property.PropertyType.Name+" "+property.Name);
            }

            // Constructors
            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                listConstructors.Items.Add(constructor.ToString());
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
