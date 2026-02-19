using UnityEngine;
using UnityEngine.SceneManagement;
// [เพิ่มสำหรับ Lab 04]
// ใช้สำหรับโหลด Scene ใหม่

public class PlayerDeath : MonoBehaviour
{
    public float reloadDelay = 0.5f;
    // หน่วงเวลาก่อนโหลดซีนใหม่ (ถ่วงเวลาให้เห็นว่าถูกทำลาย/ตายไปแล้ว)

    void OnCollisionEnter(Collision collision)
    {
        // ตรวจว่าชนกับวัตถุที่มี Tag = Enemy หรือไม่
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // โหลด Scene ปัจจุบันใหม่หลังหน่วงเวลา
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
