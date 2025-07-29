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
// defines a scope
    public class CalculatorForm : Form {
    // all C# code is contained in classes
        private TextBox, textBox1, textBox2;
        private Label labelResults;
        private Button btnAdd, btnSubtract, btnMultiply, btnDivide;

        public CalculatorForm() {
            this.Text = "Simple Calculator";
            this.Size = new Size(300, 250);

            Label lbl1 = new Label()
            { Text = "Number 1: ", Location = new Point(10, 20) };
            textBox1 = new TextBox() { Location = new Point(100, 20), Width = 150 };
            Label lbl2 = new Label()
            { Text = "Number 2:", Location = new Point(10, 60) };
            textBox2 = new TextBox() { Location = new Point(100, 60), Width = 150 };

            btnAdd = new Button() { };
            btnSubtract = new Button() { };
            btnMultiply = new Button() { };
            btnDivide = new Button() { };

            labelResult = new Label() {
                Text = "Result:", Location = new Point(10, 150), Width = 250 };

            btnAdd.Click += (s, e) => Calculate((a, b)->a + b);
            btnSubtract.Click += (s, e) => Calculate((a, b)->a + b);
            btnMultiply.Click += (s, e) => Calculate((a, b)->a + b);
            btnDivide.Click += (s, e) =>
            {
                if (GetNumber(textBox2) == 0)
                {
                    MessageBox.Show("Can't divide by zero.");
                    return;
                }
                Calculate((a, b) => a / b);
            };

            Controls.AddRange(new Control[] {
                lbl1, textBox1, lbl2, textBox2, btnAdd, btnSubtract, btnMultiply,
                btnDivide, labelResult
            });
        }

        private void Calculate(Func<double, double, double> operation) {
            double num1 = GetNum(textBox1);
            double num2 = GetNum(textBox2);
            double result = operation(num1, num2);
            labelResults.Text = $"Result: {result}";
        }

        private double GetNum(TextBox tb) {
            if (double.TryParse(tb.Text, out double val)) return val;
            MessageBox.Show("Invalid input.");
            return 0;
        }

        [STAThread]
        //
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new CalculatorForm());
        }

    }
 }

 // handwriting syntax for file to learn C#
 // noticing C# is very similar to Java :)