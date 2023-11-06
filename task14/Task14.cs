namespace lw4.task14;

public class Task14
{
    public Task14()
    {
        
    }

    public void run()
    {
        FractionTest();
        Console.WriteLine("\n\n\n");
        MixFractionTest();
    }

    public void FractionTest()
    {
        Console.WriteLine("Testing TFraction:");

        TFraction fraction1 = new TFraction(2, 4);
        TFraction fraction2 = new TFraction(3, 6);

        Console.WriteLine("Fraction 1: Numerator = " + fraction1.Numerator + ", Denominator = " + fraction1.Denominator);
        Console.WriteLine("Fraction 2: Numerator = " + fraction2.Numerator + ", Denominator = " + fraction2.Denominator);

        TFraction additionResult = fraction1 + fraction2;
        Console.WriteLine("Addition Result: Numerator = " + additionResult.Numerator + ", Denominator = " + additionResult.Denominator);

        TFraction subtractionResult = fraction1 - fraction2;
        Console.WriteLine("Subtraction Result: Numerator = " + subtractionResult.Numerator + ", Denominator = " + subtractionResult.Denominator);

        TFraction multiplicationResult = fraction1 * fraction2;
        Console.WriteLine("Multiplication Result: Numerator = " + multiplicationResult.Numerator + ", Denominator = " + multiplicationResult.Denominator);
        
        TFraction divisionResult = fraction1 / fraction2;
        Console.WriteLine("Division Result: Numerator = " + divisionResult.Numerator + ", Denominator = " + divisionResult.Denominator);
    }

    public void MixFractionTest()
    {
        Console.WriteLine("Testing TMixFraction:");

        TMixFraction mixFraction1 = new TMixFraction(1, 2, 3);
        TMixFraction mixFraction2 = new TMixFraction(1, 4, 2);

        Console.WriteLine("Mix Fraction 1: Whole = " + mixFraction1.Whole + ", Numerator = " + mixFraction1.Numerator + ", Denominator = " + mixFraction1.Denominator);
        Console.WriteLine("Mix Fraction 2: Whole = " + mixFraction2.Whole + ", Numerator = " + mixFraction2.Numerator + ", Denominator = " + mixFraction2.Denominator);

        TMixFraction additionResult = mixFraction1 + mixFraction2;
        Console.WriteLine("Addition Result: Whole = " + additionResult.Whole + ", Numerator = " + additionResult.Numerator + ", Denominator = " + additionResult.Denominator);

        TMixFraction subtractionResult = mixFraction1 - mixFraction2;
        Console.WriteLine("Subtraction Result: Whole = " + subtractionResult.Whole + ", Numerator = " + subtractionResult.Numerator + ", Denominator = " + subtractionResult.Denominator);

        TMixFraction multiplicationResult = mixFraction1 * mixFraction2;
        Console.WriteLine("Multiplication Result: Whole = " + multiplicationResult.Whole + ", Numerator = " + multiplicationResult.Numerator + ", Denominator = " + multiplicationResult.Denominator);
        
        TMixFraction divisionResult = mixFraction1 / mixFraction2;
        Console.WriteLine("Division Result: Whole = " + divisionResult.Whole + ", Numerator = " + divisionResult.Numerator + ", Denominator = " + divisionResult.Denominator);
    }
}