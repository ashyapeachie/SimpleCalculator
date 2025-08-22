/* 
* Author: Ashya Hamer
* Filename: SimpleCalculator.cs
* Description: This program is a simple calculator using C#. Program should have
basic arithmetic using textboxes and buttons- but the C# WindowsFrorms app is 
manually coded to be self contained version
*/

using System;
using System.Drawing;
using System.Windows.Forms;
// imports the System namespace (like import in other languages)

namespace SimpleCalculator {
// defines a scope
    public class CalculatorForm : Form {
        // all C# code is contained in classes
        private TextBox textBox1, textBox2;
        private Label labelResult;
        private Button btnAdd, btnSubtract, btnMultipy, btnDivide;

        public CalculatorForm()
        {
            this.Text = "Simple Calculator";
            // window's title will be "Simple Calculator"
            this.Size = new Size(300, 250);
            // the form size is set to 300 x 250 pixels 

            /* labels and textboxes for number inputs from user */
            Label lbl1 = new Label()
            { Text = "Number 1: ", Location = new Point(10, 20) };
            textBox1 = new TextBox() { Location = new Point(100, 20), Width = 150 };
            Label lbl2 = new Label()
            { Text = "Number 2:", Location = new Point(10, 60) };
            textBox2 = new TextBox() { Location = new Point(100, 60), Width = 150 };

            /* buttons for arithmetic */
            btnAdd = new Button() { Text = "+", Location = new Point(10, 100) };
            btnSubtract = new Button() { Text = "-", Location = new Point(60, 100) };
            btnMultiply = new Button() { Text = "x", Location = new Point(110, 100) };
            btnDivide = new Button() { Text = "÷", Location = new Point(160, 100) };
            // each button corresponds to an arithmetic operation
            // spaced horizontally

            /* result label */
            labelResult = new Label()
            {
                Text = "Result:",
                Location = new Point(10, 150),
                Width = 250
            };
            // used to display the result of the operation

            /* event handling */
            btnAdd.Click += (s, e) => Calculate((a, b)->a + b);
            btnSubtract.Click += (s, e) => Calculate((a, b)->a - b);
            btnMultiply.Click += (s, e) => Calculate((a, b)->a * b);
            btnDivide.Click += (s, e) =>
            {
                if (GetNum(textBox2) == 0)
                {
                    MessageBox.Show("Can't divide by zero.");
                    return;
                }
                Calculate((a, b) => a / b);
            };
            // specific division handling that checks for division by zero
            // shows message if the 2nd number is 0, otherwise performs division

            Controls.AddRange(new Control[] {
                lbl1, textBox1, lbl2, textBox2, btnAdd, btnSubtract, btnMultiply,
                btnDivide, labelResult
            });
            // adds all defined controls to the form so they appear in the UI
        }

        private void Calculate(Func<double, double, double> operation) {
            double num1 = GetNum(textBox1);
            double num2 = GetNum(textBox2);
            double result = operation(num1, num2);
            // variable data type- double
            labelResults.Text = $"Result: {result}";
            // assuming the method is being called
        }

        private double GetNum(TextBox tb) {
            if (double.TryParse(tb.Text, out double val)) return val;
            MessageBox.Show("Invalid input.");
            return 0;
        }
        // method 

        [STAThread]
        public static void Main() {
        // program entry point 
            Application.EnableVisualStyles();
            Application.Run(new CalculatorForm());
        }

    }

}

 // handwriting syntax for file to learn C#
 // noticing C# is very similar to Java :)