using System;

public class BmiCalc
{
    //public string WeightType { get; set; }

    public static void Main()
    {
        float kilograms = 0;
        float lb = 0;
        float meters = 0;
        float inches = 0;
        //int[] height = new int[2]; 

        Console.Write("Enter the weight type (Kg for Kilogram, Lb for Pound): ");
        string wType = Console.ReadLine();

        if (wType == "Kg")
        {
            Console.Write("Please enter weight(kg): ");
            kilograms = float.Parse(Console.ReadLine());

            float lConversion = (float)(kilograms / 0.45359327);
            Console.WriteLine($"Your weight converted to pounds is: {lConversion}");
        }

        if (wType == "Lb")
        {
            Console.Write("Please enter weight(lb): ");
            lb = float.Parse(Console.ReadLine());

            float kConversion = (float)(lb * 0.45359327);
            Console.WriteLine($"Your weight converted to kilograms is: {kConversion}");
        }

        Console.Write("Enter the height type (M for Meter, I for Inches): ");
        string hType = Console.ReadLine();

        if (hType == "M")
        {
            Console.Write("Please enter height(m): ");
            meters = float.Parse(Console.ReadLine());

            float ftConversion = (float)(meters * 39.37);
            Console.Write($"Your height converted to feet is: {ftConversion} ");

            float bmi = kilograms / (meters * meters);
            Console.Write($"BMI: {bmi} ");
        }

        if(hType == "I")
        {
            Console.Write("Please enter height: ");//5'11= 71 inches
            inches = float.Parse(Console.ReadLine());

            float mConversion = (float)(inches / 39.37);
            Console.WriteLine($"Your height converted to meters is: {mConversion}");

            float bmi = lb / (inches * inches);
            Console.Write($"BMI: {bmi*703} ");
        }

        //return StringSplitOptions.RemoveEmptyEntries;
    }
}