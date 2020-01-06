﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoExecPrograms
{
    class DataProcess
    {
        private String mName;
        private String mPath;
        private String mArgs;
        public String getName()
        {
            return mName;
        }
        public void setName(String s)
        {
            mName = s;
        }

        public String getPath()
        {
            return mPath;
        }
        public String getArgs()
        {
            return mArgs;
        }
        public void setPath(String s)
        {
            mPath = s;
        }
        public void setArgs(String s)
        {
            mArgs = s;
        }
        public DataProcess()
        {
        }
    }
    class DataController
    {
        private List<DataProcess> dataProcesses = new List<DataProcess>();
        public DataController()
        {
            
        }
        public void addProcess(String name, String path, String args)
        {
            DataProcess process = new DataProcess();
            process.setName(name);
            process.setPath(path);
            process.setArgs(args);
            dataProcesses.Add(process);
        }
        public void deleteProcess(String path)
        {
            dataProcesses.Remove(findProcess(path));
        }
        public DataProcess findProcess(String path)
        {
            for (int i = 0; i <= dataProcesses.Count; i ++)
            {
                DataProcess process = dataProcesses[i];
                if(process.getPath()==path)
                {
                    return process;
                }
            }
            return null;
        }
    }
}