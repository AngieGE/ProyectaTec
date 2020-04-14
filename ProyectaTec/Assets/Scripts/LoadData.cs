using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Net;
using TMPro;
//This script creates and stores the two json objects that manage the application.
public class LoadData : MonoBehaviour 
{
    private string path;
    private string _path_ContentData = "";
    private string _jsonString;
    public static DataJsonClass ContentData;

    private void Awake() {
        CheckPath();
    }

    public void CheckPath()
    {
            path = Application.dataPath;
            if (Application.platform == RuntimePlatform.OSXPlayer)
            {
                path += "/../../";
            }
            else if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                path += "/../";
            }
            else
            {
                path += "/../";
            }
            ////// JSON to Object //////
            LoadContentData();
    }
    
    private void LoadContentData()
    {
            //LoadedContentData
            // Check if exists or create a new one
             _path_ContentData = path + "/project-exhibit-content.json";
            if (System.IO.File.Exists(_path_ContentData) == false)    
            {
                string theJson = Resources.Load("project-exhibit-content").ToString();
                File.WriteAllText(Application.dataPath + "/project-exhibit-content.json", theJson); 
            }  
            
            _jsonString = File.ReadAllText(_path_ContentData);
            ContentData = JsonUtility.FromJson<DataJsonClass>(_jsonString);
    }
}