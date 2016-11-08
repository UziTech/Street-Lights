using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Street_Lights
{
    public partial class streetLights : Form
    {
        #region Global Variables
        Image copU = global::Street_Lights.Properties.Resources.copcaru;
        Image greenU = global::Street_Lights.Properties.Resources.greencaru;
        Image blueU = global::Street_Lights.Properties.Resources.bluecaru;
        Image redU = global::Street_Lights.Properties.Resources.redcaru;
        Image goU = global::Street_Lights.Properties.Resources.gou;
        Image slowU = global::Street_Lights.Properties.Resources.slowu;
        Image stopU = global::Street_Lights.Properties.Resources.stopu;
        Image copD = global::Street_Lights.Properties.Resources.copcard;
        Image greenD = global::Street_Lights.Properties.Resources.greencard;
        Image blueD = global::Street_Lights.Properties.Resources.bluecard;
        Image redD = global::Street_Lights.Properties.Resources.redcard;
        Image goD = global::Street_Lights.Properties.Resources.god;
        Image slowD = global::Street_Lights.Properties.Resources.slowd;
        Image stopD = global::Street_Lights.Properties.Resources.stopd;
        Image copR = global::Street_Lights.Properties.Resources.copcarr;
        Image greenR = global::Street_Lights.Properties.Resources.greencarr;
        Image blueR = global::Street_Lights.Properties.Resources.bluecarr;
        Image redR = global::Street_Lights.Properties.Resources.redcarr;
        Image goR = global::Street_Lights.Properties.Resources.gor;
        Image slowR = global::Street_Lights.Properties.Resources.slowr;
        Image stopR = global::Street_Lights.Properties.Resources.stopr;
        Image copL = global::Street_Lights.Properties.Resources.copcarl;
        Image greenL = global::Street_Lights.Properties.Resources.greencarl;
        Image blueL = global::Street_Lights.Properties.Resources.bluecarl;
        Image redL = global::Street_Lights.Properties.Resources.redcarl;
        Image goL = global::Street_Lights.Properties.Resources.gol;
        Image slowL = global::Street_Lights.Properties.Resources.slowl;
        Image stopL = global::Street_Lights.Properties.Resources.stopl;
        Random rand = new Random((int)DateTime.Now.Ticks);
        bool change = false;
        int changeS = 0;
        bool upStopped = true;
        int speed = 4;
        int traffic = 2;
        bool manual = true;
        int carsUp = 0;
        int carsDown = 0;
        int carsLeft = 0;
        int carsRight = 0;
        int numCars = 100;
        Color[] colorArray = new Color[7] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
        int colorIndex = 0;
        #endregion
        public streetLights()
        {
            InitializeComponent();
            upArrow.Image = stopU;
            downArrow.Image = stopD;
            leftArrow.Image = goL;
            rightArrow.Image = goR;
            manualToolStripMenuItem.Text = "Automatic";
            manual = false;
            speedShow.Text = "Speed " + speed.ToString();
            trafficShow.Text = "Traffic " + traffic.ToString();
        }
        private Image GetCarColorU(Image img)
        {
            Image i;
            do
            {
                int r = rand.Next(0, 100);
                if (r < 4)
                {
                    i = copU;
                }
                else if (r < 36)
                {
                    i = greenU;
                }
                else if (r < 68)
                {
                    i = blueU;
                }
                else
                {
                    i = redU;
                }
            } while (i == img);
            return i;
        }
        private Image GetCarColorD(Image img)
        {
            Image i;
            do
            {
                int r = rand.Next(0, 100);
                if (r < 4)
                {
                    i = copD;
                }
                else if (r < 36)
                {
                    i = greenD;
                }
                else if (r < 68)
                {
                    i = blueD;
                }
                else
                {
                    i = redD;
                }
            } while (i == img);
            return i;
        }
        private Image GetCarColorL(Image img)
        {
            Image i;
            do
            {
                int r = rand.Next(0, 100);
                if (r < 4)
                {
                    i = copL;
                }
                else if (r < 36)
                {
                    i = greenL;
                }
                else if (r < 68)
                {
                    i = blueL;
                }
                else
                {
                    i = redL;
                }
            } while (i == img);
            return i;
        }
        private Image GetCarColorR(Image img)
        {
            Image i;
            do
            {
                int r = rand.Next(0, 100);
                if (r < 4)
                {
                    i = copR;
                }
                else if (r < 36)
                {
                    i = greenR;
                }
                else if (r < 68)
                {
                    i = blueR;
                }
                else
                {
                    i = redR;
                }
            } while (i == img);
            return i;
        }
        private void addCarUp()
        {
            for (int i = 0; i < numCars; i++)
            {
                if (!upArray[i].Visible)
                {
                    upArray[i].Visible = true;
                    upArray[i].Image = GetCarColorU(upArray[i].Image);
                    upArray[i].Location = new Point(218, 412);
                    carsUp++;
                    break;
                }
            }
        }
        private void addCarDown()
        {
            for (int i = 0; i < numCars; i++)
            {
                if (!downArray[i].Visible)
                {
                    downArray[i].Visible = true;
                    downArray[i].Image = GetCarColorD(downArray[i].Image);
                    downArray[i].Location = new Point(170, -21);
                    carsDown++;
                    break;
                }
            }
        }
        private void addCarRight()
        {
            for (int i = 0; i < numCars; i++)
            {
                if (!rightArray[i].Visible)
                {
                    rightArray[i].Visible = true;
                    rightArray[i].Image = GetCarColorR(rightArray[i].Image);
                    rightArray[i].Location = new Point(-21, 223);
                    carsRight++;
                    break;
                }
            }
        }
        private void addCarLeft()
        {
            for (int i = 0; i < numCars; i++)
            {
                if (!leftArray[i].Visible)
                {
                    leftArray[i].Visible = true;
                    leftArray[i].Image = GetCarColorL(leftArray[i].Image);
                    leftArray[i].Location = new Point(406, 175);
                    carsLeft++;
                    break;
                }
            }
        }
        private void MoveVisibleCars()
        {
            #region Cars Moving Up
            for (int i = 0; i < numCars; i++)
            {
                if (upArray[i].Visible)
                {
                    if (upArray[i].Location.Y < -21)
                    {
                        upArray[i].Visible = false;
                    }
                    else
                    {
                        bool j = true;
                        for (int k = (i == numCars - 1) ? 0 : i + 1; k != i; k = (k == numCars - 1) ? 0 : k + 1)
                        {
                            if (upArray[k].Visible && upArray[k].Location.Y < upArray[i].Location.Y && upArray[i].Location.Y - upArray[k].Location.Y < 22 + speed)
                            {
                                j = false;
                                break;
                            }
                        }
                        if (j && (upArrow.Image == goU || upArray[i].Location.Y > 285 + speed || upArray[i].Location.Y < 285))
                        {
                            if (upArray[i].Location.Y >= 141 - speed && upArray[i].Location.Y < 141)
                            {
                                carsUp--;
                            }
                            upArray[i].Location = new Point(upArray[i].Location.X, upArray[i].Location.Y - speed);
                        }
                    }
                }
            }
            #endregion
            #region Cars Moving Down
            for (int i = 0; i < numCars; i++)
            {
                if (downArray[i].Visible)
                {
                    if (downArray[i].Location.Y > 413)
                    {
                        downArray[i].Visible = false;
                    }
                    else
                    {
                        bool j = true;
                        for (int k = (i == numCars - 1) ? 0 : i + 1; k != i; k = (k == numCars - 1) ? 0 : k + 1)
                        {
                            if (downArray[k].Visible && downArray[k].Location.Y > downArray[i].Location.Y && downArray[k].Location.Y - downArray[i].Location.Y < 22 + speed)
                            {
                                j = false;
                                break;
                            }
                        }
                        if (j && (downArrow.Image == goD || downArray[i].Location.Y < 110 - speed || downArray[i].Location.Y > 110))
                        {
                            if (downArray[i].Location.Y <= 258 + speed && downArray[i].Location.Y > 258)
                            {
                                carsDown--;
                            }
                            downArray[i].Location = new Point(downArray[i].Location.X, downArray[i].Location.Y + speed);
                        }
                    }
                }
            }
            #endregion
            #region Cars Moving Left
            for (int i = 0; i < numCars; i++)
            {
                if (leftArray[i].Visible)
                {
                    if (leftArray[i].Location.X < -21)
                    {
                        leftArray[i].Visible = false;
                    }
                    else
                    {
                        bool j = true;
                        for (int k = (i == numCars - 1) ? 0 : i + 1; k != i; k = (k == numCars - 1) ? 0 : k + 1)
                        {
                            if (leftArray[k].Visible && leftArray[k].Location.X < leftArray[i].Location.X && leftArray[i].Location.X - leftArray[k].Location.X < 22 + speed)
                            {
                                j = false;
                                break;
                            }
                        }
                        if (j && (leftArrow.Image == goL || leftArray[i].Location.X > 275 + speed || leftArray[i].Location.X < 275))
                        {
                            if (leftArray[i].Location.X >= 136 - speed && leftArray[i].Location.X < 136)
                            {
                                carsLeft--;
                            }
                            leftArray[i].Location = new Point(leftArray[i].Location.X - speed, leftArray[i].Location.Y);
                        }
                    }
                }
            }
            #endregion
            #region Cars Moving Right
            for (int i = 0; i < numCars; i++)
            {
                if (rightArray[i].Visible)
                {
                    if (rightArray[i].Location.X > 406)
                    {
                        rightArray[i].Visible = false;
                    }
                    else
                    {
                        bool j = true;
                        for (int k = (i == numCars - 1) ? 0 : i + 1; k != i; k = (k == numCars - 1) ? 0 : k + 1)
                        {
                            if (rightArray[k].Visible && rightArray[k].Location.X > rightArray[i].Location.X && rightArray[k].Location.X - rightArray[i].Location.X < 22 + speed)
                            {
                                j = false;
                                break;
                            }
                        }
                        if (j && (rightArrow.Image == goR || rightArray[i].Location.X < 110 - speed || rightArray[i].Location.X > 110))
                        {
                            if (rightArray[i].Location.X <= 249 + speed && rightArray[i].Location.X > 249)
                            {
                                carsRight--;
                            }
                            rightArray[i].Location = new Point(rightArray[i].Location.X + speed, rightArray[i].Location.Y);
                        }
                    }
                }
            }
            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int r = rand.Next(0, 100);
            if (r < 4 * traffic)
            {
                switch (r % 4)
                {
                    case 0:
                        addCarUp();
                        break;
                    case 1:
                        addCarDown();
                        break;
                    case 2:
                        addCarLeft();
                        break;
                    case 3:
                        addCarRight();
                        break;
                    default:
                        break;
                }
            }
            MoveVisibleCars();
            if (change)
            {
                if (changeS == 0)
                {
                    if (!upStopped)
                    {
                        downArrow.Image = slowD;
                        upArrow.Image = slowU;
                    }
                    else
                    {
                        leftArrow.Image = slowL;
                        rightArrow.Image = slowR;
                    }
                }
                if (changeS++ > 30 - speed)
                {
                    change = false;
                    changeS = 0;
                    if (!upStopped)
                    {
                        downArrow.Image = stopD;
                        upArrow.Image = stopU;
                        rightArrow.Image = goR;
                        leftArrow.Image = goL;
                    }
                    else
                    {
                        downArrow.Image = goD;
                        upArrow.Image = goU;
                        rightArrow.Image = stopR;
                        leftArrow.Image = stopL;
                    }
                    upStopped = !upStopped;
                }
            }
            else if (manual == false)
            {//Automatic Algorithm Begin
                if (upArrow.Image == goU && carsRight + carsLeft > carsDown + carsUp)
                {
                    change = true;
                    changeS = 0;
                }
                else if (leftArrow.Image == goL && carsRight + carsLeft < carsDown + carsUp)
                {
                    change = true;
                    changeS = 0;
                }
            }//Automatic Algorithm End
            changeColor();
        }
        private void changeColor()
        {
            if (++colorIndex == 350)
            {
                colorIndex = 0;
            }
            int index = colorIndex / 50;
            float redS = (float)colorArray[index].R;
            float redE = (float)colorArray[(index == 6)?0:index + 1].R;
            float greenS = (float)colorArray[index].G;
            float greenE = (float)colorArray[(index == 6) ? 0 : index + 1].G;
            float blueS = (float)colorArray[index].B;
            float blueE = (float)colorArray[(index == 6) ? 0 : index + 1].B;
            int red = (int)(cbtb.ForeColor.R + (redE - redS) / 50);
            int green = (int)(cbtb.ForeColor.G + (greenE - greenS) / 50);
            int blue = (int)(cbtb.ForeColor.B + (blueE - blueS) / 50);
            if (red < 0)
            {
                red = 0;
            }
            if (red > 255)
            {
                red = 255;
            }
            if (green < 0)
            {
                green = 0;
            }
            if (green > 255)
            {
                green = 255;
            }
            if (blue < 0)
            {
                blue = 0;
            }
            if (blue > 255)
            {
                blue = 255;
            }
            cbtb.ForeColor = Color.FromArgb(red, green, blue);
            uziTech.ForeColor = Color.FromArgb(red, green, blue);
        }
        private void UDArrow_Click(object sender, EventArgs e)
        {
            if (manual)
            {
                if (upArrow.Image == stopU)
                {
                    upArrow.Image = goU;
                    downArrow.Image = goD;
                }
                else
                {
                    upArrow.Image = stopU;
                    downArrow.Image = stopD;
                }
            }
            else
            {
                if (!change)
                {
                    change = true;
                    changeS = 0;
                }
            }
        }
        private void LRArrow_Click(object sender, EventArgs e)
        {
            if (manual)
            {
                if (leftArrow.Image == stopL)
                {
                    leftArrow.Image = goL;
                    rightArrow.Image = goR;
                }
                else
                {
                    leftArrow.Image = stopL;
                    rightArrow.Image = stopR;
                }
            }
            else
            {
                if (!change)
                {
                    change = true;
                    changeS = 0;
                }
            }
        }
        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manualToolStripMenuItem.Text == "Manual")
            {
                manualToolStripMenuItem.Text = "Automatic";
                manual = false;
            }
            else
            {
                manualToolStripMenuItem.Text = "Manual";
                manual = true;
            }
        }
        private void car_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numCars; i++)
            {
                if (sender.Equals(upArray[i]))
                {
                    upArray[i].Image = GetCarColorU(upArray[i].Image);
                }
                else if (sender.Equals(downArray[i]))
                {
                    downArray[i].Image = GetCarColorD(downArray[i].Image);
                }
                else if (sender.Equals(leftArray[i]))
                {
                    leftArray[i].Image = GetCarColorL(leftArray[i].Image);
                }
                else if (sender.Equals(rightArray[i]))
                {
                    rightArray[i].Image = GetCarColorR(rightArray[i].Image);
                }
            }
        }
        private void speed_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                speed = (speed > 19) ? 20 : speed + 1;
            }
            else if (e.Button == MouseButtons.Right)
            {
                speed = (speed < 2) ? 1 : speed - 1;
            }
            speedShow.Text = "Speed " + speed.ToString();
        }
        private void traffic_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                traffic = (traffic > 19) ? 20 : traffic + 1;
            }
            else if (e.Button == MouseButtons.Right)
            {
                traffic = (traffic < 2) ? 1 : traffic - 1;
            }
            trafficShow.Text = "Traffic " + traffic.ToString();
        }
    }
}
