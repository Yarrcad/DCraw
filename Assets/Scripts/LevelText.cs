using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text level;

    // Start is called before the first frame update
    void Start()
    {
        level.text = "Level: " + GlobalVarbs.level;
    }

    // Update is called once per frame
    void Update()
    {
        level.text = "Lavel: " + GlobalVarbs.level;
    }
}
