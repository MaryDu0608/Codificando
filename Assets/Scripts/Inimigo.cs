using NUnit.Framework;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int dano;
    public int vida;
    public bool specialAttack;


    private void Awake()
    {
        dano = Random.Range(1, 21);
        specialAttack = dano > 10;
    }

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
