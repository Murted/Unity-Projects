using System.Collections;
using UnityEngine;

public class MoveEnemies : MonoBehaviour
{
    [SerializeField] SpawnEnemies spawn;
    [SerializeField] private float speed;
    
    private void FixedUpdate()
    {
        for (int i = 0; i < spawn.enemies.Count; i++)
        {
            spawn.enemies[i].transform.position = Vector3.MoveTowards(spawn.enemies[i].transform.position, transform.position = new Vector3(0, 0, 0), 2f * Time.deltaTime);

        }
    }
}
