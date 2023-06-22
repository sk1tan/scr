using UnityEngine;

public class Destroy : MonoBehaviour {

    void Start() {
        
        // Удаление объекта, к которому привязан скрипт
        Destroy(gameObject);
    }

}
