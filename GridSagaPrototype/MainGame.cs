using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridSagaPrototype
{
    public partial class MainGame : Form //This class  has all of the code for the visual aspect of the button grid as well as passing through any necessary code
    {
        Panel gridMap = new Panel();
        Button[,] buttons = new Button[10, 10];
        Map map = new Map(10,10);
        public MainGame()
        {
            InitializeComponent();
        }


        private void MainGame_Load(object sender, EventArgs e)
        {
            this.FormClosed += closed; //Calls upon a procedure that closes the program when this window is closed


            this.SizeChanged += ResizeGrid; //Resize the grid whenever the window is resized
            gridMap.BackColor = Color.Black;
            this.Controls.Add(gridMap);


            for (int i = 0; i < buttons.GetLength(0); i++) //This creates the buttons on the grid as well as setting the attributes of the buttns
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    gridMap.Controls.Add(buttons[i, j]);
                    buttons[i, j].Size = new Size(buttons[i, j].Parent.Width / buttons.GetLength(1), buttons[i, j].Parent.Height / buttons.GetLength(0));
                    buttons[i, j].Location = new Point((buttons[i, j].Parent.Width / buttons.GetLength(1)) * j, (buttons[i, j].Parent.Height / buttons.GetLength(0)) * i);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].BackColor = Color.Green;
                    buttons[i, j].Tag = new int[] { i, j }; 
                    buttons[i, j].Click += on_click;

                }
            }

            ResizeOnStart(); //Calls upon a procedure that resizes the window
        }

        private void closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResizeGrid(object sender, EventArgs e)
        {
            ResizeOnStart();
        }


        private void ResizeOnStart()
        {
            int scale = 66;

            int screenwidth = this.Width;
            int screenheight = this.Height;

            int scaledwidth = (this.Width * scale / 100);
            int scaledheight = (this.Height * scale / 100);

            if (scaledwidth > scaledheight)
            {
                scaledwidth = scaledheight;
            }
            else
            {
                scaledheight = scaledwidth;
            }

            gridMap.Location = new Point(screenwidth / 2 - scaledwidth / 2, screenheight / 2 - scaledheight / 2);
            gridMap.Size = new Size(scaledwidth, scaledheight);
            gridMap.BackColor = Color.Black;

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {

                    buttons[i, j].Size = new Size(buttons[i, j].Parent.Width / buttons.GetLength(1), buttons[i, j].Parent.Height / buttons.GetLength(0));

                    buttons[i, j].Location = new Point((buttons[i, j].Parent.Width / buttons.GetLength(1)) * j, (buttons[i, j].Parent.Height / buttons.GetLength(0)) * i);
                }
            }
        }

        private void on_click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Pink;
            }
            else if (button.BackColor == Color.Pink)
            {
                button.BackColor = Color.Green;
            }
            int[] pos = button.Tag as int[]; //saves the position of the button clicked
        }

    }
}
