using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script25ListsDictionaries02 : MonoBehaviour
{
    public List<Script25ListsDictionaries01> OrcList = new List<Script25ListsDictionaries01>();
    Dictionary<string, Script25ListsDictionaries01> orc = new Dictionary<string, Script25ListsDictionaries01>();
    
    
    void Start()
    {
        //UsingList();
        UsingDictionary();

    }

    public void UsingList()
    {
        OrcList.Add(new Script25ListsDictionaries01("Durotan", 10, 100));
        OrcList.Add(new Script25ListsDictionaries01("Jugernaut", 15, 200));
        OrcList.Add(new Script25ListsDictionaries01("Chen", 5, 75));

        foreach (Script25ListsDictionaries01 orc in OrcList)
        {
            Debug.Log(orc.Name);
        }
    }

    public void UsingDictionary()
    {
        Script25ListsDictionaries01 orc1 = new Script25ListsDictionaries01("Durotan", 10, 100);
        Script25ListsDictionaries01 orc2 = new Script25ListsDictionaries01("Jugernaut", 15, 200);
        Script25ListsDictionaries01 orc3 = new Script25ListsDictionaries01("Chen", 5, 75);

        orc.Add("Shaman", orc1);
        orc.Add("Guerreiro", orc2);
        orc.Add("Mago", orc3);
        
    }

}
