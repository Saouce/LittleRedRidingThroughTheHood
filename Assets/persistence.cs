using UnityEngine;

public class persistence : MonoBehaviour
{


    public void Awake(){
        if(GameManager.Instance.huntsmanAxeitem){
            Destroy(gameObject);
        }
    }

    public void CollectItem(){
        GameManager.Instance.huntsmanAxeitem = true;
    }

}
