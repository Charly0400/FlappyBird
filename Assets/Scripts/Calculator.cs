using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text resultText;

    [SerializeField] 
    private TMP_InputField num1;

    [SerializeField] 
    private TMP_InputField num2;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Suma()
    {
        float.TryParse(num1.text, out float firstnumber1);
        float.TryParse(num2.text, out float firstnumber2);
        float result = firstnumber1 + firstnumber2;
        resultText.text = " RESULT = " + result;
        
    }
    public void Resta()
    {
        float.TryParse(num1.text, out float firstnumber1);
        float.TryParse(num2.text, out float firstnumber2);
        float result = firstnumber1 - firstnumber2;
        resultText.text = " RESULT = " + result;
    }
    public void Div()
    {
        float.TryParse(num1.text, out float firstnumber1);
        float.TryParse(num2.text, out float firstnumber2);
        float result = firstnumber1 / firstnumber2;
        resultText.text = " RESULT = " + result;
    }
    public void Multi()
    {
        float.TryParse(num1.text, out float firstnumber1);
        float.TryParse(num2.text, out float firstnumber2);
        float result = firstnumber1 * firstnumber2;
        resultText.text = " RESULT = " + result;
    }

}