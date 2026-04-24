using UnityEngine;

public class Exer08 : MonoBehaviour
{
    
    string palavra = "anotaramadatadamaratona";

    string invertida = "";

    void Start()
    {
        for (int i = palavra.Length -1; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        print("String invertida: " +  invertida);
    }

    void Update()
    {
        
    }
}
