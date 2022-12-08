using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /// <summary>
    /// Variables
    /// </summary>
    /// Varaibles globales
    public int CarDors = 4;
    public int x = 2;
    public int y = 3;
    public int numberOfPeople = 5;
    public string name = "Jon Snow";
    public string enemyName = "James Moriarty";
    public bool isEven = false;



    //VAriables de clase
    bool isAlive = true;
    int applesNumber = 2;

    //casting

    int piNumber = (int)3.13;


    //Se ejecuta justo antes del Start
    private void Awake()
    {
        
    }

    bool hasTheKey = true;
    int level = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Variables locales
        float gal = 3.14f;
        Debug.Log(3 + 5);
        Debug.Log(CarDors - 3);

        if (hasTheKey)
        {
            Debug.Log("Enhorabuena, puedes pasar");
        }
        else if (level > 20)
        {
            Debug.Log("Necesitas la llave");
        }
        else
        {
            Debug.Log("Tu nivel es demasiado bajo");
        }


        string characterAction = "attack";

        switch(characterAction)
        {
            case "attack":
                Debug.Log("Al ataqueeeeer!!");
                break;
            case "heal":
                Debug.Log("Me han hecho pupita, me voy a curar");
                break;
            case "deffend":
                Debug.Log("Tengo que defenderme ante este ataque");
                break;
            case "run away":
                Debug.Log("Esto es demasiado para mi, me voy corriendo.");
                break;
            default:
                Debug.Log("Esta situación aún no ha sido programada, work in progress");
                break;
        }

        int dice = 7;

        switch(dice)
        {
            case 7:
            case 15:
            case 13:
                Debug.Log("Has inlfingido un daño moderado");
                break;
            case 10:
            case 5:
                Debug.Log("Has inflingido un daño leve");
                break;
            case 20:
                Debug.Log("Has inflingido un daño crítico");
                break;
            default:
                Debug.Log("Has fallado, eres un manta, ya puedes prepararte para correr");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //es un update que va a intervalos fijos, aunque a menos frames
    private void FixedUpdate()
    {
        
    }

    void AddTwoNumbers()
    {
        Debug.Log(x + y);
    }
}
