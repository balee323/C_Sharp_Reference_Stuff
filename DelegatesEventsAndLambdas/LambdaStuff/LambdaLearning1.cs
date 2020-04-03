using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LambdaStuff
{
    public class LambdaLearning1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        delegate int AddDelegate(int a, int b);

        delegate bool LogDelegate();

        public LambdaLearning1()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.BackColor = System.Drawing.Color.Beige;

            AddingInButtons();
            UsingLambdaWithDelegate();
        }

       


        //Using Anonomyous function vs Lambda for subscribing to button click event
        private void AddingInButtons()
        {
            var button1 = new Button();
            button1.Name = "btn1";
            button1.Visible = true;
            button1.Enabled = true;
            button1.Text = "Button1";
            button1.Location = new System.Drawing.Point(250, 250);


            button1.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Button was Clicked");
            };

            this.Controls.Add(button1);



            var button2 = new Button();
            button2.Name = "btn2";
            button2.Visible = true;
            button2.Enabled = true;
            button2.Text = "Button2";
            button2.Location = new System.Drawing.Point(350, 250);


            //Same anonomyous function, but using Lambda instead
            button2.Click += (s, e) => MessageBox.Show("Button was Clicked");

            this.Controls.Add(button2);
        }

        private void UsingLambdaWithDelegate()
        {
            //created instance of delegate
            AddDelegate ad = (a, b) => a + b;

            //lets invoke the delegate
            var result = ad(5, 2);
            Console.WriteLine(ad(5, 2));


            //let's see how to use a lambda assigned to a delegate that 
            //takes no parameters.  You just have a empty () parenthesis
            LogDelegate lg = () =>
            {
                Console.WriteLine("handling a log");
                return true;
            };

            //invoke the delegate
            var logHandled = lg();




        }



    }
}
