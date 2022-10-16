using Project_Graduation.Properties;
using System;
using System.Windows.Forms;

namespace Project_Graduation
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        #region Button_Event

        private void BTN_Register_Click(object sender, EventArgs e)
        {
            Form_Register RGForm = new Form_Register();
            RGForm.ShowDialog();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            Form_Login LGForm = new Form_Login();
            LGForm.ShowDialog();
            if (LGForm.DialogResult == DialogResult.OK) this.Hide();
        }

        #endregion Button_Event_End

        private void StartForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            Random rand = new Random();
            int WallpaperNum = rand.Next(1, 6);
            switch (WallpaperNum)
            {
                case 1: 
                    this.BackgroundImage = Resources.WallPaper_1;
                    break;
                case 2:
                    this.BackgroundImage = Resources.WallPaper_2;
                    break;
                case 3:
                    this.BackgroundImage = Resources.WallPaper_3;
                    break;
                case 4:
                    this.BackgroundImage = Resources.WallPaper_4;
                    break;
                case 5:
                    this.BackgroundImage = Resources.WallPaper_5;
                    break;
                case 6:
                    this.BackgroundImage = Resources.WallPaper_6;
                    break;
            }
        }

       
    }
}
