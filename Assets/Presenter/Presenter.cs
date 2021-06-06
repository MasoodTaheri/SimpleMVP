using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Presenter 
{
    //create object from model
    calculatorModel _calculator = new calculatorModel();

    //create instance from interface
    private IcalculatorView calculatorView;

    public Presenter(IcalculatorView view)
    {
        calculatorView = view;
    }

    //create method to connect between model and it's view
    public void ConnectBetweenModelAndView()
    {
        _calculator.NumberOne = Convert.ToDouble(calculatorView.TxtNumberOne);
        _calculator.NumberTwo = Convert.ToDouble(calculatorView.TxtNumberTwo);
    }

    public void calcSum()
    {
        ConnectBetweenModelAndView();
        calculatorView.TxtResult = _calculator.CalculateSumation().ToString();
    }
    public void calcSub()
    {
        ConnectBetweenModelAndView();
        calculatorView.TxtResult = _calculator.CalculateSubtraction().ToString();
    }
    public void calcmul()
    {
        ConnectBetweenModelAndView();
        calculatorView.TxtResult = _calculator.CalculateMultiplication().ToString();
    }
    public void calcDiv()
    {
        ConnectBetweenModelAndView();
        calculatorView.TxtResult = _calculator.Calculatedivition().ToString();
    }
}
