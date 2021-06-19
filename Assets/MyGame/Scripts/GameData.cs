using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "GameData")]

public class GameData : ScriptableObject, ISerializationCallbackReceiver
{

    public bool isDoorOpened = false;
    public bool isPlayerInMaze = false;
    public void OnAfterDeserialize()
    {
        isDoorOpened = false;
        isPlayerInMaze = false;
}

    public void OnBeforeSerialize()
    {
        
    }

}
