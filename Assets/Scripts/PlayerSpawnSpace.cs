using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerSpawnSpace : MonoBehaviour
{
    public GameObject playerPrefab;

    //public GameObject spawnPoint;

    private void OnEnable()
    {
        
        
        playerPrefab.SetActive(true);
    }
}
