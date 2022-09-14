using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script18Properties : MonoBehaviour
{
    private int Exp;

    public int Experience
    {
        get { return Exp;}
    

        set {Exp = value;}
    }

    public int Life
    {
        get { return Exp /5;}

        set { Exp = value *2;}
    }

    

}
