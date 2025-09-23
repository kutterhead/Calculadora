using UnityEngine;

using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{

    public Text textoResultado;

    [SerializeField] 
    float acumulador = 0f;
    float resultado = 0f;

    int actualOperation = 0;//número que indica el tipo de operación

    [SerializeField]
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
            if (igualPulsado)
            {
                igualPulsado = false;
            }
            if (lastOperation==0)
            {

                textoResultado.text = "";

            }

            textoResultado.text += numero;

        }

    }

    bool igualPulsado = false;
    public void opera(int operation)
    {
        if (operation==5 && lastOperation == 5)
        {
            return;
        }
        


        switch (lastOperation)
        {
                case 0://no hay operación

                if (igualPulsado)
                {

                }
                else
                {
                    acumulador = float.Parse(textoResultado.text);
                    textoResultado.text = "0";

                }


                break;
                case 1://suma +
                acumulador += float.Parse(textoResultado.text);
                textoResultado.text = acumulador.ToString();
                break;

                case 2://resta -
                acumulador -= float.Parse(textoResultado.text);
                textoResultado.text = acumulador.ToString();
                break;
                case 3://multiplica *
                acumulador *= float.Parse(textoResultado.text);
                textoResultado.text = acumulador.ToString();
                break;
                case 4:// divide /
                acumulador /= float.Parse(textoResultado.text);
                textoResultado.text = acumulador.ToString();
                break;
                


                default://solucion guarda el acumulador

                acumulador = float.Parse(textoResultado.text);
                textoResultado.text = "0";

                break;



        }
        if (operation == 5)
        {
            
            //lastOperation = 0;
            igualPulsado = true;
        }
        else
        {
            igualPulsado = false;

        }
            lastOperation = operation;
    }


    public void clearAll()
    {
        textoResultado.text = "0";
        acumulador = 0f;
        lastOperation = 0;

    }

    public void clearActual()
    {
        textoResultado.text = "0";


    }


}
