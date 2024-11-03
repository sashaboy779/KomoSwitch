using System;
using System.Collections.Generic;
using System.IO;
using KomoSwitch.Models;
using Newtonsoft.Json;
using Serilog;

namespace KomoSwitch.Services
{
    public class Storage
    {
        private readonly string _path;
        
        public Storage()
        {
            _path = PathManager.WorkspacesJson;

            InitializeStorage();
        }

        private void InitializeStorage()
        {
            try
            {
                if (File.Exists(_path)) 
                    return;
            
                var placeholders = GetPlaceholderWorkspaces();
                
                File.WriteAllText(_path, JsonConvert.SerializeObject(placeholders));
            }
            catch (Exception e)
            {
                Log.Error(e, "Error while saving workspaces");
                throw;
            }
        }
        
        public List<Workspace> GetWorkspaces()
        {
            var rawJson = File.ReadAllText(_path);
            var workspaces = JsonConvert.DeserializeObject<List<Workspace>>(rawJson);
            return workspaces;
        }

        public void SaveWorkspaces(List<Workspace> workspaces)
        {
            var workspaceJson = JsonConvert.SerializeObject(workspaces);
            File.WriteAllText(_path, workspaceJson);
        }

        private static List<Workspace> GetPlaceholderWorkspaces()
        {
            return new List<Workspace>
            {
                new Workspace("A", 0, true),
                new Workspace("B", 1, false),
                new Workspace("C", 2, false),
                new Workspace("D", 3, false),
                new Workspace("E", 4, false),
                new Workspace("F", 5, false),
                new Workspace("G", 6, false),
                new Workspace("H", 7, false),
                new Workspace("I", 8, false),
            };
        }
    }
}