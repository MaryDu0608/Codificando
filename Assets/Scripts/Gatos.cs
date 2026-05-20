using UnityEngine;

public class Gatos : MonoBehaviour
{
    public string nome;
    public bool sono;

    private void Start()
    {
        Gatos malhado = new Gatos();
        malhado.nome = "Açucarado";
        malhado.sono = true;
    }
    

    
}
