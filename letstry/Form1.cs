using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letstry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Input_Reader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Output.Text = Input_Reader.Text; // Display TextBox input in the label
                Processor processor = new Processor();
                Output.Text = processor.ProcessInput(Input_Reader.Text);
                e.SuppressKeyPress = true;   // Optional: suppress the "ding" sound when Enter is pressed
            }
        }
    }
}


public class Processor
{
    private long Num = 0;
    private long temp = 0;
    private long unit = 0, ten = 0, hundred = 0;
    private string number;
    private string spelling;
    private readonly string[] str = { " ", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private readonly string[] str2 = { " ", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    private readonly string hnd = "Hundred", th = "Thousand";

    // Method to process input and return result
    public string ProcessInput(string userInput)
    {
        // Example operation: Convert to uppercase
        string result = userInput.ToUpper(); // Replace with your specific logic
        number = result;
        if (TypeChecker(number))
        {
            Num = long.Parse(number);// Parsing string into long int
            if (Num==0)
            {
                return "Zero";
            }
            return LengthChecker();
        }
        else
        {
            return "Please enter the only Positive Number";
        }
        
        
       
        return result;
    }
    private bool TypeChecker(string number) /*Checking whether string is valid conatains only numbers, nothing else*/
    {
        if (Regex.IsMatch(number, @"^(\+|-)?\d+$"))
        {
                return true;
        }
        else
        {
            Console.WriteLine("Wrong Input (other than numbers) ");
            return false;
          //  UserInput();/*need to build this logic again if nedded*/ not needed
        }
        
    }
    private string LengthChecker()
    {
        
        if (Num < 0) Num *= -1;

        if (Num < 1000) { return BreakNumber(Num); };
        if (Num % 100000 == 0) { return "Zero"; }
        if (Num > 999) {
            long temp = (int)(Num / 1000);
            temp = (int)(temp % 1000);
            string temp2=BreakNumber(temp);
            Console.WriteLine("Thousand ");
            temp = (int)(Num % 1000);
            string temp3=BreakNumber(temp);
            return temp2 + "Thousand " + temp3;
        }
        return "";
    }
    private string BreakNumber(long number1)
    {
        unit = number1 % 10;
        temp = number1 / 10;
        ten = temp % 10;
        temp = number1 / 100;
        hundred = temp % 10;
        return Print(unit, ten, hundred, number1);
    }
    private string Print(long unit, long ten, long hundred, long number1)
    {
        if (number1 == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (number1 < 20)
        {
            spelling = str[number1] + " ";
        }
        else if (number1 > 19 && number1 < 100)
        {
            spelling = str2[ten] + " " + str[unit] + " ";
        }
        else if (number1 > 99 && number1 < 1000)
        {
            if (ten < 2)
            {
                temp = number1 % 100;
                spelling = str[hundred] + " " + hnd + " " + str[temp] + " ";
            }
            else
            {
                spelling = str[hundred] + " " + hnd + " " + str2[ten] + " " + str[unit] + " ";
            }
        }
        return spelling;
    }


}