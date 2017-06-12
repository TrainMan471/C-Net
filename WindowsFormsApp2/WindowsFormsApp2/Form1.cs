using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//This is the function created when a button from the toolbox is dragged onto the form.
        {
            MessageBox.Show("Hello I am very thirsty", "This is the title of the dialog box"); //With this line of code, when someone creates a button and clicks on it, a windown dialog box will appear and
                                                                                               //and display a message. When made like this: "MessageBox.Show("Hello", "MyText"), the second parameter will be
                                                                                               //the title of the dialog box.
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering over the button");//This line of code is created for a "Mouse Hovering Over" event.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int number = 5;
            //MessageBox.Show(number.ToString());//Since the code line "MessageBox only displays String variables, it will not display int data type variables correctly.
            //To remedy this, the "ToString" method is used to convert the int data type number into a string.

            //bool redhair = false;
            //MessageBox.Show(redhair.ToString()); 

            // object myObject = true; //You can set an object equal to anything. Here, "myObject is equal to "true".
            // MessageBox.Show(myObject.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Text = "Lemons"; //with this line of code you can access properties of your form. Here, when the button is clicked the text within button three is changed
            //to lemons.
            button3.Enabled = false;   //<-----This line of code here means that button 3 will not be able to be interacted with once it is clicked.

        }

        private void button4_Click(object sender, EventArgs e)//This function says that if the text inside the text box is 
                                                              //equal to string "Mike" then the button above it will display 
                                                              //a message box that says hello.
        {
            if (textBox1.Text == "Mike")
            {
                MessageBox.Show("Hello");
            }

            else if (textBox1.Text == "Peter")
            {
                MessageBox.Show("Hello Peter!");
            }

            else if (textBox1.Text == "Nate")
            {
                MessageBox.Show("Hello Nate");
            }

            else
            {
                MessageBox.Show("Sorry, that is not correct.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*if (!checkBox1.Checked)//Another way of writing checkBox1.Checked == "true";
            {
                MessageBox.Show("Message Box is checked.");

            }

            //Way of writing it with a bool data type:
            /* bool myBool = true;
             * if (!myBool)
             * {
             *   MessageBox.Show("myBool is true");
             *  }
             *  */

            int numberOne = 7;
            int numberTwo = 12;
            int numberThree = 17;


            if (numberOne <= numberTwo )
            {
                MessageBox.Show("7 is less than 12");
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBox1.Text == "Mike" && checkBox3.Checked && i == 0)//Combing logic statements together with AND(&&)
            {
                MessageBox.Show("hello there!");
            }



        }
    }
}
