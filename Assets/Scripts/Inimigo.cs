using NUnit.Framework;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int dano;
    public int vida;
    public bool specialAttack;
    

    public void Atacar()
    {
        if (specialAttack)
        {
            Debug.Log("Super Ataque!");

        }
        else
        {
            Debug.Log("Ataquei");

        }
    }
    void Start()
    {

    }


    
}
