using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCountC : MonoBehaviour
{
    TMPro.TMP_Text text;
    public int count;

    void Awake(){
        text = GetComponent<TMPro.TMP_Text>();
    }

    // Start is called before the first frame update
    void Start() => UpdateCount();

    void OnEnable() => CollectibleC.OnCollected += OnCollectibleCollected;
    void OnDisable() => CollectibleC.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {CollectibleC.total}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
