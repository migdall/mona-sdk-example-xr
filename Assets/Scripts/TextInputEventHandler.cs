using UnityEngine;
using UnityEngine.Events;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextInputEventHandler : MonoBehaviour, ISelectHandler
{
    public UnityEvent onTextSelect; 

    private UnityAction selectAction;

    void Start()
    {
        selectAction += () => HandleSelect("halo");
        onTextSelect = new UnityEvent();
        onTextSelect.AddListener(selectAction);
    }

    public void HandleSelect(string arg0)
    {
        Debug.Log("TMP Text selected: " + arg0);
        LobbyManager lobbyManager = gameObject.GetComponent<LobbyManager>();
        string lobbyId = lobbyManager.GetLobbyDataLobbyId();
        Debug.Log("Lobby ID: " + lobbyId);
        LobbyController lobbyController = GameObject.Find("Lobby").GetComponent<LobbyController>();
        lobbyController.SetSelectedLobbyId(lobbyId);
    }

    void ISelectHandler.OnSelect(BaseEventData eventData)
    {
        Debug.Log("TMP Text selected");
        onTextSelect.Invoke();
    }
}
