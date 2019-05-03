using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace power_projectC
{
    public partial class Form1 : Form
    {
        public int num_ofLayers { get; private set; }

        public Form1()
        {
            InitializeComponent();
            textBox_r.Enabled = false;
            textBox_r1.Enabled = false;
            textBox_r2.Enabled = false;
            textBox_r3.Enabled = false;
            textBox_r4.Enabled = false;
            textBox_e1.Enabled = false;
            textBox_e2.Enabled = false;
            textBox_e3.Enabled = false;
            textBox_e4.Enabled = false;
            textBox_q.Enabled = false;
            textBox_v.Enabled = false;

            layer1.Visible = false;
            layer2.Visible = false;
            layer3.Visible = false;
            layer4.Visible = false;

            textBox_e1min.ReadOnly = true;
            textBox_e1max.ReadOnly = true;
            textBox_thick1.ReadOnly = true;
            textBox_v1.ReadOnly = true;
            textBox_e2min.ReadOnly = true;
            textBox_e2max.ReadOnly = true;
            textBox_thick2.ReadOnly = true;
            textBox_v2.ReadOnly = true;
            textBox_e3min.ReadOnly = true;
            textBox_e3max.ReadOnly = true;
            textBox_thick3.ReadOnly = true;
            textBox_v3.ReadOnly = true;
            textBox_e4min.ReadOnly = true;
            textBox_e4max.ReadOnly = true;
            textBox_thick4.ReadOnly = true;
            textBox_v4.ReadOnly = true;
            textBox_c.ReadOnly = true;
            textBox_i.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            num_ofLayers = Convert.ToInt32(num_layers.Text);
            
            if (num_ofLayers == 2)
            {
                textBox_r.Enabled = true;
                textBox_r1.Enabled = true;
                textBox_r2.Enabled = true;
                textBox_r3.Enabled = false;
                textBox_r4.Enabled = false;
                textBox_e1.Enabled = true;
                textBox_e2.Enabled = true;
                textBox_e3.Enabled = false;
                textBox_e4.Enabled = false;
                textBox_q.Enabled = true;
                textBox_v.Enabled = true;
            }
            else if (num_ofLayers == 3)
            {
                textBox_r.Enabled = true;
                textBox_r1.Enabled = true;
                textBox_r2.Enabled = true;
                textBox_r3.Enabled = true;
                textBox_r4.Enabled = false;
                textBox_e1.Enabled = true;
                textBox_e2.Enabled = true;
                textBox_e3.Enabled = true;
                textBox_e4.Enabled = false;
                textBox_q.Enabled = true;
                textBox_v.Enabled = true;
            }
            else if (num_ofLayers == 4)
            {
                textBox_r.Enabled = true;
                textBox_r1.Enabled = true;
                textBox_r2.Enabled = true;
                textBox_r3.Enabled = true;
                textBox_r4.Enabled = true;
                textBox_e1.Enabled = true;
                textBox_e2.Enabled = true;
                textBox_e3.Enabled = true;
                textBox_e4.Enabled = true;
                textBox_q.Enabled = true;
                textBox_v.Enabled = true;
            }
        }
        
        private void enter_Click(object sender, EventArgs e)
        {
            double r, r1, r2, r3, r4, e1, e2, e3, e4, q, v;
            r = 0; r1 = 0; r2 = 0;r3 = 0;r4 = 0;e1 = 0;e2 = 0;e3 = 0;e4 = 0;q = 0;v = 0;
            if (textBox_r.Enabled == true)
            {
                r = (float)Convert.ToDouble(textBox_r.Text);
            }
            if (textBox_r1.Enabled == true)
            {
                r1 = (float)Convert.ToDouble(textBox_r1.Text);
            }
            if (textBox_r2.Enabled == true)
            {
                r2 = (float)Convert.ToDouble(textBox_r2.Text);
            }
            if (textBox_r3.Enabled == true)
            {
                r3 = (float)Convert.ToDouble(textBox_r3.Text);
            }
            if (textBox_r4.Enabled == true)
            {
                r4 = (float)Convert.ToDouble(textBox_r4.Text);
            }
            if (textBox_e1.Enabled == true)
            {
                e1 = (float)Convert.ToDouble(textBox_e1.Text);
            }
            if (textBox_e2.Enabled == true)
            {
                e2 = (float)Convert.ToDouble(textBox_e2.Text);
            }
            if (textBox_e3.Enabled == true)
            {
                e3 = (float)Convert.ToDouble(textBox_e3.Text);
            }
            if (textBox_e4.Enabled == true)
            {
                e4 = (float)Convert.ToDouble(textBox_e4.Text);
            }
            if (textBox_q.Enabled == true)
            {
                q = (float)Convert.ToDouble(textBox_q.Text);
            }
            if (textBox_v.Enabled == true)
            {
                v = (float)Convert.ToDouble(textBox_v.Text);
            }
            const double Epsilon = 8.85E-12;


            if (num_ofLayers == 2)
            {
                double v1 = q/(2 * 3.14 * Epsilon * e1) * Math.Log(r1/r);
                double v2 = q / (2 * 3.14 * Epsilon * e2) * Math.Log(r2 / r1);
                double emax1 = q / (2 * 3.14 * Epsilon * e1 * r);
                double emax2 = q / (2 * 3.14 * Epsilon * e2 * r1);
                double emin1 = q / (2 * 3.14 * Epsilon * e1 * r1);
                double emin2 = q / (2 * 3.14 * Epsilon * e2 * r2);
                double c = 2 * 3.14 * Epsilon / ((1 / e1 * Math.Log(r1 / r)) + (1 / e2 * Math.Log(r2 / r1)));
                double thickness1 = r1 - r;
                double thickness2 = r2 - r1;
                double I_ch = 2 * 3.14 * 50 * c * v;

                layer1.Visible = true;
                layer2.Visible = true;
                textBox_c.Text = c.ToString();
                textBox_i.Text = I_ch.ToString();

                textBox_e1max.Text = emax1.ToString();
                textBox_e1min.Text = emin1.ToString();
                textBox_v1.Text = v1.ToString();
                textBox_thick1.Text = thickness1.ToString();
                textBox_e2max.Text = emax2.ToString();
                textBox_e2min.Text = emin2.ToString();
                textBox_v2.Text = v2.ToString();
                textBox_thick2.Text = thickness2.ToString();
            }
            else if(num_ofLayers == 3)
            {
                double v1 = q / (2 * 3.14 * Epsilon * e1) * Math.Log(r1 / r);
                double v2 = q / (2 * 3.14 * Epsilon * e2) * Math.Log(r2 / r1);
                double v3 = q / (2 * 3.14 * Epsilon * e3) * Math.Log(r3 / r2);
                double emax1 = q / (2 * 3.14 * Epsilon * e1 * r);
                double emax2 = q / (2 * 3.14 * Epsilon * e2 * r1);
                double emax3 = q / (2 * 3.14 * Epsilon * e3 * r2);
                double emin1 = q / (2 * 3.14 * Epsilon * e1 * r1);
                double emin2 = q / (2 * 3.14 * Epsilon * e2 * r2);
                double emin3 = q / (2 * 3.14 * Epsilon * e3 * r3);
                double c = 2 * 3.14 * Epsilon / ((1 / e1 * Math.Log(r1 / r)) + (1 / e2 * Math.Log(r2 / r1)) + (1 / e3 * Math.Log(r3 / r2)));
                double thickness1 = r1 - r;
                double thickness2 = r2 - r1;
                double thickness3 = r3 - r2;
                double I_ch = 2 * 3.14 * 50 * c * v;
                layer1.Visible = true;
                layer2.Visible = true;
                layer3.Visible = true;

                textBox_c.Text = c.ToString();
                textBox_i.Text = I_ch.ToString();
                textBox_e1max.Text = emax1.ToString();
                textBox_e1min.Text = emin1.ToString();
                textBox_v1.Text = v1.ToString();
                textBox_thick1.Text = thickness1.ToString();
                textBox_e2max.Text = emax2.ToString();
                textBox_e2min.Text = emin2.ToString();
                textBox_v2.Text = v2.ToString();
                textBox_thick2.Text = thickness2.ToString();
                textBox_e3max.Text = emax3.ToString();
                textBox_e3min.Text = emin3.ToString();
                textBox_v3.Text = v3.ToString();
                textBox_thick3.Text = thickness3.ToString();
            }
            else if (num_ofLayers == 4)
            {
                double v1 = q / (2 * 3.14 * Epsilon * e1) * Math.Log(r1 / r);
                double v2 = q / (2 * 3.14 * Epsilon * e2) * Math.Log(r2 / r1);
                double v3 = q / (2 * 3.14 * Epsilon * e3) * Math.Log(r3 / r2);
                double v4 = q / (2 * 3.14 * Epsilon * e4) * Math.Log(r4 / r3);
                double emax1 = q / (2 * 3.14 * Epsilon * e1 * r);
                double emax2 = q / (2 * 3.14 * Epsilon * e2 * r1);
                double emax3 = q / (2 * 3.14 * Epsilon * e3 * r2);
                double emax4 = q / (2 * 3.14 * Epsilon * e4 * r3);
                double emin1 = q / (2 * 3.14 * Epsilon * e1 * r1);
                double emin2 = q / (2 * 3.14 * Epsilon * e2 * r2);
                double emin3 = q / (2 * 3.14 * Epsilon * e3 * r3);
                double emin4 = q / (2 * 3.14 * Epsilon * e4 * r4);
                double c = 2 * 3.14 * Epsilon / ((1 / e1 * Math.Log(r1 / r)) + (1 / e2 * Math.Log(r2 / r1)) + (1 / e3 * Math.Log(r3 / r2)) + (1 / e4 * Math.Log(r4 / r3)));
                double thickness1 = r1 - r;
                double thickness2 = r2 - r1;
                double thickness3 = r3 - r2;
                double thickness4 = r4 - r3;
                double I_ch = 2 * 3.14 * 50 * c * v;

                layer1.Visible = true;
                layer2.Visible = true;
                layer3.Visible = true;
                layer4.Visible = true;
                textBox_c.Text = c.ToString();
                textBox_i.Text = I_ch.ToString();

                textBox_e1max.Text = emax1.ToString();
                textBox_e1min.Text = emin1.ToString();
                textBox_v1.Text = v1.ToString();
                textBox_thick1.Text = thickness1.ToString();
                textBox_e2max.Text = emax2.ToString();
                textBox_e2min.Text = emin2.ToString();
                textBox_v2.Text = v2.ToString();
                textBox_thick2.Text = thickness2.ToString();
                textBox_e3max.Text = emax3.ToString();
                textBox_e3min.Text = emin3.ToString();
                textBox_v3.Text = v3.ToString();
                textBox_thick3.Text = thickness3.ToString();
                textBox_e4max.Text = emax4.ToString();
                textBox_e4min.Text = emin4.ToString();
                textBox_v4.Text = v4.ToString();
                textBox_thick4.Text = thickness4.ToString();
            }


        }
    }
}
