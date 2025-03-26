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

        Characters[] character = new Characters[4];
        

        public MainGame()
        {
            InitializeComponent();
        }


        private void MainGame_Load(object sender, EventArgs e) //
        {
            character[0] = new Characters(100, 2, 4, 4, 4, Resources.CharacterOneSprite);
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
                    buttons[i, j].BackgroundImage = null;
                }
            }
            foreach (int[] move in map.currentPossibleMoves) //highlights the possible moves in blue
            {
                buttons[move[0], move[1]].BackColor = Color.Blue;
            }

            if (Globals.LastPosition[0] < buttons.GetLength(0) && Globals.LastPosition[1] < buttons.GetLength(1))
            {
                buttons[Globals.LastPosition[0], Globals.LastPosition[1]].BackColor = Color.Orange;
            }


            foreach(Characters c in character) //place all characters into the map.
            {
                if (c != null)
                {
                    if (c.getXPos() < buttons.GetLength(0) && c.getYPos() < buttons.GetLength(1))
                    {
                        buttons[c.getXPos(), c.getYPos()].BackgroundImage = Resources.CharacterOneSprite; //change this to map a dictionary to character sprites
                    }
                }
            }
        }
        

        private void on_click(object sender, EventArgs e)
        {

            Button button = (sender as Button);
            int[] pos = button.Tag as int[]; //saves the position of the button clicked
            bool movemade = false;

            foreach (int[] move in map.currentPossibleMoves) //checks if the move is possible
            {
                if (pos[0] == move[0] && pos[1] == move[1])
                {
                    character[Globals.lastCharacterID].setXPos(pos[0]); //makes the move
                    character[Globals.lastCharacterID].setYPos(pos[1]);
                    movemade = true;
                    break;
                }
            }
            map.currentPossibleMoves.Clear(); //clear possible moves (if it's clicking an empty square it deselects everything)

            if (movemade == false) //if the click was not finding a move, then it could be a character click.
            {
                for (int i = 0; i < character.Length; i++)
                {
                    if (character[i] != null)
                    {
                        if (character[i].getXPos() == pos[0] && character[i].getYPos() == pos[1]) //if tile is character move it.
                        {
                            Globals.lastCharacterID = i;
                            map.moveSearch(pos[0], pos[1]);
                            break;
                        }
                    }
                }
            }

            Globals.LastPosition = pos;
            ResizeGrid();
            
        }

    }
}
