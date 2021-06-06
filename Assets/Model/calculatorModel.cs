using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculatorModel 
{
    public double NumberOne { get; set; }
    public double NumberTwo { get; set; }

    public double CalculateSumation() { return NumberOne + NumberTwo; }
    public double CalculateSubtraction() { return NumberOne - NumberTwo; }
    public double CalculateMultiplication() { return NumberOne * NumberTwo; }
    public double Calculatedivition() { return NumberOne / NumberTwo; }
}
