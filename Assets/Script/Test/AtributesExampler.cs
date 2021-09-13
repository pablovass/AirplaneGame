using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributesExampler : MonoBehaviour
{

    [Space] // visualiza atributos agrupados en Unity
    [Header("numbers")] //nombre del grupo
    public int score;
    [SerializeField] //visualiza en unity atributo pribado en Unity
     private int money;

    [Space]
    [Header("Other values")]
    [SerializeField]
    private int password;
    [HideInInspector] //esconde atributo publico 
    public int numbersRang;


    [Space]
    [Header("Slides")]//coloca un t�tulo
    public int numberRun;

    [SerializeField]
    [Header("Text")]
    public string name;


    //Valores:
    [Space]
    [Range(0, 5)] //Delimita el rango de los valores de una variable
    public int life;

    [SerializeField]
    [Min(0)]    //Establece el valor m�nimo asignable desde el editor
    private string namee;
    [TextArea] //a�ade una caja de texto m�s grande
    private string dialoge;

    [Header("tool")]//si no le pones nonbre al heder te da error
    [Tooltip("es la id del jugadoe , cambiar con cuidado")] //a�ade una descripci�n que se muestra al colocar el mouse por encima de la propiedad
    [SerializeField]
    private string id;

    public Player player;
    

    //Visibilidad:

    //muy utilizado para testing
    [ContextMenu("nombre")] //nos permite ejecutar una funci�n desde el inspector a trav�s del nombre dado
    public void Myfunction()
    {
        Debug.Log("MyFuntion fuen ejecutada");
    }
    
    // visualizar clases en unity
    [System.Serializable]
    public class Player
    {
        public int idPlayer;
        public string namePlayer;

    }
}
