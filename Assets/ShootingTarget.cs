using UnityEngine;
using UnityEngine.UI;
public class ShootingTarget : MonoBehaviour
{
    [SerializeField] GameObject prefabExplosion;
    RaycastHit hit;
    void Update()
    {
        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray ray = Camera.main.ScreenPointToRay(center);
        if (Input.GetButtonDown("Fire1"))
        {   Debug.Log("fire");
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //Renvoie V si le rayon croise un collider
            {
                GameObject Go = Instantiate(prefabExplosion, hit.transform.position, Quaternion.identity);
                Destroy(Go, 5f);
                Destroy(hit.collider.transform.gameObject); } // Détruire l’ennemi
        }
    }

   
}