using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(1,3) == 2)
        {
            GameObject spawned = Instantiate(enemy, new Vector3(-10, -2, 0), transform.rotation);
            spawned.transform.Translate(Vector2.right*Time.deltaTime);
        }
    }
}
