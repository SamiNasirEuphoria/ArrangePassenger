using System;
using DG.Tweening;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace TJ.Scripts
{
    public class Helper : MonoBehaviour
    {
        public static Helper instance;

        public Transform[] points;
        public BoxCollider[] vehicleColliders;

        public GameObject handIcon;
        public TextMeshPro info;
        public string carTXT;
        public string vanTXT;
        public string busTXT;

        private int count = 0;


        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            if (points.Length > 0)
                handIcon.transform.DOMove(points[0].position, 0.5f);
            if (vehicleColliders.Length > 0)
                vehicleColliders[0].enabled = true;
        }

        public void MoveHand()
        {
            count++;
            if (count < points.Length && count < vehicleColliders.Length)
            {
                handIcon.transform.DOMove(new Vector3(points[count].position.x, points[count].position.y, handIcon.transform.position.z), 0.5f);
                vehicleColliders[count].enabled = true;
            }
            else
            {
                handIcon.SetActive(false);
            }

            info.text = count switch
            {
                1 => carTXT,
                2 => busTXT,
                3 => vanTXT,
                _ => info.text
            };
        }
    }
}