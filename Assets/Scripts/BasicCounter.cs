using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCounter : MonoBehaviour
{
    public const int MaxCont = 10;
    public BasicCounter(int cont = 0)
    {
        Count = cont;
    }

    public void Increment()
    {
        Count = Mathf.Min(MaxCont, Count + 1);
    }

    public int Count { get; private set; }
}