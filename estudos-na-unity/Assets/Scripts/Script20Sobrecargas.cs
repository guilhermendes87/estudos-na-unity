using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script20Sobrecargas : MonoBehaviour
{
    public int Add(int Val1, int Val2)
    {
        return Val1* Val2;
    }

    public string Add(string Str1, string Str2)
    {
        return Str1 + " " + Str2;
    }
}
