using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destoryDelay = 0.5f;

    Color32 hasPackageColor = new Color32(230, 106, 231, 255);
    Color32 noPackageColor = new Color32(255, 255, 255, 255);
    SpriteRenderer spriteRenderer;

    void Start() {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision Happened!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Package") && !this.hasPackage) {
            this.hasPackage = true;
            Destroy(other.gameObject, destoryDelay);
            this.spriteRenderer.color = this.hasPackageColor;
            Debug.Log("Pickup Package.");
        } else if (other.tag.Equals("Customer") && this.hasPackage) {
            this.hasPackage = false;
            this.spriteRenderer.color = this.noPackageColor;
            Debug.Log("Package Delivered.");
        }
    }
}
