using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;

public class RoomList : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    public RoomInfo info;

    public void SetUp(RoomInfo _info)
    {
        info = _info;
        text.text = _info.Name;
    }

    public void OnCLick()
    {
        Launcher.Instance.JoinRoom(info);
    }
}
