using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_ModelingHome;

namespace WindowsFormsGame_HideAndSeek
{
    public partial class GameForm : Form
    {
        int Moves;
        Location currentLocation;

        OutsideWithHidingPlace driveway;
        OutsideWithHidingPlace garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;

        Room stairs;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        RoomWithHidingPlace diningRoom;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        Opponent opponent;

        public GameForm()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void buttonGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBoxExists.SelectedIndex]);
        }

        private void buttonGoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void CreateObjects()
        {

            livingRoom = new RoomWithDoor("Living room", "Big sofa", "In wardrobe", "Oak door");
            diningRoom = new RoomWithHidingPlace("Dining room", "Big dining table", "In big cupboard");
            kitchen = new RoomWithDoor("Kitchen", "Great oven", "In cupboard","Grate door");
            stairs = new Room("Stairs", "Wood stairs");
            hallway = new RoomWithHidingPlace("Hallway", "Big picture", "In wardrobe");
            bathroom = new RoomWithHidingPlace("Bathroom", "Big bath", "In bath");
            masterBedroom = new RoomWithHidingPlace("Master bedroom", "Big bed", "Under bed");
            secondBedroom = new RoomWithHidingPlace("Bedroom", "Bed", "Under bed");

            frontYard = new OutsideWithDoor("Lawn", false, "Oak door");
            backYard = new OutsideWithDoor("Back yard", true, "Grate door");
            garden = new OutsideWithHidingPlace("Garden", false, "In barn");
            driveway = new OutsideWithHidingPlace("Driweway", true, "In garage");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            masterBedroom.Exits = new Location[] { hallway };
            bathroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            backYard.Exits = new Location[] { garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            frontYard.Exits = new Location[] { garden, driveway };
            driveway.Exits = new Location[] { backYard, frontYard };

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
        }
        private void RedrawForm()
        {
            comboBoxExists.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                comboBoxExists.Items.Add(currentLocation.Exits[i].Name);
            }
            comboBoxExists.SelectedIndex = 0;
            textBoxDescription.Text = currentLocation.Description + "\r\n (move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                buttonCheck.Text = "Check" + hidingPlace.HidingPlaceName;
                buttonCheck.Visible = true;
            }
            else
                buttonCheck.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                buttonGoThroughTheDoor.Visible = true;
            else buttonGoThroughTheDoor.Visible = false;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("I was found for " + Moves + " moves.");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                textBoxDescription.Text = $"Opponent was found for {Moves} moves. He is hiding {foundLocation.HidingPlaceName}";
            }
            Moves = 0;
            buttonHide.Visible = true;
            buttonGoHere.Visible = false;
            buttonGoThroughTheDoor.Visible = false;
            buttonCheck.Visible = false;
            comboBoxExists.Visible = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            buttonHide.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                opponent.Move();
                textBoxDescription.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            textBoxDescription.Text = "I am going to look";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            buttonGoHere.Visible = true;
            comboBoxExists.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
