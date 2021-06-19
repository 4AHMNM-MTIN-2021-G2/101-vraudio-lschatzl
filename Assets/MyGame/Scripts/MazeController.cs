using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour
{

    public GameData myGameData;
    public GameObject entrance;

    private Script_AnimateDoor entranceAnim;

    // Start is called before the first frame update
    void Start()
    {
        entranceAnim = entrance.GetComponent<Script_AnimateDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myGameData.isDoorOpened && myGameData.isPlayerInMaze)
        {

        }

    }
}
