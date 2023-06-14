using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncherLeft : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectilePrefab;

    public void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, projectilePrefab.transform.rotation);
        Vector3 origScale = projectile.transform.localScale;
        projectile.transform.localScale = new Vector3(origScale.x * -1, origScale.y, origScale.z);
    }
}
