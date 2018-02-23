using System;
using System.Collections.Generic;
using System.Diagnostics;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Api.E01D
{
    public class ProcessesApi
    {
        public Process[] GetAll()
        {
            

            var allProcceses = Process.GetProcesses();

            return allProcceses;
        }

        public void KillIfStarted(AbsoluteFilePath executable)
        {
            var all = GetAll();

            for (int i = 0; i < all.Length; i++)
            {
                var process = all[i];


                try
                {
                    if (process.MainModule.FileName.ToLower() == executable.Value.ToLower())
                    {
                        process.Kill();
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
        }
    }
}
