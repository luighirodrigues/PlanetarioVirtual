using UnityEngine;

public class Navegador : MonoBehaviour
{
    public Camera origem;
    public Material material;
    public Renderer mesh;
    public TextMesh nome;
    public Audio audio;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(origem.transform.position, origem.transform.forward, out hit))
        {
            
            material = hit.transform.GetComponent<MeshRenderer>().material;
            if (hit.transform.name.Equals("Display"))
            {
                Debug.Log("Display Atingido!");
            }
            else
            {
                Debug.Log(material.name);
                nome.text = hit.transform.name;
                mesh.sharedMaterial = material;
                FindObjectOfType<AudioManager>().Play(hit.transform.name);
            }
        }
    }
    
}
