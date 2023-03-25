using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button serverButton;
    [SerializeField] private Button clientButton;

    private void Awake() {
        string[] args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-launch-server") 
            {
                NetworkManager.Singleton.StartServer();
                
            }
        }

        serverButton.onClick.AddListener(() => {
            NetworkManager.Singleton.StartServer();
            Debug.Log("STARTED SERVER");
        });

        clientButton.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        });
    }
}
