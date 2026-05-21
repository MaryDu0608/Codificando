using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int vida;
    public int dano;
    public float velocidade;

    public void Atacar()
    {
        vida -= dano;
    }
    void Start()
    {
        
    }

}
