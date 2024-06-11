using UnityEngine;

public class LobbyData : ScriptableObject
{
    [SerializeField]
    private string lobbyId;
    [SerializeField]
    private string lobbyName;

    // Public method to set the lobby ID
    public void SetLobbyId(string id)
    {
        lobbyId = id;
    }

    // Public method to get the lobby ID
    public string GetLobbyId()
    {
        return lobbyId;
    }

    // Public method to set the lobby name
    public void SetLobbyName(string name)
    {
        lobbyName = name;
    }

    // Public method to get the lobby name
    public string GetLobbyName()
    {
        return lobbyName;
    }
}
