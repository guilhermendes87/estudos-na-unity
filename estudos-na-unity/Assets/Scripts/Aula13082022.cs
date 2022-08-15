using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aula13082022 : MonoBehaviour
{
    public InputField textBox1, textBox2, textBoxResposta;
    public Button botaoSoma, botaoSubtrai;
    public int n1, n2, rSoma, rSub;

    void VerificaSoma()
    {
        n1 = int.Parse(textBox1.text);
        n2 = int.Parse(textBox2.text);
        rSoma = n1 + n2;
        
        textBoxResposta.text = rSoma.ToString();
                
        Debug.Log(rSoma);
    }
    void VerificaSubtrai()
    {
        n1 = int.Parse(textBox1.text);
        n2 = int.Parse(textBox2.text);
        rSub = n1 - n2;

        textBoxResposta.text = rSub.ToString();

        Debug.Log(rSub);
    }

    // Start is called before the first frame update
    void Start()
    {
        botaoSoma.onClick.AddListener(VerificaSoma);
        botaoSubtrai.onClick.AddListener(VerificaSubtrai);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
