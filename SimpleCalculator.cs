/* 
* Author: Ashya Hamer
* Filename: SimpleCalculator.cs
* Description: This program is a simple calculator using C#. Program should have
basic arithmetic using textboxes and buttons- but the C# WindowsFrorms app is 
manually coded to be self contained version
 */

 using System;
// imports the System namespace 

 namespace SimpleCalculator {
    public class CalculatorForm : Form {
        private TextBox, textBox1, textBox2;
        private Label labelResults;
        private Button btnAdd, btnSubtract, btnMultiply, btnDivide;

        public CalculatorForm() {
            this.Text = "Simple Calculator";
            this.Size = new Size(300, 250);

            Label lbl1 = new Label()
            { Text = "Number 1: ", Location = new Point(10, 20) };
            textBox1 = new TextBox() { };
            Label lbl2 = new labelResult()
            { Text };
            // textBox2 = new TextBox() {};

            // btnAdd
            // btnSubtract
            // btnMultiply
            // btnDivide

            labelResult = new Label() {
                Text = "Result:", Location = new Point(10, 150), Width = 250 };

            // btnAdd.Click
            // btnSubtract.Click
            // btnMultiply.Click
            // btnDivide.Click
        }

        // private void

        // private double

        public static void Main() {

        }

    }
 }

 // handwriting syntax for file to learn C#
 // noticing C# is very similar to Java :)