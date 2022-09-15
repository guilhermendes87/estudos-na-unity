using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script23Tavern : MonoBehaviour
{
    public Script23MyCharacter[] Chars;
    // Start is called before the first frame update
    void Start()
    {
        Chars = new Script23MyCharacter[2];
        Chars[0] = new Script23ManCharacter();
        Chars[1] = new Script23OrcCharacter();

        EnterTavern();
    }

    public void EnterTavern()
    {
        foreach(Script23MyCharacter c in Chars)
        {
            c.Say();
        }
    }


}
