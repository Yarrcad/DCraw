using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeathText : MonoBehaviour
{
    public Text high;

    // Start is called before the first frame update
    void Start()
    {
        high.text = "Your Score: " + GlobalVarbs.level + "\nHighScore: " + GlobalVarbs.highest;
    }

    // Update is called once per frame
    void Update()
    {
        high.text = "Your Score: " + GlobalVarbs.level + "\nHighScore: " + GlobalVarbs.highest;
    }
}
