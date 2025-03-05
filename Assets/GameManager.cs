using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject cutSceneAvatar;
    [SerializeField] GameObject playerArmature;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransferControlToUser()
    {
        //copy the position and rotation of the cut scene avatar to the play armature  
        playerArmature.transform.position= cutSceneAvatar.transform.position;
        playerArmature.transform.rotation = cutSceneAvatar.transform.rotation;
        //then disable the cut scene avatar
        cutSceneAvatar.SetActive(false);
        //then enable the player armature
        playerArmature.SetActive(true);

    }
}
