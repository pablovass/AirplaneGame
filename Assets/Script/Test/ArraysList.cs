using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysList : MonoBehaviour
{
    //arrays
    public int[] nombre=new int [2] ;
    public int[] count;
    //array list 
    public List<string> names = new List<string>();
    
    
    
    private void Start()
    {
        foreach (int item in count)
        {
            Debug.Log(item);    
        }
        names.Add("juan");
        names.Add("juan1");
        names.Add("juan2");
        names.Add("juan3");
        names.Remove("juan2");

        foreach (string item in  names)
        {
            Debug.Log(item);
        }
    }
}
