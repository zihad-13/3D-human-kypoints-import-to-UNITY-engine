using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class ReadData : MonoBehaviour
{

    
    //public string filename;
    // Start is called before the first frame update
    void Start()
    {
        //Read();
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/

    public static List<CSVReader> Read(string filename)
    {
        int bone_num = 17;
        List<Vector3[]> data3d = new List<Vector3[]>();
        List<CSVReader> csvread = new List<CSVReader>();
        string[] Lines = System.IO.File.ReadAllLines(filename);
        string[] Columns = Lines[0].Split(",");
        //Debug.Log(Columns[0]);
        for (int i = 0; i <= Lines.Length - 1; i++)
        {
            if (i == 0) continue;
            Vector3[] vs = new Vector3[bone_num];
            string[] str = Lines[i].Split(",");
            for (int j = 0; j <= str.Length-3; j += 3)
            {

                //vs[(int)(j / 3)] = new Vector3(-float.Parse(str[j], CultureInfo.InvariantCulture), float.Parse(str[j + 2], CultureInfo.InvariantCulture), -float.Parse(str[j + 1], CultureInfo.InvariantCulture));
                vs[(int)(j / 3)] = new Vector3(-float.Parse(str[j], CultureInfo.InvariantCulture), -float.Parse(str[j + 1], CultureInfo.InvariantCulture), -float.Parse(str[j + 2], CultureInfo.InvariantCulture));


            }
            //Debug.Log(vs[0]);
            data3d.Add(vs);


        }
        /*for (int k = 0; k < bone_num; k++) {
            Debug.Log(data3d[0][0]);
        }*/

        csvread.Add(new CSVReader { keypoints3d = data3d });




        return csvread;

    }




    public class CSVReader
    {
        public List<Vector3[]> keypoints3d { get; set; }
    }
}

