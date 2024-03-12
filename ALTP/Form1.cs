using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ALTP
{
    public partial class Form1 : Form
    {
        private bool isPanelVisible;

        private System.Threading.Timer timer;
        private bool isColorChanged;
        ALTP.GradientColorPanel panel1 = new ALTP.GradientColorPanel()
        {
            StartColor = Color.Red,
            EndColor = Color.Orange
        };

        ALTP.GradientColorPanel panel12 = new ALTP.GradientColorPanel()
        {
            StartColor = Color.Green,
            EndColor = Color.Yellow
        };
        public Form1()
        {

           
           // this.panel1.Controls.Add(this.label1);
            panel1.Location = new System.Drawing.Point(31, 91);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(236, 71);
            panel1.TabIndex = 1;
            this.Controls.Add(panel1);


            panel12.Location = new System.Drawing.Point(31, 91);
            panel12.Name = "panel12";
            panel12.Size = new System.Drawing.Size(236, 71);
            panel12.TabIndex = 1;
            this.Controls.Add(panel12);

            timer = new System.Threading.Timer(TogglePanelVisibility, null, 0, 500);


            //timer = new System.Threading.Timer(ChangePanelColor, null, 0, 2000);

            ALTP.GradientColorPanel panel2 = new ALTP.GradientColorPanel()
            {
                StartColor = Color.Red,
                EndColor = Color.Orange
            };
            // this.panel1.Controls.Add(this.label1);
            panel2.Location = new System.Drawing.Point(31, 200);
            panel2.Name = "panel1";
            panel2.Size = new System.Drawing.Size(236, 71);
            panel2.TabIndex = 1;
            this.Controls.Add(panel2);


            ALTP.GradientColorPanel panel3 = new ALTP.GradientColorPanel()
            {
                StartColor = Color.Red,
                EndColor = Color.Orange
            };
            // this.panel1.Controls.Add(this.label1);
            panel3.Location = new System.Drawing.Point(31, 310);
            panel3.Name = "panel1";
            panel3.Size = new System.Drawing.Size(236, 71);
            panel3.TabIndex = 1;
            this.Controls.Add(panel3);


            ALTP.GradientColorPanel panel4 = new ALTP.GradientColorPanel()
            {
                StartColor = Color.Red,
                EndColor = Color.DarkRed
            };
            // this.panel1.Controls.Add(this.label1);
            panel4.Location = new System.Drawing.Point(31, 420);
            panel4.Name = "panel1";
            panel4.Size = new System.Drawing.Size(236, 71);
            panel4.TabIndex = 1;
            this.Controls.Add(panel4);


            Label label = new Label()
            {
                Text = "Bắt đầu",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel1.Controls.Add(label);
            CenterControlInPanel(label, panel1);


            Label label12 = new Label()
            {
                Text = "Bắt đầu",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel12.Controls.Add(label12);
            CenterControlInPanel(label12, panel12);

            Label label2 = new Label()
            {
                Text = "Hướng dẫn",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel2.Controls.Add(label2);
            CenterControlInPanel(label2, panel2);


            Label label3 = new Label()
            {
                Text = "Cài đặt",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel3.Controls.Add(label3);
            CenterControlInPanel(label3, panel3);


            Label label4 = new Label()
            {
                Text = "Thoát",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel4.Controls.Add(label4);
            CenterControlInPanel(label4, panel4);

            InitializeComponent();
          


        }
       

        private void TogglePanelVisibility(object state)
        {

            if (panel1.InvokeRequired)
            {
                panel1.Invoke(new MethodInvoker(delegate { TogglePanelVisibility(state); }));
            }
            else
            {
                isPanelVisible = !isPanelVisible;
                panel1.Visible = isPanelVisible;
            }
            /*
                        isPanelVisible = !isPanelVisible;
                        if(isPanelVisible )
                        {
                            panel1.Visible = false;
                            panel12.Visible = true;


                        }
                        else
                        {
                            panel1.Visible = true;
                            panel12.Visible = false;

                        }*/
            /* if (panel1.InvokeRequired)
             {
                 panel1.Invoke(new MethodInvoker(TogglePanelVisibility));
             }
             else
             {
                 isPanelVisible = !isPanelVisible;
                 panel1.Visible = isPanelVisible;
             }*/
        }
        private void CenterControlInPanel(Control control, Panel panel)
        {
            control.Anchor = AnchorStyles.None;
            control.Location = new Point((panel.Width - control.Width) / 2, (panel.Height - control.Height) / 2);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
