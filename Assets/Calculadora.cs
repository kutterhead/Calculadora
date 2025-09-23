using UnityEngine;

using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{

    public Text textoResultado;

    [SerializeField] 
    float acumulador = 0f;
    float resultado = 0f;

    int actualOperation = 0;//número que indica el tipo de operación

    int lastOperation = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textoResultado.text = "0";
    }

   public void addNumber(string numero)
    {
        if (textoResultado.text == "0" && numero != ",")
        {
            textoResultado.text = "";
        }

        if (textoResultado.text.Contains(","))
        {
            if (numero != ",")
            {

                textoResultado.text += numero;

            }
        }else
        {
            textoResultado.text += numero;

        }

    }

    public void opera(int operation)
    {
    switch (lastOperation)
        {
                case 0://no hay operación

                acumulador = float.Parse(textoResultado.text);
                textoResultado.text = "0";

                break;
                case 1://suma +
                acumulador += float.Parse(textoResultado.text);
                textoResultado.text = acumulador.ToString();
                break;

                case 2://resta -
                break;
                case 3://multiplica *
                break;
                case 4:// divide /
                break;
                default:
                break;



        }
        lastOperation = operation;
    }


}
