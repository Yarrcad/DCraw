using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerController thePlayer;

    public GameObject gameOverScreen;


    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (thePlayer.dead == true)
        {
            if (GlobalVarbs.level > GlobalVarbs.highest)
                GlobalVarbs.highest = GlobalVarbs.level;
       
        }

    }

}
