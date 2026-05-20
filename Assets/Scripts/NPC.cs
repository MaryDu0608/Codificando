using UnityEngine;

public class NPC : MonoBehaviour
{
    public string nome;
    public bool interagível;
    public int idade;

    void Start()
    {
        NPC madelaine = new NPC();
        madelaine.nome = "madelaine";
        madelaine.idade = 19;
        madelaine.interagível = true;

        NPC andy = new NPC();
        andy.nome = "andy";
        andy.idade = 20;
        andy.interagível = false;
    }

   
}
