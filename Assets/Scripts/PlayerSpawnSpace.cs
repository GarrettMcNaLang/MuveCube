using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerSpawnSpace : MonoBehaviour
{
    public GameObject playerPrefab;

    public GameObject spawnPoint;

   


    
    private void OnEnable()
    {
        
            Instantiate(playerPrefab, spawnPoint.transform.position, Quaternion.identity);
        
       
    }
}
