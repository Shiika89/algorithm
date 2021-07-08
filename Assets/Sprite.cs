using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sprite[] image = Resources.LoadAll<Sprite>("Textures");

        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 2; x++)
            {
                int i = 0;
                Instantiate(image[i], new Vector3(x, y, 0f), Quaternion.identity);
                i += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
