using UnityEngine;

public class ChangeColorHDRP : MonoBehaviour
{
    Renderer rend;
    MaterialPropertyBlock block;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        block = new MaterialPropertyBlock();
    }

    void Start()
    {
        SetColor(Color.red);
    }

    public void SetColor(Color color)
    {
        rend.GetPropertyBlock(block); // ดึงค่าปัจจุบัน
        block.SetColor("_BaseColor", color);
        rend.SetPropertyBlock(block); // ส่งค่ากลับเข้า Renderer
    }
}