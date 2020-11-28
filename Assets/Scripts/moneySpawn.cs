using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneySpawn : MonoBehaviour {

    public Transform startPos;
    public GameObject moneyModel;

    // Start is called before the first frame update
    public void spawnMoney() {
        Instantiate(moneyModel, startPos.position, startPos.rotation);
    }
}
