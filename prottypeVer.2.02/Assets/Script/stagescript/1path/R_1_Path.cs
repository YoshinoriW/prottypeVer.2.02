using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_1_Path: MonoBehaviour {
    GameObject MainScript;
    StageState stageState;
    public GameObject PseudoPlayer;
    void Start()
    {
        MainScript = GameObject.Find("Main Script");
        stageState = MainScript.GetComponent<StageState>();
        PseudoPlayer = GameObject.Find("Pseudo-player");

    }

    private void OnTriggerEnter(Collider collider)
    {
        PseudoPlayer.SendMessage("IntegerMessage");

        if (stageState.RightFlag == true)
        {
            PseudoPlayer.SendMessage("RightMessage");
        }

        Debug.Log("Centorで当たり判定が発生しました。");
    }
}
