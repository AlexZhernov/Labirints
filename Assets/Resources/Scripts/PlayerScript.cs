using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    private static int lvl = 1;
    private GameObject platform ;
    private static Material changePlatMaterial;
    private static Material currPlatMaterial;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        changePlatMaterial = Resources.Load<Material>("Materials/Transparent");
        currPlatMaterial = Resources.Load<Material>("Materials/Highlight");
        platform  = GameObject.FindWithTag("Level " + lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider hole)
    {  
        Destroy(hole.gameObject);
        ChangePlatform(changePlatMaterial);
        if (lvl < 6) 
        { 
            lvl++;
            platform  = GameObject.FindWithTag("Level " + lvl);
            ChangePlatform(currPlatMaterial);
            text.text = lvl + " Līmenis";
        }
        else
        {
            text.text = "Bye bye ball";
        }
    }

    void ChangePlatform(Material material)
    {
        foreach (var item in platform.GetComponentsInChildren<Renderer>() )
        {
            if (item.gameObject.tag != "Passthrough")
            {
                item.material = material;
            }
            
        }       
    }
}


