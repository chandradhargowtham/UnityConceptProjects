using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class launcher : MonoBehaviourPunCallbacks
{
    public GameObject currentObject;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.LogError("Connected To Master");
        PhotonNetwork.JoinOrCreateRoom("room",new RoomOptions { MaxPlayers=3},TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.LogError("Room Joined");
        currentObject= PhotonNetwork.Instantiate("Cube", new Vector3(0, 0, 0), Quaternion.identity);

    }

    private void Update()
    {
        if(currentObject!=null)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentObject.transform.Translate(Vector3.up);
        }
    }


}
