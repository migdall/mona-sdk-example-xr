using Unity.Netcode;
using UnityEngine;

public class NetworkCoinCollector : NetworkBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            NetworkGameManager.Instance.DestroyCollectible(other.gameObject.GetComponent<NetworkObject>().NetworkObjectId);
            NetworkGameManager.Instance.UpdatePlayerScore(this.gameObject.GetComponent<NetworkObject>().NetworkObjectId);
        }

        if (other.gameObject.CompareTag("Cannonball"))
        {
            NetworkGameManager.Instance.UpdatePlayerScore(this.gameObject.GetComponent<NetworkObject>().NetworkObjectId, true);
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            NetworkGameManager.Instance.UpdatePlayerGameState(this.gameObject.GetComponent<NetworkObject>().NetworkObjectId);
        }
    }
}
