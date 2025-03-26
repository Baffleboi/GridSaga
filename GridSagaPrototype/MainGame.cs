using GridSagaPrototype.Properties;
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
        public Button[,] buttons = new Button[10, 10];
        public Button[,] getButtons() { return buttons; }
        public Map map = new Map(10,10,1);

        Characters playerOne = new Characters(100, 2, 4, 4, 4, Resources.CharacterOneSprite);

        public MainGame()
        {
            InitializeComponent();
        }


        private void MainGame_Load(object sender, EventArgs e) //
        {
            this.FormClosed += closed; //Calls upon a procedure that closes the program when this window is closed


            this.SizeChanged += ResizeProcedure; //Resize the grid whenever the window is resized
            this.Controls.Add(gridMap);


            for (int i = 0; i < buttons.GetLength(0); i++) //This creates the buttons on the grid as well as setting the attributes of the buttns
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    gridMap.Controls.Add(buttons[i, j]);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].BackColor = Color.SeaGreen;
                    buttons[i, j].Tag = new int[] { i, j }; 
                    buttons[i, j].Click += on_click;

               }
            }

            ResizeGrid(); //Calls upon a procedure that resizes the window
        }

        private void closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResizeProcedure(object sender, EventArgs e)
        {
            ResizeGrid();
        }


        private void ResizeGrid() //this procedure will resize the objects on the form whenever the window is resized
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

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {

                    buttons[i, j].Size = new Size(buttons[i, j].Parent.Width / buttons.GetLength(1), buttons[i, j].Parent.Height / buttons.GetLength(0));

                    buttons[i, j].Location = new Point((buttons[i, j].Parent.Width / buttons.GetLength(1)) * j, (buttons[i, j].Parent.Height / buttons.GetLength(0)) * i);
                    buttons[i, j].BackColor = map.getTile(i,j).getTileColor();
                    buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            if (Globals.LastPosition[0] < buttons.GetLength(0) && Globals.LastPosition[1] < buttons.GetLength(1))
            {
                buttons[Globals.LastPosition[0], Globals.LastPosition[1]].BackColor = Color.Orange;
            }

            if (playerOne.getXPos() < buttons.GetLength(0) && playerOne.getYPos() < buttons.GetLength(1)) 
            {
                buttons[playerOne.getXPos(), playerOne.getYPos()].BackgroundImage = Resources.CharacterOneSprite;
            }
        }
        
        private void makeGridGreen()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].BackColor = map.getTile(i, j).getTileColor();
                }
            }
        }

        private void on_click(object sender, EventArgs e)
        {
            makeGridGreen();
            Button button = (sender as Button);
            int[] pos = button.Tag as int[]; //saves the position of the button clicked
            map.moveSearch(pos[0], pos[1]);
            //-----------------------
            //Getting the list code goes here
            //-----------------------
            Globals.LastPosition = pos;
            ResizeGrid();
        }

    }
}
