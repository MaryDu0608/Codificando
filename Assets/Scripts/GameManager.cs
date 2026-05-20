using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<Inimigo> inimigoList = new();

    private void Start()
    {
        for(int i = 0; i < inimigoList.Count; i++)
        {
            inimigoList[i].Atacar();

        }
    }
}
